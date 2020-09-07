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
    [NativeName("Name", "_D3D11_SIGNATURE_PARAMETER_DESC")]
    public unsafe partial struct SignatureParameterDesc
    {
        public SignatureParameterDesc
        (
            byte* semanticName = default,
            uint semanticIndex = default,
            uint register = default,
            D3DName systemValueType = default,
            D3DRegisterComponentType componentType = default,
            byte mask = default,
            byte readWriteMask = default,
            uint stream = default,
            D3DMinPrecision minPrecision = default
        )
        {
            SemanticName = semanticName;
            SemanticIndex = semanticIndex;
            Register = register;
            SystemValueType = systemValueType;
            ComponentType = componentType;
            Mask = mask;
            ReadWriteMask = readWriteMask;
            Stream = stream;
            MinPrecision = minPrecision;
        }


        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "SemanticName")]
        public byte* SemanticName;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SemanticIndex")]
        public uint SemanticIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Register")]
        public uint Register;

        [NativeName("Type", "D3D_NAME")]
        [NativeName("Type.Name", "D3D_NAME")]
        [NativeName("Name", "SystemValueType")]
        public D3DName SystemValueType;

        [NativeName("Type", "D3D_REGISTER_COMPONENT_TYPE")]
        [NativeName("Type.Name", "D3D_REGISTER_COMPONENT_TYPE")]
        [NativeName("Name", "ComponentType")]
        public D3DRegisterComponentType ComponentType;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "Mask")]
        public byte Mask;

        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "ReadWriteMask")]
        public byte ReadWriteMask;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Stream")]
        public uint Stream;

        [NativeName("Type", "D3D_MIN_PRECISION")]
        [NativeName("Type.Name", "D3D_MIN_PRECISION")]
        [NativeName("Name", "MinPrecision")]
        public D3DMinPrecision MinPrecision;
    }
}
