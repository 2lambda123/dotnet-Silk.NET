// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES;

[NativeName("Name", "MapTextureFormatINTEL")]
public enum MapTextureFormatINTEL : int
{
    [NativeName("Name", "GL_LAYOUT_DEFAULT_INTEL")]
    LayoutDefaultIntel = 0x0,
    [NativeName("Name", "GL_LAYOUT_LINEAR_INTEL")]
    LayoutLinearIntel = 0x1,
    [NativeName("Name", "GL_LAYOUT_LINEAR_CPU_CACHED_INTEL")]
    LayoutLinearCpuCachedIntel = 0x2,
}
