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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDrmFormatModifierPropertiesListEXT")]
    public unsafe partial struct DrmFormatModifierPropertiesListEXT
    {
        public DrmFormatModifierPropertiesListEXT
        (
            StructureType? sType = StructureType.DrmFormatModifierPropertiesListExt,
            void* pNext = null,
            uint? drmFormatModifierCount = null,
            DrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties = null
        )
        {
            fixed (DrmFormatModifierPropertiesListEXT* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (drmFormatModifierCount is not null)
            {
                DrmFormatModifierCount = drmFormatModifierCount.Value;
            }

            if (pDrmFormatModifierProperties is not null)
            {
                PDrmFormatModifierProperties = pDrmFormatModifierProperties;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "drmFormatModifierCount")]
        public uint DrmFormatModifierCount;
/// <summary></summary>
        [NativeName("Type", "VkDrmFormatModifierPropertiesEXT*")]
        [NativeName("Type.Name", "VkDrmFormatModifierPropertiesEXT")]
        [NativeName("Name", "pDrmFormatModifierProperties")]
        public DrmFormatModifierPropertiesEXT* PDrmFormatModifierProperties;
    }
}
