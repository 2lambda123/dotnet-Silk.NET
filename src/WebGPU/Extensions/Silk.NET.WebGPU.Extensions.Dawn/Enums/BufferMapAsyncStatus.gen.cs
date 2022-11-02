// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUBufferMapAsyncStatus")]
    public enum BufferMapAsyncStatus : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Success\"")]
        [NativeName("Name", "WGPUBufferMapAsyncStatus_Success")]
        BufferMapAsyncStatusSuccess = 0x0,
        [Obsolete("Deprecated in favour of \"Error\"")]
        [NativeName("Name", "WGPUBufferMapAsyncStatus_Error")]
        BufferMapAsyncStatusError = 0x1,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "WGPUBufferMapAsyncStatus_Unknown")]
        BufferMapAsyncStatusUnknown = 0x2,
        [Obsolete("Deprecated in favour of \"DeviceLost\"")]
        [NativeName("Name", "WGPUBufferMapAsyncStatus_DeviceLost")]
        BufferMapAsyncStatusDeviceLost = 0x3,
        [Obsolete("Deprecated in favour of \"DestroyedBeforeCallback\"")]
        [NativeName("Name", "WGPUBufferMapAsyncStatus_DestroyedBeforeCallback")]
        BufferMapAsyncStatusDestroyedBeforeCallback = 0x4,
        [Obsolete("Deprecated in favour of \"UnmappedBeforeCallback\"")]
        [NativeName("Name", "WGPUBufferMapAsyncStatus_UnmappedBeforeCallback")]
        BufferMapAsyncStatusUnmappedBeforeCallback = 0x5,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUBufferMapAsyncStatus_Force32")]
        BufferMapAsyncStatusForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_Success")]
        Success = 0x0,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_Error")]
        Error = 0x1,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_Unknown")]
        Unknown = 0x2,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_DeviceLost")]
        DeviceLost = 0x3,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_DestroyedBeforeCallback")]
        DestroyedBeforeCallback = 0x4,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_UnmappedBeforeCallback")]
        UnmappedBeforeCallback = 0x5,
        [NativeName("Name", "WGPUBufferMapAsyncStatus_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
