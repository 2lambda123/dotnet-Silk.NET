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

namespace Silk.NET.OpenGL.Extensions.EXT
{
    public static class ExtDrawInstancedOverloads
    {
        public static unsafe void DrawElementsInstanced<T0>(this ExtDrawInstanced thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint primcount) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indicesSpp = indices)
                thisApi.DrawElementsInstanced(mode, count, type, indicesSpp, primcount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this ExtDrawInstanced thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint primcount) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indicesSpp = indices)
                thisApi.DrawElementsInstanced(mode, count, type, indicesSpp, primcount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this ExtDrawInstanced thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint primcount) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indicesSpp = indices)
                thisApi.DrawElementsInstanced(mode, count, type, indicesSpp, primcount);
        }

    }
}

