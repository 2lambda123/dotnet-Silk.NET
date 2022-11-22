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
    [NativeName("Name", "D3D12_RASTERIZER_DESC")]
    public unsafe partial struct RasterizerDesc
    {
        public RasterizerDesc
        (
            FillMode? fillMode = null,
            CullMode? cullMode = null,
            Silk.NET.Core.Bool32? frontCounterClockwise = null,
            int? depthBias = null,
            float? depthBiasClamp = null,
            float? slopeScaledDepthBias = null,
            Silk.NET.Core.Bool32? depthClipEnable = null,
            Silk.NET.Core.Bool32? multisampleEnable = null,
            Silk.NET.Core.Bool32? antialiasedLineEnable = null,
            uint? forcedSampleCount = null,
            ConservativeRasterizationMode? conservativeRaster = null
        ) : this()
        {
            if (fillMode is not null)
            {
                FillMode = fillMode.Value;
            }

            if (cullMode is not null)
            {
                CullMode = cullMode.Value;
            }

            if (frontCounterClockwise is not null)
            {
                FrontCounterClockwise = frontCounterClockwise.Value;
            }

            if (depthBias is not null)
            {
                DepthBias = depthBias.Value;
            }

            if (depthBiasClamp is not null)
            {
                DepthBiasClamp = depthBiasClamp.Value;
            }

            if (slopeScaledDepthBias is not null)
            {
                SlopeScaledDepthBias = slopeScaledDepthBias.Value;
            }

            if (depthClipEnable is not null)
            {
                DepthClipEnable = depthClipEnable.Value;
            }

            if (multisampleEnable is not null)
            {
                MultisampleEnable = multisampleEnable.Value;
            }

            if (antialiasedLineEnable is not null)
            {
                AntialiasedLineEnable = antialiasedLineEnable.Value;
            }

            if (forcedSampleCount is not null)
            {
                ForcedSampleCount = forcedSampleCount.Value;
            }

            if (conservativeRaster is not null)
            {
                ConservativeRaster = conservativeRaster.Value;
            }
        }


        [NativeName("Type", "D3D12_FILL_MODE")]
        [NativeName("Type.Name", "D3D12_FILL_MODE")]
        [NativeName("Name", "FillMode")]
        public FillMode FillMode;

        [NativeName("Type", "D3D12_CULL_MODE")]
        [NativeName("Type.Name", "D3D12_CULL_MODE")]
        [NativeName("Name", "CullMode")]
        public CullMode CullMode;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "FrontCounterClockwise")]
        public Silk.NET.Core.Bool32 FrontCounterClockwise;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "DepthBias")]
        public int DepthBias;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "DepthBiasClamp")]
        public float DepthBiasClamp;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "SlopeScaledDepthBias")]
        public float SlopeScaledDepthBias;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DepthClipEnable")]
        public Silk.NET.Core.Bool32 DepthClipEnable;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MultisampleEnable")]
        public Silk.NET.Core.Bool32 MultisampleEnable;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AntialiasedLineEnable")]
        public Silk.NET.Core.Bool32 AntialiasedLineEnable;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ForcedSampleCount")]
        public uint ForcedSampleCount;

        [NativeName("Type", "D3D12_CONSERVATIVE_RASTERIZATION_MODE")]
        [NativeName("Type.Name", "D3D12_CONSERVATIVE_RASTERIZATION_MODE")]
        [NativeName("Name", "ConservativeRaster")]
        public ConservativeRasterizationMode ConservativeRaster;
    }
}
