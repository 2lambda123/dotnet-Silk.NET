// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_INTRA_REFRESH")]
    public unsafe partial struct VideoEncoderIntraRefresh
    {
        public VideoEncoderIntraRefresh
        (
            VideoEncoderIntraRefreshMode? mode = null,
            uint? intraRefreshDuration = null
        ) : this()
        {
            if (mode is not null)
            {
                Mode = mode.Value;
            }

            if (intraRefreshDuration is not null)
            {
                IntraRefreshDuration = intraRefreshDuration.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE")]
        [NativeName("Name", "Mode")]
        public VideoEncoderIntraRefreshMode Mode;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "IntraRefreshDuration")]
        public uint IntraRefreshDuration;
    }
}
