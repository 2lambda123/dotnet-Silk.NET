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
    [Guid("00000016-0000-0000-c000-000000000046")]
    [NativeName("Name", "IMessageFilter")]
    public unsafe partial struct IMessageFilter : IComVtbl<IMessageFilter>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000016-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMessageFilter val)
            => Unsafe.As<IMessageFilter, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMessageFilter
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
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint HandleInComingCall(uint dwCallType, IntPtr* htaskCaller, uint dwTickCount, InterfaceInfo* lpInterfaceInfo)
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, uint, IntPtr*, uint, InterfaceInfo*, uint>)@this->LpVtbl[3])(@this, dwCallType, htaskCaller, dwTickCount, lpInterfaceInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint HandleInComingCall(uint dwCallType, IntPtr* htaskCaller, uint dwTickCount, ref InterfaceInfo lpInterfaceInfo)
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (InterfaceInfo* lpInterfaceInfoPtr = &lpInterfaceInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, uint, IntPtr*, uint, InterfaceInfo*, uint>)@this->LpVtbl[3])(@this, dwCallType, htaskCaller, dwTickCount, lpInterfaceInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint HandleInComingCall(uint dwCallType, ref IntPtr htaskCaller, uint dwTickCount, InterfaceInfo* lpInterfaceInfo)
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (IntPtr* htaskCallerPtr = &htaskCaller)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, uint, IntPtr*, uint, InterfaceInfo*, uint>)@this->LpVtbl[3])(@this, dwCallType, htaskCallerPtr, dwTickCount, lpInterfaceInfo);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint HandleInComingCall(uint dwCallType, ref IntPtr htaskCaller, uint dwTickCount, ref InterfaceInfo lpInterfaceInfo)
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (IntPtr* htaskCallerPtr = &htaskCaller)
            {
                fixed (InterfaceInfo* lpInterfaceInfoPtr = &lpInterfaceInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, uint, IntPtr*, uint, InterfaceInfo*, uint>)@this->LpVtbl[3])(@this, dwCallType, htaskCallerPtr, dwTickCount, lpInterfaceInfoPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint RetryRejectedCall(IntPtr* htaskCallee, uint dwTickCount, uint dwRejectType)
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, IntPtr*, uint, uint, uint>)@this->LpVtbl[4])(@this, htaskCallee, dwTickCount, dwRejectType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint RetryRejectedCall(ref IntPtr htaskCallee, uint dwTickCount, uint dwRejectType)
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (IntPtr* htaskCalleePtr = &htaskCallee)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, IntPtr*, uint, uint, uint>)@this->LpVtbl[4])(@this, htaskCalleePtr, dwTickCount, dwRejectType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint MessagePending(IntPtr* htaskCallee, uint dwTickCount, uint dwPendingType)
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, IntPtr*, uint, uint, uint>)@this->LpVtbl[5])(@this, htaskCallee, dwTickCount, dwPendingType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint MessagePending(ref IntPtr htaskCallee, uint dwTickCount, uint dwPendingType)
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (IntPtr* htaskCalleePtr = &htaskCallee)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMessageFilter*, IntPtr*, uint, uint, uint>)@this->LpVtbl[5])(@this, htaskCalleePtr, dwTickCount, dwPendingType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMessageFilter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
