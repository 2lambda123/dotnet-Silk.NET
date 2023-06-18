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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_maintenance4")]
    public unsafe partial class KhrMaintenance4 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_maintenance4";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceBufferMemoryRequirementsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceBufferMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceBufferMemoryRequirements* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceImageMemoryRequirementsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceImageMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageMemoryRequirements* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceImageSparseMemoryRequirementsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDeviceImageSparseMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceImageMemoryRequirements* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements);

        public KhrMaintenance4(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

