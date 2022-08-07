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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12SwapChainAssistantVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Luid GetLUID<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        Luid ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Luid>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject<TThis>(this TThis thisVtbl, Guid* riid, void** ppv) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppv) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject<TThis>(this TThis thisVtbl, ref Guid riid, void** ppv) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppv) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, void** ppvResource, Guid* riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvQueuePtr = &ppvQueue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, void** ppvResource, ref Guid riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidQueuePtr = &riidQueue)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, void** ppvResource, ref Guid riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidQueuePtr = &riidQueue)
        {
            fixed (void** ppvQueuePtr = &ppvQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResource, riidQueuePtr, ppvQueuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, ref void* ppvResource, Guid* riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, ref void* ppvResource, Guid* riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            fixed (void** ppvQueuePtr = &ppvQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueue, ppvQueuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, ref void* ppvResource, ref Guid riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            fixed (Guid* riidQueuePtr = &riidQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, Guid* riidResource, ref void* ppvResource, ref Guid riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvResourcePtr = &ppvResource)
        {
            fixed (Guid* riidQueuePtr = &riidQueue)
            {
                fixed (void** ppvQueuePtr = &ppvQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, void** ppvResource, Guid* riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvQueuePtr = &ppvQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueue, ppvQueuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, void** ppvResource, ref Guid riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (Guid* riidQueuePtr = &riidQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, void** ppvResource, ref Guid riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (Guid* riidQueuePtr = &riidQueue)
            {
                fixed (void** ppvQueuePtr = &ppvQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResource, riidQueuePtr, ppvQueuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, ref void* ppvResource, Guid* riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, ref void* ppvResource, Guid* riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                fixed (void** ppvQueuePtr = &ppvQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueue, ppvQueuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, ref void* ppvResource, ref Guid riidQueue, void** ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                fixed (Guid* riidQueuePtr = &riidQueue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueue);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue<TThis>(this TThis thisVtbl, ref Guid riidResource, ref void* ppvResource, ref Guid riidQueue, ref void* ppvQueue) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidResourcePtr = &riidResource)
        {
            fixed (void** ppvResourcePtr = &ppvResource)
            {
                fixed (Guid* riidQueuePtr = &riidQueue)
                {
                    fixed (void** ppvQueuePtr = &ppvQueue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResourcePtr, ppvResourcePtr, riidQueuePtr, ppvQueuePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InsertImplicitSync<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12SwapChainAssistant>
    {
        var @this = (ID3D12SwapChainAssistant*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, int>)@this->LpVtbl[6])(@this);
        return ret;
    }

}
