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
    [Guid("86b88e4d-afa4-4d7b-88e4-68a51c4a0aec")]
    [NativeName("Name", "ID2D1SvgDocument")]
    public unsafe partial struct ID2D1SvgDocument
    {
        public static readonly Guid Guid = new("86b88e4d-afa4-4d7b-88e4-68a51c4a0aec");

        public static implicit operator ID2D1Resource(ID2D1SvgDocument val)
            => Unsafe.As<ID2D1SvgDocument, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1SvgDocument val)
            => Unsafe.As<ID2D1SvgDocument, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1SvgDocument
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
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1Factory**, void>)LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1Factory**, void>)LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int SetViewportSize(D2D_SIZE_F viewportSize)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, D2D_SIZE_F, int>)LpVtbl[4])(@this, viewportSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly D2D_SIZE_F GetViewportSize()
        {
            D2D_SIZE_F silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            D2D_SIZE_F* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, D2D_SIZE_F*, D2D_SIZE_F*>)LpVtbl[5])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetRoot(ID2D1SvgElement* root)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1SvgElement*, int>)LpVtbl[6])(@this, root);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRoot(ref ID2D1SvgElement root)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* rootPtr = &root)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1SvgElement*, int>)LpVtbl[6])(@this, rootPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetRoot(ID2D1SvgElement** root)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1SvgElement**, void>)LpVtbl[7])(@this, root);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetRoot(ref ID2D1SvgElement* root)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgElement** rootPtr = &root)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1SvgElement**, void>)LpVtbl[7])(@this, rootPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindElementById(char* id, ID2D1SvgElement** svgElement)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, char*, ID2D1SvgElement**, int>)LpVtbl[8])(@this, id, svgElement);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindElementById(char* id, ref ID2D1SvgElement* svgElement)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement** svgElementPtr = &svgElement)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, char*, ID2D1SvgElement**, int>)LpVtbl[8])(@this, id, svgElementPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindElementById(ref char id, ID2D1SvgElement** svgElement)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* idPtr = &id)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, char*, ID2D1SvgElement**, int>)LpVtbl[8])(@this, idPtr, svgElement);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindElementById(ref char id, ref ID2D1SvgElement* svgElement)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* idPtr = &id)
            {
                fixed (ID2D1SvgElement** svgElementPtr = &svgElement)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, char*, ID2D1SvgElement**, int>)LpVtbl[8])(@this, idPtr, svgElementPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindElementById([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ID2D1SvgElement** svgElement)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, byte*, ID2D1SvgElement**, int>)LpVtbl[8])(@this, idPtr, svgElement);
            SilkMarshal.Free((nint)idPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindElementById([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ref ID2D1SvgElement* svgElement)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
            fixed (ID2D1SvgElement** svgElementPtr = &svgElement)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, byte*, ID2D1SvgElement**, int>)LpVtbl[8])(@this, idPtr, svgElementPtr);
            }
            SilkMarshal.Free((nint)idPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Serialize(IStream* outputXmlStream, ID2D1SvgElement* subtree)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, IStream*, ID2D1SvgElement*, int>)LpVtbl[9])(@this, outputXmlStream, subtree);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Serialize(IStream* outputXmlStream, ref ID2D1SvgElement subtree)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement* subtreePtr = &subtree)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, IStream*, ID2D1SvgElement*, int>)LpVtbl[9])(@this, outputXmlStream, subtreePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Serialize(ref IStream outputXmlStream, ID2D1SvgElement* subtree)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStream* outputXmlStreamPtr = &outputXmlStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, IStream*, ID2D1SvgElement*, int>)LpVtbl[9])(@this, outputXmlStreamPtr, subtree);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Serialize(ref IStream outputXmlStream, ref ID2D1SvgElement subtree)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStream* outputXmlStreamPtr = &outputXmlStream)
            {
                fixed (ID2D1SvgElement* subtreePtr = &subtree)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, IStream*, ID2D1SvgElement*, int>)LpVtbl[9])(@this, outputXmlStreamPtr, subtreePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Deserialize(IStream* inputXmlStream, ID2D1SvgElement** subtree)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, IStream*, ID2D1SvgElement**, int>)LpVtbl[10])(@this, inputXmlStream, subtree);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Deserialize(IStream* inputXmlStream, ref ID2D1SvgElement* subtree)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgElement** subtreePtr = &subtree)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, IStream*, ID2D1SvgElement**, int>)LpVtbl[10])(@this, inputXmlStream, subtreePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Deserialize(ref IStream inputXmlStream, ID2D1SvgElement** subtree)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStream* inputXmlStreamPtr = &inputXmlStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, IStream*, ID2D1SvgElement**, int>)LpVtbl[10])(@this, inputXmlStreamPtr, subtree);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Deserialize(ref IStream inputXmlStream, ref ID2D1SvgElement* subtree)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStream* inputXmlStreamPtr = &inputXmlStream)
            {
                fixed (ID2D1SvgElement** subtreePtr = &subtree)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, IStream*, ID2D1SvgElement**, int>)LpVtbl[10])(@this, inputXmlStreamPtr, subtreePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePaint(SvgPaintType paintType, _D3DCOLORVALUE* color, char* id, ID2D1SvgPaint** paint)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, _D3DCOLORVALUE*, char*, ID2D1SvgPaint**, int>)LpVtbl[11])(@this, paintType, color, id, paint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePaint(SvgPaintType paintType, _D3DCOLORVALUE* color, char* id, ref ID2D1SvgPaint* paint)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgPaint** paintPtr = &paint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, _D3DCOLORVALUE*, char*, ID2D1SvgPaint**, int>)LpVtbl[11])(@this, paintType, color, id, paintPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePaint(SvgPaintType paintType, _D3DCOLORVALUE* color, ref char id, ID2D1SvgPaint** paint)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* idPtr = &id)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, _D3DCOLORVALUE*, char*, ID2D1SvgPaint**, int>)LpVtbl[11])(@this, paintType, color, idPtr, paint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePaint(SvgPaintType paintType, _D3DCOLORVALUE* color, ref char id, ref ID2D1SvgPaint* paint)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* idPtr = &id)
            {
                fixed (ID2D1SvgPaint** paintPtr = &paint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, _D3DCOLORVALUE*, char*, ID2D1SvgPaint**, int>)LpVtbl[11])(@this, paintType, color, idPtr, paintPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePaint(SvgPaintType paintType, _D3DCOLORVALUE* color, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ID2D1SvgPaint** paint)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, _D3DCOLORVALUE*, byte*, ID2D1SvgPaint**, int>)LpVtbl[11])(@this, paintType, color, idPtr, paint);
            SilkMarshal.Free((nint)idPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePaint(SvgPaintType paintType, _D3DCOLORVALUE* color, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ref ID2D1SvgPaint* paint)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
            fixed (ID2D1SvgPaint** paintPtr = &paint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, _D3DCOLORVALUE*, byte*, ID2D1SvgPaint**, int>)LpVtbl[11])(@this, paintType, color, idPtr, paintPtr);
            }
            SilkMarshal.Free((nint)idPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePaint(SvgPaintType paintType, ref _D3DCOLORVALUE color, char* id, ID2D1SvgPaint** paint)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_D3DCOLORVALUE* colorPtr = &color)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, _D3DCOLORVALUE*, char*, ID2D1SvgPaint**, int>)LpVtbl[11])(@this, paintType, colorPtr, id, paint);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePaint(SvgPaintType paintType, ref _D3DCOLORVALUE color, char* id, ref ID2D1SvgPaint* paint)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_D3DCOLORVALUE* colorPtr = &color)
            {
                fixed (ID2D1SvgPaint** paintPtr = &paint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, _D3DCOLORVALUE*, char*, ID2D1SvgPaint**, int>)LpVtbl[11])(@this, paintType, colorPtr, id, paintPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePaint(SvgPaintType paintType, ref _D3DCOLORVALUE color, ref char id, ID2D1SvgPaint** paint)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_D3DCOLORVALUE* colorPtr = &color)
            {
                fixed (char* idPtr = &id)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, _D3DCOLORVALUE*, char*, ID2D1SvgPaint**, int>)LpVtbl[11])(@this, paintType, colorPtr, idPtr, paint);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePaint(SvgPaintType paintType, ref _D3DCOLORVALUE color, ref char id, ref ID2D1SvgPaint* paint)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_D3DCOLORVALUE* colorPtr = &color)
            {
                fixed (char* idPtr = &id)
                {
                    fixed (ID2D1SvgPaint** paintPtr = &paint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, _D3DCOLORVALUE*, char*, ID2D1SvgPaint**, int>)LpVtbl[11])(@this, paintType, colorPtr, idPtr, paintPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePaint(SvgPaintType paintType, ref _D3DCOLORVALUE color, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ID2D1SvgPaint** paint)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_D3DCOLORVALUE* colorPtr = &color)
            {
            var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, _D3DCOLORVALUE*, byte*, ID2D1SvgPaint**, int>)LpVtbl[11])(@this, paintType, colorPtr, idPtr, paint);
            SilkMarshal.Free((nint)idPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePaint(SvgPaintType paintType, ref _D3DCOLORVALUE color, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string id, ref ID2D1SvgPaint* paint)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_D3DCOLORVALUE* colorPtr = &color)
            {
            var idPtr = (byte*) SilkMarshal.StringToPtr(id, NativeStringEncoding.UTF8);
                fixed (ID2D1SvgPaint** paintPtr = &paint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, _D3DCOLORVALUE*, byte*, ID2D1SvgPaint**, int>)LpVtbl[11])(@this, paintType, colorPtr, idPtr, paintPtr);
                }
            SilkMarshal.Free((nint)idPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeDashArray(SvgLength* dashes, uint dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgLength*, uint, ID2D1SvgStrokeDashArray**, int>)LpVtbl[12])(@this, dashes, dashesCount, strokeDashArray);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeDashArray(SvgLength* dashes, uint dashesCount, ref ID2D1SvgStrokeDashArray* strokeDashArray)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgStrokeDashArray** strokeDashArrayPtr = &strokeDashArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgLength*, uint, ID2D1SvgStrokeDashArray**, int>)LpVtbl[12])(@this, dashes, dashesCount, strokeDashArrayPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeDashArray(ref SvgLength dashes, uint dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SvgLength* dashesPtr = &dashes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgLength*, uint, ID2D1SvgStrokeDashArray**, int>)LpVtbl[12])(@this, dashesPtr, dashesCount, strokeDashArray);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeDashArray(ref SvgLength dashes, uint dashesCount, ref ID2D1SvgStrokeDashArray* strokeDashArray)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SvgLength* dashesPtr = &dashes)
            {
                fixed (ID2D1SvgStrokeDashArray** strokeDashArrayPtr = &strokeDashArray)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgLength*, uint, ID2D1SvgStrokeDashArray**, int>)LpVtbl[12])(@this, dashesPtr, dashesCount, strokeDashArrayPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePointCollection(D2D_POINT_2F* points, uint pointsCount, ID2D1SvgPointCollection** pointCollection)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, D2D_POINT_2F*, uint, ID2D1SvgPointCollection**, int>)LpVtbl[13])(@this, points, pointsCount, pointCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePointCollection(D2D_POINT_2F* points, uint pointsCount, ref ID2D1SvgPointCollection* pointCollection)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgPointCollection** pointCollectionPtr = &pointCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, D2D_POINT_2F*, uint, ID2D1SvgPointCollection**, int>)LpVtbl[13])(@this, points, pointsCount, pointCollectionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePointCollection(ref D2D_POINT_2F points, uint pointsCount, ID2D1SvgPointCollection** pointCollection)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_POINT_2F* pointsPtr = &points)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, D2D_POINT_2F*, uint, ID2D1SvgPointCollection**, int>)LpVtbl[13])(@this, pointsPtr, pointsCount, pointCollection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePointCollection(ref D2D_POINT_2F points, uint pointsCount, ref ID2D1SvgPointCollection* pointCollection)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D2D_POINT_2F* pointsPtr = &points)
            {
                fixed (ID2D1SvgPointCollection** pointCollectionPtr = &pointCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, D2D_POINT_2F*, uint, ID2D1SvgPointCollection**, int>)LpVtbl[13])(@this, pointsPtr, pointsCount, pointCollectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathData(float* segmentData, uint segmentDataCount, SvgPathCommand* commands, uint commandsCount, ID2D1SvgPathData** pathData)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)LpVtbl[14])(@this, segmentData, segmentDataCount, commands, commandsCount, pathData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathData(float* segmentData, uint segmentDataCount, SvgPathCommand* commands, uint commandsCount, ref ID2D1SvgPathData* pathData)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgPathData** pathDataPtr = &pathData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)LpVtbl[14])(@this, segmentData, segmentDataCount, commands, commandsCount, pathDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathData(float* segmentData, uint segmentDataCount, ref SvgPathCommand commands, uint commandsCount, ID2D1SvgPathData** pathData)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SvgPathCommand* commandsPtr = &commands)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)LpVtbl[14])(@this, segmentData, segmentDataCount, commandsPtr, commandsCount, pathData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathData(float* segmentData, uint segmentDataCount, ref SvgPathCommand commands, uint commandsCount, ref ID2D1SvgPathData* pathData)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SvgPathCommand* commandsPtr = &commands)
            {
                fixed (ID2D1SvgPathData** pathDataPtr = &pathData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)LpVtbl[14])(@this, segmentData, segmentDataCount, commandsPtr, commandsCount, pathDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathData(ref float segmentData, uint segmentDataCount, SvgPathCommand* commands, uint commandsCount, ID2D1SvgPathData** pathData)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* segmentDataPtr = &segmentData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)LpVtbl[14])(@this, segmentDataPtr, segmentDataCount, commands, commandsCount, pathData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathData(ref float segmentData, uint segmentDataCount, SvgPathCommand* commands, uint commandsCount, ref ID2D1SvgPathData* pathData)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* segmentDataPtr = &segmentData)
            {
                fixed (ID2D1SvgPathData** pathDataPtr = &pathData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)LpVtbl[14])(@this, segmentDataPtr, segmentDataCount, commands, commandsCount, pathDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathData(ref float segmentData, uint segmentDataCount, ref SvgPathCommand commands, uint commandsCount, ID2D1SvgPathData** pathData)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* segmentDataPtr = &segmentData)
            {
                fixed (SvgPathCommand* commandsPtr = &commands)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)LpVtbl[14])(@this, segmentDataPtr, segmentDataCount, commandsPtr, commandsCount, pathData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathData(ref float segmentData, uint segmentDataCount, ref SvgPathCommand commands, uint commandsCount, ref ID2D1SvgPathData* pathData)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* segmentDataPtr = &segmentData)
            {
                fixed (SvgPathCommand* commandsPtr = &commands)
                {
                    fixed (ID2D1SvgPathData** pathDataPtr = &pathData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)LpVtbl[14])(@this, segmentDataPtr, segmentDataCount, commandsPtr, commandsCount, pathDataPtr);
                    }
                }
            }
            return ret;
        }

    }
}
