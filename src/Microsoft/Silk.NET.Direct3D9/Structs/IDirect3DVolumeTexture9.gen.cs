// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "IDirect3DVolumeTexture9")]
    public unsafe partial struct IDirect3DVolumeTexture9
    {
        public static implicit operator IDirect3DBaseTexture9(IDirect3DVolumeTexture9 val)
            => Unsafe.As<IDirect3DVolumeTexture9, IDirect3DBaseTexture9>(ref val);

        public readonly ref IDirect3DBaseTexture9 AsDirect3DBaseTexture9()
        {
            fixed (IDirect3DVolumeTexture9* @this = &this)
            {
                return ref *(IDirect3DBaseTexture9*)@this;
            }
        }

        public static implicit operator IDirect3DResource9(IDirect3DVolumeTexture9 val)
            => Unsafe.As<IDirect3DVolumeTexture9, IDirect3DResource9>(ref val);

        public readonly ref IDirect3DResource9 AsDirect3DResource9()
        {
            fixed (IDirect3DVolumeTexture9* @this = &this)
            {
                return ref *(IDirect3DResource9*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DVolumeTexture9 val)
            => Unsafe.As<IDirect3DVolumeTexture9, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDirect3DVolumeTexture9* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDirect3DVolumeTexture9
        (
            char* name = null,
            uint? width = null,
            uint? height = null,
            uint? depth = null,
            uint? levels = null,
            uint? usage = null,
            Format? format = null,
            Pool? pool = null,
            uint? priority = null,
            uint? lOD = null,
            Texturefiltertype? filterType = null,
            uint? lockCount = null,
            void** lpVtbl = null
        ) : this()
        {
            if (name is not null)
            {
                Name = name;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (depth is not null)
            {
                Depth = depth.Value;
            }

            if (levels is not null)
            {
                Levels = levels.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (pool is not null)
            {
                Pool = pool.Value;
            }

            if (priority is not null)
            {
                Priority = priority.Value;
            }

            if (lOD is not null)
            {
                LOD = lOD.Value;
            }

            if (filterType is not null)
            {
                FilterType = filterType.Value;
            }

            if (lockCount is not null)
            {
                LockCount = lockCount.Value;
            }

            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "Name")]
        public char* Name;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Depth")]
        public uint Depth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Levels")]
        public uint Levels;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Usage")]
        public uint Usage;

        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "Format")]
        public Format Format;

        [NativeName("Type", "D3DPOOL")]
        [NativeName("Type.Name", "D3DPOOL")]
        [NativeName("Name", "Pool")]
        public Pool Pool;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Priority")]
        public uint Priority;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "LOD")]
        public uint LOD;

        [NativeName("Type", "D3DTEXTUREFILTERTYPE")]
        [NativeName("Type.Name", "D3DTEXTUREFILTERTYPE")]
        [NativeName("Name", "FilterType")]
        public Texturefiltertype FilterType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "LockCount")]
        public uint LockCount;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData(Guid* refguid, void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, T0*, uint, uint, int>)LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int SetPrivateData(ref Guid refguid, void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, T0*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (T0* pDataPtr = &pData)
                {
                    fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int FreePrivateData(Guid* refguid)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, int>)LpVtbl[6])(@this, refguid);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int FreePrivateData(ref Guid refguid)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Guid*, int>)LpVtbl[6])(@this, refguidPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint SetPriority(uint PriorityNew)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, uint>)LpVtbl[7])(@this, PriorityNew);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint GetPriority()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly void PreLoad()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, void>)LpVtbl[9])(@this);
        }

        /// <summary>To be added.</summary>
        public readonly Resourcetype GetType()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                Resourcetype ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Resourcetype>)LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint SetLOD(uint LODNew)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, uint>)LpVtbl[11])(@this, LODNew);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint GetLOD()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint GetLevelCount()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint>)LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int SetAutoGenFilterType(Texturefiltertype FilterType)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Texturefiltertype, int>)LpVtbl[14])(@this, FilterType);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly Texturefiltertype GetAutoGenFilterType()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                Texturefiltertype ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Texturefiltertype>)LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly void GenerateMipSubLevels()
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, void>)LpVtbl[16])(@this);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetLevelDesc(uint Level, VolumeDesc* pDesc)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, VolumeDesc*, int>)LpVtbl[17])(@this, Level, pDesc);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetLevelDesc(uint Level, ref VolumeDesc pDesc)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (VolumeDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, VolumeDesc*, int>)LpVtbl[17])(@this, Level, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetVolumeLevel(uint Level, IDirect3DVolume9** ppVolumeLevel)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, IDirect3DVolume9**, int>)LpVtbl[18])(@this, Level, ppVolumeLevel);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetVolumeLevel(uint Level, ref IDirect3DVolume9* ppVolumeLevel)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DVolume9** ppVolumeLevelPtr = &ppVolumeLevel)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, IDirect3DVolume9**, int>)LpVtbl[18])(@this, Level, ppVolumeLevelPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int LockBox(uint Level, LockedBox* pLockedVolume, Box* pBox, uint Flags)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, LockedBox*, Box*, uint, int>)LpVtbl[19])(@this, Level, pLockedVolume, pBox, Flags);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int LockBox(uint Level, LockedBox* pLockedVolume, ref Box pBox, uint Flags)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Box* pBoxPtr = &pBox)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, LockedBox*, Box*, uint, int>)LpVtbl[19])(@this, Level, pLockedVolume, pBoxPtr, Flags);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int LockBox(uint Level, ref LockedBox pLockedVolume, Box* pBox, uint Flags)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (LockedBox* pLockedVolumePtr = &pLockedVolume)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, LockedBox*, Box*, uint, int>)LpVtbl[19])(@this, Level, pLockedVolumePtr, pBox, Flags);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int LockBox(uint Level, ref LockedBox pLockedVolume, ref Box pBox, uint Flags)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (LockedBox* pLockedVolumePtr = &pLockedVolume)
            {
                fixed (Box* pBoxPtr = &pBox)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, LockedBox*, Box*, uint, int>)LpVtbl[19])(@this, Level, pLockedVolumePtr, pBoxPtr, Flags);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int UnlockBox(uint Level)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, uint, int>)LpVtbl[20])(@this, Level);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int AddDirtyBox(Box* pDirtyBox)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Box*, int>)LpVtbl[21])(@this, pDirtyBox);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int AddDirtyBox(ref Box pDirtyBox)
        {
            var @this = (IDirect3DVolumeTexture9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Box* pDirtyBoxPtr = &pDirtyBox)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolumeTexture9*, Box*, int>)LpVtbl[21])(@this, pDirtyBoxPtr);
            }
            return ret;
        }

    }
}
