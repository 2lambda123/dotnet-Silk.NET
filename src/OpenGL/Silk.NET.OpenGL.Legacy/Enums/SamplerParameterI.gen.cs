// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy;

[NativeName("Name", "SamplerParameterI")]
public enum SamplerParameterI : int
{
    [NativeName("Name", "GL_TEXTURE_MAG_FILTER")]
    TextureMagFilter = 0x2800,
    [NativeName("Name", "GL_TEXTURE_MIN_FILTER")]
    TextureMinFilter = 0x2801,
    [NativeName("Name", "GL_TEXTURE_WRAP_S")]
    TextureWrapS = 0x2802,
    [NativeName("Name", "GL_TEXTURE_WRAP_T")]
    TextureWrapT = 0x2803,
    [NativeName("Name", "GL_TEXTURE_WRAP_R")]
    TextureWrapR = 0x8072,
    [NativeName("Name", "GL_TEXTURE_COMPARE_MODE")]
    TextureCompareMode = 0x884C,
    [NativeName("Name", "GL_TEXTURE_COMPARE_FUNC")]
    TextureCompareFunc = 0x884D,
    [NativeName("Name", "GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
    TextureUnnormalizedCoordinatesArm = 0x8F6A,
}
