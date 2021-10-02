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

namespace Silk.NET.Direct3D9
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d9types_L2100_C5")]
    public unsafe partial struct AuthenticatedchannelProtectionFlagsUnion
    {
        public AuthenticatedchannelProtectionFlagsUnion
        (
            uint? value = null
        ) : this()
        {
            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Value")]
        public uint Value;
    }
}
