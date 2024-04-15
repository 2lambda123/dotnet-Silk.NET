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
    [Guid("c70b221b-40e4-4a17-89af-025a0727a6dc")]
    [NativeName("Name", "ID3D12Device6")]
    public unsafe partial struct ID3D12Device6 : IComVtbl<ID3D12Device6>, IComVtbl<ID3D12Device5>, IComVtbl<ID3D12Device4>, IComVtbl<ID3D12Device3>, IComVtbl<ID3D12Device2>, IComVtbl<ID3D12Device1>, IComVtbl<ID3D12Device>, IComVtbl<ID3D12Object>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c70b221b-40e4-4a17-89af-025a0727a6dc");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12Device5(ID3D12Device6 val)
            => Unsafe.As<ID3D12Device6, ID3D12Device5>(ref val);

        public static implicit operator ID3D12Device4(ID3D12Device6 val)
            => Unsafe.As<ID3D12Device6, ID3D12Device4>(ref val);

        public static implicit operator ID3D12Device3(ID3D12Device6 val)
            => Unsafe.As<ID3D12Device6, ID3D12Device3>(ref val);

        public static implicit operator ID3D12Device2(ID3D12Device6 val)
            => Unsafe.As<ID3D12Device6, ID3D12Device2>(ref val);

        public static implicit operator ID3D12Device1(ID3D12Device6 val)
            => Unsafe.As<ID3D12Device6, ID3D12Device1>(ref val);

        public static implicit operator ID3D12Device(ID3D12Device6 val)
            => Unsafe.As<ID3D12Device6, ID3D12Device>(ref val);

        public static implicit operator ID3D12Object(ID3D12Device6 val)
            => Unsafe.As<ID3D12Device6, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12Device6 val)
            => Unsafe.As<ID3D12Device6, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12Device6
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
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guidPtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, char*, int>)@this->LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, char*, int>)@this->LpVtbl[6])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, byte*, int>)@this->LpVtbl[6])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNodeCount()
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, Guid* riid, void** ppCommandQueue)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riid, ppCommandQueue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, Guid* riid, ref void* ppCommandQueue)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCommandQueuePtr = &ppCommandQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riid, ppCommandQueuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, ref Guid riid, void** ppCommandQueue)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riidPtr, ppCommandQueue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, ref Guid riid, ref void* ppCommandQueue)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandQueuePtr = &ppCommandQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDesc, riidPtr, ppCommandQueuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandQueueDesc pDesc, Guid* riid, void** ppCommandQueue)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandQueueDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riid, ppCommandQueue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandQueueDesc pDesc, Guid* riid, ref void* ppCommandQueue)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandQueueDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppCommandQueuePtr = &ppCommandQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riid, ppCommandQueuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandQueueDesc pDesc, ref Guid riid, void** ppCommandQueue)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandQueueDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riidPtr, ppCommandQueue);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandQueueDesc pDesc, ref Guid riid, ref void* ppCommandQueue)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandQueueDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCommandQueuePtr = &ppCommandQueue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandQueueDesc*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pDescPtr, riidPtr, ppCommandQueuePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandAllocator(CommandListType type, Guid* riid, void** ppCommandAllocator)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riid, ppCommandAllocator);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandAllocator(CommandListType type, Guid* riid, ref void* ppCommandAllocator)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCommandAllocatorPtr = &ppCommandAllocator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riid, ppCommandAllocatorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandAllocator(CommandListType type, ref Guid riid, void** ppCommandAllocator)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riidPtr, ppCommandAllocator);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandAllocator(CommandListType type, ref Guid riid, ref void* ppCommandAllocator)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandAllocatorPtr = &ppCommandAllocator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandListType, Guid*, void**, int>)@this->LpVtbl[9])(@this, type, riidPtr, ppCommandAllocatorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riid, ppPipelineStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riidPtr, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GraphicsPipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GraphicsPipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GraphicsPipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GraphicsPipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GraphicsPipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riid, ppPipelineStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riidPtr, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ComputePipelineStateDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ComputePipelineStateDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ComputePipelineStateDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ComputePipelineStateDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComputePipelineStateDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[11])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandListPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riidPtr, ppCommandList);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialState, riidPtr, ppCommandListPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riid, ppCommandList);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riid, ppCommandListPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riidPtr, ppCommandList);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ID3D12CommandAllocator* pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCommandListPtr = &ppCommandList)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocator, pInitialStatePtr, riidPtr, ppCommandListPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riid, ppCommandList);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riid, ppCommandListPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riidPtr, ppCommandList);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState* pInitialState, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCommandListPtr = &ppCommandList)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialState, riidPtr, ppCommandListPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riid, ppCommandList);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    fixed (void** ppCommandListPtr = &ppCommandList)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riid, ppCommandListPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riidPtr, ppCommandList);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pCommandAllocatorPtr = &pCommandAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppCommandListPtr = &ppCommandList)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, ID3D12CommandAllocator*, ID3D12PipelineState*, Guid*, void**, int>)@this->LpVtbl[12])(@this, nodeMask, type, pCommandAllocatorPtr, pInitialStatePtr, riidPtr, ppCommandListPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckFeatureSupport(Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Feature, void*, uint, int>)@this->LpVtbl[13])(@this, Feature, pFeatureSupportData, FeatureSupportDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckFeatureSupport<T0>(Feature Feature, ref T0 pFeatureSupportData, uint FeatureSupportDataSize) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pFeatureSupportDataPtr = &pFeatureSupportData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Feature, void*, uint, int>)@this->LpVtbl[13])(@this, Feature, pFeatureSupportDataPtr, FeatureSupportDataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDesc, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorHeapDesc pDescriptorHeapDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorHeapDesc pDescriptorHeapDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorHeapDesc pDescriptorHeapDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorHeapDesc pDescriptorHeapDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DescriptorHeapDesc* pDescriptorHeapDescPtr = &pDescriptorHeapDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, DescriptorHeapDesc*, Guid*, void**, int>)@this->LpVtbl[14])(@this, pDescriptorHeapDescPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetDescriptorHandleIncrementSize(DescriptorHeapType DescriptorHeapType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, DescriptorHeapType, uint>)@this->LpVtbl[15])(@this, DescriptorHeapType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature(uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature(uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignaturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature(uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, void** ppvRootSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riidPtr, ppvRootSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature(uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignature, blobLengthInBytes, riidPtr, ppvRootSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature<T0>(uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, void** ppvRootSignature) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riid, ppvRootSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature<T0>(uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlobWithRootSignature, nuint blobLengthInBytes, Guid* riid, ref void* ppvRootSignature) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riid, ppvRootSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature<T0>(uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, void** ppvRootSignature) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riidPtr, ppvRootSignature);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature<T0>(uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlobWithRootSignature, nuint blobLengthInBytes, ref Guid riid, ref void* ppvRootSignature) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pBlobWithRootSignaturePtr = &pBlobWithRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[16])(@this, nodeMask, pBlobWithRootSignaturePtr, blobLengthInBytes, riidPtr, ppvRootSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateConstantBufferView([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConstantBufferViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[17])(@this, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateConstantBufferView([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ConstantBufferViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ConstantBufferViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ConstantBufferViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[17])(@this, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateShaderResourceView(ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResource, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateShaderResourceView(ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ShaderResourceViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResource, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateShaderResourceView(ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResourcePtr, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateShaderResourceView(ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (ShaderResourceViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, ShaderResourceViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[18])(@this, pResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ID3D12Resource* pResource, ID3D12Resource* pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResource, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ID3D12Resource* pResource, ID3D12Resource* pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResource, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ID3D12Resource* pResource, ref ID3D12Resource pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResourcePtr, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ID3D12Resource* pResource, ref ID3D12Resource pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
            {
                fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResource, pCounterResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ref ID3D12Resource pResource, ID3D12Resource* pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResource, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ref ID3D12Resource pResource, ID3D12Resource* pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResource, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView(ref ID3D12Resource pResource, ref ID3D12Resource pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResourcePtr, pDesc, DestDescriptor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateUnorderedAccessView(ref ID3D12Resource pResource, ref ID3D12Resource pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (ID3D12Resource* pCounterResourcePtr = &pCounterResource)
                {
                    fixed (UnorderedAccessViewDesc* pDescPtr = &pDesc)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, ID3D12Resource*, UnorderedAccessViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[19])(@this, pResourcePtr, pCounterResourcePtr, pDescPtr, DestDescriptor);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateRenderTargetView(ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResource, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateRenderTargetView(ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RenderTargetViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResource, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateRenderTargetView(ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResourcePtr, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateRenderTargetView(ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (RenderTargetViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, RenderTargetViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[20])(@this, pResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateDepthStencilView(ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResource, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateDepthStencilView(ID3D12Resource* pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DepthStencilViewDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResource, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateDepthStencilView(ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResourcePtr, pDesc, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateDepthStencilView(ref ID3D12Resource pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (DepthStencilViewDesc* pDescPtr = &pDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, DepthStencilViewDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[21])(@this, pResourcePtr, pDescPtr, DestDescriptor);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateSampler([Flow(Silk.NET.Core.Native.FlowDirection.In)] SamplerDesc* pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, SamplerDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[22])(@this, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateSampler([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SamplerDesc pDesc, CpuDescriptorHandle DestDescriptor)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (SamplerDesc* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, SamplerDesc*, CpuDescriptorHandle, void>)@this->LpVtbl[22])(@this, pDescPtr, DestDescriptor);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                {
                    fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CpuDescriptorHandle* pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
                {
                    fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
                {
                    fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizes, DescriptorHeapsType);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyDescriptors(uint NumDestDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pDestDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CpuDescriptorHandle pSrcDescriptorRangeStarts, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pSrcDescriptorRangeSizes, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDestDescriptorRangeStartsPtr = &pDestDescriptorRangeStarts)
            {
                fixed (uint* pDestDescriptorRangeSizesPtr = &pDestDescriptorRangeSizes)
                {
                    fixed (CpuDescriptorHandle* pSrcDescriptorRangeStartsPtr = &pSrcDescriptorRangeStarts)
                    {
                        fixed (uint* pSrcDescriptorRangeSizesPtr = &pSrcDescriptorRangeSizes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle*, uint*, uint, CpuDescriptorHandle*, uint*, DescriptorHeapType, void>)@this->LpVtbl[23])(@this, NumDestDescriptorRanges, pDestDescriptorRangeStartsPtr, pDestDescriptorRangeSizesPtr, NumSrcDescriptorRanges, pSrcDescriptorRangeStartsPtr, pSrcDescriptorRangeSizesPtr, DescriptorHeapsType);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyDescriptorsSimple(uint NumDescriptors, CpuDescriptorHandle DestDescriptorRangeStart, CpuDescriptorHandle SrcDescriptorRangeStart, DescriptorHeapType DescriptorHeapsType)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CpuDescriptorHandle, CpuDescriptorHandle, DescriptorHeapType, void>)@this->LpVtbl[24])(@this, NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDescs)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo*>)@this->LpVtbl[25])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDescs)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo*>)@this->LpVtbl[25])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr);
            }
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly HeapProperties GetCustomHeapProperties(uint nodeMask, HeapType heapType)
        {
            HeapProperties silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            HeapProperties* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, uint, HeapType, HeapProperties*>)@this->LpVtbl[26])(@this, pSilkDotNetReturnFixupResult, nodeMask, heapType);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[27])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDesc, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, Guid*, void**, int>)@this->LpVtbl[28])(@this, pDescPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ID3D12Heap* pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeap, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Heap* pHeapPtr = &pHeap)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Heap*, ulong, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[29])(@this, pHeapPtr, HeapOffset, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDesc, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValue, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, Guid*, void**, int>)@this->LpVtbl[30])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, Name, pHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, void** pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, ref void* pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandle);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            fixed (void** pHandlePtr = &pHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributes, Access, NamePtr, pHandlePtr);
            }
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, Name, pHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, Name, pHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, void** pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, ref void* pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* NamePtr = &Name)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandlePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandle);
            SilkMarshal.Free((nint)NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ID3D12DeviceChild* pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObject, pAttributesPtr, Access, NamePtr, pHandlePtr);
                }
            SilkMarshal.Free((nint)NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, Name, pHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, Name, pHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, void** pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, ref void* pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (char* NamePtr = &Name)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandlePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandle);
            SilkMarshal.Free((nint)NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                fixed (void** pHandlePtr = &pHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributes, Access, NamePtr, pHandlePtr);
                }
            SilkMarshal.Free((nint)NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, Name, pHandle);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, Name, pHandlePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, void** pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (char* NamePtr = &Name)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandle);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, ref void* pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
                    fixed (char* NamePtr = &Name)
                    {
                        fixed (void** pHandlePtr = &pHandle)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandlePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandle);
            SilkMarshal.Free((nint)NamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref ID3D12DeviceChild pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12DeviceChild* pObjectPtr = &pObject)
            {
                fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
                {
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
                    fixed (void** pHandlePtr = &pHandle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12DeviceChild*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)@this->LpVtbl[31])(@this, pObjectPtr, pAttributesPtr, Access, NamePtr, pHandlePtr);
                    }
            SilkMarshal.Free((nint)NamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle(void* NTHandle, Guid* riid, void** ppvObj)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riid, ppvObj);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle(void* NTHandle, Guid* riid, ref void* ppvObj)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riid, ppvObjPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle(void* NTHandle, ref Guid riid, void** ppvObj)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riidPtr, ppvObj);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle(void* NTHandle, ref Guid riid, ref void* ppvObj)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandle, riidPtr, ppvObjPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle<T0>(ref T0 NTHandle, Guid* riid, void** ppvObj) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* NTHandlePtr = &NTHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riid, ppvObj);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle<T0>(ref T0 NTHandle, Guid* riid, ref void* ppvObj) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* NTHandlePtr = &NTHandle)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riid, ppvObjPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle<T0>(ref T0 NTHandle, ref Guid riid, void** ppvObj) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* NTHandlePtr = &NTHandle)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riidPtr, ppvObj);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle<T0>(ref T0 NTHandle, ref Guid riid, ref void* ppvObj) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* NTHandlePtr = &NTHandle)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjPtr = &ppvObj)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[32])(@this, NTHandlePtr, riidPtr, ppvObjPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandleByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, uint Access, void** pNTHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, Name, Access, pNTHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandleByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, uint Access, ref void* pNTHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pNTHandlePtr = &pNTHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, Name, Access, pNTHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandleByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, uint Access, void** pNTHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandleByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, uint Access, ref void* pNTHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
                fixed (void** pNTHandlePtr = &pNTHandle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, char*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandleByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, uint Access, void** pNTHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, byte*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandle);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandleByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, uint Access, ref void* pNTHandle)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            fixed (void** pNTHandlePtr = &pNTHandle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, byte*, uint, void**, int>)@this->LpVtbl[33])(@this, NamePtr, Access, pNTHandlePtr);
            }
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MakeResident(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, ID3D12Pageable**, int>)@this->LpVtbl[34])(@this, NumObjects, ppObjects);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MakeResident(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D12Pageable* ppObjects)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, ID3D12Pageable**, int>)@this->LpVtbl[34])(@this, NumObjects, ppObjectsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Evict(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, ID3D12Pageable**, int>)@this->LpVtbl[35])(@this, NumObjects, ppObjects);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Evict(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D12Pageable* ppObjects)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, ID3D12Pageable**, int>)@this->LpVtbl[35])(@this, NumObjects, ppObjectsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFence(ulong InitialValue, FenceFlags Flags, Guid* riid, void** ppFence)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riid, ppFence);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFence(ulong InitialValue, FenceFlags Flags, Guid* riid, ref void* ppFence)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppFencePtr = &ppFence)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riid, ppFencePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFence(ulong InitialValue, FenceFlags Flags, ref Guid riid, void** ppFence)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riidPtr, ppFence);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFence(ulong InitialValue, FenceFlags Flags, ref Guid riid, ref void* ppFence)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppFencePtr = &ppFence)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ulong, FenceFlags, Guid*, void**, int>)@this->LpVtbl[36])(@this, InitialValue, Flags, riidPtr, ppFencePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceRemovedReason()
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, int>)@this->LpVtbl[37])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRowsPtr = &pNumRows)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, PlacedSubresourceFootprint* pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pNumRowsPtr = &pNumRows)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytes);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytes, pTotalBytesPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, uint* pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRows, pRowSizeInBytesPtr, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytes);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ulong* pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytes, pTotalBytesPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ulong* pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytes);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetCopyableFootprints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDesc, uint FirstSubresource, uint NumSubresources, ulong BaseOffset, ref PlacedSubresourceFootprint pLayouts, ref uint pNumRows, ref ulong pRowSizeInBytes, ref ulong pTotalBytes)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (PlacedSubresourceFootprint* pLayoutsPtr = &pLayouts)
                {
                    fixed (uint* pNumRowsPtr = &pNumRows)
                    {
                        fixed (ulong* pRowSizeInBytesPtr = &pRowSizeInBytes)
                        {
                            fixed (ulong* pTotalBytesPtr = &pTotalBytes)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, uint, uint, ulong, PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void>)@this->LpVtbl[38])(@this, pResourceDescPtr, FirstSubresource, NumSubresources, BaseOffset, pLayoutsPtr, pNumRowsPtr, pRowSizeInBytesPtr, pTotalBytesPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDesc, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in QueryHeapDesc pDesc, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueryHeapDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in QueryHeapDesc pDesc, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueryHeapDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in QueryHeapDesc pDesc, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueryHeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in QueryHeapDesc pDesc, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueryHeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, QueryHeapDesc*, Guid*, void**, int>)@this->LpVtbl[39])(@this, pDescPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStablePowerState(Silk.NET.Core.Bool32 Enable)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[40])(@this, Enable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignature);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riid, ppvCommandSignaturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riidPtr, ppvCommandSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignature, riidPtr, ppvCommandSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riid, ppvCommandSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riid, ppvCommandSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riidPtr, ppvCommandSignature);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDesc, pRootSignaturePtr, riidPtr, ppvCommandSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riid, ppvCommandSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, Guid* riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riid, ppvCommandSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riidPtr, ppvCommandSignature);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ID3D12RootSignature* pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignature, riidPtr, ppvCommandSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riid, ppvCommandSignature);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, Guid* riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riid, ppvCommandSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, void** ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riidPtr, ppvCommandSignature);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, ref Guid riid, ref void* ppvCommandSignature)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CommandSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvCommandSignaturePtr = &ppvCommandSignature)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, CommandSignatureDesc*, ID3D12RootSignature*, Guid*, void**, int>)@this->LpVtbl[41])(@this, pDescPtr, pRootSignaturePtr, riidPtr, ppvCommandSignaturePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ID3D12Resource* pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResource, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResource, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDesc, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMips, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                        {
                            fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                        {
                            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetResourceTiling(ref ID3D12Resource pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (uint* pNumTilesForEntireResourcePtr = &pNumTilesForEntireResource)
                {
                    fixed (PackedMipInfo* pPackedMipDescPtr = &pPackedMipDesc)
                    {
                        fixed (TileShape* pStandardTileShapeForNonPackedMipsPtr = &pStandardTileShapeForNonPackedMips)
                        {
                            fixed (uint* pNumSubresourceTilingsPtr = &pNumSubresourceTilings)
                            {
                                fixed (SubresourceTiling* pSubresourceTilingsForNonPackedMipsPtr = &pSubresourceTilingsForNonPackedMips)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Resource*, uint*, PackedMipInfo*, TileShape*, uint*, uint, SubresourceTiling*, void>)@this->LpVtbl[42])(@this, pTiledResourcePtr, pNumTilesForEntireResourcePtr, pPackedMipDescPtr, pStandardTileShapeForNonPackedMipsPtr, pNumSubresourceTilingsPtr, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMipsPtr);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly Luid GetAdapterLuid()
        {
            Luid silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Luid* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Luid*, Luid*>)@this->LpVtbl[43])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint BlobLength, Guid* riid, void** ppPipelineLibrary)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlob, BlobLength, riid, ppPipelineLibrary);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint BlobLength, Guid* riid, ref void* ppPipelineLibrary)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlob, BlobLength, riid, ppPipelineLibraryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint BlobLength, ref Guid riid, void** ppPipelineLibrary)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlob, BlobLength, riidPtr, ppPipelineLibrary);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint BlobLength, ref Guid riid, ref void* ppPipelineLibrary)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlob, BlobLength, riidPtr, ppPipelineLibraryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint BlobLength, Guid* riid, void** ppPipelineLibrary) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riid, ppPipelineLibrary);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint BlobLength, Guid* riid, ref void* ppPipelineLibrary) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riid, ppPipelineLibraryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint BlobLength, ref Guid riid, void** ppPipelineLibrary) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riidPtr, ppPipelineLibrary);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint BlobLength, ref Guid riid, ref void* ppPipelineLibrary) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineLibraryPtr = &ppPipelineLibrary)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[44])(@this, pLibraryBlobPtr, BlobLength, riidPtr, ppPipelineLibraryPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion([Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Fence** ppFences, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFences, pFenceValues, NumFences, Flags, hEvent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Fence** ppFences, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hEventPtr = &hEvent)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFences, pFenceValues, NumFences, Flags, hEventPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion([Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Fence** ppFences, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pFenceValuesPtr = &pFenceValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFences, pFenceValuesPtr, NumFences, Flags, hEvent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Fence** ppFences, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pFenceValuesPtr = &pFenceValues)
            {
                fixed (void* hEventPtr = &hEvent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFences, pFenceValuesPtr, NumFences, Flags, hEventPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D12Fence* ppFences, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Fence** ppFencesPtr = &ppFences)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFencesPtr, pFenceValues, NumFences, Flags, hEvent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D12Fence* ppFences, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Fence** ppFencesPtr = &ppFences)
            {
                fixed (void* hEventPtr = &hEvent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFencesPtr, pFenceValues, NumFences, Flags, hEventPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D12Fence* ppFences, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Fence** ppFencesPtr = &ppFences)
            {
                fixed (ulong* pFenceValuesPtr = &pFenceValues)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFencesPtr, pFenceValuesPtr, NumFences, Flags, hEvent);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D12Fence* ppFences, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Fence** ppFencesPtr = &ppFences)
            {
                fixed (ulong* pFenceValuesPtr = &pFenceValues)
                {
                    fixed (void* hEventPtr = &hEvent)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12Fence**, ulong*, uint, MultipleFenceWaitFlags, void*, int>)@this->LpVtbl[45])(@this, ppFencesPtr, pFenceValuesPtr, NumFences, Flags, hEventPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetResidencyPriority(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResidencyPriority* pPriorities)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, ID3D12Pageable**, ResidencyPriority*, int>)@this->LpVtbl[46])(@this, NumObjects, ppObjects, pPriorities);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetResidencyPriority(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResidencyPriority pPriorities)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResidencyPriority* pPrioritiesPtr = &pPriorities)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, ID3D12Pageable**, ResidencyPriority*, int>)@this->LpVtbl[46])(@this, NumObjects, ppObjects, pPrioritiesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetResidencyPriority(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D12Pageable* ppObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResidencyPriority* pPriorities)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, ID3D12Pageable**, ResidencyPriority*, int>)@this->LpVtbl[46])(@this, NumObjects, ppObjectsPtr, pPriorities);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetResidencyPriority(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D12Pageable* ppObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResidencyPriority pPriorities)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                fixed (ResidencyPriority* pPrioritiesPtr = &pPriorities)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, ID3D12Pageable**, ResidencyPriority*, int>)@this->LpVtbl[46])(@this, NumObjects, ppObjectsPtr, pPrioritiesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPipelineStatePtr = &ppPipelineState)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDesc, riid, ppPipelineStatePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDesc, riidPtr, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDesc, riidPtr, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineStateStreamDesc pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDescPtr, riid, ppPipelineState);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineStateStreamDesc pDesc, Guid* riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppPipelineStatePtr = &ppPipelineState)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDescPtr, riid, ppPipelineStatePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineStateStreamDesc pDesc, ref Guid riid, void** ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDescPtr, riidPtr, ppPipelineState);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineStateStreamDesc pDesc, ref Guid riid, ref void* ppPipelineState)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppPipelineStatePtr = &ppPipelineState)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[47])(@this, pDescPtr, riidPtr, ppPipelineStatePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pAddress, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddress, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pAddress, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddress, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pAddress, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddress, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pAddress, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddress, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pAddress, Guid* riid, void** ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pAddressPtr = &pAddress)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddressPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pAddress, Guid* riid, ref void* ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pAddressPtr = &pAddress)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddressPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pAddress, ref Guid riid, void** ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pAddressPtr = &pAddress)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddressPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pAddress, ref Guid riid, ref void* ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pAddressPtr = &pAddress)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[48])(@this, pAddressPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping(void* hFileMapping, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMapping, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping(void* hFileMapping, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMapping, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping(void* hFileMapping, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMapping, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping(void* hFileMapping, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMapping, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping<T0>(ref T0 hFileMapping, Guid* riid, void** ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hFileMappingPtr = &hFileMapping)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMappingPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping<T0>(ref T0 hFileMapping, Guid* riid, ref void* ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hFileMappingPtr = &hFileMapping)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMappingPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping<T0>(ref T0 hFileMapping, ref Guid riid, void** ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hFileMappingPtr = &hFileMapping)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMappingPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping<T0>(ref T0 hFileMapping, ref Guid riid, ref void* ppvHeap) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hFileMappingPtr = &hFileMapping)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void*, Guid*, void**, int>)@this->LpVtbl[49])(@this, hFileMappingPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueMakeResident(ResidencyFlags Flags, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects, ID3D12Fence* pFenceToSignal, ulong FenceValueToSignal)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)@this->LpVtbl[50])(@this, Flags, NumObjects, ppObjects, pFenceToSignal, FenceValueToSignal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueMakeResident(ResidencyFlags Flags, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D12Pageable** ppObjects, ref ID3D12Fence pFenceToSignal, ulong FenceValueToSignal)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Fence* pFenceToSignalPtr = &pFenceToSignal)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)@this->LpVtbl[50])(@this, Flags, NumObjects, ppObjects, pFenceToSignalPtr, FenceValueToSignal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueMakeResident(ResidencyFlags Flags, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D12Pageable* ppObjects, ID3D12Fence* pFenceToSignal, ulong FenceValueToSignal)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)@this->LpVtbl[50])(@this, Flags, NumObjects, ppObjectsPtr, pFenceToSignal, FenceValueToSignal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueMakeResident(ResidencyFlags Flags, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D12Pageable* ppObjects, ref ID3D12Fence pFenceToSignal, ulong FenceValueToSignal)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Pageable** ppObjectsPtr = &ppObjects)
            {
                fixed (ID3D12Fence* pFenceToSignalPtr = &pFenceToSignal)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResidencyFlags, uint, ID3D12Pageable**, ID3D12Fence*, ulong, int>)@this->LpVtbl[50])(@this, Flags, NumObjects, ppObjectsPtr, pFenceToSignalPtr, FenceValueToSignal);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList1(uint nodeMask, CommandListType type, CommandListFlags flags, Guid* riid, void** ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)@this->LpVtbl[51])(@this, nodeMask, type, flags, riid, ppCommandList);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList1(uint nodeMask, CommandListType type, CommandListFlags flags, Guid* riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCommandListPtr = &ppCommandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)@this->LpVtbl[51])(@this, nodeMask, type, flags, riid, ppCommandListPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList1(uint nodeMask, CommandListType type, CommandListFlags flags, ref Guid riid, void** ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)@this->LpVtbl[51])(@this, nodeMask, type, flags, riidPtr, ppCommandList);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList1(uint nodeMask, CommandListType type, CommandListFlags flags, ref Guid riid, ref void* ppCommandList)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCommandListPtr = &ppCommandList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint, CommandListType, CommandListFlags, Guid*, void**, int>)@this->LpVtbl[51])(@this, nodeMask, type, flags, riidPtr, ppCommandListPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProtectedResourceSessionDesc* pDesc, Guid* riid, void** ppSession)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDesc, riid, ppSession);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProtectedResourceSessionDesc* pDesc, Guid* riid, ref void* ppSession)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppSessionPtr = &ppSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDesc, riid, ppSessionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProtectedResourceSessionDesc* pDesc, ref Guid riid, void** ppSession)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDesc, riidPtr, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProtectedResourceSessionDesc* pDesc, ref Guid riid, ref void* ppSession)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDesc, riidPtr, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ProtectedResourceSessionDesc pDesc, Guid* riid, void** ppSession)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDescPtr, riid, ppSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ProtectedResourceSessionDesc pDesc, Guid* riid, ref void* ppSession)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppSessionPtr = &ppSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDescPtr, riid, ppSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ProtectedResourceSessionDesc pDesc, ref Guid riid, void** ppSession)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDescPtr, riidPtr, ppSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ProtectedResourceSessionDesc pDesc, ref Guid riid, ref void* ppSession)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ProtectedResourceSessionDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppSessionPtr = &ppSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ProtectedResourceSessionDesc*, Guid*, void**, int>)@this->LpVtbl[52])(@this, pDescPtr, riidPtr, ppSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResourcePtr = &riidResource)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapProperties, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (Guid* riidResourcePtr = &riidResource)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResource, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidResourcePtr = &riidResource)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValue, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResource, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (Guid* riidResourcePtr = &riidResource)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSession, riidResourcePtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResource, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                        {
                            fixed (Guid* riidResourcePtr = &riidResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResource);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riidResource, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapProperties* pHeapPropertiesPtr = &pHeapProperties)
            {
                fixed (ResourceDesc* pDescPtr = &pDesc)
                {
                    fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                    {
                        fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                        {
                            fixed (Guid* riidResourcePtr = &riidResource)
                            {
                                fixed (void** ppvResourcePtr = &ppvResource)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapProperties*, HeapFlags, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[53])(@this, pHeapPropertiesPtr, HeapFlags, pDescPtr, InitialResourceState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidResourcePtr, ppvResourcePtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSession, riid, ppvHeap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvHeapPtr = &ppvHeap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSession, riid, ppvHeapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSession, riidPtr, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSession, riidPtr, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDesc, pProtectedSessionPtr, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSession, riid, ppvHeap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvHeapPtr = &ppvHeap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSession, riid, ppvHeapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSession, riidPtr, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSession, riidPtr, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riid, ppvHeap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvHeapPtr = &ppvHeap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riid, ppvHeapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riidPtr, ppvHeap);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvHeap)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HeapDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvHeapPtr = &ppvHeap)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, HeapDesc*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[54])(@this, pDescPtr, pProtectedSessionPtr, riidPtr, ppvHeapPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDesc, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppvResourcePtr = &ppvResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riid, ppvResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSession, riidPtr, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValue, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (void** ppvResourcePtr = &ppvResource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riid, ppvResourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ID3D12ProtectedResourceSession* pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSession, riidPtr, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResource);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, Guid* riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (void** ppvResourcePtr = &ppvResource)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riid, ppvResourcePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, void** ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResource);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, ref Guid riid, ref void* ppvResource)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pDescPtr = &pDesc)
            {
                fixed (ClearValue* pOptimizedClearValuePtr = &pOptimizedClearValue)
                {
                    fixed (ID3D12ProtectedResourceSession* pProtectedSessionPtr = &pProtectedSession)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppvResourcePtr = &ppvResource)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceDesc*, ResourceStates, ClearValue*, ID3D12ProtectedResourceSession*, Guid*, void**, int>)@this->LpVtbl[55])(@this, pDescPtr, InitialState, pOptimizedClearValuePtr, pProtectedSessionPtr, riidPtr, ppvResourcePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ResourceAllocationInfo GetResourceAllocationInfo1(uint visibleMask, uint numResourceDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDescs, ResourceAllocationInfo1* pResourceAllocationInfo1)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ResourceAllocationInfo GetResourceAllocationInfo1(uint visibleMask, uint numResourceDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pResourceDescs, ref ResourceAllocationInfo1 pResourceAllocationInfo1)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            fixed (ResourceAllocationInfo1* pResourceAllocationInfo1Ptr = &pResourceAllocationInfo1)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescs, pResourceAllocationInfo1Ptr);
            }
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ResourceAllocationInfo GetResourceAllocationInfo1(uint visibleMask, uint numResourceDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDescs, ResourceAllocationInfo1* pResourceAllocationInfo1)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr, pResourceAllocationInfo1);
            }
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ResourceAllocationInfo GetResourceAllocationInfo1(uint visibleMask, uint numResourceDescs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pResourceDescs, ref ResourceAllocationInfo1 pResourceAllocationInfo1)
        {
            ResourceAllocationInfo silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ResourceAllocationInfo* ret = default;
            fixed (ResourceDesc* pResourceDescsPtr = &pResourceDescs)
            {
                fixed (ResourceAllocationInfo1* pResourceAllocationInfo1Ptr = &pResourceAllocationInfo1)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ResourceAllocationInfo*, uint, uint, ResourceDesc*, ResourceAllocationInfo1*, ResourceAllocationInfo*>)@this->LpVtbl[56])(@this, pSilkDotNetReturnFixupResult, visibleMask, numResourceDescs, pResourceDescsPtr, pResourceAllocationInfo1Ptr);
                }
            }
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ID3D12LifetimeOwner* pOwner, Guid* riid, void** ppvTracker)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwner, riid, ppvTracker);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ID3D12LifetimeOwner* pOwner, Guid* riid, ref void* ppvTracker)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvTrackerPtr = &ppvTracker)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwner, riid, ppvTrackerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ID3D12LifetimeOwner* pOwner, ref Guid riid, void** ppvTracker)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwner, riidPtr, ppvTracker);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ID3D12LifetimeOwner* pOwner, ref Guid riid, ref void* ppvTracker)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvTrackerPtr = &ppvTracker)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwner, riidPtr, ppvTrackerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ref ID3D12LifetimeOwner pOwner, Guid* riid, void** ppvTracker)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwnerPtr, riid, ppvTracker);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ref ID3D12LifetimeOwner pOwner, Guid* riid, ref void* ppvTracker)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
            {
                fixed (void** ppvTrackerPtr = &ppvTracker)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwnerPtr, riid, ppvTrackerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ref ID3D12LifetimeOwner pOwner, ref Guid riid, void** ppvTracker)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwnerPtr, riidPtr, ppvTracker);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker(ref ID3D12LifetimeOwner pOwner, ref Guid riid, ref void* ppvTracker)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12LifetimeOwner* pOwnerPtr = &pOwner)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvTrackerPtr = &ppvTracker)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, ID3D12LifetimeOwner*, Guid*, void**, int>)@this->LpVtbl[57])(@this, pOwnerPtr, riidPtr, ppvTrackerPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void RemoveDevice()
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, void>)@this->LpVtbl[58])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommands(uint* pNumMetaCommands, MetaCommandDesc* pDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint*, MetaCommandDesc*, int>)@this->LpVtbl[59])(@this, pNumMetaCommands, pDescs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommands(uint* pNumMetaCommands, ref MetaCommandDesc pDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MetaCommandDesc* pDescsPtr = &pDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint*, MetaCommandDesc*, int>)@this->LpVtbl[59])(@this, pNumMetaCommands, pDescsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommands(ref uint pNumMetaCommands, MetaCommandDesc* pDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumMetaCommandsPtr = &pNumMetaCommands)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint*, MetaCommandDesc*, int>)@this->LpVtbl[59])(@this, pNumMetaCommandsPtr, pDescs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumerateMetaCommands(ref uint pNumMetaCommands, ref MetaCommandDesc pDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumMetaCommandsPtr = &pNumMetaCommands)
            {
                fixed (MetaCommandDesc* pDescsPtr = &pDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, uint*, MetaCommandDesc*, int>)@this->LpVtbl[59])(@this, pNumMetaCommandsPtr, pDescsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pParameterCountPtr = &pParameterCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pParameterCountPtr = &pParameterCount)
            {
                fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                fixed (uint* pParameterCountPtr = &pParameterCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(Guid* CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
            {
                fixed (uint* pParameterCountPtr = &pParameterCount)
                {
                    fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandId, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCount, pParameterDescsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (uint* pParameterCountPtr = &pParameterCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, uint* pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (uint* pParameterCountPtr = &pParameterCount)
                {
                    fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytes, pParameterCountPtr, pParameterDescsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, uint* pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
                {
                    fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCount, pParameterDescsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, MetaCommandParameterDesc* pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
                {
                    fixed (uint* pParameterCountPtr = &pParameterCount)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumerateMetaCommandParameters(ref Guid CommandId, MetaCommandParameterStage Stage, ref uint pTotalStructureSizeInBytes, ref uint pParameterCount, ref MetaCommandParameterDesc pParameterDescs)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (uint* pTotalStructureSizeInBytesPtr = &pTotalStructureSizeInBytes)
                {
                    fixed (uint* pParameterCountPtr = &pParameterCount)
                    {
                        fixed (MetaCommandParameterDesc* pParameterDescsPtr = &pParameterDescs)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, MetaCommandParameterStage, uint*, uint*, MetaCommandParameterDesc*, int>)@this->LpVtbl[60])(@this, CommandIdPtr, Stage, pTotalStructureSizeInBytesPtr, pParameterCountPtr, pParameterDescsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(Guid* CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(Guid* CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppMetaCommandPtr = &ppMetaCommand)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(Guid* CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(Guid* CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(Guid* CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(Guid* CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(Guid* CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(Guid* CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandId, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(ref Guid CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(ref Guid CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(ref Guid CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand(ref Guid CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(ref Guid CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, void** ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommand);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(ref Guid CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, Guid* riid, ref void* ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
                {
                    fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riid, ppMetaCommandPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(ref Guid CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, void** ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommand);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0>(ref Guid CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, ref Guid riid, ref void* ppMetaCommand) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* CommandIdPtr = &CommandId)
            {
                fixed (void* pCreationParametersDataPtr = &pCreationParametersData)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppMetaCommandPtr = &ppMetaCommand)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, Guid*, uint, void*, nuint, Guid*, void**, int>)@this->LpVtbl[61])(@this, CommandIdPtr, NodeMask, pCreationParametersDataPtr, CreationParametersDataSizeInBytes, riidPtr, ppMetaCommandPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, Guid* riid, void** ppStateObject)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDesc, riid, ppStateObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, Guid* riid, ref void* ppStateObject)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppStateObjectPtr = &ppStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDesc, riid, ppStateObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, ref Guid riid, void** ppStateObject)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDesc, riidPtr, ppStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, ref Guid riid, ref void* ppStateObject)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppStateObjectPtr = &ppStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDesc, riidPtr, ppStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StateObjectDesc pDesc, Guid* riid, void** ppStateObject)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDescPtr, riid, ppStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StateObjectDesc pDesc, Guid* riid, ref void* ppStateObject)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppStateObjectPtr = &ppStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDescPtr, riid, ppStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StateObjectDesc pDesc, ref Guid riid, void** ppStateObject)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDescPtr, riidPtr, ppStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StateObjectDesc pDesc, ref Guid riid, ref void* ppStateObject)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppStateObjectPtr = &ppStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[62])(@this, pDescPtr, riidPtr, ppStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetRaytracingAccelerationStructurePrebuildInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] BuildRaytracingAccelerationStructureInputs* pDesc, RaytracingAccelerationStructurePrebuildInfo* pInfo)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Device6*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)@this->LpVtbl[63])(@this, pDesc, pInfo);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetRaytracingAccelerationStructurePrebuildInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] BuildRaytracingAccelerationStructureInputs* pDesc, ref RaytracingAccelerationStructurePrebuildInfo pInfo)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RaytracingAccelerationStructurePrebuildInfo* pInfoPtr = &pInfo)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)@this->LpVtbl[63])(@this, pDesc, pInfoPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetRaytracingAccelerationStructurePrebuildInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BuildRaytracingAccelerationStructureInputs pDesc, RaytracingAccelerationStructurePrebuildInfo* pInfo)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (BuildRaytracingAccelerationStructureInputs* pDescPtr = &pDesc)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12Device6*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)@this->LpVtbl[63])(@this, pDescPtr, pInfo);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetRaytracingAccelerationStructurePrebuildInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BuildRaytracingAccelerationStructureInputs pDesc, ref RaytracingAccelerationStructurePrebuildInfo pInfo)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (BuildRaytracingAccelerationStructureInputs* pDescPtr = &pDesc)
            {
                fixed (RaytracingAccelerationStructurePrebuildInfo* pInfoPtr = &pInfo)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12Device6*, BuildRaytracingAccelerationStructureInputs*, RaytracingAccelerationStructurePrebuildInfo*, void>)@this->LpVtbl[63])(@this, pDescPtr, pInfoPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe DriverMatchingIdentifierStatus CheckDriverMatchingIdentifier(SerializedDataType SerializedDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SerializedDataDriverMatchingIdentifier* pIdentifierToCheck)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            DriverMatchingIdentifierStatus ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, SerializedDataType, SerializedDataDriverMatchingIdentifier*, DriverMatchingIdentifierStatus>)@this->LpVtbl[64])(@this, SerializedDataType, pIdentifierToCheck);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly DriverMatchingIdentifierStatus CheckDriverMatchingIdentifier(SerializedDataType SerializedDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SerializedDataDriverMatchingIdentifier pIdentifierToCheck)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            DriverMatchingIdentifierStatus ret = default;
            fixed (SerializedDataDriverMatchingIdentifier* pIdentifierToCheckPtr = &pIdentifierToCheck)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, SerializedDataType, SerializedDataDriverMatchingIdentifier*, DriverMatchingIdentifierStatus>)@this->LpVtbl[64])(@this, SerializedDataType, pIdentifierToCheckPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBackgroundProcessingMode(BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, void* hEventToSignalUponCompletion, int* pbFurtherMeasurementsDesired)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)@this->LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletion, pbFurtherMeasurementsDesired);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBackgroundProcessingMode(BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, void* hEventToSignalUponCompletion, ref int pbFurtherMeasurementsDesired)
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pbFurtherMeasurementsDesiredPtr = &pbFurtherMeasurementsDesired)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)@this->LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletion, pbFurtherMeasurementsDesiredPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBackgroundProcessingMode<T0>(BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, ref T0 hEventToSignalUponCompletion, int* pbFurtherMeasurementsDesired) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hEventToSignalUponCompletionPtr = &hEventToSignalUponCompletion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)@this->LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletionPtr, pbFurtherMeasurementsDesired);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBackgroundProcessingMode<T0>(BackgroundProcessingMode Mode, MeasurementsAction MeasurementsAction, ref T0 hEventToSignalUponCompletion, ref int pbFurtherMeasurementsDesired) where T0 : unmanaged
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hEventToSignalUponCompletionPtr = &hEventToSignalUponCompletion)
            {
                fixed (int* pbFurtherMeasurementsDesiredPtr = &pbFurtherMeasurementsDesired)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Device6*, BackgroundProcessingMode, MeasurementsAction, void*, int*, int>)@this->LpVtbl[65])(@this, Mode, MeasurementsAction, hEventToSignalUponCompletionPtr, pbFurtherMeasurementsDesiredPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pData) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref guid, (Silk.NET.Core.Native.IUnknown*) pData.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandQueue<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc, out ComPtr<TI0> ppCommandQueue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCommandQueue = default;
            return @this->CreateCommandQueue(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandQueue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCommandQueue<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandQueueDesc pDesc, out ComPtr<TI0> ppCommandQueue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCommandQueue = default;
            return @this->CreateCommandQueue(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandQueue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCommandAllocator<TI0>(CommandListType type, out ComPtr<TI0> ppCommandAllocator) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCommandAllocator = default;
            return @this->CreateCommandAllocator(type, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandAllocator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGraphicsPipelineState<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->CreateGraphicsPipelineState(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGraphicsPipelineState<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GraphicsPipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->CreateGraphicsPipelineState(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComputePipelineState<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->CreateComputePipelineState(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateComputePipelineState<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ComputePipelineStateDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->CreateComputePipelineState(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCommandList<TI0, TI1, TI2>(uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ComPtr<TI1> pInitialState, out ComPtr<TI2> ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<TI2>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCommandList = default;
            return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, (ID3D12PipelineState*) pInitialState.Handle, SilkMarshal.GuidPtrOf<TI2>(), (void**) ppCommandList.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList<TI0, TI1>(uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ComPtr<TI1> pInitialState, Guid* riid, ref void* ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, (ID3D12PipelineState*) pInitialState.Handle, riid, ref ppCommandList);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList<TI0, TI1>(uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ComPtr<TI1> pInitialState, ref Guid riid, void** ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, (ID3D12PipelineState*) pInitialState.Handle, ref riid, ppCommandList);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList<TI0, TI1>(uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ComPtr<TI1> pInitialState, ref Guid riid, ref void* ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, (ID3D12PipelineState*) pInitialState.Handle, ref riid, ref ppCommandList);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCommandList<TI0, TI1>(uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ref ID3D12PipelineState pInitialState, out ComPtr<TI1> ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCommandList = default;
            return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, ref pInitialState, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppCommandList.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList<TI0>(uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ref ID3D12PipelineState pInitialState, Guid* riid, ref void* ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, ref pInitialState, riid, ref ppCommandList);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList<TI0>(uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, void** ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, ref pInitialState, ref riid, ppCommandList);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList<TI0>(uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ref ID3D12PipelineState pInitialState, ref Guid riid, ref void* ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandList(nodeMask, type, (ID3D12CommandAllocator*) pCommandAllocator.Handle, ref pInitialState, ref riid, ref ppCommandList);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCommandList<TI0, TI1>(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ComPtr<TI0> pInitialState, out ComPtr<TI1> ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCommandList = default;
            return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator, (ID3D12PipelineState*) pInitialState.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppCommandList.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList<TI0>(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ComPtr<TI0> pInitialState, Guid* riid, ref void* ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator, (ID3D12PipelineState*) pInitialState.Handle, riid, ref ppCommandList);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList<TI0>(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ComPtr<TI0> pInitialState, ref Guid riid, void** ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator, (ID3D12PipelineState*) pInitialState.Handle, ref riid, ppCommandList);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList<TI0>(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ComPtr<TI0> pInitialState, ref Guid riid, ref void* ppCommandList) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator, (ID3D12PipelineState*) pInitialState.Handle, ref riid, ref ppCommandList);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCommandList<TI0>(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState, out ComPtr<TI0> ppCommandList) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCommandList = default;
            return @this->CreateCommandList(nodeMask, type, ref pCommandAllocator, ref pInitialState, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandList.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDescriptorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->CreateDescriptorHeap(pDescriptorHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDescriptorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorHeapDesc pDescriptorHeapDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->CreateDescriptorHeap(in pDescriptorHeapDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRootSignature<TI0>(uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvRootSignature = default;
            return @this->CreateRootSignature(nodeMask, pBlobWithRootSignature, blobLengthInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateRootSignature<T0, TI0>(uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlobWithRootSignature, nuint blobLengthInBytes, out ComPtr<TI0> ppvRootSignature) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvRootSignature = default;
            return @this->CreateRootSignature(nodeMask, in pBlobWithRootSignature, blobLengthInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateShaderResourceView<TI0>(ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderResourceViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CreateShaderResourceView((ID3D12Resource*) pResource.Handle, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateShaderResourceView<TI0>(ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ShaderResourceViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CreateShaderResourceView((ID3D12Resource*) pResource.Handle, in pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView<TI0, TI1>(ComPtr<TI0> pResource, ComPtr<TI1> pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CreateUnorderedAccessView((ID3D12Resource*) pResource.Handle, (ID3D12Resource*) pCounterResource.Handle, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateUnorderedAccessView<TI0, TI1>(ComPtr<TI0> pResource, ComPtr<TI1> pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CreateUnorderedAccessView((ID3D12Resource*) pResource.Handle, (ID3D12Resource*) pCounterResource.Handle, in pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView<TI0>(ComPtr<TI0> pResource, ref ID3D12Resource pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CreateUnorderedAccessView((ID3D12Resource*) pResource.Handle, ref pCounterResource, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateUnorderedAccessView<TI0>(ComPtr<TI0> pResource, ref ID3D12Resource pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CreateUnorderedAccessView((ID3D12Resource*) pResource.Handle, ref pCounterResource, in pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateUnorderedAccessView<TI0>(ref ID3D12Resource pResource, ComPtr<TI0> pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnorderedAccessViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CreateUnorderedAccessView(ref pResource, (ID3D12Resource*) pCounterResource.Handle, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateUnorderedAccessView<TI0>(ref ID3D12Resource pResource, ComPtr<TI0> pCounterResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnorderedAccessViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CreateUnorderedAccessView(ref pResource, (ID3D12Resource*) pCounterResource.Handle, in pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateRenderTargetView<TI0>(ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderTargetViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CreateRenderTargetView((ID3D12Resource*) pResource.Handle, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateRenderTargetView<TI0>(ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderTargetViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CreateRenderTargetView((ID3D12Resource*) pResource.Handle, in pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CreateDepthStencilView<TI0>(ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DepthStencilViewDesc* pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CreateDepthStencilView((ID3D12Resource*) pResource.Handle, pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly void CreateDepthStencilView<TI0>(ComPtr<TI0> pResource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DepthStencilViewDesc pDesc, CpuDescriptorHandle DestDescriptor) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->CreateDepthStencilView((ID3D12Resource*) pResource.Handle, in pDesc, DestDescriptor);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->CreateHeap(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->CreateHeap(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0, TI1>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, pOptimizedClearValue, ref riid, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, pOptimizedClearValue, ref riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0, TI1>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, ref riid, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, ref riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0, TI1>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, ref riid, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, ref riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreatePlacedResource<TI0, TI1>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, Guid* riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, ref riid, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref Guid riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePlacedResource((ID3D12Heap*) pHeap.Handle, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, ref riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreatePlacedResource(ref pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreatePlacedResource(ref pHeap, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePlacedResource<TI0>(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreatePlacedResource(ref pHeap, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreatePlacedResource<TI0>(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreatePlacedResource(ref pHeap, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateReservedResource(pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateReservedResource(pDesc, InitialState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateReservedResource(in pDesc, InitialState, pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateReservedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateReservedResource(in pDesc, InitialState, in pOptimizedClearValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle<TI0>(ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, pAttributes, Access, Name, pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle<TI0>(ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, pAttributes, Access, Name, ref pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle<TI0>(ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, pAttributes, Access, in Name, pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle<TI0>(ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, pAttributes, Access, in Name, ref pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle<TI0>(ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, pAttributes, Access, Name, pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle<TI0>(ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, pAttributes, Access, Name, ref pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle<TI0>(ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, in pAttributes, Access, Name, pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle<TI0>(ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, in pAttributes, Access, Name, ref pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle<TI0>(ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, in pAttributes, Access, in Name, pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle<TI0>(ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, in pAttributes, Access, in Name, ref pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle<TI0>(ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, void** pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, in pAttributes, Access, Name, pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle<TI0>(ComPtr<TI0> pObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.SecurityAttributes pAttributes, uint Access, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name, ref void* pHandle) where TI0 : unmanaged, IComVtbl<ID3D12DeviceChild>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateSharedHandle((ID3D12DeviceChild*) pObject.Handle, in pAttributes, Access, Name, ref pHandle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenSharedHandle<TI0>(void* NTHandle, out ComPtr<TI0> ppvObj) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObj = default;
            return @this->OpenSharedHandle(NTHandle, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObj.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int OpenSharedHandle<T0, TI0>(ref T0 NTHandle, out ComPtr<TI0> ppvObj) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObj = default;
            return @this->OpenSharedHandle(ref NTHandle, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObj.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int MakeResident<TI0>(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppObjects) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MakeResident(NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Evict<TI0>(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppObjects) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Evict(NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFence<TI0>(ulong InitialValue, FenceFlags Flags, out ComPtr<TI0> ppFence) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppFence = default;
            return @this->CreateFence(InitialValue, Flags, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppFence.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->CreateQueryHeap(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in QueryHeapDesc pDesc, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->CreateQueryHeap(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ComPtr<TI0> pRootSignature, out ComPtr<TI1> ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvCommandSignature = default;
            return @this->CreateCommandSignature(pDesc, (ID3D12RootSignature*) pRootSignature.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvCommandSignature.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ComPtr<TI0> pRootSignature, Guid* riid, ref void* ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandSignature(pDesc, (ID3D12RootSignature*) pRootSignature.Handle, riid, ref ppvCommandSignature);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ComPtr<TI0> pRootSignature, ref Guid riid, void** ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandSignature(pDesc, (ID3D12RootSignature*) pRootSignature.Handle, ref riid, ppvCommandSignature);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ComPtr<TI0> pRootSignature, ref Guid riid, ref void* ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandSignature(pDesc, (ID3D12RootSignature*) pRootSignature.Handle, ref riid, ref ppvCommandSignature);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature, out ComPtr<TI0> ppvCommandSignature) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvCommandSignature = default;
            return @this->CreateCommandSignature(pDesc, ref pRootSignature, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvCommandSignature.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCommandSignature<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ComPtr<TI0> pRootSignature, out ComPtr<TI1> ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvCommandSignature = default;
            return @this->CreateCommandSignature(in pDesc, (ID3D12RootSignature*) pRootSignature.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvCommandSignature.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ComPtr<TI0> pRootSignature, Guid* riid, ref void* ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandSignature(in pDesc, (ID3D12RootSignature*) pRootSignature.Handle, riid, ref ppvCommandSignature);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ComPtr<TI0> pRootSignature, ref Guid riid, void** ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandSignature(in pDesc, (ID3D12RootSignature*) pRootSignature.Handle, ref riid, ppvCommandSignature);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ComPtr<TI0> pRootSignature, ref Guid riid, ref void* ppvCommandSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommandSignature(in pDesc, (ID3D12RootSignature*) pRootSignature.Handle, ref riid, ref ppvCommandSignature);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCommandSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature, out ComPtr<TI0> ppvCommandSignature) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvCommandSignature = default;
            return @this->CreateCommandSignature(in pDesc, ref pRootSignature, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvCommandSignature.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, uint* pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, PackedMipInfo* pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, TileShape* pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, SubresourceTiling* pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetResourceTiling<TI0>(ComPtr<TI0> pTiledResource, ref uint pNumTilesForEntireResource, ref PackedMipInfo pPackedMipDesc, ref TileShape pStandardTileShapeForNonPackedMips, ref uint pNumSubresourceTilings, uint FirstSubresourceTilingToGet, ref SubresourceTiling pSubresourceTilingsForNonPackedMips) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetResourceTiling((ID3D12Resource*) pTiledResource.Handle, ref pNumTilesForEntireResource, ref pPackedMipDesc, ref pStandardTileShapeForNonPackedMips, ref pNumSubresourceTilings, FirstSubresourceTilingToGet, ref pSubresourceTilingsForNonPackedMips);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineLibrary<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint BlobLength, out ComPtr<TI0> ppPipelineLibrary) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineLibrary = default;
            return @this->CreatePipelineLibrary(pLibraryBlob, BlobLength, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineLibrary.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreatePipelineLibrary<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint BlobLength, out ComPtr<TI0> ppPipelineLibrary) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineLibrary = default;
            return @this->CreatePipelineLibrary(in pLibraryBlob, BlobLength, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineLibrary.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppFences, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent) where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetEventOnMultipleFenceCompletion((ID3D12Fence**) ppFences.GetAddressOf(), pFenceValues, NumFences, Flags, hEvent);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppFences, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetEventOnMultipleFenceCompletion((ID3D12Fence**) ppFences.GetAddressOf(), pFenceValues, NumFences, Flags, ref hEvent);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetEventOnMultipleFenceCompletion<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppFences, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, void* hEvent) where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetEventOnMultipleFenceCompletion((ID3D12Fence**) ppFences.GetAddressOf(), in pFenceValues, NumFences, Flags, hEvent);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetEventOnMultipleFenceCompletion<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppFences, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong pFenceValues, uint NumFences, MultipleFenceWaitFlags Flags, ref T0 hEvent) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetEventOnMultipleFenceCompletion((ID3D12Fence**) ppFences.GetAddressOf(), in pFenceValues, NumFences, Flags, ref hEvent);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetResidencyPriority<TI0>(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResidencyPriority* pPriorities) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetResidencyPriority(NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf(), pPriorities);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetResidencyPriority<TI0>(uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResidencyPriority pPriorities) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetResidencyPriority(NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf(), in pPriorities);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePipelineState<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->CreatePipelineState(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreatePipelineState<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineStateStreamDesc pDesc, out ComPtr<TI0> ppPipelineState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppPipelineState = default;
            return @this->CreatePipelineState(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppPipelineState.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromAddress<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pAddress, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->OpenExistingHeapFromAddress(pAddress, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int OpenExistingHeapFromAddress<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pAddress, out ComPtr<TI0> ppvHeap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->OpenExistingHeapFromAddress(in pAddress, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenExistingHeapFromFileMapping<TI0>(void* hFileMapping, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->OpenExistingHeapFromFileMapping(hFileMapping, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int OpenExistingHeapFromFileMapping<T0, TI0>(ref T0 hFileMapping, out ComPtr<TI0> ppvHeap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->OpenExistingHeapFromFileMapping(ref hFileMapping, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int EnqueueMakeResident<TI0, TI1>(ResidencyFlags Flags, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppObjects, ComPtr<TI1> pFenceToSignal, ulong FenceValueToSignal) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnqueueMakeResident(Flags, NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf(), (ID3D12Fence*) pFenceToSignal.Handle, FenceValueToSignal);
        }

        /// <summary>To be documented.</summary>
        public readonly int EnqueueMakeResident<TI0>(ResidencyFlags Flags, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppObjects, ref ID3D12Fence pFenceToSignal, ulong FenceValueToSignal) where TI0 : unmanaged, IComVtbl<ID3D12Pageable>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnqueueMakeResident(Flags, NumObjects, (ID3D12Pageable**) ppObjects.GetAddressOf(), ref pFenceToSignal, FenceValueToSignal);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueMakeResident<TI0>(ResidencyFlags Flags, uint NumObjects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D12Pageable* ppObjects, ComPtr<TI0> pFenceToSignal, ulong FenceValueToSignal) where TI0 : unmanaged, IComVtbl<ID3D12Fence>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->EnqueueMakeResident(Flags, NumObjects, in ppObjects, (ID3D12Fence*) pFenceToSignal.Handle, FenceValueToSignal);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCommandList1<TI0>(uint nodeMask, CommandListType type, CommandListFlags flags, out ComPtr<TI0> ppCommandList) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCommandList = default;
            return @this->CreateCommandList1(nodeMask, type, flags, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCommandList.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProtectedResourceSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProtectedResourceSessionDesc* pDesc, out ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppSession = default;
            return @this->CreateProtectedResourceSession(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateProtectedResourceSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ProtectedResourceSessionDesc pDesc, out ComPtr<TI0> ppSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppSession = default;
            return @this->CreateProtectedResourceSession(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, Guid* riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, Guid* riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, Guid* riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, Guid* riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, Guid* riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, Guid* riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, Guid* riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, Guid* riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riidResource, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riidResource, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->CreateHeap1(pDesc, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ComPtr<TI0> pProtectedSession, Guid* riid, ref void* ppvHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHeap1(pDesc, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riid, ref ppvHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ComPtr<TI0> pProtectedSession, ref Guid riid, void** ppvHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHeap1(pDesc, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riid, ppvHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ComPtr<TI0> pProtectedSession, ref Guid riid, ref void* ppvHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHeap1(pDesc, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riid, ref ppvHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->CreateHeap1(pDesc, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateHeap1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->CreateHeap1(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ComPtr<TI0> pProtectedSession, Guid* riid, ref void* ppvHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHeap1(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riid, ref ppvHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ComPtr<TI0> pProtectedSession, ref Guid riid, void** ppvHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHeap1(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riid, ppvHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ComPtr<TI0> pProtectedSession, ref Guid riid, ref void* ppvHeap) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHeap1(in pDesc, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riid, ref ppvHeap);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvHeap) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvHeap = default;
            return @this->CreateHeap1(in pDesc, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvHeap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, Guid* riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riid, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riid, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateReservedResource1(pDesc, InitialState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, Guid* riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateReservedResource1(pDesc, InitialState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riid, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateReservedResource1(pDesc, InitialState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riid, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateReservedResource1(pDesc, InitialState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateReservedResource1(pDesc, InitialState, in pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateReservedResource1(in pDesc, InitialState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, Guid* riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateReservedResource1(in pDesc, InitialState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riid, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateReservedResource1(in pDesc, InitialState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riid, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateReservedResource1(in pDesc, InitialState, pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateReservedResource1(in pDesc, InitialState, pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateReservedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, out ComPtr<TI1> ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateReservedResource1(in pDesc, InitialState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, Guid* riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateReservedResource1(in pDesc, InitialState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riid, void** ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateReservedResource1(in pDesc, InitialState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riid, ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession, ref Guid riid, ref void* ppvResource) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateReservedResource1(in pDesc, InitialState, in pOptimizedClearValue, (ID3D12ProtectedResourceSession*) pProtectedSession.Handle, ref riid, ref ppvResource);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession, out ComPtr<TI0> ppvResource) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResource = default;
            return @this->CreateReservedResource1(in pDesc, InitialState, in pOptimizedClearValue, ref pProtectedSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateLifetimeTracker<TI0, TI1>(ComPtr<TI0> pOwner, out ComPtr<TI1> ppvTracker) where TI0 : unmanaged, IComVtbl<ID3D12LifetimeOwner>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvTracker = default;
            return @this->CreateLifetimeTracker((ID3D12LifetimeOwner*) pOwner.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvTracker.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker<TI0>(ComPtr<TI0> pOwner, Guid* riid, ref void* ppvTracker) where TI0 : unmanaged, IComVtbl<ID3D12LifetimeOwner>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLifetimeTracker((ID3D12LifetimeOwner*) pOwner.Handle, riid, ref ppvTracker);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker<TI0>(ComPtr<TI0> pOwner, ref Guid riid, void** ppvTracker) where TI0 : unmanaged, IComVtbl<ID3D12LifetimeOwner>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLifetimeTracker((ID3D12LifetimeOwner*) pOwner.Handle, ref riid, ppvTracker);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLifetimeTracker<TI0>(ComPtr<TI0> pOwner, ref Guid riid, ref void* ppvTracker) where TI0 : unmanaged, IComVtbl<ID3D12LifetimeOwner>, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateLifetimeTracker((ID3D12LifetimeOwner*) pOwner.Handle, ref riid, ref ppvTracker);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateLifetimeTracker<TI0>(ref ID3D12LifetimeOwner pOwner, out ComPtr<TI0> ppvTracker) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvTracker = default;
            return @this->CreateLifetimeTracker(ref pOwner, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvTracker.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<TI0>(Guid* CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, out ComPtr<TI0> ppMetaCommand) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppMetaCommand = default;
            return @this->CreateMetaCommand(CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppMetaCommand.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<T0, TI0>(Guid* CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, out ComPtr<TI0> ppMetaCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppMetaCommand = default;
            return @this->CreateMetaCommand(CommandId, NodeMask, in pCreationParametersData, CreationParametersDataSizeInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppMetaCommand.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetaCommand<TI0>(ref Guid CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParametersData, nuint CreationParametersDataSizeInBytes, out ComPtr<TI0> ppMetaCommand) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppMetaCommand = default;
            return @this->CreateMetaCommand(ref CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppMetaCommand.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMetaCommand<T0, TI0>(ref Guid CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes, out ComPtr<TI0> ppMetaCommand) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppMetaCommand = default;
            return @this->CreateMetaCommand(ref CommandId, NodeMask, in pCreationParametersData, CreationParametersDataSizeInBytes, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppMetaCommand.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, out ComPtr<TI0> ppStateObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppStateObject = default;
            return @this->CreateStateObject(pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StateObjectDesc pDesc, out ComPtr<TI0> ppStateObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppStateObject = default;
            return @this->CreateStateObject(in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommandQueue<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandQueueDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommandQueue(pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateCommandQueue<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandQueueDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommandQueue(in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateCommandAllocator<TI0>(CommandListType type) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommandAllocator(type, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateGraphicsPipelineState<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateGraphicsPipelineState(pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateGraphicsPipelineState<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GraphicsPipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateGraphicsPipelineState(in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateComputePipelineState<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateComputePipelineState(pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateComputePipelineState<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ComputePipelineStateDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateComputePipelineState(in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI2> CreateCommandList<TI0, TI1, TI2>(uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ComPtr<TI1> pInitialState) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<TI2>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommandList(nodeMask, type, pCommandAllocator, pInitialState, out ComPtr<TI2> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateCommandList<TI0, TI1>(uint nodeMask, CommandListType type, ComPtr<TI0> pCommandAllocator, ref ID3D12PipelineState pInitialState) where TI0 : unmanaged, IComVtbl<ID3D12CommandAllocator>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommandList(nodeMask, type, pCommandAllocator, ref pInitialState, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateCommandList<TI0, TI1>(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ComPtr<TI0> pInitialState) where TI0 : unmanaged, IComVtbl<ID3D12PipelineState>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommandList(nodeMask, type, ref pCommandAllocator, pInitialState, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateCommandList<TI0>(uint nodeMask, CommandListType type, ref ID3D12CommandAllocator pCommandAllocator, ref ID3D12PipelineState pInitialState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommandList(nodeMask, type, ref pCommandAllocator, ref pInitialState, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateDescriptorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorHeapDesc* pDescriptorHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateDescriptorHeap(pDescriptorHeapDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateDescriptorHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorHeapDesc pDescriptorHeapDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateDescriptorHeap(in pDescriptorHeapDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateRootSignature<TI0>(uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlobWithRootSignature, nuint blobLengthInBytes) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateRootSignature(nodeMask, pBlobWithRootSignature, blobLengthInBytes, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateRootSignature<T0, TI0>(uint nodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlobWithRootSignature, nuint blobLengthInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateRootSignature(nodeMask, in pBlobWithRootSignature, blobLengthInBytes, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateCommittedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateHeap(pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateHeap(in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreatePlacedResource<TI0, TI1>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreatePlacedResource<TI0, TI1>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreatePlacedResource<TI0, TI1>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreatePlacedResource(pHeap, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreatePlacedResource<TI0, TI1>(ComPtr<TI0> pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<ID3D12Heap>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreatePlacedResource(pHeap, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreatePlacedResource<TI0>(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreatePlacedResource(ref pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreatePlacedResource<TI0>(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreatePlacedResource(ref pHeap, HeapOffset, pDesc, InitialState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreatePlacedResource<TI0>(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreatePlacedResource(ref pHeap, HeapOffset, in pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreatePlacedResource<TI0>(ref ID3D12Heap pHeap, ulong HeapOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreatePlacedResource(ref pHeap, HeapOffset, in pDesc, InitialState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateReservedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateReservedResource(pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateReservedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateReservedResource(pDesc, InitialState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateReservedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateReservedResource(in pDesc, InitialState, pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateReservedResource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateReservedResource(in pDesc, InitialState, in pOptimizedClearValue, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> OpenSharedHandle<TI0>(void* NTHandle) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->OpenSharedHandle(NTHandle, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> OpenSharedHandle<T0, TI0>(ref T0 NTHandle) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->OpenSharedHandle(ref NTHandle, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateFence<TI0>(ulong InitialValue, FenceFlags Flags) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateFence(InitialValue, Flags, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateQueryHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryHeapDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateQueryHeap(pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateQueryHeap<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in QueryHeapDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateQueryHeap(in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateCommandSignature<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ComPtr<TI0> pRootSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommandSignature(pDesc, pRootSignature, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommandSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CommandSignatureDesc* pDesc, ref ID3D12RootSignature pRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommandSignature(pDesc, ref pRootSignature, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateCommandSignature<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ComPtr<TI0> pRootSignature) where TI0 : unmanaged, IComVtbl<ID3D12RootSignature>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommandSignature(in pDesc, pRootSignature, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateCommandSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CommandSignatureDesc pDesc, ref ID3D12RootSignature pRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommandSignature(in pDesc, ref pRootSignature, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreatePipelineLibrary<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint BlobLength) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreatePipelineLibrary(pLibraryBlob, BlobLength, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreatePipelineLibrary<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint BlobLength) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreatePipelineLibrary(in pLibraryBlob, BlobLength, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreatePipelineState<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreatePipelineState(pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreatePipelineState<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PipelineStateStreamDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreatePipelineState(in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> OpenExistingHeapFromAddress<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pAddress) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->OpenExistingHeapFromAddress(pAddress, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> OpenExistingHeapFromAddress<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pAddress) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->OpenExistingHeapFromAddress(in pAddress, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> OpenExistingHeapFromFileMapping<TI0>(void* hFileMapping) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->OpenExistingHeapFromFileMapping(hFileMapping, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> OpenExistingHeapFromFileMapping<T0, TI0>(ref T0 hFileMapping) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->OpenExistingHeapFromFileMapping(ref hFileMapping, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateCommandList1<TI0>(uint nodeMask, CommandListType type, CommandListFlags flags) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommandList1(nodeMask, type, flags, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateProtectedResourceSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ProtectedResourceSessionDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateProtectedResourceSession(pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateProtectedResourceSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ProtectedResourceSessionDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateProtectedResourceSession(in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapProperties* pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(in pHeapProperties, HeapFlags, pDesc, InitialResourceState, in pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateCommittedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateCommittedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapProperties pHeapProperties, HeapFlags HeapFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialResourceState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCommittedResource1(in pHeapProperties, HeapFlags, in pDesc, InitialResourceState, in pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateHeap1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateHeap1(pDesc, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HeapDesc* pDesc, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateHeap1(pDesc, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateHeap1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateHeap1(in pDesc, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateHeap1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HeapDesc pDesc, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateHeap1(in pDesc, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateReservedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateReservedResource1(pDesc, InitialState, pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateReservedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateReservedResource1(pDesc, InitialState, in pOptimizedClearValue, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceDesc* pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateReservedResource1(pDesc, InitialState, in pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateReservedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateReservedResource1(in pDesc, InitialState, pOptimizedClearValue, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearValue* pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateReservedResource1(in pDesc, InitialState, pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateReservedResource1<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ComPtr<TI0> pProtectedSession) where TI0 : unmanaged, IComVtbl<ID3D12ProtectedResourceSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateReservedResource1(in pDesc, InitialState, in pOptimizedClearValue, pProtectedSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateReservedResource1<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceDesc pDesc, ResourceStates InitialState, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ClearValue pOptimizedClearValue, ref ID3D12ProtectedResourceSession pProtectedSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateReservedResource1(in pDesc, InitialState, in pOptimizedClearValue, ref pProtectedSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateLifetimeTracker<TI0, TI1>(ComPtr<TI0> pOwner) where TI0 : unmanaged, IComVtbl<ID3D12LifetimeOwner>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateLifetimeTracker(pOwner, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateLifetimeTracker<TI0>(ref ID3D12LifetimeOwner pOwner) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateLifetimeTracker(ref pOwner, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateMetaCommand<TI0>(Guid* CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParametersData, nuint CreationParametersDataSizeInBytes) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateMetaCommand(CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateMetaCommand<T0, TI0>(Guid* CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateMetaCommand(CommandId, NodeMask, in pCreationParametersData, CreationParametersDataSizeInBytes, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateMetaCommand<TI0>(ref Guid CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pCreationParametersData, nuint CreationParametersDataSizeInBytes) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateMetaCommand(ref CommandId, NodeMask, pCreationParametersData, CreationParametersDataSizeInBytes, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateMetaCommand<T0, TI0>(ref Guid CommandId, uint NodeMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pCreationParametersData, nuint CreationParametersDataSizeInBytes) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateMetaCommand(ref CommandId, NodeMask, in pCreationParametersData, CreationParametersDataSizeInBytes, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateStateObject(pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in StateObjectDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Device6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateStateObject(in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
