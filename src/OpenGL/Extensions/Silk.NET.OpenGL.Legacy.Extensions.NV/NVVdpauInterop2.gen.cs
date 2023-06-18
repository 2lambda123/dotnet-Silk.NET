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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_vdpau_interop2")]
    public unsafe partial class NVVdpauInterop2 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vdpau_interop2";
        [NativeApi(EntryPoint = "glVDPAURegisterVideoSurfaceWithPictureStructureNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint VdpauregisterVideoSurfaceWithPictureStructure([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* vdpSurface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textureNames, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool isFrameStructure);

        public NVVdpauInterop2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

