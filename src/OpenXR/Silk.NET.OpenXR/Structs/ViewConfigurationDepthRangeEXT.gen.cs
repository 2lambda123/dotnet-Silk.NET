// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrViewConfigurationDepthRangeEXT")]
    public unsafe partial struct ViewConfigurationDepthRangeEXT
    {
        public ViewConfigurationDepthRangeEXT
        (
            StructureType? type = StructureType.TypeViewConfigurationDepthRangeExt,
            void* next = null,
            float? recommendedNearZ = null,
            float? minNearZ = null,
            float? recommendedFarZ = null,
            float? maxFarZ = null
        )
        {
            fixed (ViewConfigurationDepthRangeEXT* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (recommendedNearZ is not null)
            {
                RecommendedNearZ = recommendedNearZ.Value;
            }

            if (minNearZ is not null)
            {
                MinNearZ = minNearZ.Value;
            }

            if (recommendedFarZ is not null)
            {
                RecommendedFarZ = recommendedFarZ.Value;
            }

            if (maxFarZ is not null)
            {
                MaxFarZ = maxFarZ.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "recommendedNearZ")]
        public float RecommendedNearZ;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "minNearZ")]
        public float MinNearZ;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "recommendedFarZ")]
        public float RecommendedFarZ;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "maxFarZ")]
        public float MaxFarZ;
    }
}
