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

namespace Silk.NET.Direct3D.Compilers;

public unsafe static class DxcExtraOutputsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetOutputCount<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Guid* iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObject, ppOutputType, ppOutputName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Guid* iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObject, ppOutputType, ppOutputNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Guid* iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputType, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObject, ppOutputTypePtr, ppOutputName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Guid* iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
        {
            fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObject, ppOutputTypePtr, ppOutputNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Guid* iid, ref void* ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObjectPtr, ppOutputType, ppOutputName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Guid* iid, ref void* ppvObject, IDxcBlobUtf16** ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObjectPtr, ppOutputType, ppOutputNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Guid* iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputType, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObjectPtr, ppOutputTypePtr, ppOutputName);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Guid* iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
            {
                fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObjectPtr, ppOutputTypePtr, ppOutputNamePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObject, ppOutputType, ppOutputName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObject, ppOutputType, ppOutputNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputType, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObject, ppOutputTypePtr, ppOutputName);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
            {
                fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObject, ppOutputTypePtr, ppOutputNamePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, ref void* ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObjectPtr, ppOutputType, ppOutputName);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, ref void* ppvObject, IDxcBlobUtf16** ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObjectPtr, ppOutputType, ppOutputNamePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputType, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObjectPtr, ppOutputTypePtr, ppOutputName);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
                {
                    fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObjectPtr, ppOutputTypePtr, ppOutputNamePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetOutput<TI0, TI1, TI2, TThis>(this TThis thisVtbl, uint uIndex, ref ComPtr<TI0> ppvObject, ref ComPtr<TI1> ppOutputType, ref ComPtr<TI2> ppOutputName) where TI0 : unmanaged, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI2> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(uIndex, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf(), (IDxcBlobUtf16**) ppOutputType.GetAddressOf(), (IDxcBlobUtf16**) ppOutputName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TI1, TThis>(this TThis thisVtbl, uint uIndex, ref ComPtr<TI0> ppvObject, ref ComPtr<TI1> ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TI0 : unmanaged, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI1> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(uIndex, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf(), (IDxcBlobUtf16**) ppOutputType.GetAddressOf(), ref ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TI1, TThis>(this TThis thisVtbl, uint uIndex, ref ComPtr<TI0> ppvObject, ref IDxcBlobUtf16* ppOutputType, ref ComPtr<TI1> ppOutputName) where TI0 : unmanaged, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI1> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(uIndex, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf(), ref ppOutputType, (IDxcBlobUtf16**) ppOutputName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TThis>(this TThis thisVtbl, uint uIndex, ref ComPtr<TI0> ppvObject, ref IDxcBlobUtf16* ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(uIndex, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf(), ref ppOutputType, ref ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TI1, TThis>(this TThis thisVtbl, uint uIndex, Guid* iid, ref void* ppvObject, ref ComPtr<TI0> ppOutputType, ref ComPtr<TI1> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI1> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(uIndex, iid, ref ppvObject, (IDxcBlobUtf16**) ppOutputType.GetAddressOf(), (IDxcBlobUtf16**) ppOutputName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TThis>(this TThis thisVtbl, uint uIndex, Guid* iid, ref void* ppvObject, ref ComPtr<TI0> ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI0> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(uIndex, iid, ref ppvObject, (IDxcBlobUtf16**) ppOutputType.GetAddressOf(), ref ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TThis>(this TThis thisVtbl, uint uIndex, Guid* iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputType, ref ComPtr<TI0> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI0> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(uIndex, iid, ref ppvObject, ref ppOutputType, (IDxcBlobUtf16**) ppOutputName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Span<Guid> iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetOutput(uIndex, ref iid.GetPinnableReference(), ppvObject, ppOutputType, ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TI1, TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, void** ppvObject, ref ComPtr<TI0> ppOutputType, ref ComPtr<TI1> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI1> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(uIndex, ref iid, ppvObject, (IDxcBlobUtf16**) ppOutputType.GetAddressOf(), (IDxcBlobUtf16**) ppOutputName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Span<Guid> iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetOutput(uIndex, ref iid.GetPinnableReference(), ppvObject, ppOutputType, ref ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, void** ppvObject, ref ComPtr<TI0> ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI0> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(uIndex, ref iid, ppvObject, (IDxcBlobUtf16**) ppOutputType.GetAddressOf(), ref ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Span<Guid> iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputType, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetOutput(uIndex, ref iid.GetPinnableReference(), ppvObject, ref ppOutputType, ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputType, ref ComPtr<TI0> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI0> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(uIndex, ref iid, ppvObject, ref ppOutputType, (IDxcBlobUtf16**) ppOutputName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Span<Guid> iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetOutput(uIndex, ref iid.GetPinnableReference(), ppvObject, ref ppOutputType, ref ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Span<Guid> iid, ref void* ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetOutput(uIndex, ref iid.GetPinnableReference(), ref ppvObject, ppOutputType, ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TI1, TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, ref void* ppvObject, ref ComPtr<TI0> ppOutputType, ref ComPtr<TI1> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI1> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(uIndex, ref iid, ref ppvObject, (IDxcBlobUtf16**) ppOutputType.GetAddressOf(), (IDxcBlobUtf16**) ppOutputName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Span<Guid> iid, ref void* ppvObject, IDxcBlobUtf16** ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetOutput(uIndex, ref iid.GetPinnableReference(), ref ppvObject, ppOutputType, ref ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, ref void* ppvObject, ref ComPtr<TI0> ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI0> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(uIndex, ref iid, ref ppvObject, (IDxcBlobUtf16**) ppOutputType.GetAddressOf(), ref ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Span<Guid> iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputType, IDxcBlobUtf16** ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetOutput(uIndex, ref iid.GetPinnableReference(), ref ppvObject, ref ppOutputType, ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TI0, TThis>(this TThis thisVtbl, uint uIndex, ref Guid iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputType, ref ComPtr<TI0> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobUtf16>, IComVtbl<TI0> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetOutput(uIndex, ref iid, ref ppvObject, ref ppOutputType, (IDxcBlobUtf16**) ppOutputName.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOutput<TThis>(this TThis thisVtbl, uint uIndex, Span<Guid> iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputType, ref IDxcBlobUtf16* ppOutputName) where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetOutput(uIndex, ref iid.GetPinnableReference(), ref ppvObject, ref ppOutputType, ref ppOutputName);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDxcExtraOutputs>
    {
        var @this = (IDxcExtraOutputs*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
