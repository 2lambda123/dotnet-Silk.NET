// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ShadingRateCombinerOp")]
    public enum ShadingRateCombinerOp : int
    {
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_EXT")]
        FragmentShadingRateCombinerOpKeepExt = 0x96D2,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_EXT")]
        FragmentShadingRateCombinerOpReplaceExt = 0x96D3,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_EXT")]
        FragmentShadingRateCombinerOpMinExt = 0x96D4,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_EXT")]
        FragmentShadingRateCombinerOpMaxExt = 0x96D5,
        [NativeName("Name", "GL_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_EXT")]
        FragmentShadingRateCombinerOpMulExt = 0x96D6,
    }
}
