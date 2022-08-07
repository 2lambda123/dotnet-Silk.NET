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
    [Guid("82bc481c-6b9b-4030-aedb-7ee3d1df1e63")]
    [NativeName("Name", "ID3D12DeviceRemovedExtendedDataSettings")]
    public unsafe partial struct ID3D12DeviceRemovedExtendedDataSettings : IComVtbl<ID3D12DeviceRemovedExtendedDataSettings>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("82bc481c-6b9b-4030-aedb-7ee3d1df1e63");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12DeviceRemovedExtendedDataSettings val)
            => Unsafe.As<ID3D12DeviceRemovedExtendedDataSettings, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12DeviceRemovedExtendedDataSettings
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
            var @this = (ID3D12DeviceRemovedExtendedDataSettings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetAutoBreadcrumbsEnablement(DredEnablement Enablement)
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, DredEnablement, void>)@this->LpVtbl[3])(@this, Enablement);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPageFaultEnablement(DredEnablement Enablement)
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, DredEnablement, void>)@this->LpVtbl[4])(@this, Enablement);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetWatsonDumpEnablement(DredEnablement Enablement)
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, DredEnablement, void>)@this->LpVtbl[5])(@this, Enablement);
        }

    }
}
