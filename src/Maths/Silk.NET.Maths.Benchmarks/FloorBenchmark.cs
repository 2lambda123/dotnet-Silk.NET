﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Silk.NET.Maths.Benchmark
{
    [SimpleJob(RunStrategy.Throughput)]
    public class FloorBenchmark
    {
        [ParamsSource("GenerateNumber")] public float X;
        public int XInt;
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            XInt = (int)X;
        }
        
        [Benchmark(Baseline = true)]
        public float Sys()
        {
#if MATHF
            return MathF.Floor(X);
#else
            return (float)Math.Floor(X);
#endif
        }

        [Benchmark]
        public float SilkFloat()
        {
            return Scalar.Floor(X);
        }

        [Benchmark]
        public int SilkInt()
        {
            return Scalar.Floor(XInt);
        }

        private const int NumbersTested = 1;
        private static Random _random = new Random();
        public IEnumerable<float> GenerateNumber()
        {
            for (int i = 0; i < NumbersTested; i++)
                yield return (float) _random.NextDouble();
        }
    }
}
