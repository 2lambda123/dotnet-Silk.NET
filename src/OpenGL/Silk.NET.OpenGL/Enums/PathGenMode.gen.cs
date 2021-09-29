// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL;

[NativeName("Name", "PathGenMode")]
public enum PathGenMode : int
{
    [NativeName("Name", "GL_NONE")]
    None = 0x0,
    [NativeName("Name", "GL_PATH_OBJECT_BOUNDING_BOX_NV")]
    PathObjectBoundingBoxNV = 0x908A,
}
