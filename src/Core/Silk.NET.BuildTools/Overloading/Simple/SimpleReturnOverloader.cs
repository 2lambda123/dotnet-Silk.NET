﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Builders;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public static class SimpleReturnOverloader
    {
        /// <summary>
        /// The suffix appended to function names of return type overloads.
        /// </summary>
        /// <remarks>
        /// "S" for historical reasons as that's what we'd use for string overloads.
        /// </remarks>
        public const string ReturnOverloadSuffix = "S";
        
        /// <summary>
        /// Returns an enumerable containing the original function signature, as well as all overload variants
        /// generated by the overloaders. 
        /// </summary>
        /// <param name="original">The original function signature.</param>
        /// <param name="core">The core project for this profile. May be used by some overloads.</param>
        /// <param name="overloaders">The overloaders to use in getting function overloads.</param>
        /// <returns>An enumerable containing the original function signature and all overloads.</returns>
        public static IEnumerable<Function> GetWithOverloads(Function original,
            Project core,
            IEnumerable<ISimpleReturnOverloader> overloaders)
        {
            yield return original;
            foreach (var overloader in overloaders)
            {
                var attrs = original.Attributes
                    .Select(x => new Attribute { Name = x.Name, Arguments = new(x.Arguments) })
                    .ToList();
                if (overloader.TryGetReturnTypeVariant(original.ReturnType, out var varied, attrs, core))
                {
                    var ret = new FunctionSignatureBuilder(original)
                        .WithName(original.Name + ReturnOverloadSuffix)
                        .WithReturnType(varied)
                        .WithAttributes(attrs)
                        .Build();
                    ret.Kind = SignatureKind.ReturnOverload;
                    yield return ret;
                    break; // only overload the return type once
                }
            }
        }
    }
}
