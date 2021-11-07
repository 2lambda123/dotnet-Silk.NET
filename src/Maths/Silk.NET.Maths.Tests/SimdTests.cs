// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#if NET5_0_OR_GREATER

using System;
using System.Numerics;
using Xunit;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace Silk.NET.Maths.Tests
{
    public unsafe class SimdTests_Vector_Vector_Vector
    {
        static void FillWithRandomData(void* ptr, int len)
        {
            var rand = new Random(10);
            for (int i = 0; i < len; i++)
                *((byte*)ptr + i) = (byte)rand.Next(4, 12);
        }

        [Fact]
        public void Simd64_GreaterThan_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThan(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThan_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThan(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThan_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThan(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThan_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThan(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThan_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThan(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThan_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThan(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThan_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThan(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThan_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThan(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThan_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThan(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThan_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThan(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThan_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThan(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThan_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThan(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThan_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThan(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThan_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThan(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThan_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThan(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThan_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThan(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThan_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThan(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThan_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThan(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThan_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThan(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThan_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThan(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThanOrEqual_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThanOrEqual_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThanOrEqual_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThanOrEqual_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThanOrEqual_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThanOrEqual_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThanOrEqual_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThanOrEqual_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThanOrEqual_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_GreaterThanOrEqual_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThanOrEqual_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThanOrEqual_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThanOrEqual_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThanOrEqual_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThanOrEqual_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThanOrEqual_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThanOrEqual_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThanOrEqual_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThanOrEqual_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_LessThanOrEqual_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Add_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Add(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Add_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Add(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Add_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Add(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Add_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Add(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Add_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Add(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Add_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Add(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Add_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Add(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Add_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Add(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Add_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Add(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Add_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Add(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Subtract_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Subtract(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Subtract_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Subtract(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Subtract_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Subtract(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Subtract_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Subtract(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Subtract_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Subtract(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Subtract_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Subtract(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Subtract_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Subtract(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Subtract_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Subtract(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Subtract_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Subtract(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Subtract_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Subtract(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Multiply_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Multiply(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Multiply_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Multiply(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Multiply_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Multiply(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Multiply_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Multiply(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Multiply_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Multiply(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Multiply_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Multiply(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Multiply_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Multiply(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Multiply_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Multiply(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Multiply_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Multiply(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Multiply_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Multiply(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Divide_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Divide(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Divide_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Divide(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Divide_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Divide(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Divide_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Divide(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Divide_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Divide(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Divide_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Divide(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Divide_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Divide(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Divide_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Divide(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Divide_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Divide(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Divide_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Divide(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_And_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.And(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_And_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.And(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_And_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.And(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_And_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.And(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_And_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.And(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_And_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.And(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_And_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.And(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_And_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.And(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_And_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.And(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_And_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.And(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Xor_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Xor(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Xor_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Xor(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Xor_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Xor(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Xor_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Xor(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Xor_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Xor(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Xor_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Xor(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Xor_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Xor(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Xor_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Xor(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Xor_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Xor(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Xor_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Xor(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Or_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Or(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Or_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Or(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Or_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Or(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Or_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Or(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Or_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Or(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Or_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Or(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Or_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Or(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Or_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Or(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Or_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Or(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Or_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Or(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Min_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Min(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Min_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Min(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Min_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Min(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Min_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Min(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Min_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Min(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Min_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Min(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Min_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Min(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Min_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Min(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Min_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Min(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Min_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Min(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Max_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Max(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Max_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Max(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Max_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Max(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Max_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Max(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Max_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Max(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Max_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Max(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Max_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Max(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Max_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Max(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Max_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Max(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Max_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Max(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Equal_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Equal(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Equal_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Equal(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Equal_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Equal(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Equal_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Equal(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Equal_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Equal(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Equal_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Equal(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Equal_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Equal(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Equal_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Equal(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Equal_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Equal(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_Equal_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.Equal(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_NotEqual_byte()
        {
            Vector64<byte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.NotEqual(a, b);
            for (int i = 0; i < Vector64<byte>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_NotEqual_sbyte()
        {
            Vector64<sbyte> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.NotEqual(a, b);
            for (int i = 0; i < Vector64<sbyte>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_NotEqual_ushort()
        {
            Vector64<ushort> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.NotEqual(a, b);
            for (int i = 0; i < Vector64<ushort>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_NotEqual_short()
        {
            Vector64<short> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.NotEqual(a, b);
            for (int i = 0; i < Vector64<short>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_NotEqual_uint()
        {
            Vector64<uint> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.NotEqual(a, b);
            for (int i = 0; i < Vector64<uint>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_NotEqual_int()
        {
            Vector64<int> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.NotEqual(a, b);
            for (int i = 0; i < Vector64<int>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_NotEqual_ulong()
        {
            Vector64<ulong> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.NotEqual(a, b);
            for (int i = 0; i < Vector64<ulong>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_NotEqual_long()
        {
            Vector64<long> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.NotEqual(a, b);
            for (int i = 0; i < Vector64<long>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_NotEqual_float()
        {
            Vector64<float> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.NotEqual(a, b);
            for (int i = 0; i < Vector64<float>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd64_NotEqual_double()
        {
            Vector64<double> a, b;
            FillWithRandomData(&a, 8); 
            FillWithRandomData(&b, 8);
            var actual = Simd64.NotEqual(a, b);
            for (int i = 0; i < Vector64<double>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThan_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThan(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThan_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThan(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThan_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThan(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThan_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThan(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThan_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThan(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThan_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThan(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThan_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThan(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThan_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThan(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThan_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThan(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThan_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThan(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThan_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThan(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThan_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThan(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThan_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThan(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThan_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThan(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThan_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThan(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThan_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThan(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThan_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThan(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThan_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThan(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThan_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThan(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThan_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThan(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThanOrEqual_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThanOrEqual_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThanOrEqual_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThanOrEqual_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThanOrEqual_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThanOrEqual_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThanOrEqual_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThanOrEqual_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThanOrEqual_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_GreaterThanOrEqual_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThanOrEqual_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThanOrEqual_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThanOrEqual_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThanOrEqual_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThanOrEqual_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThanOrEqual_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThanOrEqual_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThanOrEqual_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThanOrEqual_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_LessThanOrEqual_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Add_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Add(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Add_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Add(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Add_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Add(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Add_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Add(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Add_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Add(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Add_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Add(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Add_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Add(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Add_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Add(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Add_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Add(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Add_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Add(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Subtract_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Subtract(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Subtract_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Subtract(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Subtract_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Subtract(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Subtract_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Subtract(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Subtract_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Subtract(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Subtract_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Subtract(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Subtract_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Subtract(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Subtract_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Subtract(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Subtract_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Subtract(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Subtract_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Subtract(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Multiply_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Multiply(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Multiply_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Multiply(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Multiply_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Multiply(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Multiply_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Multiply(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Multiply_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Multiply(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Multiply_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Multiply(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Multiply_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Multiply(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Multiply_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Multiply(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Multiply_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Multiply(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Multiply_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Multiply(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Divide_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Divide(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Divide_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Divide(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Divide_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Divide(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Divide_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Divide(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Divide_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Divide(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Divide_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Divide(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Divide_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Divide(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Divide_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Divide(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Divide_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Divide(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Divide_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Divide(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_And_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.And(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_And_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.And(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_And_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.And(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_And_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.And(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_And_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.And(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_And_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.And(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_And_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.And(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_And_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.And(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_And_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.And(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_And_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.And(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Xor_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Xor(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Xor_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Xor(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Xor_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Xor(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Xor_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Xor(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Xor_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Xor(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Xor_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Xor(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Xor_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Xor(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Xor_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Xor(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Xor_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Xor(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Xor_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Xor(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Or_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Or(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Or_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Or(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Or_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Or(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Or_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Or(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Or_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Or(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Or_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Or(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Or_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Or(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Or_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Or(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Or_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Or(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Or_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Or(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Min_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Min(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Min_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Min(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Min_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Min(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Min_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Min(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Min_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Min(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Min_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Min(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Min_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Min(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Min_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Min(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Min_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Min(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Min_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Min(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Max_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Max(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Max_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Max(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Max_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Max(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Max_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Max(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Max_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Max(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Max_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Max(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Max_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Max(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Max_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Max(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Max_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Max(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Max_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Max(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Equal_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Equal(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Equal_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Equal(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Equal_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Equal(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Equal_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Equal(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Equal_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Equal(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Equal_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Equal(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Equal_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Equal(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Equal_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Equal(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Equal_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Equal(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_Equal_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.Equal(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_NotEqual_byte()
        {
            Vector128<byte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.NotEqual(a, b);
            for (int i = 0; i < Vector128<byte>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_NotEqual_sbyte()
        {
            Vector128<sbyte> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.NotEqual(a, b);
            for (int i = 0; i < Vector128<sbyte>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_NotEqual_ushort()
        {
            Vector128<ushort> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.NotEqual(a, b);
            for (int i = 0; i < Vector128<ushort>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_NotEqual_short()
        {
            Vector128<short> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.NotEqual(a, b);
            for (int i = 0; i < Vector128<short>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_NotEqual_uint()
        {
            Vector128<uint> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.NotEqual(a, b);
            for (int i = 0; i < Vector128<uint>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_NotEqual_int()
        {
            Vector128<int> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.NotEqual(a, b);
            for (int i = 0; i < Vector128<int>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_NotEqual_ulong()
        {
            Vector128<ulong> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.NotEqual(a, b);
            for (int i = 0; i < Vector128<ulong>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_NotEqual_long()
        {
            Vector128<long> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.NotEqual(a, b);
            for (int i = 0; i < Vector128<long>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_NotEqual_float()
        {
            Vector128<float> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.NotEqual(a, b);
            for (int i = 0; i < Vector128<float>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd128_NotEqual_double()
        {
            Vector128<double> a, b;
            FillWithRandomData(&a, 16); 
            FillWithRandomData(&b, 16);
            var actual = Simd128.NotEqual(a, b);
            for (int i = 0; i < Vector128<double>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThan_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThan(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThan_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThan(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThan_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThan(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThan_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThan(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThan_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThan(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThan_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThan(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThan_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThan(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThan_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThan(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThan_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThan(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThan_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThan(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.GreaterThan(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThan_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThan(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThan_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThan(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThan_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThan(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThan_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThan(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThan_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThan(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThan_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThan(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThan_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThan(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThan_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThan(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThan_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThan(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThan_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThan(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.LessThan(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThanOrEqual_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThanOrEqual_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThanOrEqual_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThanOrEqual_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThanOrEqual_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThanOrEqual_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThanOrEqual_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThanOrEqual_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThanOrEqual_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_GreaterThanOrEqual_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.GreaterThanOrEqual(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.GreaterThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThanOrEqual_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThanOrEqual_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThanOrEqual_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThanOrEqual_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThanOrEqual_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThanOrEqual_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThanOrEqual_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThanOrEqual_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThanOrEqual_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_LessThanOrEqual_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.LessThanOrEqual(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.LessThanOrEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Add_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Add(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Add_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Add(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Add_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Add(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Add_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Add(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Add_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Add(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Add_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Add(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Add_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Add(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Add_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Add(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Add_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Add(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Add_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Add(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.Add(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Subtract_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Subtract(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Subtract_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Subtract(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Subtract_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Subtract(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Subtract_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Subtract(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Subtract_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Subtract(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Subtract_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Subtract(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Subtract_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Subtract(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Subtract_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Subtract(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Subtract_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Subtract(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Subtract_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Subtract(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.Subtract(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Multiply_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Multiply(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Multiply_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Multiply(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Multiply_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Multiply(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Multiply_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Multiply(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Multiply_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Multiply(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Multiply_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Multiply(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Multiply_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Multiply(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Multiply_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Multiply(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Multiply_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Multiply(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Multiply_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Multiply(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.Multiply(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Divide_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Divide(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Divide_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Divide(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Divide_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Divide(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Divide_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Divide(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Divide_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Divide(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Divide_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Divide(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Divide_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Divide(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Divide_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Divide(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Divide_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Divide(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Divide_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Divide(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.Divide(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_And_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.And(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_And_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.And(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_And_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.And(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_And_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.And(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_And_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.And(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_And_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.And(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_And_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.And(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_And_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.And(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_And_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.And(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_And_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.And(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.And(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Xor_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Xor(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Xor_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Xor(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Xor_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Xor(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Xor_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Xor(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Xor_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Xor(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Xor_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Xor(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Xor_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Xor(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Xor_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Xor(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Xor_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Xor(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Xor_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Xor(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.Xor(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Or_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Or(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Or_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Or(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Or_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Or(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Or_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Or(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Or_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Or(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Or_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Or(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Or_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Or(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Or_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Or(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Or_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Or(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Or_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Or(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.Or(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Min_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Min(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Min_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Min(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Min_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Min(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Min_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Min(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Min_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Min(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Min_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Min(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Min_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Min(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Min_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Min(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Min_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Min(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Min_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Min(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.Min(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Max_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Max(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Max_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Max(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Max_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Max(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Max_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Max(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Max_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Max(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Max_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Max(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Max_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Max(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Max_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Max(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Max_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Max(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Max_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Max(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.Max(a.GetElement(i), b.GetElement(i)), actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Equal_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Equal(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Equal_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Equal(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Equal_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Equal(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Equal_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Equal(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Equal_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Equal(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Equal_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Equal(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Equal_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Equal(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Equal_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Equal(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Equal_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Equal(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_Equal_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.Equal(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.Equal(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_NotEqual_byte()
        {
            Vector256<byte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.NotEqual(a, b);
            for (int i = 0; i < Vector256<byte>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<byte>.AllBitsSet : Scalar<byte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_NotEqual_sbyte()
        {
            Vector256<sbyte> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.NotEqual(a, b);
            for (int i = 0; i < Vector256<sbyte>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<sbyte>.AllBitsSet : Scalar<sbyte>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_NotEqual_ushort()
        {
            Vector256<ushort> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.NotEqual(a, b);
            for (int i = 0; i < Vector256<ushort>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ushort>.AllBitsSet : Scalar<ushort>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_NotEqual_short()
        {
            Vector256<short> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.NotEqual(a, b);
            for (int i = 0; i < Vector256<short>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<short>.AllBitsSet : Scalar<short>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_NotEqual_uint()
        {
            Vector256<uint> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.NotEqual(a, b);
            for (int i = 0; i < Vector256<uint>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<uint>.AllBitsSet : Scalar<uint>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_NotEqual_int()
        {
            Vector256<int> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.NotEqual(a, b);
            for (int i = 0; i < Vector256<int>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<int>.AllBitsSet : Scalar<int>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_NotEqual_ulong()
        {
            Vector256<ulong> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.NotEqual(a, b);
            for (int i = 0; i < Vector256<ulong>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<ulong>.AllBitsSet : Scalar<ulong>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_NotEqual_long()
        {
            Vector256<long> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.NotEqual(a, b);
            for (int i = 0; i < Vector256<long>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<long>.AllBitsSet : Scalar<long>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_NotEqual_float()
        {
            Vector256<float> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.NotEqual(a, b);
            for (int i = 0; i < Vector256<float>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<float>.AllBitsSet : Scalar<float>.Zero, actual.GetElement(i));
        }
        [Fact]
        public void Simd256_NotEqual_double()
        {
            Vector256<double> a, b;
            FillWithRandomData(&a, 32); 
            FillWithRandomData(&b, 32);
            var actual = Simd256.NotEqual(a, b);
            for (int i = 0; i < Vector256<double>.Count; i++)
                Assert.Equal(Scalar.NotEqual(a.GetElement(i), b.GetElement(i)) ? Scalar<double>.AllBitsSet : Scalar<double>.Zero, actual.GetElement(i));
        }
    }
}
#endif