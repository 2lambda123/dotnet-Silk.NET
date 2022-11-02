// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUTextureSampleType")]
    public enum TextureSampleType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "WGPUTextureSampleType_Undefined")]
        TextureSampleTypeUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"Float\"")]
        [NativeName("Name", "WGPUTextureSampleType_Float")]
        TextureSampleTypeFloat = 0x1,
        [Obsolete("Deprecated in favour of \"UnfilterableFloat\"")]
        [NativeName("Name", "WGPUTextureSampleType_UnfilterableFloat")]
        TextureSampleTypeUnfilterableFloat = 0x2,
        [Obsolete("Deprecated in favour of \"Depth\"")]
        [NativeName("Name", "WGPUTextureSampleType_Depth")]
        TextureSampleTypeDepth = 0x3,
        [Obsolete("Deprecated in favour of \"Sint\"")]
        [NativeName("Name", "WGPUTextureSampleType_Sint")]
        TextureSampleTypeSint = 0x4,
        [Obsolete("Deprecated in favour of \"Uint\"")]
        [NativeName("Name", "WGPUTextureSampleType_Uint")]
        TextureSampleTypeUint = 0x5,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUTextureSampleType_Force32")]
        TextureSampleTypeForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUTextureSampleType_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUTextureSampleType_Float")]
        Float = 0x1,
        [NativeName("Name", "WGPUTextureSampleType_UnfilterableFloat")]
        UnfilterableFloat = 0x2,
        [NativeName("Name", "WGPUTextureSampleType_Depth")]
        Depth = 0x3,
        [NativeName("Name", "WGPUTextureSampleType_Sint")]
        Sint = 0x4,
        [NativeName("Name", "WGPUTextureSampleType_Uint")]
        Uint = 0x5,
        [NativeName("Name", "WGPUTextureSampleType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
