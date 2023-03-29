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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    public static class KhrSubgroupsOverloads
    {
        public static unsafe int GetKernelSubGroupInfo<T0, T1>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] KernelSubGroupInfo param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] Span<T0> input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* input_valueSpp = input_value)
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_valueSpp, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (KernelSubGroupInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetKernelSubGroupInfo<T0, T1>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] Span<T0> input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* input_valueSpp = input_value)
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_valueSpp, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (KernelSubGroupInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        public static unsafe int GetKernelSubGroupInfo<T0, T1>(this KhrSubgroups thisApi, [Flow(FlowDirection.In)] nint in_kernel, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] uint param_name, [Flow(FlowDirection.In)] nuint input_value_size, [Flow(FlowDirection.In)] Span<T0> input_value, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T1> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* input_valueSpp = input_value)
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetKernelSubGroupInfo(in_kernel, in_device, param_name, input_value_size, input_valueSpp, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

    }
}

