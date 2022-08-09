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

namespace Silk.NET.DirectStorage;

public unsafe static class DStorageFactoryVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] QueueDesc* desc, Guid* riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, desc, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] QueueDesc* desc, Guid* riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, desc, riid, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] QueueDesc* desc, ref Guid riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, desc, riidPtr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] QueueDesc* desc, ref Guid riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, desc, riidPtr, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in QueueDesc desc, Guid* riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (QueueDesc* descPtr = &desc)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, descPtr, riid, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in QueueDesc desc, Guid* riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (QueueDesc* descPtr = &desc)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, descPtr, riid, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in QueueDesc desc, ref Guid riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (QueueDesc* descPtr = &desc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, descPtr, riidPtr, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in QueueDesc desc, ref Guid riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (QueueDesc* descPtr = &desc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, descPtr, riidPtr, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, char* path, Guid* riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, path, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, char* path, Guid* riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, path, riid, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, char* path, ref Guid riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, path, riidPtr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, char* path, ref Guid riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, path, riidPtr, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, ref char path, Guid* riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pathPtr = &path)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riid, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, ref char path, Guid* riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pathPtr = &path)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riid, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, ref char path, ref Guid riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pathPtr = &path)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riidPtr, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, ref char path, ref Guid riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* pathPtr = &path)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riidPtr, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Guid* riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riid, ppv);
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Guid* riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riid, ppvPtr);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref Guid riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riidPtr, ppv);
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref Guid riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riidPtr, ppvPtr);
            }
        }
        SilkMarshal.Free((nint)pathPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, byte* name, Guid* riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, name, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, byte* name, Guid* riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, name, riid, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, byte* name, ref Guid riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, name, riidPtr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, byte* name, ref Guid riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, name, riidPtr, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, ref byte name, Guid* riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riid, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, ref byte name, Guid* riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riid, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, ref byte name, ref Guid riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, ref byte name, ref Guid riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* namePtr = &name)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Guid* riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riid, ppv);
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Guid* riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riid, ppvPtr);
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, ref Guid riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppv);
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, ref Guid riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppvPtr);
            }
        }
        SilkMarshal.Free((nint)namePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetDebugFlags<TThis>(this TThis thisVtbl, uint flags) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, void>)@this->LpVtbl[6])(@this, flags);
    }

    /// <summary>To be documented.</summary>
    public static int SetStagingBufferSize<TThis>(this TThis thisVtbl, uint size) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, int>)@this->LpVtbl[7])(@this, size);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TI0, TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] QueueDesc* desc, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppv = default;
        return @this->CreateQueue(desc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] QueueDesc* desc, Span<Guid> riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateQueue(desc, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] QueueDesc* desc, Span<Guid> riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateQueue(desc, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<QueueDesc> desc, Guid* riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateQueue(in desc.GetPinnableReference(), riid, ppv);
    }

    /// <summary>To be documented.</summary>
    public static int CreateQueue<TI0, TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in QueueDesc desc, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppv = default;
        return @this->CreateQueue(in desc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<QueueDesc> desc, Guid* riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateQueue(in desc.GetPinnableReference(), riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<QueueDesc> desc, Span<Guid> riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateQueue(in desc.GetPinnableReference(), ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateQueue<TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] ReadOnlySpan<QueueDesc> desc, Span<Guid> riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateQueue(in desc.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TI0, TThis>(this TThis thisVtbl, char* path, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppv = default;
        return @this->OpenFile(path, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, char* path, Span<Guid> riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->OpenFile(path, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, char* path, Span<Guid> riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->OpenFile(path, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, Span<char> path, Guid* riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->OpenFile(ref path.GetPinnableReference(), riid, ppv);
    }

    /// <summary>To be documented.</summary>
    public static int OpenFile<TI0, TThis>(this TThis thisVtbl, ref char path, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppv = default;
        return @this->OpenFile(ref path, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, Span<char> path, Guid* riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->OpenFile(ref path.GetPinnableReference(), riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, Span<char> path, Span<Guid> riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->OpenFile(ref path.GetPinnableReference(), ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, Span<char> path, Span<Guid> riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->OpenFile(ref path.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static int OpenFile<TI0, TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppv = default;
        return @this->OpenFile(path, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<Guid> riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->OpenFile(path, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int OpenFile<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<Guid> riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->OpenFile(path, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TI0, TThis>(this TThis thisVtbl, uint capacity, byte* name, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppv = default;
        return @this->CreateStatusArray(capacity, name, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, byte* name, Span<Guid> riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateStatusArray(capacity, name, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, byte* name, Span<Guid> riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateStatusArray(capacity, name, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, Span<byte> name, Guid* riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateStatusArray(capacity, ref name.GetPinnableReference(), riid, ppv);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStatusArray<TI0, TThis>(this TThis thisVtbl, uint capacity, ref byte name, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppv = default;
        return @this->CreateStatusArray(capacity, ref name, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, Span<byte> name, Guid* riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateStatusArray(capacity, ref name.GetPinnableReference(), riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, Span<byte> name, Span<Guid> riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateStatusArray(capacity, ref name.GetPinnableReference(), ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, Span<byte> name, Span<Guid> riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateStatusArray(capacity, ref name.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStatusArray<TI0, TThis>(this TThis thisVtbl, uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppv = default;
        return @this->CreateStatusArray(capacity, name, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Span<Guid> riid, void** ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateStatusArray(capacity, name, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStatusArray<TThis>(this TThis thisVtbl, uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Span<Guid> riid, ref void* ppv) where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CreateStatusArray(capacity, name, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0, TThis>(this TThis thisVtbl) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateQueue<TI0, TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] QueueDesc* desc) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateQueue(desc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateQueue<TI0, TThis>(this TThis thisVtbl, [Flow(FlowDirection.In)] in QueueDesc desc) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateQueue(in desc, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> OpenFile<TI0, TThis>(this TThis thisVtbl, char* path) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenFile(path, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> OpenFile<TI0, TThis>(this TThis thisVtbl, ref char path) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenFile(ref path, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> OpenFile<TI0, TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->OpenFile(path, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateStatusArray<TI0, TThis>(this TThis thisVtbl, uint capacity, byte* name) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateStatusArray(capacity, name, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateStatusArray<TI0, TThis>(this TThis thisVtbl, uint capacity, ref byte name) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateStatusArray(capacity, ref name, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateStatusArray<TI0, TThis>(this TThis thisVtbl, uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDStorageFactory>
    {
        var @this = (IDStorageFactory*) thisVtbl.AsVtblPtr();
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateStatusArray(capacity, name, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
