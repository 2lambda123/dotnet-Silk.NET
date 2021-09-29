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

namespace Silk.NET.Direct3D11;

[NativeName("Name", "D3D11_FEATURE_DATA_FORMAT_SUPPORT")]
public unsafe partial struct FeatureDataFormatSupport
{
    public FeatureDataFormatSupport
    (
            Silk.NET.DXGI.Format? inFormat = null,
            uint? outFormatSupport = null
    ) : this()
    {
        if (inFormat is not null)
        {
            InFormat = inFormat.Value;
        }

        if (outFormatSupport is not null)
        {
            OutFormatSupport = outFormatSupport.Value;
        }
    }


    [NativeName("Type", "DXGI_FORMAT")]
    [NativeName("Type.Name", "DXGI_FORMAT")]
    [NativeName("Name", "InFormat")]
    public Silk.NET.DXGI.Format InFormat;

    [NativeName("Type", "UINT")]
    [NativeName("Type.Name", "UINT")]
    [NativeName("Name", "OutFormatSupport")]
    public uint OutFormatSupport;
}
