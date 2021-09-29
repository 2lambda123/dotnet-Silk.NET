// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11;

[NativeName("Name", "D3D11_RLDO_FLAGS")]
public enum RldoFlags : int
{
    [NativeName("Name", "D3D11_RLDO_SUMMARY")]
    RldoSummary = 0x1,
    [NativeName("Name", "D3D11_RLDO_DETAIL")]
    RldoDetail = 0x2,
    [NativeName("Name", "D3D11_RLDO_IGNORE_INTERNAL")]
    RldoIgnoreInternal = 0x4,
}
