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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_device_generated_commands")]
    public unsafe partial class NVDeviceGeneratedCommands : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_device_generated_commands";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindPipelineShaderGroupNV", Convention = CallingConvention.Winapi)]
        public partial void CmdBindPipelineShaderGroup([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] Pipeline pipeline, [Count(Count = 0)] uint groupIndex);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdExecuteGeneratedCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdExecuteGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Bool32 isPreprocessed, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] GeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPreprocessGeneratedCommandsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdPreprocessGeneratedCommands([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] GeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateIndirectCommandsLayoutNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] IndirectCommandsLayoutCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] IndirectCommandsLayoutNV* pIndirectCommandsLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyIndirectCommandsLayoutNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyIndirectCommandsLayout([Count(Count = 0)] Device device, [Count(Count = 0)] IndirectCommandsLayoutNV indirectCommandsLayout, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetGeneratedCommandsMemoryRequirements([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] GeneratedCommandsMemoryRequirementsInfoNV* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements);

        public NVDeviceGeneratedCommands(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

