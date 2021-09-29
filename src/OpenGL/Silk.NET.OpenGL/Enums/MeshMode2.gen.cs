// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL;

[NativeName("Name", "MeshMode2")]
public enum MeshMode2 : int
{
    [NativeName("Name", "GL_POINT")]
    Point = 0x1B00,
    [NativeName("Name", "GL_LINE")]
    Line = 0x1B01,
    [NativeName("Name", "GL_FILL")]
    Fill = 0x1B02,
}
