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

namespace Silk.NET.Vulkan;

[NativeName("Name", "VkDispatchIndirectCommand")]
public unsafe partial struct DispatchIndirectCommand
{
    public DispatchIndirectCommand
    (
            uint? x = null,
            uint? y = null,
            uint? z = null
    ) : this()
    {
        if (x is not null)
        {
            X = x.Value;
        }

        if (y is not null)
        {
            Y = y.Value;
        }

        if (z is not null)
        {
            Z = z.Value;
        }
    }

/// <summary></summary>
    [NativeName("Type", "uint32_t")]
    [NativeName("Type.Name", "uint32_t")]
    [NativeName("Name", "x")]
    public uint X;
/// <summary></summary>
    [NativeName("Type", "uint32_t")]
    [NativeName("Type.Name", "uint32_t")]
    [NativeName("Name", "y")]
    public uint Y;
/// <summary></summary>
    [NativeName("Type", "uint32_t")]
    [NativeName("Type.Name", "uint32_t")]
    [NativeName("Name", "z")]
    public uint Z;
}
