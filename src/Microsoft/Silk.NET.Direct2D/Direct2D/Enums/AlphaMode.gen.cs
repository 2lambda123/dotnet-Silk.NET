// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_ALPHA_MODE")]
    public enum AlphaMode : int
    {
        [NativeName("Name", "D2D1_ALPHA_MODE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "D2D1_ALPHA_MODE_PREMULTIPLIED")]
        Premultiplied = 0x1,
        [NativeName("Name", "D2D1_ALPHA_MODE_STRAIGHT")]
        Straight = 0x2,
        [NativeName("Name", "D2D1_ALPHA_MODE_IGNORE")]
        Ignore = 0x3,
        [NativeName("Name", "D2D1_ALPHA_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
