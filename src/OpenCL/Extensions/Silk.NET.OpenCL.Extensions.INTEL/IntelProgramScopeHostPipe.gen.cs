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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_program_scope_host_pipe")]
    public unsafe partial class IntelProgramScopeHostPipe : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_program_scope_host_pipe";
        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReadHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueReadHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueReadHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueReadHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_read, [Flow(FlowDirection.Out)] out T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] byte* pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueWriteHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In)] in byte pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] nint* event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueWriteHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] nint* @event) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clEnqueueWriteHostPipeINTEL", Convention = CallingConvention.Winapi)]
        public partial int EnqueueWriteHostPipe<T0>([Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint program, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pipe_symbol, [Flow(FlowDirection.In)] bool blocking_write, [Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint num_events_in_wait_list, [Flow(FlowDirection.In)] in nint event_wait_list, [Flow(FlowDirection.Out)] out nint @event) where T0 : unmanaged;

        public IntelProgramScopeHostPipe(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

