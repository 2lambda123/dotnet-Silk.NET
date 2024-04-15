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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUNativeLimits")]
    public unsafe partial struct NativeLimits
    {
        public NativeLimits
        (
            uint? maxPushConstantSize = null,
            uint? maxNonSamplerBindings = null
        ) : this()
        {
            if (maxPushConstantSize is not null)
            {
                MaxPushConstantSize = maxPushConstantSize.Value;
            }

            if (maxNonSamplerBindings is not null)
            {
                MaxNonSamplerBindings = maxNonSamplerBindings.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPushConstantSize")]
        public uint MaxPushConstantSize;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxNonSamplerBindings")]
        public uint MaxNonSamplerBindings;
    }
}
