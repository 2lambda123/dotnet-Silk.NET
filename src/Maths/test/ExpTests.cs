﻿using System;
using Xunit;

namespace Silk.NET.Numerics.Tests
{
    public class ExpTests
    {
        [Fact]
        public void MaxInf()
        {
            var value = 3.5990256e+33f + 1;
            var expected = float.PositiveInfinity;
            Assert.StrictEqual(expected, MathF.Exp(value));
            Assert.StrictEqual(expected, Operations.Exp(value));
        }
        
        [Fact]
        public void Exp0()
        {
            var value = 0f;
            var expected = 1f;
            Assert.StrictEqual(expected, MathF.Exp(value));
            Assert.StrictEqual(expected, Operations.Exp(value));
        }
        
        [Fact]
        public void Exp1()
        {
            var value = 1f;
            var expected = 2.71828182846f;
            Assert.StrictEqual(expected, MathF.Exp(value));
            Assert.StrictEqual(expected, Operations.Exp(value));
        }
        
        [Fact]
        public void Exp2()
        {
            var value = 2f;
            var expected = 7.38905609893f;
            Assert.Equal(expected, MathF.Exp(value));
            Assert.Equal(expected, Operations.Exp(value));
        }
        
        [Fact]
        public void Exp5()
        {
            var value = 5f;
            var expected = 148.413159103f;
            Assert.Equal(expected, MathF.Exp(value));
            Assert.Equal(expected, Operations.Exp(value));
        }
        
        // [Fact]
        // public void Exp50()
        // {
        //     var value = 50f;
        //     var expected = 5.1847055e+21f;
        //     Assert.Equal(expected, MathF.Exp(value));
        //     Assert.Equal(expected, Operations.Exp(value));
        // }
    }
}
