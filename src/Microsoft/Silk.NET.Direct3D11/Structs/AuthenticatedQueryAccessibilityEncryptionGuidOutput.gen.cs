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
    [NativeName("Name", "D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_OUTPUT")]
    public unsafe partial struct AuthenticatedQueryAccessibilityEncryptionGuidOutput
    {
        public AuthenticatedQueryAccessibilityEncryptionGuidOutput
        (
            AuthenticatedQueryOutput output = default,
            uint encryptionGuidIndex = default,
            Guid encryptionGuid = default
        )
        {
            Output = output;
            EncryptionGuidIndex = encryptionGuidIndex;
            EncryptionGuid = encryptionGuid;
        }


        [NativeName("Type", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedQueryOutput Output;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "EncryptionGuidIndex")]
        public uint EncryptionGuidIndex;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "EncryptionGuid")]
        public Guid EncryptionGuid;
    }
}
