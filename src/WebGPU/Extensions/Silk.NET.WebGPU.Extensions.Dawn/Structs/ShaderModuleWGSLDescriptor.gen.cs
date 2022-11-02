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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUShaderModuleWGSLDescriptor")]
    public unsafe partial struct ShaderModuleWGSLDescriptor
    {
        public ShaderModuleWGSLDescriptor
        (
            ChainedStruct? chain = null,
            byte* source = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (source is not null)
            {
                Source = source;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "source")]
        public byte* Source;
    }
}
