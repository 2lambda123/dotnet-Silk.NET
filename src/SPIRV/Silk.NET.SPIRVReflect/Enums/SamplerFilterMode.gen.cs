// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "SpvSamplerFilterMode_")]
    public enum SamplerFilterMode : int
    {
        [NativeName("Name", "SpvSamplerFilterModeNearest")]
        Nearest = 0x0,
        [NativeName("Name", "SpvSamplerFilterModeLinear")]
        Linear = 0x1,
        [NativeName("Name", "SpvSamplerFilterModeMax")]
        Max = 0x7FFFFFFF,
    }
}
