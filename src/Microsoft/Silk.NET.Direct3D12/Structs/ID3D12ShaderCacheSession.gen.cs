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

namespace Silk.NET.Direct3D12
{
    [Guid("28e2495d-0f64-4ae4-a6ec-129255dc49a8")]
    [NativeName("Name", "ID3D12ShaderCacheSession")]
    public unsafe partial struct ID3D12ShaderCacheSession : IComVtbl<ID3D12ShaderCacheSession>, IComVtbl<ID3D12DeviceChild>, IComVtbl<ID3D12Object>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("28e2495d-0f64-4ae4-a6ec-129255dc49a8");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12DeviceChild(ID3D12ShaderCacheSession val)
            => Unsafe.As<ID3D12ShaderCacheSession, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12ShaderCacheSession val)
            => Unsafe.As<ID3D12ShaderCacheSession, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12ShaderCacheSession val)
            => Unsafe.As<ID3D12ShaderCacheSession, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12ShaderCacheSession
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
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, char*, int>)@this->LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, void* pValue, uint* pValueSize)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)@this->LpVtbl[8])(@this, pKey, KeySize, pValue, pValueSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pValue, uint ValueSize)
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void*, uint, void*, uint, int>)@this->LpVtbl[9])(@this, pKey, KeySize, pValue, ValueSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDeleteOnDestroy()
        {
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, void>)@this->LpVtbl[10])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly ShaderCacheSessionDesc GetDesc()
        {
            ShaderCacheSessionDesc silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12ShaderCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ShaderCacheSessionDesc* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderCacheSession*, ShaderCacheSessionDesc*, ShaderCacheSessionDesc*>)@this->LpVtbl[11])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

    }
}
