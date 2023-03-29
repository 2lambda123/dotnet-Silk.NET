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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVExternalMemoryRdmaOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryRemoteAddress<T0>(this NVExternalMemoryRdma thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<MemoryGetRemoteAddressInfoNV> pMemoryGetRemoteAddressInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<T0> pAddress) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pAddressSpp = pAddress)
                return thisApi.GetMemoryRemoteAddress(device, in pMemoryGetRemoteAddressInfo.GetPinnableReference(), pAddressSpp);
        }

    }
}

