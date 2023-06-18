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
    [Extension("VK_KHR_maintenance3")]
    public unsafe partial class KhrMaintenance3 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_maintenance3";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDescriptorSetLayoutSupportKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDescriptorSetLayoutSupport([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorSetLayoutCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DescriptorSetLayoutSupport* pSupport);

        public KhrMaintenance3(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

