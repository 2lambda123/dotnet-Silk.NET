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
    [Guid("689f1f85-c72e-4e33-8f19-85754efd5ace")]
    [NativeName("Name", "ID2D1DrawingStateBlock1")]
    public unsafe partial struct ID2D1DrawingStateBlock1
    {
        public static readonly Guid Guid = new("689f1f85-c72e-4e33-8f19-85754efd5ace");

        public static implicit operator ID2D1DrawingStateBlock(ID2D1DrawingStateBlock1 val)
            => Unsafe.As<ID2D1DrawingStateBlock1, ID2D1DrawingStateBlock>(ref val);

        public static implicit operator ID2D1Resource(ID2D1DrawingStateBlock1 val)
            => Unsafe.As<ID2D1DrawingStateBlock1, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1DrawingStateBlock1 val)
            => Unsafe.As<ID2D1DrawingStateBlock1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1DrawingStateBlock1
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
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, ID2D1Factory**, void>)LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, ID2D1Factory**, void>)LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDescription(DrawingStateDescription* stateDescription)
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, DrawingStateDescription*, void>)LpVtbl[4])(@this, stateDescription);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDescription(ref DrawingStateDescription stateDescription)
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DrawingStateDescription* stateDescriptionPtr = &stateDescription)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, DrawingStateDescription*, void>)LpVtbl[4])(@this, stateDescriptionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDescription(DrawingStateDescription* stateDescription)
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, DrawingStateDescription*, void>)LpVtbl[5])(@this, stateDescription);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDescription(ref DrawingStateDescription stateDescription)
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DrawingStateDescription* stateDescriptionPtr = &stateDescription)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, DrawingStateDescription*, void>)LpVtbl[5])(@this, stateDescriptionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams)
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, IDWriteRenderingParams*, void>)LpVtbl[6])(@this, textRenderingParams);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTextRenderingParams(ref IDWriteRenderingParams textRenderingParams)
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteRenderingParams* textRenderingParamsPtr = &textRenderingParams)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, IDWriteRenderingParams*, void>)LpVtbl[6])(@this, textRenderingParamsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams)
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, IDWriteRenderingParams**, void>)LpVtbl[7])(@this, textRenderingParams);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTextRenderingParams(ref IDWriteRenderingParams* textRenderingParams)
        {
            var @this = (ID2D1DrawingStateBlock1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteRenderingParams** textRenderingParamsPtr = &textRenderingParams)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock1*, IDWriteRenderingParams**, void>)LpVtbl[7])(@this, textRenderingParamsPtr);
            }
        }

    }
}
