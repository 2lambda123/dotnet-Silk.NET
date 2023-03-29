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
    [Extension("INTEL_create_buffer_with_properties")]
    public unsafe partial class IntelCreateBufferWithProperties : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_create_buffer_with_properties";
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in MemProperties properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in MemProperties properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in MemProperties properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in MemProperties properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [Obsolete("The \"ungrouped\" enums (INTEL, CLEnum) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateBufferWithProperties([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] in CLEnum properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        public IntelCreateBufferWithProperties(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

