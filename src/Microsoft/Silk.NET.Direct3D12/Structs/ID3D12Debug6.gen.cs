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
    [Guid("82a816d6-5d01-4157-97d0-4975463fd1ed")]
    [NativeName("Name", "ID3D12Debug6")]
    public unsafe partial struct ID3D12Debug6
    {
        public static readonly Guid Guid = new("82a816d6-5d01-4157-97d0-4975463fd1ed");

        public static implicit operator ID3D12Debug5(ID3D12Debug6 val)
            => Unsafe.As<ID3D12Debug6, ID3D12Debug5>(ref val);

        public static implicit operator ID3D12Debug4(ID3D12Debug6 val)
            => Unsafe.As<ID3D12Debug6, ID3D12Debug4>(ref val);

        public static implicit operator ID3D12Debug3(ID3D12Debug6 val)
            => Unsafe.As<ID3D12Debug6, ID3D12Debug3>(ref val);

        public static implicit operator ID3D12Debug(ID3D12Debug6 val)
            => Unsafe.As<ID3D12Debug6, ID3D12Debug>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12Debug6 val)
            => Unsafe.As<ID3D12Debug6, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12Debug6
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
            var @this = (ID3D12Debug6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug6*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12Debug6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug6*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12Debug6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug6*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12Debug6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug6*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12Debug6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug6*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12Debug6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Debug6*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void EnableDebugLayer()
        {
            var @this = (ID3D12Debug6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Debug6*, void>)LpVtbl[3])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetEnableGPUBasedValidation(int Enable)
        {
            var @this = (ID3D12Debug6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Debug6*, int, void>)LpVtbl[4])(@this, Enable);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetEnableSynchronizedCommandQueueValidation(int Enable)
        {
            var @this = (ID3D12Debug6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Debug6*, int, void>)LpVtbl[5])(@this, Enable);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGPUBasedValidationFlags(GpuBasedValidationFlags Flags)
        {
            var @this = (ID3D12Debug6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Debug6*, GpuBasedValidationFlags, void>)LpVtbl[6])(@this, Flags);
        }

        /// <summary>To be documented.</summary>
        public readonly void DisableDebugLayer()
        {
            var @this = (ID3D12Debug6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Debug6*, void>)LpVtbl[7])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetEnableAutoName(int Enable)
        {
            var @this = (ID3D12Debug6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Debug6*, int, void>)LpVtbl[8])(@this, Enable);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetForceLegacyBarrierValidation(int Enable)
        {
            var @this = (ID3D12Debug6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Debug6*, int, void>)LpVtbl[9])(@this, Enable);
        }

    }
}
