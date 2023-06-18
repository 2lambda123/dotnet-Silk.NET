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
    [Guid("00000002-0000-0000-c000-000000000046")]
    [NativeName("Name", "IMalloc")]
    public unsafe partial struct IMalloc : IComVtbl<IMalloc>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000002-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMalloc val)
            => Unsafe.As<IMalloc, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMalloc
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
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* Alloc(nuint cb)
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, nuint, void*>)@this->LpVtbl[3])(@this, cb);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* Realloc(void* pv, nuint cb)
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, nuint, void*>)@this->LpVtbl[4])(@this, pv, cb);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Free(void* pv)
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IMalloc*, void*, void>)@this->LpVtbl[5])(@this, pv);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe nuint GetSize(void* pv)
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, nuint>)@this->LpVtbl[6])(@this, pv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DidAlloc(void* pv)
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMalloc*, void*, int>)@this->LpVtbl[7])(@this, pv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void HeapMinimize()
        {
            var @this = (IMalloc*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IMalloc*, void>)@this->LpVtbl[8])(@this);
        }

    }
}
