// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.KHR
{
    [Extension("KHR_parallel_shader_compile")]
    public unsafe partial class KhrParallelShaderCompile : NativeExtension<GL>
    {
        public const string ExtensionName = "KHR_parallel_shader_compile";
        [NativeApi(EntryPoint = "glMaxShaderCompilerThreadsKHR")]
        public partial void MaxShaderCompilerThreads([Flow(FlowDirection.In)] uint count);

        public KhrParallelShaderCompile(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

