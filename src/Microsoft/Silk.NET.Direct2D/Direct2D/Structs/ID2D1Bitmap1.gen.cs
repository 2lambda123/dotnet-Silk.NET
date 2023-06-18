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
    [Guid("a898a84c-3873-4588-b08b-ebbf978df041")]
    [NativeName("Name", "ID2D1Bitmap1")]
    public unsafe partial struct ID2D1Bitmap1 : IComVtbl<ID2D1Bitmap1>, IComVtbl<ID2D1Bitmap>, IComVtbl<ID2D1Image>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a898a84c-3873-4588-b08b-ebbf978df041");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Bitmap(ID2D1Bitmap1 val)
            => Unsafe.As<ID2D1Bitmap1, ID2D1Bitmap>(ref val);

        public static implicit operator ID2D1Image(ID2D1Bitmap1 val)
            => Unsafe.As<ID2D1Bitmap1, ID2D1Image>(ref val);

        public static implicit operator ID2D1Resource(ID2D1Bitmap1 val)
            => Unsafe.As<ID2D1Bitmap1, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Bitmap1 val)
            => Unsafe.As<ID2D1Bitmap1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Bitmap1
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
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Maths.Vector2D<float> GetSize()
        {
            Silk.NET.Maths.Vector2D<float> silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Maths.Vector2D<float>* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*>)@this->LpVtbl[4])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Maths.Vector2D<uint> GetPixelSize()
        {
            Silk.NET.Maths.Vector2D<uint> silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Maths.Vector2D<uint>* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, Silk.NET.Maths.Vector2D<uint>*>)@this->LpVtbl[5])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly PixelFormat GetPixelFormat()
        {
            PixelFormat silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            PixelFormat* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, PixelFormat*, PixelFormat*>)@this->LpVtbl[6])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(float* dpiX, float* dpiY)
        {
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, float*, float*, void>)@this->LpVtbl[7])(@this, dpiX, dpiY);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromBitmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1Bitmap* bitmap, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
        {
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[8])(@this, destPoint, bitmap, srcRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromRenderTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<uint>* destPoint, ID2D1RenderTarget* renderTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* srcRect)
        {
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Vector2D<uint>*, ID2D1RenderTarget*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[9])(@this, destPoint, renderTarget, srcRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyFromMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<uint>* dstRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* srcData, uint pitch)
        {
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.Maths.Box2D<uint>*, void*, uint, int>)@this->LpVtbl[10])(@this, dstRect, srcData, pitch);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetColorContext(ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, ID2D1ColorContext**, void>)@this->LpVtbl[11])(@this, colorContext);
        }

        /// <summary>To be documented.</summary>
        public readonly BitmapOptions GetOptions()
        {
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            BitmapOptions ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, BitmapOptions>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSurface(Silk.NET.DXGI.IDXGISurface** dxgiSurface)
        {
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, Silk.NET.DXGI.IDXGISurface**, int>)@this->LpVtbl[13])(@this, dxgiSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map(MapOptions options, MappedRect* mappedRect)
        {
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, MapOptions, MappedRect*, int>)@this->LpVtbl[14])(@this, options, mappedRect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Unmap()
        {
            var @this = (ID2D1Bitmap1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Bitmap1*, int>)@this->LpVtbl[15])(@this);
            return ret;
        }

    }
}
