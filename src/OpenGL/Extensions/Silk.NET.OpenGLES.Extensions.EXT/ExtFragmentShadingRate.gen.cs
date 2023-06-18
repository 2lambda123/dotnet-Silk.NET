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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_fragment_shading_rate")]
    public unsafe partial class ExtFragmentShadingRate : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_fragment_shading_rate";
        [NativeApi(EntryPoint = "glFramebufferShadingRateEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferShadingRate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int baseLayer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numLayers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texelWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texelHeight);

        [NativeApi(EntryPoint = "glGetFragmentShadingRatesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentShadingRates([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* shadingRates);

        [NativeApi(EntryPoint = "glShadingRateEXT", Convention = CallingConvention.Winapi)]
        public partial void ShadingRate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT rate);

        [NativeApi(EntryPoint = "glShadingRateCombinerOpsEXT", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateCombinerOp([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT combinerOp0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT combinerOp1);

        public ExtFragmentShadingRate(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

