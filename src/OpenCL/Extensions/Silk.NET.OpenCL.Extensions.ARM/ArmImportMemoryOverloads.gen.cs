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

namespace Silk.NET.OpenCL.Extensions.ARM
{
    public static class ArmImportMemoryOverloads
    {
        public static unsafe nint ImportMemory(this ArmImportMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, properties, memory, size, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint ImportMemory<T0>(this ArmImportMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] Span<T0> memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, properties, out memory.GetPinnableReference(), size, errcode_ret);
        }

        public static unsafe nint ImportMemory<T0>(this ArmImportMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] nint* properties, [Flow(FlowDirection.Out)] Span<T0> memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, properties, out memory.GetPinnableReference(), size, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint ImportMemory(this ArmImportMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, in properties.GetPinnableReference(), memory, size, errcode_ret);
        }

        public static unsafe nint ImportMemory(this ArmImportMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.Out)] void* memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, in properties.GetPinnableReference(), memory, size, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint ImportMemory<T0>(this ArmImportMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.Out)] Span<T0> memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, in properties.GetPinnableReference(), out memory.GetPinnableReference(), size, errcode_ret);
        }

        public static unsafe nint ImportMemory<T0>(this ArmImportMemory thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ARM flags, [Flow(FlowDirection.In)] ReadOnlySpan<nint> properties, [Flow(FlowDirection.Out)] Span<T0> memory, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ImportMemory(context, flags, in properties.GetPinnableReference(), out memory.GetPinnableReference(), size, out errcode_ret.GetPinnableReference());
        }

    }
}

