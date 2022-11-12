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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_AUTHENTICATED_CONFIGURE_OUTPUT")]
    public unsafe partial struct AuthenticatedConfigureOutput
    {
        public AuthenticatedConfigureOutput
        (
            OMAC? omac = null,
            Guid? configureType = null,
            nint* hChannel = null,
            uint? sequenceNumber = null,
            int? returnCode = null
        ) : this()
        {
            if (omac is not null)
            {
                Omac = omac.Value;
            }

            if (configureType is not null)
            {
                ConfigureType = configureType.Value;
            }

            if (hChannel is not null)
            {
                HChannel = hChannel;
            }

            if (sequenceNumber is not null)
            {
                SequenceNumber = sequenceNumber.Value;
            }

            if (returnCode is not null)
            {
                ReturnCode = returnCode.Value;
            }
        }


        [NativeName("Type", "D3D11_OMAC")]
        [NativeName("Type.Name", "D3D11_OMAC")]
        [NativeName("Name", "omac")]
        public OMAC Omac;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "ConfigureType")]
        public Guid ConfigureType;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "hChannel")]
        public nint* HChannel;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SequenceNumber")]
        public uint SequenceNumber;

        [NativeName("Type", "HRESULT")]
        [NativeName("Type.Name", "HRESULT")]
        [NativeName("Name", "ReturnCode")]
        public int ReturnCode;
    }
}
