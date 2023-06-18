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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_command_buffer")]
    public unsafe partial class KhrCommandBuffer : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_command_buffer";
        [NativeApi(EntryPoint = "clCommandBarrierWithWaitListKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int CommandBarrierWithWaitList([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sync_point_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* sync_point, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* mutable_handle);

        [NativeApi(EntryPoint = "clCommandCopyBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int CommandCopyBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint src_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint dst_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sync_point_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* sync_point, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* mutable_handle);

        [NativeApi(EntryPoint = "clCommandCopyBufferRectKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int CommandCopyBufferRect([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* src_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* dst_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint src_row_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint src_slice_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint dst_row_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint dst_slice_pitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sync_point_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* sync_point, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* mutable_handle);

        [NativeApi(EntryPoint = "clCommandCopyBufferToImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int CommandCopyBufferToImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint src_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* dst_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sync_point_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* sync_point, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* mutable_handle);

        [NativeApi(EntryPoint = "clCommandCopyImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int CommandCopyImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* src_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* dst_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sync_point_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* sync_point, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* mutable_handle);

        [NativeApi(EntryPoint = "clCommandCopyImageToBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int CommandCopyImageToBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint src_image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint dst_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* src_origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint dst_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sync_point_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* sync_point, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* mutable_handle);

        [NativeApi(EntryPoint = "clCommandFillBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int CommandFillBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pattern, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint pattern_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sync_point_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* sync_point, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* mutable_handle);

        [NativeApi(EntryPoint = "clCommandFillImageKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int CommandFillImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fill_color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* origin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sync_point_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* sync_point, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* mutable_handle);

        [NativeApi(EntryPoint = "clCommandNDRangeKernelKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int CommandNdrangeKernel([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NdrangeKernelCommandProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint kernel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint work_dim, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* global_work_offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* global_work_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint* local_work_size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_sync_points_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sync_point_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* sync_point, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* mutable_handle);

        [NativeApi(EntryPoint = "clCreateCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandBufferProperties* properties, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clEnqueueCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_queues, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* queues, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clFinalizeCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public partial int FinalizeCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer);

        [NativeApi(EntryPoint = "clGetCommandBufferInfoKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetCommandBufferInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandBufferInfo param_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint param_value_size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* param_value, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nuint* param_value_size_ret);

        [NativeApi(EntryPoint = "clReleaseCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public partial int ReleaseCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer);

        [NativeApi(EntryPoint = "clRetainCommandBufferKHR", Convention = CallingConvention.Winapi)]
        public partial int RetainCommandBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_buffer);

        public KhrCommandBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

