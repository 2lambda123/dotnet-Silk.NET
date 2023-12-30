// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using static Silk.NET.DirectX.D3D12_VIDEO_PROCESS_FILTER;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS"]/*'/>
[Flags]
public enum D3D12_VIDEO_PROCESS_FILTER_FLAGS
{
    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_NONE"]/*'/>

    D3D12_VIDEO_PROCESS_FILTER_FLAG_NONE = 0,

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_BRIGHTNESS"]/*'/>

    D3D12_VIDEO_PROCESS_FILTER_FLAG_BRIGHTNESS = (1 << D3D12_VIDEO_PROCESS_FILTER_BRIGHTNESS),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_CONTRAST"]/*'/>

    D3D12_VIDEO_PROCESS_FILTER_FLAG_CONTRAST = (1 << D3D12_VIDEO_PROCESS_FILTER_CONTRAST),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_HUE"]/*'/>

    D3D12_VIDEO_PROCESS_FILTER_FLAG_HUE = (1 << D3D12_VIDEO_PROCESS_FILTER_HUE),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_SATURATION"]/*'/>

    D3D12_VIDEO_PROCESS_FILTER_FLAG_SATURATION = (1 << D3D12_VIDEO_PROCESS_FILTER_SATURATION),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_NOISE_REDUCTION"]/*'/>

    D3D12_VIDEO_PROCESS_FILTER_FLAG_NOISE_REDUCTION =
        (1 << D3D12_VIDEO_PROCESS_FILTER_NOISE_REDUCTION),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_EDGE_ENHANCEMENT"]/*'/>

    D3D12_VIDEO_PROCESS_FILTER_FLAG_EDGE_ENHANCEMENT =
        (1 << D3D12_VIDEO_PROCESS_FILTER_EDGE_ENHANCEMENT),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_ANAMORPHIC_SCALING"]/*'/>

    D3D12_VIDEO_PROCESS_FILTER_FLAG_ANAMORPHIC_SCALING =
        (1 << D3D12_VIDEO_PROCESS_FILTER_ANAMORPHIC_SCALING),

    /// <include file='D3D12_VIDEO_PROCESS_FILTER_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FILTER_FLAGS.D3D12_VIDEO_PROCESS_FILTER_FLAG_STEREO_ADJUSTMENT"]/*'/>

    D3D12_VIDEO_PROCESS_FILTER_FLAG_STEREO_ADJUSTMENT =
        (1 << D3D12_VIDEO_PROCESS_FILTER_STEREO_ADJUSTMENT),
}
