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
    [Guid("0c711683-2853-4846-9bb0-f3e60639e46a")]
    [NativeName("Name", "ID3D11Texture3D1")]
    public unsafe partial struct ID3D11Texture3D1 : IComVtbl<ID3D11Texture3D1>, IComVtbl<ID3D11Texture3D>, IComVtbl<ID3D11Resource>, IComVtbl<ID3D11DeviceChild>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0c711683-2853-4846-9bb0-f3e60639e46a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D11Texture3D(ID3D11Texture3D1 val)
            => Unsafe.As<ID3D11Texture3D1, ID3D11Texture3D>(ref val);

        public static implicit operator ID3D11Resource(ID3D11Texture3D1 val)
            => Unsafe.As<ID3D11Texture3D1, ID3D11Resource>(ref val);

        public static implicit operator ID3D11DeviceChild(ID3D11Texture3D1 val)
            => Unsafe.As<ID3D11Texture3D1, ID3D11DeviceChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11Texture3D1 val)
            => Unsafe.As<ID3D11Texture3D1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11Texture3D1
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D11Texture3D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11Texture3D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11Texture3D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            var @this = (ID3D11Texture3D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11Texture3D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D11Texture3D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11Texture3D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetType(ResourceDimension* pResourceDimension)
        {
            var @this = (ID3D11Texture3D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, ResourceDimension*, void>)@this->LpVtbl[7])(@this, pResourceDimension);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetEvictionPriority(uint EvictionPriority)
        {
            var @this = (ID3D11Texture3D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, uint, void>)@this->LpVtbl[8])(@this, EvictionPriority);
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetEvictionPriority()
        {
            var @this = (ID3D11Texture3D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, uint>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesc(Texture3DDesc* pDesc)
        {
            var @this = (ID3D11Texture3D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, Texture3DDesc*, void>)@this->LpVtbl[10])(@this, pDesc);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesc1(Texture3DDesc1* pDesc)
        {
            var @this = (ID3D11Texture3D1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11Texture3D1*, Texture3DDesc1*, void>)@this->LpVtbl[11])(@this, pDesc);
        }

    }
}
