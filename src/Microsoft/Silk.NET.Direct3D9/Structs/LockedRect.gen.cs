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

namespace Silk.NET.Direct3D9;

[NativeName("Name", "_D3DLOCKED_RECT")]
public unsafe partial struct LockedRect
{
    public LockedRect
    (
            int? pitch = null,
            void* pBits = null
    ) : this()
    {
        if (pitch is not null)
        {
            Pitch = pitch.Value;
        }

        if (pBits is not null)
        {
            PBits = pBits;
        }
    }


    [NativeName("Type", "INT")]
    [NativeName("Type.Name", "INT")]
    [NativeName("Name", "Pitch")]
    public int Pitch;

    [NativeName("Type", "void *")]
    [NativeName("Type.Name", "void *")]
    [NativeName("Name", "pBits")]
    public void* PBits;
}
