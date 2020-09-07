// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TRACE_VALUE")]
    public unsafe partial struct TraceValue
    {
        public TraceValue
        (
            byte validMask = default
        )
        {
            ValidMask = validMask;
        }

        [NativeName("Type", "UINT [4]")]
        [NativeName("Type.Name", "UINT [4]")]
        [NativeName("Name", "Bits")]
        public fixed uint Bits[4];

        [NativeName("Type", "D3D11_TRACE_COMPONENT_MASK")]
        [NativeName("Type.Name", "D3D11_TRACE_COMPONENT_MASK")]
        [NativeName("Name", "ValidMask")]
        public byte ValidMask;
    }
}
