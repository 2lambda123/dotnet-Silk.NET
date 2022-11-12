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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D11_OPTIONS2")]
    public unsafe partial struct FeatureDataD3D11Options2
    {
        public FeatureDataD3D11Options2
        (
            bool? pSSpecifiedStencilRefSupported = null,
            bool? typedUAVLoadAdditionalFormats = null,
            bool? rOVsSupported = null,
            ConservativeRasterizationTier? conservativeRasterizationTier = null,
            TiledResourcesTier? tiledResourcesTier = null,
            bool? mapOnDefaultTextures = null,
            bool? standardSwizzle = null,
            bool? unifiedMemoryArchitecture = null
        ) : this()
        {
            if (pSSpecifiedStencilRefSupported is not null)
            {
                PSSpecifiedStencilRefSupported = pSSpecifiedStencilRefSupported.Value;
            }

            if (typedUAVLoadAdditionalFormats is not null)
            {
                TypedUAVLoadAdditionalFormats = typedUAVLoadAdditionalFormats.Value;
            }

            if (rOVsSupported is not null)
            {
                ROVsSupported = rOVsSupported.Value;
            }

            if (conservativeRasterizationTier is not null)
            {
                ConservativeRasterizationTier = conservativeRasterizationTier.Value;
            }

            if (tiledResourcesTier is not null)
            {
                TiledResourcesTier = tiledResourcesTier.Value;
            }

            if (mapOnDefaultTextures is not null)
            {
                MapOnDefaultTextures = mapOnDefaultTextures.Value;
            }

            if (standardSwizzle is not null)
            {
                StandardSwizzle = standardSwizzle.Value;
            }

            if (unifiedMemoryArchitecture is not null)
            {
                UnifiedMemoryArchitecture = unifiedMemoryArchitecture.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "PSSpecifiedStencilRefSupported")]
        public bool PSSpecifiedStencilRefSupported;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "TypedUAVLoadAdditionalFormats")]
        public bool TypedUAVLoadAdditionalFormats;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ROVsSupported")]
        public bool ROVsSupported;

        [NativeName("Type", "D3D11_CONSERVATIVE_RASTERIZATION_TIER")]
        [NativeName("Type.Name", "D3D11_CONSERVATIVE_RASTERIZATION_TIER")]
        [NativeName("Name", "ConservativeRasterizationTier")]
        public ConservativeRasterizationTier ConservativeRasterizationTier;

        [NativeName("Type", "D3D11_TILED_RESOURCES_TIER")]
        [NativeName("Type.Name", "D3D11_TILED_RESOURCES_TIER")]
        [NativeName("Name", "TiledResourcesTier")]
        public TiledResourcesTier TiledResourcesTier;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MapOnDefaultTextures")]
        public bool MapOnDefaultTextures;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "StandardSwizzle")]
        public bool StandardSwizzle;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "UnifiedMemoryArchitecture")]
        public bool UnifiedMemoryArchitecture;
    }
}
