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
    [NativeName("Name", "VkPhysicalDeviceIDPropertiesKHR")]
    public unsafe partial struct PhysicalDeviceIDPropertiesKHR
    {
        public PhysicalDeviceIDPropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceIDProperties,
            void* pNext = null,
            uint? deviceNodeMask = null,
            Bool32? deviceLuidvalid = null
        )
        {
            fixed (PhysicalDeviceIDPropertiesKHR* @this = &this)
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

            if (deviceNodeMask is not null)
            {
                DeviceNodeMask = deviceNodeMask.Value;
            }

            if (deviceLuidvalid is not null)
            {
                DeviceLuidvalid = deviceLuidvalid.Value;
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
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "deviceUUID")]
        public fixed byte DeviceUuid[16];
        /// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "driverUUID")]
        public fixed byte DriverUuid[16];
        /// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "deviceLUID")]
        public fixed byte DeviceLuid[8];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceNodeMask")]
        public uint DeviceNodeMask;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "deviceLUIDValid")]
        public Bool32 DeviceLuidvalid;
    }
}
