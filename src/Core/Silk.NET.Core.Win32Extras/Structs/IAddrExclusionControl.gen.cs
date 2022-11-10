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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("00000148-0000-0000-c000-000000000046")]
    [NativeName("Name", "IAddrExclusionControl")]
    public unsafe partial struct IAddrExclusionControl : IComVtbl<IAddrExclusionControl>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000148-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IAddrExclusionControl val)
            => Unsafe.As<IAddrExclusionControl, Silk.NET.Core.Native.IUnknown>(ref val);

        public IAddrExclusionControl
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
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentAddrExclusionList(Guid* riid, void** ppEnumerator)
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppEnumerator);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentAddrExclusionList(Guid* riid, ref void* ppEnumerator)
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppEnumeratorPtr = &ppEnumerator)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppEnumeratorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentAddrExclusionList(ref Guid riid, void** ppEnumerator)
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppEnumerator);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentAddrExclusionList(ref Guid riid, ref void* ppEnumerator)
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppEnumeratorPtr = &ppEnumerator)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppEnumeratorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateAddrExclusionList(Silk.NET.Core.Native.IUnknown* pEnumerator)
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, pEnumerator);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateAddrExclusionList(ref Silk.NET.Core.Native.IUnknown pEnumerator)
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pEnumeratorPtr = &pEnumerator)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAddrExclusionControl*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, pEnumeratorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCurrentAddrExclusionList<TI0>(out ComPtr<TI0> ppEnumerator) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppEnumerator = default;
            return @this->GetCurrentAddrExclusionList(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppEnumerator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateAddrExclusionList<TI0>(ComPtr<TI0> pEnumerator) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UpdateAddrExclusionList((Silk.NET.Core.Native.IUnknown*) pEnumerator.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetCurrentAddrExclusionList<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAddrExclusionControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetCurrentAddrExclusionList(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
