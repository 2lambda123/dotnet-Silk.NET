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

namespace Silk.NET.Vulkan.Video;

[NativeName("Name", "StdVideoDecodeH265ReferenceInfoFlags")]
public unsafe partial struct StdVideoDecodeH265ReferenceInfoFlags
{
    public StdVideoDecodeH265ReferenceInfoFlags
    (
            uint? isLongTerm = null,
            uint? isNonExisting = null
    ) : this()
    {
        if (isLongTerm is not null)
        {
            IsLongTerm = isLongTerm.Value;
        }

        if (isNonExisting is not null)
        {
            IsNonExisting = isNonExisting.Value;
        }
    }


    private uint _bitfield1;

    public uint IsLongTerm
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (uint)(_bitfield1 & 0x1u);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
    }

    public uint IsNonExisting
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => (uint)((_bitfield1 >> 1) & 0x1u);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
    }
}
