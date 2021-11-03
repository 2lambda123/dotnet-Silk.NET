﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if INTRINSICS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace Silk.NET.Maths
{
    public static class Simd256<T> where T : unmanaged
    {
        public static bool IsSupported => typeof(T) == typeof(sbyte)
                                          || typeof(T) == typeof(byte)
                                          || typeof(T) == typeof(ushort)
                                          || typeof(T) == typeof(short)
                                          || typeof(T) == typeof(uint)
                                          || typeof(T) == typeof(int)
                                          || typeof(T) == typeof(ulong)
                                          || typeof(T) == typeof(long)
                                          || typeof(T) == typeof(float)
                                          || typeof(T) == typeof(double);
        
        /// <summary>
        /// Represents the smallest positive value that is greater than zero. Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector256<T> Epsilon;

        /// <summary>
        /// Represents the largest possible value.
        /// </summary>
        public static readonly Vector256<T> MaxValue;

        /// <summary>
        /// Represents the smallest possible value.
        /// </summary>
        public static readonly Vector256<T> MinValue;

        /// <summary>
        /// Represents not a number (NaN). Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector256<T> NaN;

        /// <summary>
        /// Represents negative infinity. Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector256<T> NegativeInfinity;

        /// <summary>
        /// Represents positive infinity. Zero for non-floating point numbers.
        /// </summary>
        public static readonly Vector256<T> PositiveInfinity;

        /// <summary>
        /// Represents zero.
        /// </summary>
        public static readonly Vector256<T> Zero = Vector256<T>.Zero;

        /// <summary>
        /// Represents one.
        /// </summary>
        public static readonly Vector256<T> One;

        /// <summary>
        /// Represents two.
        /// </summary>
        public static readonly Vector256<T> Two;

        /// <summary>
        /// Represents negative one.
        /// </summary>
        public static readonly Vector256<T> MinusOne;

        /// <summary>
        /// Represents negative two.
        /// </summary>
        public static readonly Vector256<T> MinusTwo;

        /// <summary>
        /// Represents the natural logarithmic base, specified by the constant, <code>e</code>.
        /// </summary>
        public static readonly Vector256<T> E;

        /// <summary>
        /// Represents the ratio of the circumference of a circle to its diameter, specified by the constant, <code>π</code>.
        /// </summary>
        public static readonly Vector256<T> Pi;

        /// <summary>
        /// Represents Pi divided by two.
        /// </summary>
        public static readonly Vector256<T> PiOver2;

        /// <summary>
        /// Represents the number of radians in one turn, specified by the constant, <code>τ</code>.
        /// </summary>
        public static readonly Vector256<T> Tau;

        [MethodImpl(Scalar.MaxOpt)]
        static Simd256()
        {
            Epsilon = Simd256.Create(Scalar<T>.Epsilon);
            MaxValue = Simd256.Create(Scalar<T>.MaxValue);
            MinValue = Simd256.Create(Scalar<T>.MinValue);
            NaN = Simd256.Create(Scalar<T>.NaN);
            NegativeInfinity = Simd256.Create(Scalar<T>.NegativeInfinity);
            PositiveInfinity = Simd256.Create(Scalar<T>.PositiveInfinity);
            One = Simd256.Create(Scalar<T>.One);
            Two = Simd256.Create(Scalar<T>.Two);
            MinusOne = Simd256.Create(Scalar<T>.MinusOne);
            MinusTwo = Simd256.Create(Scalar<T>.MinusTwo);
            E = Simd256.Create(Scalar<T>.E);
            Pi = Simd256.Create(Scalar<T>.Pi);
            PiOver2 = Simd256.Create(Scalar<T>.PiOver2);
            Tau = Simd256.Create(Scalar<T>.Tau);
        }
    }
}
#endif
