// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_INK_NIB_SHAPE")]
    public enum InkNibShape : int
    {
        [Obsolete("Deprecated in favour of \"Round\"")]
        [NativeName("Name", "D2D1_INK_NIB_SHAPE_ROUND")]
        InkNibShapeRound = 0x0,
        [Obsolete("Deprecated in favour of \"Square\"")]
        [NativeName("Name", "D2D1_INK_NIB_SHAPE_SQUARE")]
        InkNibShapeSquare = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_INK_NIB_SHAPE_FORCE_DWORD")]
        InkNibShapeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_INK_NIB_SHAPE_ROUND")]
        Round = 0x0,
        [NativeName("Name", "D2D1_INK_NIB_SHAPE_SQUARE")]
        Square = 0x1,
        [NativeName("Name", "D2D1_INK_NIB_SHAPE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
