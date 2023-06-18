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

namespace Silk.NET.Direct2D
{
    [Guid("31e6e7bc-e0ff-4d46-8c64-a0a8c41c15d3")]
    [NativeName("Name", "ID2D1Multithread")]
    public unsafe partial struct ID2D1Multithread : IComVtbl<ID2D1Multithread>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("31e6e7bc-e0ff-4d46-8c64-a0a8c41c15d3");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Multithread val)
            => Unsafe.As<ID2D1Multithread, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Multithread
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
            var @this = (ID2D1Multithread*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Multithread*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Multithread*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Multithread*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Multithread*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Multithread*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetMultithreadProtected()
        {
            var @this = (ID2D1Multithread*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Multithread*, Silk.NET.Core.Bool32>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void Enter()
        {
            var @this = (ID2D1Multithread*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Multithread*, void>)@this->LpVtbl[4])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void Leave()
        {
            var @this = (ID2D1Multithread*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Multithread*, void>)@this->LpVtbl[5])(@this);
        }

    }
}
