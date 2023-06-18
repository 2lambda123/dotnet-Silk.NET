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

namespace Silk.NET.DXGI
{
    [Guid("aba496dd-b617-4cb8-a866-bc44d7eb1fa2")]
    [NativeName("Name", "IDXGISurface2")]
    public unsafe partial struct IDXGISurface2 : IComVtbl<IDXGISurface2>, IComVtbl<IDXGISurface1>, IComVtbl<Silk.NET.DXGI.IDXGISurface>, IComVtbl<Silk.NET.DXGI.IDXGIDeviceSubObject>, IComVtbl<Silk.NET.DXGI.IDXGIObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("aba496dd-b617-4cb8-a866-bc44d7eb1fa2");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDXGISurface1(IDXGISurface2 val)
            => Unsafe.As<IDXGISurface2, IDXGISurface1>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGISurface(IDXGISurface2 val)
            => Unsafe.As<IDXGISurface2, Silk.NET.DXGI.IDXGISurface>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIDeviceSubObject(IDXGISurface2 val)
            => Unsafe.As<IDXGISurface2, Silk.NET.DXGI.IDXGIDeviceSubObject>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIObject(IDXGISurface2 val)
            => Unsafe.As<IDXGISurface2, Silk.NET.DXGI.IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGISurface2 val)
            => Unsafe.As<IDXGISurface2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGISurface2
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
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppDevice)
        {
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(SurfaceDesc* pDesc)
        {
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, SurfaceDesc*, int>)@this->LpVtbl[8])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map(MappedRect* pLockedRect, uint MapFlags)
        {
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, MappedRect*, uint, int>)@this->LpVtbl[9])(@this, pLockedRect, MapFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Unmap()
        {
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, int>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDC(Silk.NET.Core.Bool32 Discard, nint* phdc)
        {
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Silk.NET.Core.Bool32, nint*, int>)@this->LpVtbl[11])(@this, Discard, phdc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReleaseDC(Silk.NET.Maths.Box2D<int>* pDirtyRect)
        {
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[12])(@this, pDirtyRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResource(Guid* riid, void** ppParentResource, uint* pSubresourceIndex)
        {
            var @this = (IDXGISurface2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISurface2*, Guid*, void**, uint*, int>)@this->LpVtbl[13])(@this, riid, ppParentResource, pSubresourceIndex);
            return ret;
        }

    }
}
