// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkLineRasterizationModeEXT")]
    public enum LineRasterizationModeEXT : int
    {
        [Obsolete("Deprecated in favour of \"DefaultExt\"")]
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT")]
        LineRasterizationModeDefaultExt = 0,
        [Obsolete("Deprecated in favour of \"RectangularExt\"")]
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT")]
        LineRasterizationModeRectangularExt = 1,
        [Obsolete("Deprecated in favour of \"BresenhamExt\"")]
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT")]
        LineRasterizationModeBresenhamExt = 2,
        [Obsolete("Deprecated in favour of \"RectangularSmoothExt\"")]
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT")]
        LineRasterizationModeRectangularSmoothExt = 3,
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT")]
        DefaultExt = 0,
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT")]
        RectangularExt = 1,
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT")]
        BresenhamExt = 2,
        [NativeName("Name", "VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT")]
        RectangularSmoothExt = 3,
    }
}
