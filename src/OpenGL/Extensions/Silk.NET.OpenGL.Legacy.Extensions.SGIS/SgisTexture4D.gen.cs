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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_texture4D")]
    public unsafe partial class SgisTexture4D : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_texture4D";
        [NativeApi(EntryPoint = "glTexImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexImage4D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size4d, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage4DSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexSubImage4D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int woffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size4d, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS type, [Count(Computed = "format, type, width, height, depth, size4d"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        public SgisTexture4D(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

