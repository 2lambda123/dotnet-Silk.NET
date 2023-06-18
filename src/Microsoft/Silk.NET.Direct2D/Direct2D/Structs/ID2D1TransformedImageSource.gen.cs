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
    [Guid("7f1f79e5-2796-416c-8f55-700f911445e5")]
    [NativeName("Name", "ID2D1TransformedImageSource")]
    public unsafe partial struct ID2D1TransformedImageSource : IComVtbl<ID2D1TransformedImageSource>, IComVtbl<ID2D1Image>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("7f1f79e5-2796-416c-8f55-700f911445e5");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Image(ID2D1TransformedImageSource val)
            => Unsafe.As<ID2D1TransformedImageSource, ID2D1Image>(ref val);

        public static implicit operator ID2D1Resource(ID2D1TransformedImageSource val)
            => Unsafe.As<ID2D1TransformedImageSource, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1TransformedImageSource val)
            => Unsafe.As<ID2D1TransformedImageSource, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1TransformedImageSource
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
            var @this = (ID2D1TransformedImageSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformedImageSource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1TransformedImageSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformedImageSource*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1TransformedImageSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformedImageSource*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1TransformedImageSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1TransformedImageSource*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetSource(ID2D1ImageSource** imageSource)
        {
            var @this = (ID2D1TransformedImageSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1TransformedImageSource*, ID2D1ImageSource**, void>)@this->LpVtbl[4])(@this, imageSource);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetProperties(TransformedImageSourceProperties* properties)
        {
            var @this = (ID2D1TransformedImageSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1TransformedImageSource*, TransformedImageSourceProperties*, void>)@this->LpVtbl[5])(@this, properties);
        }

    }
}
