// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if INTRINSICS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
#if SSE
using System.Runtime.Intrinsics.X86;
#endif
#if AdvSIMD
using System.Runtime.Intrinsics.Arm;
#endif

namespace Silk.NET.Maths
{
    public static unsafe partial class Simd256
    {
        /// <summary>
        /// Performs hardware-accelerated GreaterThanOrEqual on 256-bit vectors.
        /// </summary>
        [MethodImpl(Scalar.MaxOpt)]
        public static Vector256<T> GreaterThanOrEqual<T>(Vector256<T> left, Vector256<T> right) where T : unmanaged
        {
            return Single(left, right);            
                        
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Single(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(float))
                {
#if AVX && NET5_0_OR_GREATER
                    return Avx2.CompareGreaterThanOrEqual(left.AsSingle(), right.AsSingle()).As<float, T>();
#elif AVX
                    return Avx2.Compare(left.AsSingle(), right.AsSingle(), FloatComparisonMode.OrderedGreaterThanOrEqualSignaling).As<float, T>();
#endif
                }
        
                return Double(left, right);
            }            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Double(Vector256<T> left, Vector256<T> right)
            {
                if (typeof(T) == typeof(double))
                {
#if AVX && NET5_0_OR_GREATER
                    return Avx2.CompareGreaterThanOrEqual(left.AsDouble(), right.AsDouble()).As<double, T>();
#elif AVX
                    return Avx2.Compare(left.AsDouble(), right.AsDouble(), FloatComparisonMode.OrderedGreaterThanOrEqualSignaling).As<double, T>();
#endif
                }
        
                return OtherHWAccelerated(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> OtherHWAccelerated(Vector256<T> left, Vector256<T> right)
            {
                if (Simd128<T>.IsHardwareAccelerated)
                {   
#if AdvSIMD
                    var leftLow = *(Vector128<T>*)&left;
                    var leftHigh = *((Vector128<T>*)&left + 1);
                    var rightLow = *(Vector128<T>*)&right;
                    var rightHigh = *((Vector128<T>*)&right + 1);
                    Vector256<T> res;
                    *(Vector128<T>*)&res = Simd128.GreaterThanOrEqual(leftLow, rightLow);
                    *((Vector128<T>*)&res + 1) = Simd128.GreaterThanOrEqual(leftHigh, rightHigh);
                    return res;
#else
                    /*
                     
                    128 bit Avx2 doesn't have accelerated GreaterThanOrEqual
                    
                    */
                    return Or(GreaterThan(left, right), Equal(left, right));
#endif                    
                }
                return Other(left, right);
            }
            
            [MethodImpl(Scalar.MaxOpt)]
            static Vector256<T> Other(Vector256<T> left, Vector256<T> right)
            {
                var vec = Vector256<T>.Zero;
                for (int i = 0; i < Vector256<T>.Count; i++)
                {
                    vec = vec.WithElement(i, Scalar.GreaterThanOrEqual(left.GetElement(i), right.GetElement(i)) ? Scalar<T>.AllBitsSet : Scalar<T>.Zero);
                }
                return vec;
            }
        }
    }
}
#endif
