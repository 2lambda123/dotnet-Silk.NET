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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_texture_border_clamp")]
    public unsafe partial class OesTextureBorderClamp : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_texture_border_clamp";
        [NativeApi(EntryPoint = "glGetSamplerParameterIivOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuivOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIivOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuivOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glSamplerParameterIivOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuivOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void SamplerParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glTexParameterIivOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIuivOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        public OesTextureBorderClamp(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

