// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.EGL.Extensions.EXT
{
    public static class ExtSwapBuffersWithDamageOverloads
    {
        public static unsafe bool SwapBuffersWithDamage(this ExtSwapBuffersWithDamage thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] ReadOnlySpan<int> rects, [Flow(FlowDirection.In)] int n_rects)
        {
            // SpanOverloader
            return thisApi.SwapBuffersWithDamage(dpy, surface, in rects.GetPinnableReference(), n_rects);
        }

    }
}

