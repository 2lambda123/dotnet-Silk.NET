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
    [Extension("VK_NV_device_diagnostic_checkpoints")]
    public unsafe partial class NVDeviceDiagnosticCheckpoints : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_device_diagnostic_checkpoints";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCheckpointNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetCheckpoint([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] void* pCheckpointMarker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetQueueCheckpointDataNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueueCheckpointData([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint* pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CheckpointDataNV* pCheckpointData);

        public NVDeviceDiagnosticCheckpoints(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

