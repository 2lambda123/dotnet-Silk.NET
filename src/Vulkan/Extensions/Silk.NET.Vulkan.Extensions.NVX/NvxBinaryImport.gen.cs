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

namespace Silk.NET.Vulkan.Extensions.NVX
{
    [Extension("VK_NVX_binary_import")]
    public unsafe partial class NvxBinaryImport : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NVX_binary_import";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCuLaunchKernelNVX")]
        public unsafe partial void CmdCuLaunchKernel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] CuLaunchInfoNVX* pLaunchInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdCuLaunchKernelNVX")]
        public partial void CmdCuLaunchKernel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in CuLaunchInfoNVX pLaunchInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuFunctionNVX")]
        public unsafe partial Result CreateCuFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CuFunctionCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CuFunctionNVX* pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuFunctionNVX")]
        public unsafe partial Result CreateCuFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CuFunctionCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CuFunctionNVX pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuFunctionNVX")]
        public unsafe partial Result CreateCuFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CuFunctionCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CuFunctionNVX* pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuFunctionNVX")]
        public unsafe partial Result CreateCuFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CuFunctionCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CuFunctionNVX pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuFunctionNVX")]
        public unsafe partial Result CreateCuFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CuFunctionCreateInfoNVX pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CuFunctionNVX* pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuFunctionNVX")]
        public unsafe partial Result CreateCuFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CuFunctionCreateInfoNVX pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CuFunctionNVX pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuFunctionNVX")]
        public unsafe partial Result CreateCuFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CuFunctionCreateInfoNVX pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CuFunctionNVX* pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuFunctionNVX")]
        public partial Result CreateCuFunction([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CuFunctionCreateInfoNVX pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CuFunctionNVX pFunction);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuModuleNVX")]
        public unsafe partial Result CreateCuModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CuModuleCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CuModuleNVX* pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuModuleNVX")]
        public unsafe partial Result CreateCuModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CuModuleCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CuModuleNVX pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuModuleNVX")]
        public unsafe partial Result CreateCuModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CuModuleCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CuModuleNVX* pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuModuleNVX")]
        public unsafe partial Result CreateCuModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] CuModuleCreateInfoNVX* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CuModuleNVX pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuModuleNVX")]
        public unsafe partial Result CreateCuModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CuModuleCreateInfoNVX pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CuModuleNVX* pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuModuleNVX")]
        public unsafe partial Result CreateCuModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CuModuleCreateInfoNVX pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CuModuleNVX pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuModuleNVX")]
        public unsafe partial Result CreateCuModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CuModuleCreateInfoNVX pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] CuModuleNVX* pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateCuModuleNVX")]
        public partial Result CreateCuModule([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in CuModuleCreateInfoNVX pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out CuModuleNVX pModule);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyCuFunctionNVX")]
        public unsafe partial void DestroyCuFunction([Count(Count = 0)] Device device, [Count(Count = 0)] CuFunctionNVX function, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyCuFunctionNVX")]
        public partial void DestroyCuFunction([Count(Count = 0)] Device device, [Count(Count = 0)] CuFunctionNVX function, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyCuModuleNVX")]
        public unsafe partial void DestroyCuModule([Count(Count = 0)] Device device, [Count(Count = 0)] CuModuleNVX module, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyCuModuleNVX")]
        public partial void DestroyCuModule([Count(Count = 0)] Device device, [Count(Count = 0)] CuModuleNVX module, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        public NvxBinaryImport(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

