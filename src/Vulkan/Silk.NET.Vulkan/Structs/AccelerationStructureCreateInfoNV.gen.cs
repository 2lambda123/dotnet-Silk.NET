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
    [NativeName("Name", "VkAccelerationStructureCreateInfoNV")]
    public unsafe partial struct AccelerationStructureCreateInfoNV
    {
        public AccelerationStructureCreateInfoNV
        (
            StructureType? sType = StructureType.AccelerationStructureCreateInfoNV,
            void* pNext = null,
            ulong? compactedSize = null,
            AccelerationStructureInfoNV? info = null
        )
        {
            fixed (AccelerationStructureCreateInfoNV* @this = &this)
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

            if (compactedSize is not null)
            {
                CompactedSize = compactedSize.Value;
            }

            if (info is not null)
            {
                Info = info.Value;
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
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "compactedSize")]
        public ulong CompactedSize;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureInfoNV")]
        [NativeName("Type.Name", "VkAccelerationStructureInfoNV")]
        [NativeName("Name", "info")]
        public AccelerationStructureInfoNV Info;
    }
}
