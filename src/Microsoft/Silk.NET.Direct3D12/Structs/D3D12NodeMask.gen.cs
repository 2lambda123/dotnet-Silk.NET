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

namespace Silk.NET.Direct3D12;

[NativeName("Name", "D3D12_NODE_MASK")]
public unsafe partial struct D3D12NodeMask
{
    public D3D12NodeMask
    (
            uint? nodeMask = null
    ) : this()
    {
        if (nodeMask is not null)
        {
            NodeMask = nodeMask.Value;
        }
    }


    [NativeName("Type", "UINT")]
    [NativeName("Type.Name", "UINT")]
    [NativeName("Name", "NodeMask")]
    public uint NodeMask;
}
