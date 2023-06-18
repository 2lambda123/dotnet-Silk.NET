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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_fragment_shader")]
    public unsafe partial class AtiFragmentShader : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_fragment_shader";
        [NativeApi(EntryPoint = "glAlphaFragmentOp1ATI", Convention = CallingConvention.Winapi)]
        public partial void AlphaFragmentOp1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI op, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstMod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1Rep, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1Mod);

        [NativeApi(EntryPoint = "glAlphaFragmentOp2ATI", Convention = CallingConvention.Winapi)]
        public partial void AlphaFragmentOp2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI op, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstMod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1Rep, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1Mod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2Rep, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2Mod);

        [NativeApi(EntryPoint = "glAlphaFragmentOp3ATI", Convention = CallingConvention.Winapi)]
        public partial void AlphaFragmentOp3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI op, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstMod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1Rep, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1Mod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2Rep, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2Mod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg3, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg3Rep, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg3Mod);

        [NativeApi(EntryPoint = "glBeginFragmentShaderATI", Convention = CallingConvention.Winapi)]
        public partial void BeginFragmentShader();

        [NativeApi(EntryPoint = "glBindFragmentShaderATI", Convention = CallingConvention.Winapi)]
        public partial void BindFragmentShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glColorFragmentOp1ATI", Convention = CallingConvention.Winapi)]
        public partial void ColorFragmentOp1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI op, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstMod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1Rep, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1Mod);

        [NativeApi(EntryPoint = "glColorFragmentOp2ATI", Convention = CallingConvention.Winapi)]
        public partial void ColorFragmentOp2([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI op, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstMod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1Rep, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1Mod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2Rep, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2Mod);

        [NativeApi(EntryPoint = "glColorFragmentOp3ATI", Convention = CallingConvention.Winapi)]
        public partial void ColorFragmentOp3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI op, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstMod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1Rep, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg1Mod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2Rep, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg2Mod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg3, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg3Rep, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arg3Mod);

        [NativeApi(EntryPoint = "glDeleteFragmentShaderATI", Convention = CallingConvention.Winapi)]
        public partial void DeleteFragmentShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glEndFragmentShaderATI", Convention = CallingConvention.Winapi)]
        public partial void EndFragmentShader();

        [NativeApi(EntryPoint = "glGenFragmentShadersATI", Convention = CallingConvention.Winapi)]
        public partial uint GenFragmentShaders([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glPassTexCoordATI", Convention = CallingConvention.Winapi)]
        public partial void PassTexCoord([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI swizzle);

        [NativeApi(EntryPoint = "glSampleMapATI", Convention = CallingConvention.Winapi)]
        public partial void SampleMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint interp, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI swizzle);

        [NativeApi(EntryPoint = "glSetFragmentShaderConstantATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetFragmentShaderConstant([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dst, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        public AtiFragmentShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

