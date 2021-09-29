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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI;

[Extension("ATI_draw_buffers")]
public unsafe partial class AtiDrawBuffers : NativeExtension<GL>
{
    public const string ExtensionName = "ATI_draw_buffers";
    [NativeApi(EntryPoint = "glDrawBuffersATI")]
    public unsafe partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ATI* bufs);

    [NativeApi(EntryPoint = "glDrawBuffersATI")]
    public partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in ATI bufs);

    [NativeApi(EntryPoint = "glDrawBuffersATI")]
    public unsafe partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] DrawBufferMode* bufs);

    [NativeApi(EntryPoint = "glDrawBuffersATI")]
    public partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in DrawBufferMode bufs);

    public unsafe void DrawBuffers([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<ATI> bufs)
    {
        // ImplicitCountSpanOverloader
        DrawBuffers((uint) bufs.Length, in bufs.GetPinnableReference());
    }

    public unsafe void DrawBuffers([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<DrawBufferMode> bufs)
    {
        // ImplicitCountSpanOverloader
        DrawBuffers((uint) bufs.Length, in bufs.GetPinnableReference());
    }

    public AtiDrawBuffers(INativeContext ctx)
        : base(ctx)
    {
    }
}

