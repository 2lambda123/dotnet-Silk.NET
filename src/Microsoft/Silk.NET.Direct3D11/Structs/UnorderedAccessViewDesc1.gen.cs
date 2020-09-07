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
    [NativeName("Name", "D3D11_UNORDERED_ACCESS_VIEW_DESC1")]
    public unsafe partial struct UnorderedAccessViewDesc1
    {
        public UnorderedAccessViewDesc1
        (
            Silk.NET.DXGI.Format format = default,
            UavDimension viewDimension = default
        )
        {
            Format = format;
            ViewDimension = viewDimension;
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "D3D11_UAV_DIMENSION")]
        [NativeName("Type.Name", "D3D11_UAV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public UavDimension ViewDimension;
    }
}
