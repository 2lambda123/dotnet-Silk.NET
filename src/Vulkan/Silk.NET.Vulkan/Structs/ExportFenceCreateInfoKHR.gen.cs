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
    [NativeName("Name", "VkExportFenceCreateInfoKHR")]
    public unsafe partial struct ExportFenceCreateInfoKHR
    {
        public ExportFenceCreateInfoKHR
        (
            StructureType? sType = StructureType.ExportFenceCreateInfo,
            void* pNext = null,
            ExternalFenceHandleTypeFlags? handleTypes = null
        )
        {
            fixed (ExportFenceCreateInfoKHR* @this = &this)
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

            if (handleTypes is not null)
            {
                HandleTypes = handleTypes.Value;
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
        [NativeName("Type", "VkExternalFenceHandleTypeFlags")]
        [NativeName("Type.Name", "VkExternalFenceHandleTypeFlags")]
        [NativeName("Name", "handleTypes")]
        public ExternalFenceHandleTypeFlags HandleTypes;
    }
}
