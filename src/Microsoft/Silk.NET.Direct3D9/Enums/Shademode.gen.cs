// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9;

[NativeName("Name", "_D3DSHADEMODE")]
public enum Shademode : int
{
    [NativeName("Name", "D3DSHADE_FLAT")]
    ShadeFlat = 0x1,
    [NativeName("Name", "D3DSHADE_GOURAUD")]
    ShadeGouraud = 0x2,
    [NativeName("Name", "D3DSHADE_PHONG")]
    ShadePhong = 0x3,
    [NativeName("Name", "D3DSHADE_FORCE_DWORD")]
    ShadeForceDword = 0x7FFFFFFF,
}
