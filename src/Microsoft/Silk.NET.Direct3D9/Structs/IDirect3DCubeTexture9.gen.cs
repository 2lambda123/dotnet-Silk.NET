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

namespace Silk.NET.Direct3D9
{
    [Guid("fff32f81-d953-473a-9223-93d652aba93f")]
    [NativeName("Name", "IDirect3DCubeTexture9")]
    public unsafe partial struct IDirect3DCubeTexture9 : IComVtbl<IDirect3DCubeTexture9>, IComVtbl<IDirect3DBaseTexture9>, IComVtbl<IDirect3DResource9>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("fff32f81-d953-473a-9223-93d652aba93f");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDirect3DBaseTexture9(IDirect3DCubeTexture9 val)
            => Unsafe.As<IDirect3DCubeTexture9, IDirect3DBaseTexture9>(ref val);

        public static implicit operator IDirect3DResource9(IDirect3DCubeTexture9 val)
            => Unsafe.As<IDirect3DCubeTexture9, IDirect3DResource9>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DCubeTexture9 val)
            => Unsafe.As<IDirect3DCubeTexture9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DCubeTexture9
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
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* refguid, [Flow(FlowDirection.In)] void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid refguid, [Flow(FlowDirection.In)] void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint, uint, int>)@this->LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, void*, uint*, int>)@this->LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FreePrivateData(Guid* refguid)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, int>)@this->LpVtbl[6])(@this, refguid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FreePrivateData(ref Guid refguid)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Guid*, int>)@this->LpVtbl[6])(@this, refguidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint SetPriority(uint PriorityNew)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint, uint>)@this->LpVtbl[7])(@this, PriorityNew);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPriority()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PreLoad()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, void>)@this->LpVtbl[9])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly Resourcetype GetType()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Resourcetype ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Resourcetype>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint SetLOD(uint LODNew)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint, uint>)@this->LpVtbl[11])(@this, LODNew);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetLOD()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetLevelCount()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAutoGenFilterType(Texturefiltertype FilterType)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Texturefiltertype, int>)@this->LpVtbl[14])(@this, FilterType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Texturefiltertype GetAutoGenFilterType()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Texturefiltertype ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, Texturefiltertype>)@this->LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void GenerateMipSubLevels()
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, void>)@this->LpVtbl[16])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLevelDesc(uint Level, SurfaceDesc* pDesc)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint, SurfaceDesc*, int>)@this->LpVtbl[17])(@this, Level, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLevelDesc(uint Level, ref SurfaceDesc pDesc)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, uint, SurfaceDesc*, int>)@this->LpVtbl[17])(@this, Level, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCubeMapSurface(CubemapFaces FaceType, uint Level, IDirect3DSurface9** ppCubeMapSurface)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, IDirect3DSurface9**, int>)@this->LpVtbl[18])(@this, FaceType, Level, ppCubeMapSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCubeMapSurface(CubemapFaces FaceType, uint Level, ref IDirect3DSurface9* ppCubeMapSurface)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DSurface9** ppCubeMapSurfacePtr = &ppCubeMapSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, IDirect3DSurface9**, int>)@this->LpVtbl[18])(@this, FaceType, Level, ppCubeMapSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockRect(CubemapFaces FaceType, uint Level, LockedRect* pLockedRect, [Flow(FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint Flags)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[19])(@this, FaceType, Level, pLockedRect, pRect, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockRect(CubemapFaces FaceType, uint Level, LockedRect* pLockedRect, [Flow(FlowDirection.In)] in Silk.NET.Maths.Box2D<int> pRect, uint Flags)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[19])(@this, FaceType, Level, pLockedRect, pRectPtr, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockRect(CubemapFaces FaceType, uint Level, ref LockedRect pLockedRect, [Flow(FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pRect, uint Flags)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LockedRect* pLockedRectPtr = &pLockedRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[19])(@this, FaceType, Level, pLockedRectPtr, pRect, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LockRect(CubemapFaces FaceType, uint Level, ref LockedRect pLockedRect, [Flow(FlowDirection.In)] in Silk.NET.Maths.Box2D<int> pRect, uint Flags)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LockedRect* pLockedRectPtr = &pLockedRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* pRectPtr = &pRect)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, LockedRect*, Silk.NET.Maths.Box2D<int>*, uint, int>)@this->LpVtbl[19])(@this, FaceType, Level, pLockedRectPtr, pRectPtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnlockRect(CubemapFaces FaceType, uint Level)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, uint, int>)@this->LpVtbl[20])(@this, FaceType, Level);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddDirtyRect(CubemapFaces FaceType, [Flow(FlowDirection.In)] Silk.NET.Maths.Box2D<int>* pDirtyRect)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[21])(@this, FaceType, pDirtyRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddDirtyRect(CubemapFaces FaceType, [Flow(FlowDirection.In)] in Silk.NET.Maths.Box2D<int> pDirtyRect)
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* pDirtyRectPtr = &pDirtyRect)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DCubeTexture9*, CubemapFaces, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[21])(@this, FaceType, pDirtyRectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDevice<TI0>(ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDevice((IDirect3DDevice9**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCubeMapSurface<TI0>(CubemapFaces FaceType, uint Level, ref ComPtr<TI0> ppCubeMapSurface) where TI0 : unmanaged, IComVtbl<IDirect3DSurface9>, IComVtbl<TI0>
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetCubeMapSurface(FaceType, Level, (IDirect3DSurface9**) ppCubeMapSurface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3DCubeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
