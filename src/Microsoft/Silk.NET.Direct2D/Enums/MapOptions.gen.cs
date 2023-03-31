// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_MAP_OPTIONS")]
    public enum MapOptions : int
    {
        [NativeName("Name", "D2D1_MAP_OPTIONS_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_MAP_OPTIONS_READ")]
        Read = 0x1,
        [NativeName("Name", "D2D1_MAP_OPTIONS_WRITE")]
        Write = 0x2,
        [NativeName("Name", "D2D1_MAP_OPTIONS_DISCARD")]
        Discard = 0x4,
        [NativeName("Name", "D2D1_MAP_OPTIONS_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
