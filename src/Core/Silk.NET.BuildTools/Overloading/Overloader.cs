// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Overloading
{
    public static class Overloader
    {
        public static ISimpleParameterOverloader[][] ParameterOverloaders { get; } =
        {
            new ISimpleParameterOverloader[]
            {
                new GroupOverloader(),
                new ClassOverloader(),
                new OpenCLUngroupCompatOverloader()
            },
            new ISimpleParameterOverloader[]
            {
                new RefOverloader(),
                new StringOverloader()
            }
        };

        public static ISimpleReturnOverloader[] ReturnOverloaders { get; } =
        {
            new StringOverloader()
        };

        public static IComplexFunctionOverloader[] FunctionOverloaders { get; } =
        {
            new ReturnTypeOverloader(),
            new ArrayParameterOverloader(),
            new StringArrayOverloader(),
            new SpanOverloader(),
            new ImplicitCountSpanOverloader()
        };

        private static IEnumerable<T> Filter<T>
        (
            this IEnumerable<T> elements,
            Function function,
            Dictionary<string, string[]>? overloadExcludedFunctions
        ) => elements.Where
        (
            x => !(overloadExcludedFunctions?.TryGetValue(x.GetType().Name, out var v) ?? false) ||
                 !v.Contains(function.NativeName)
        );

        public static IEnumerable<Function> GetWithVariants
        (
            IEnumerable<Function> functions,
            Profile profile,
            Dictionary<string, string[]>? overloadExcludedFunctions
        )
        {
            var enumerable = functions;
            foreach (var overloaders in ParameterOverloaders)
            {
                enumerable = Get(enumerable, overloaders);
            }

            foreach (var overload in enumerable)
            {
                foreach (var final in SimpleReturnOverloader.GetWithOverloads
                    (overload, profile, ReturnOverloaders.Filter(overload, overloadExcludedFunctions)))
                {
                    yield return final;
                }
            }

            IEnumerable<Function> Get(IEnumerable<Function> functions, ISimpleParameterOverloader[] overloaders)
            {
                foreach (var function in functions)
                {
                    foreach (var overload in SimpleParameterOverloader.GetWithOverloads
                        (function, profile, overloaders.Filter(function, overloadExcludedFunctions)))
                    {
                        yield return overload;
                    }
                }
            }
        }

        public static IEnumerable<ImplementedFunction> GetOverloads
        (
            IEnumerable<Function> allFunctions,
            Project core,
            Dictionary<string, string[]>? overloadExcludedFunctions,
            bool fastCheck = false
        )
        {
            return fastCheck? Get().RemoveDuplicatesFast(CheckDuplicate, GetSignature) : Get().RemoveDuplicates(CheckDuplicate);

            static bool CheckDuplicate(ImplementedFunction left, ImplementedFunction right)
                => left.Signature.Equals(right.Signature);

            static string GetSignature(ImplementedFunction func)
                => func.Signature.ToString(null, returnType: false, appendAttributes: false);

            IEnumerable<ImplementedFunction> Get()
            {
                foreach (var function in allFunctions)
                {
                    foreach (var overload in ComplexFunctionOverloader.GetOverloads
                        (function, core, FunctionOverloaders.Filter(function, overloadExcludedFunctions)))
                    {
                        yield return overload;
                    }
                }
            }
        }
    }
}
