// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES;

[NativeName("Name", "ClampColorModeARB")]
public enum ClampColorModeARB : int
{
    [NativeName("Name", "GL_FALSE")]
    False = 0x0,
    [NativeName("Name", "GL_TRUE")]
    True = 0x1,
    [NativeName("Name", "GL_FIXED_ONLY")]
    FixedOnly = 0x891D,
    [NativeName("Name", "GL_FIXED_ONLY_ARB")]
    FixedOnlyArb = 0x891D,
}
