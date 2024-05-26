// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum UniformType : uint
{
    Int = unchecked((uint)0x1404),
    UnsignedInt = unchecked((uint)0x1405),
    Float = unchecked((uint)0x1406),
    Double = unchecked((uint)0x140A),
    FloatVec2 = unchecked((uint)0x8B50),
    FloatVec3 = unchecked((uint)0x8B51),
    FloatVec4 = unchecked((uint)0x8B52),
    IntVec2 = unchecked((uint)0x8B53),
    IntVec3 = unchecked((uint)0x8B54),
    IntVec4 = unchecked((uint)0x8B55),
    Bool = unchecked((uint)0x8B56),
    BoolVec2 = unchecked((uint)0x8B57),
    BoolVec3 = unchecked((uint)0x8B58),
    BoolVec4 = unchecked((uint)0x8B59),
    FloatMat2 = unchecked((uint)0x8B5A),
    FloatMat3 = unchecked((uint)0x8B5B),
    FloatMat4 = unchecked((uint)0x8B5C),
    Sampler1D = unchecked((uint)0x8B5D),
    Sampler2D = unchecked((uint)0x8B5E),
    Sampler3D = unchecked((uint)0x8B5F),
    SamplerCube = unchecked((uint)0x8B60),
    Sampler1DShadow = unchecked((uint)0x8B61),
    Sampler2DShadow = unchecked((uint)0x8B62),
    FloatMAT2X3 = unchecked((uint)0x8B65),
    FloatMAT2X4 = unchecked((uint)0x8B66),
    FloatMAT3X2 = unchecked((uint)0x8B67),
    FloatMAT3X4 = unchecked((uint)0x8B68),
    FloatMAT4X2 = unchecked((uint)0x8B69),
    FloatMAT4X3 = unchecked((uint)0x8B6A),
    Sampler1DArray = unchecked((uint)0x8DC0),
    Sampler2DArray = unchecked((uint)0x8DC1),
    Sampler1DArrayShadow = unchecked((uint)0x8DC3),
    Sampler2DArrayShadow = unchecked((uint)0x8DC4),
    SamplerCubeShadow = unchecked((uint)0x8DC5),
    UnsignedIntVec2 = unchecked((uint)0x8DC6),
    UnsignedIntVec3 = unchecked((uint)0x8DC7),
    UnsignedIntVec4 = unchecked((uint)0x8DC8),
    IntSampler1D = unchecked((uint)0x8DC9),
    IntSampler2D = unchecked((uint)0x8DCA),
    IntSampler3D = unchecked((uint)0x8DCB),
    IntSamplerCube = unchecked((uint)0x8DCC),
    IntSampler1DArray = unchecked((uint)0x8DCE),
    IntSampler2DArray = unchecked((uint)0x8DCF),
    UnsignedIntSampler1D = unchecked((uint)0x8DD1),
    UnsignedIntSampler2D = unchecked((uint)0x8DD2),
    UnsignedIntSampler3D = unchecked((uint)0x8DD3),
    UnsignedIntSamplerCube = unchecked((uint)0x8DD4),
    UnsignedIntSampler1DArray = unchecked((uint)0x8DD6),
    UnsignedIntSampler2DArray = unchecked((uint)0x8DD7),
    Sampler2DRect = unchecked((uint)0x8B63),
    Sampler2DRectShadow = unchecked((uint)0x8B64),
    SamplerBuffer = unchecked((uint)0x8DC2),
    IntSampler2DRect = unchecked((uint)0x8DCD),
    IntSamplerBuffer = unchecked((uint)0x8DD0),
    UnsignedIntSampler2DRect = unchecked((uint)0x8DD5),
    UnsignedIntSamplerBuffer = unchecked((uint)0x8DD8),
    Sampler2DMultisample = unchecked((uint)0x9108),
    IntSampler2DMultisample = unchecked((uint)0x9109),
    UnsignedIntSampler2DMultisample = unchecked((uint)0x910A),
    Sampler2DMultisampleArray = unchecked((uint)0x910B),
    IntSampler2DMultisampleArray = unchecked((uint)0x910C),
    UnsignedIntSampler2DMultisampleArray = unchecked((uint)0x910D),
    SamplerCubeMapArray = unchecked((uint)0x900C),
    SamplerCubeMapArrayShadow = unchecked((uint)0x900D),
    IntSamplerCubeMapArray = unchecked((uint)0x900E),
    UnsignedIntSamplerCubeMapArray = unchecked((uint)0x900F),
    DoubleVec2 = unchecked((uint)0x8FFC),
    DoubleVec3 = unchecked((uint)0x8FFD),
    DoubleVec4 = unchecked((uint)0x8FFE),
    DoubleMat2 = unchecked((uint)0x8F46),
    DoubleMat3 = unchecked((uint)0x8F47),
    DoubleMat4 = unchecked((uint)0x8F48),
    DoubleMAT2X3 = unchecked((uint)0x8F49),
    DoubleMAT2X4 = unchecked((uint)0x8F4A),
    DoubleMAT3X2 = unchecked((uint)0x8F4B),
    DoubleMAT3X4 = unchecked((uint)0x8F4C),
    DoubleMAT4X2 = unchecked((uint)0x8F4D),
    DoubleMAT4X3 = unchecked((uint)0x8F4E)
}
