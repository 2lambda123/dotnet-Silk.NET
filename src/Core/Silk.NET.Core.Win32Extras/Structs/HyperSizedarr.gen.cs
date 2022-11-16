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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_HYPER_SIZEDARR")]
    public unsafe partial struct HyperSizedarr
    {
        public HyperSizedarr
        (
            uint? clSize = null,
            long* pData = null
        ) : this()
        {
            if (clSize is not null)
            {
                ClSize = clSize.Value;
            }

            if (pData is not null)
            {
                PData = pData;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "clSize")]
        public uint ClSize;

        [NativeName("Type", "long long *")]
        [NativeName("Type.Name", "long long *")]
        [NativeName("Name", "pData")]
        public long* PData;
    }
}
