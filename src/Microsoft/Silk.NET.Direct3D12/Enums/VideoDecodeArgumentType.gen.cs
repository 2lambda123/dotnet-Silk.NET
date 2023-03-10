// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE")]
    public enum VideoDecodeArgumentType : int
    {
        [Obsolete("Deprecated in favour of \"PictureParameters\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE_PICTURE_PARAMETERS")]
        VideoDecodeArgumentTypePictureParameters = 0x0,
        [Obsolete("Deprecated in favour of \"InverseQuantizationMatrix\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE_INVERSE_QUANTIZATION_MATRIX")]
        VideoDecodeArgumentTypeInverseQuantizationMatrix = 0x1,
        [Obsolete("Deprecated in favour of \"SliceControl\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE_SLICE_CONTROL")]
        VideoDecodeArgumentTypeSliceControl = 0x2,
        [Obsolete("Deprecated in favour of \"MaxValid\"")]
        [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE_MAX_VALID")]
        VideoDecodeArgumentTypeMaxValid = 0x3,
        [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE_PICTURE_PARAMETERS")]
        PictureParameters = 0x0,
        [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE_INVERSE_QUANTIZATION_MATRIX")]
        InverseQuantizationMatrix = 0x1,
        [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE_SLICE_CONTROL")]
        SliceControl = 0x2,
        [NativeName("Name", "D3D12_VIDEO_DECODE_ARGUMENT_TYPE_MAX_VALID")]
        MaxValid = 0x3,
    }
}
