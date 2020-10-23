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
    [NativeName("Name", "XrGraphicsBindingVulkanKHR")]
    public unsafe partial struct GraphicsBindingVulkanKHR
    {
        public GraphicsBindingVulkanKHR
        (
            StructureType? type = StructureType.TypeGraphicsBindingVulkanKhr,
            void* next = null,
            Silk.NET.Core.Native.VkHandle? instance = null,
            Silk.NET.Core.Native.VkHandle? physicalDevice = null,
            Silk.NET.Core.Native.VkHandle? device = null,
            uint? queueFamilyIndex = null,
            uint? queueIndex = null
        )
        {
            fixed (GraphicsBindingVulkanKHR* @this = &this)
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

            if (instance is not null)
            {
                Instance = instance.Value;
            }

            if (physicalDevice is not null)
            {
                PhysicalDevice = physicalDevice.Value;
            }

            if (device is not null)
            {
                Device = device.Value;
            }

            if (queueFamilyIndex is not null)
            {
                QueueFamilyIndex = queueFamilyIndex.Value;
            }

            if (queueIndex is not null)
            {
                QueueIndex = queueIndex.Value;
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
        [NativeName("Type", "VkInstance")]
        [NativeName("Type.Name", "VkInstance")]
        [NativeName("Name", "instance")]
        public Silk.NET.Core.Native.VkHandle Instance;
/// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevice")]
        public Silk.NET.Core.Native.VkHandle PhysicalDevice;
/// <summary></summary>
        [NativeName("Type", "VkDevice")]
        [NativeName("Type.Name", "VkDevice")]
        [NativeName("Name", "device")]
        public Silk.NET.Core.Native.VkHandle Device;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueFamilyIndex")]
        public uint QueueFamilyIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueIndex")]
        public uint QueueIndex;
    }
}
