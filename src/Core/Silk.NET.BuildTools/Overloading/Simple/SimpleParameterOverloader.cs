﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    /// <summary>
    /// Creates simple function overloads.
    /// </summary>
    ///<remarks>
    /// It is "simple" in the sense that:
    /// <list type="bullet">
    /// <item><description>The signatures it generates are SilkTouch compatible.</description></item>
    /// <item><description>No extra code is needed in order to make the function work.</description></item>
    /// </list>
    /// While this is the simplest overloading step, it is the one that has the most impact.
    /// </remarks>
    public static class SimpleParameterOverloader
    {
        /// <summary>
        /// Returns an enumerable containing the original function signature, as well as all overload variants
        /// generated by the 
        /// </summary>
        /// <param name="original">The original function signature.</param>
        /// <param name="core">The core project for this profile. May be used by some overloads.</param>
        /// <param name="overloaders">The overloaders to use in getting function overloads.</param>
        /// <returns>An enumerable containing the original function signature and all overloads.</returns>
        public static IEnumerable<Function> GetWithOverloads
        (
            Function original,
            Project core,
            IEnumerable<ISimpleParameterOverloader> overloaders
        )
        {
            if (original.Parameters.Count == 0)
            {
                yield return original;
                yield break;
            }
            
            var parameters = original.Parameters.Select(x => new List<Parameter> {x}).ToList();
            foreach (var parameter in parameters)
            {
                foreach (var overloader in overloaders)
                {
                    if (overloader.TryGetParameterVariant(parameter[0], out var variant, core))
                    {
                        parameter.Add(variant);
                    }
                }
            }

            foreach (var combination in Combinations(parameters))
            {
                var numGenericTypeParams = 0;
                var ret = new FunctionSignatureBuilder(original).WithParameters
                    (
                        combination.Select
                            (
                                x => !x.Type.IsGenericTypeParameterReference
                                    ? x
                                    : new ParameterSignatureBuilder(x).WithType
                                        (
                                            new TypeSignatureBuilder(x.Type).WithName("T" + numGenericTypeParams++)
                                                .Build()
                                        )
                                        .Build()
                            )
                            .ToList()
                    )
                    .WithGenericTypeParameters
                    (
                        Enumerable.Range(0, numGenericTypeParams)
                            .Select
                            (
                                x => new GenericTypeParameter
                                    {Name = "T" + x, Constraints = new List<string> {"unmanaged"}}
                            )
                            .ToList()
                    )
                    .Build();
                ret.Kind = original.Kind == SignatureKind.Normal ? ret.Parameters.SequenceEqual
                    (original.Parameters)
                    ? SignatureKind.Normal
                    : SignatureKind.SimpleOverload : original.Kind;

                if (ret.NativeName.ConstitutesVulkanOutOverload() &&
                    (ret.Parameters.LastOrDefault()?.Type.IsOut ?? false))
                {
                    var last = ret.Parameters.Last();
                    var outStruct = core.Structs.FirstOrDefault(x => x.Name == last.Type.Name);
                    var outSType = outStruct?.Fields.FirstOrDefault();
                    if (outSType is not null && outSType.Name == "SType" && outSType.DefaultAssignment is not null)
                    {
                        ret.Attributes.Add
                        (
                            new()
                            {
                                Name = "Inject",
                                Arguments = new()
                                {
                                    "SilkTouchStage.Begin",
                                    $"\"{last.Name} = new({outSType.DefaultAssignment});\""
                                }
                            }
                        );
                    }
                }
                    
                yield return ret;
            }
        }

        [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
        private static IEnumerable<IReadOnlyList<T>> Combinations<T>(IEnumerable<IReadOnlyList<T>> collections)
        {
            // Any multiple enumeration will be benign and enumerating to an array or list is a needless allocation.
            if (collections.Count() == 1)
            {
                foreach (var item in collections.Single())
                    yield return new List<T> {item};
            }
            else if (collections.Count() > 1)
            {
                foreach (var item in collections.First())
                foreach (var tail in Combinations(collections.Skip(1)))
                    yield return new[] {item}.Concat(tail).ToList();
            }
        }
    }
}
