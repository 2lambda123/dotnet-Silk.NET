// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_CONTEXT_TYPE")]
    public enum ContextType
    {
        [NativeName("Name", "D3D11_CONTEXT_TYPE_ALL")]
        ContextTypeAll = 0x0,
        [NativeName("Name", "D3D11_CONTEXT_TYPE_3D")]
        ContextType3D = 0x1,
        [NativeName("Name", "D3D11_CONTEXT_TYPE_COMPUTE")]
        ContextTypeCompute = 0x2,
        [NativeName("Name", "D3D11_CONTEXT_TYPE_COPY")]
        ContextTypeCopy = 0x3,
        [NativeName("Name", "D3D11_CONTEXT_TYPE_VIDEO")]
        ContextTypeVideo = 0x4,
    }
}
