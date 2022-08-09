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
    [Guid("d52f011b-b56e-453c-a05a-a7f311c8f472")]
    [NativeName("Name", "ID3D12VideoDecodeCommandList1")]
    public unsafe partial struct ID3D12VideoDecodeCommandList1 : IComVtbl<ID3D12VideoDecodeCommandList1>, IComVtbl<ID3D12VideoDecodeCommandList>, IComVtbl<ID3D12CommandList>, IComVtbl<ID3D12DeviceChild>, IComVtbl<ID3D12Object>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d52f011b-b56e-453c-a05a-a7f311c8f472");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12VideoDecodeCommandList(ID3D12VideoDecodeCommandList1 val)
            => Unsafe.As<ID3D12VideoDecodeCommandList1, ID3D12VideoDecodeCommandList>(ref val);

        public static implicit operator ID3D12CommandList(ID3D12VideoDecodeCommandList1 val)
            => Unsafe.As<ID3D12VideoDecodeCommandList1, ID3D12CommandList>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12VideoDecodeCommandList1 val)
            => Unsafe.As<ID3D12VideoDecodeCommandList1, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12VideoDecodeCommandList1 val)
            => Unsafe.As<ID3D12VideoDecodeCommandList1, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VideoDecodeCommandList1 val)
            => Unsafe.As<ID3D12VideoDecodeCommandList1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12VideoDecodeCommandList1
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
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName(char* Name)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, char*, int>)@this->LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName(ref char Name)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly CommandListType GetType()
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            CommandListType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, CommandListType>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Close()
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, int>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reset(ID3D12CommandAllocator* pAllocator)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12CommandAllocator*, int>)@this->LpVtbl[10])(@this, pAllocator);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset(ref ID3D12CommandAllocator pAllocator)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12CommandAllocator*, int>)@this->LpVtbl[10])(@this, pAllocatorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearState()
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, void>)@this->LpVtbl[11])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResourceBarrier(uint NumBarriers, ResourceBarrier* pBarriers)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, uint, ResourceBarrier*, void>)@this->LpVtbl[12])(@this, NumBarriers, pBarriers);
        }

        /// <summary>To be documented.</summary>
        public readonly void ResourceBarrier(uint NumBarriers, ref ResourceBarrier pBarriers)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, uint, ResourceBarrier*, void>)@this->LpVtbl[12])(@this, NumBarriers, pBarriersPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, DiscardRegion* pRegion)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResource, pRegion);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, ref DiscardRegion pRegion)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DiscardRegion* pRegionPtr = &pRegion)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResource, pRegionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ref ID3D12Resource pResource, DiscardRegion* pRegion)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResourcePtr, pRegion);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardResource(ref ID3D12Resource pResource, ref DiscardRegion pRegion)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (DiscardRegion* pRegionPtr = &pRegion)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12Resource*, DiscardRegion*, void>)@this->LpVtbl[13])(@this, pResourcePtr, pRegionPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[14])(@this, pQueryHeap, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[14])(@this, pQueryHeapPtr, Type, Index);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EndQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[15])(@this, pQueryHeap, Type, Index);
        }

        /// <summary>To be documented.</summary>
        public readonly void EndQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)@this->LpVtbl[15])(@this, pQueryHeapPtr, Type, Index);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)@this->LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPredication(ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[17])(@this, pBuffer, AlignedBufferOffset, Operation);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPredication(ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12Resource*, ulong, PredicationOp, void>)@this->LpVtbl[17])(@this, pBufferPtr, AlignedBufferOffset, Operation);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetMarker(uint Metadata, void* pData, uint Size)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, uint, void*, uint, void>)@this->LpVtbl[18])(@this, Metadata, pData, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMarker<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataPtr = &pData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, uint, void*, uint, void>)@this->LpVtbl[18])(@this, Metadata, pDataPtr, Size);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginEvent(uint Metadata, void* pData, uint Size)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, uint, void*, uint, void>)@this->LpVtbl[19])(@this, Metadata, pData, Size);
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginEvent<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataPtr = &pData)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, uint, void*, uint, void>)@this->LpVtbl[19])(@this, Metadata, pDataPtr, Size);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void EndEvent()
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, void>)@this->LpVtbl[20])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoder, pOutputArguments, pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoder, pOutputArguments, pInputArgumentsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoder, pOutputArgumentsPtr, pInputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoder, pOutputArgumentsPtr, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoderPtr, pOutputArguments, pInputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoderPtr, pOutputArguments, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArguments);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DecodeFrame(ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[21])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, WritebufferimmediateMode* pModes)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParams, pModes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, ref WritebufferimmediateMode pModes)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateMode* pModesPtr = &pModes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParams, pModesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, WritebufferimmediateMode* pModes)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParamsPtr, pModes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, ref WritebufferimmediateMode pModes)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
            {
                fixed (WritebufferimmediateMode* pModesPtr = &pModes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)@this->LpVtbl[22])(@this, Count, pParamsPtr, pModesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoder, pOutputArguments, pInputArguments);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoder, pOutputArguments, pInputArgumentsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoder, pOutputArgumentsPtr, pInputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoder, pOutputArgumentsPtr, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoderPtr, pOutputArguments, pInputArguments);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoderPtr, pOutputArguments, pInputArgumentsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArguments);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DecodeFrame1(ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
                {
                    fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList1*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)@this->LpVtbl[23])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDevice<TI0>(out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDevice = default;
            return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetDevice<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12VideoDecodeCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
