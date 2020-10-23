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
    [NativeName("Name", "VkDeviceEventInfoEXT")]
    public unsafe partial struct DeviceEventInfoEXT
    {
        public DeviceEventInfoEXT
        (
            StructureType? sType = StructureType.DeviceEventInfoExt,
            void* pNext = null,
            DeviceEventTypeEXT? deviceEvent = null
        )
        {
            fixed (DeviceEventInfoEXT* @this = &this)
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

            if (deviceEvent is not null)
            {
                DeviceEvent = deviceEvent.Value;
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
        [NativeName("Type", "VkDeviceEventTypeEXT")]
        [NativeName("Type.Name", "VkDeviceEventTypeEXT")]
        [NativeName("Name", "deviceEvent")]
        public DeviceEventTypeEXT DeviceEvent;
    }
}
