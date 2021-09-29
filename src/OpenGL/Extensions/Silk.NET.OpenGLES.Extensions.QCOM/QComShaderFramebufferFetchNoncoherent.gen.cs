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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM;

[Extension("QCOM_shader_framebuffer_fetch_noncoherent")]
public unsafe partial class QComShaderFramebufferFetchNoncoherent : NativeExtension<GL>
{
    public const string ExtensionName = "QCOM_shader_framebuffer_fetch_noncoherent";
    [NativeApi(EntryPoint = "glFramebufferFetchBarrierQCOM")]
    public partial void FramebufferFetchBarrier();

    public QComShaderFramebufferFetchNoncoherent(INativeContext ctx)
        : base(ctx)
    {
    }
}

