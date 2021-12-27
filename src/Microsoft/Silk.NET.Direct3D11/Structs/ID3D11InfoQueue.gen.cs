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

namespace Silk.NET.Direct3D11
{
    [Guid("6543dbb6-1b48-42f5-ab82-e97ec74326f6")]
    [NativeName("Name", "ID3D11InfoQueue")]
    public unsafe partial struct ID3D11InfoQueue
    {
        public static readonly Guid Guid = new("6543dbb6-1b48-42f5-ab82-e97ec74326f6");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11InfoQueue val)
            => Unsafe.As<ID3D11InfoQueue, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11InfoQueue
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
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMessageCountLimit(ulong MessageCountLimit)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, ulong, int>)LpVtbl[3])(@this, MessageCountLimit);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong, int>)LpVtbl[3])(@this, MessageCountLimit);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong, int>)LpVtbl[3])(@this, MessageCountLimit);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearStoredMessages()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, void>)LpVtbl[4])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMessageA(ulong MessageIndex, Message* pMessage, nuint* pMessageByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, ulong, Message*, nuint*, int>)LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLength);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong, Message*, nuint*, int>)LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLength);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong, Message*, nuint*, int>)LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLength);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMessageA(ulong MessageIndex, Message* pMessage, ref nuint pMessageByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pMessageByteLengthPtr = &pMessageByteLength)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, ulong, Message*, nuint*, int>)LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLengthPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong, Message*, nuint*, int>)LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLengthPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong, Message*, nuint*, int>)LpVtbl[5])(@this, MessageIndex, pMessage, pMessageByteLengthPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMessageA(ulong MessageIndex, ref Message pMessage, nuint* pMessageByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Message* pMessagePtr = &pMessage)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, ulong, Message*, nuint*, int>)LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLength);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong, Message*, nuint*, int>)LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLength);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong, Message*, nuint*, int>)LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLength);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMessageA(ulong MessageIndex, ref Message pMessage, ref nuint pMessageByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Message* pMessagePtr = &pMessage)
            {
                fixed (nuint* pMessageByteLengthPtr = &pMessageByteLength)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11InfoQueue*, ulong, Message*, nuint*, int>)LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLengthPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong, Message*, nuint*, int>)LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLengthPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, ulong, Message*, nuint*, int>)LpVtbl[5])(@this, MessageIndex, pMessagePtr, pMessageByteLengthPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumMessagesAllowedByStorageFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong>)LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumMessagesDeniedByStorageFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong>)LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumStoredMessages()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong>)LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumStoredMessagesAllowedByRetrievalFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong>)LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetNumMessagesDiscardedByMessageCountLimit()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong>)LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetMessageCountLimit()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, ulong>)LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddStorageFilterEntries(InfoQueueFilter* pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[12])(@this, pFilter);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[12])(@this, pFilter);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[12])(@this, pFilter);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddStorageFilterEntries(ref InfoQueueFilter pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[12])(@this, pFilterPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[12])(@this, pFilterPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[12])(@this, pFilterPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStorageFilter(InfoQueueFilter* pFilter, nuint* pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, pFilter, pFilterByteLength);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, pFilter, pFilterByteLength);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, pFilter, pFilterByteLength);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStorageFilter(InfoQueueFilter* pFilter, ref nuint pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, pFilter, pFilterByteLengthPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, pFilter, pFilterByteLengthPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, pFilter, pFilterByteLengthPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStorageFilter(ref InfoQueueFilter pFilter, nuint* pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, pFilterPtr, pFilterByteLength);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, pFilterPtr, pFilterByteLength);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, pFilterPtr, pFilterByteLength);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStorageFilter(ref InfoQueueFilter pFilter, ref nuint pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, pFilterPtr, pFilterByteLengthPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, pFilterPtr, pFilterByteLengthPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[13])(@this, pFilterPtr, pFilterByteLengthPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearStorageFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, void>)LpVtbl[14])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int PushEmptyStorageFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, int>)LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushCopyOfStorageFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, int>)LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushStorageFilter(InfoQueueFilter* pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[17])(@this, pFilter);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[17])(@this, pFilter);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[17])(@this, pFilter);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushStorageFilter(ref InfoQueueFilter pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[17])(@this, pFilterPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[17])(@this, pFilterPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[17])(@this, pFilterPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PopStorageFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, void>)LpVtbl[18])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetStorageFilterStackSize()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, uint>)LpVtbl[19])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddRetrievalFilterEntries(InfoQueueFilter* pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[20])(@this, pFilter);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[20])(@this, pFilter);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[20])(@this, pFilter);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddRetrievalFilterEntries(ref InfoQueueFilter pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[20])(@this, pFilterPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[20])(@this, pFilterPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[20])(@this, pFilterPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRetrievalFilter(InfoQueueFilter* pFilter, nuint* pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[21])(@this, pFilter, pFilterByteLength);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[21])(@this, pFilter, pFilterByteLength);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[21])(@this, pFilter, pFilterByteLength);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRetrievalFilter(InfoQueueFilter* pFilter, ref nuint pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[21])(@this, pFilter, pFilterByteLengthPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[21])(@this, pFilter, pFilterByteLengthPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[21])(@this, pFilter, pFilterByteLengthPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRetrievalFilter(ref InfoQueueFilter pFilter, nuint* pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[21])(@this, pFilterPtr, pFilterByteLength);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[21])(@this, pFilterPtr, pFilterByteLength);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[21])(@this, pFilterPtr, pFilterByteLength);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRetrievalFilter(ref InfoQueueFilter pFilter, ref nuint pFilterByteLength)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
                fixed (nuint* pFilterByteLengthPtr = &pFilterByteLength)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[21])(@this, pFilterPtr, pFilterByteLengthPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[21])(@this, pFilterPtr, pFilterByteLengthPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, nuint*, int>)LpVtbl[21])(@this, pFilterPtr, pFilterByteLengthPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearRetrievalFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, void>)LpVtbl[22])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int PushEmptyRetrievalFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, int>)LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushCopyOfRetrievalFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, int>)LpVtbl[24])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PushRetrievalFilter(InfoQueueFilter* pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[25])(@this, pFilter);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[25])(@this, pFilter);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[25])(@this, pFilter);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PushRetrievalFilter(ref InfoQueueFilter pFilter)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InfoQueueFilter* pFilterPtr = &pFilter)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[25])(@this, pFilterPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[25])(@this, pFilterPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, InfoQueueFilter*, int>)LpVtbl[25])(@this, pFilterPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void PopRetrievalFilter()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, void>)LpVtbl[26])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetRetrievalFilterStackSize()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, uint>)LpVtbl[27])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMessage(MessageCategory Category, MessageSeverity Severity, MessageID ID, byte* pDescription)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescription);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescription);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescription);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMessage(MessageCategory Category, MessageSeverity Severity, MessageID ID, ref byte pDescription)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pDescriptionPtr = &pDescription)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMessage(MessageCategory Category, MessageSeverity Severity, MessageID ID, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageCategory, MessageSeverity, MessageID, byte*, int>)LpVtbl[28])(@this, Category, Severity, ID, pDescriptionPtr);
            }
            #endif
            SilkMarshal.Free((nint)pDescriptionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddApplicationMessage(MessageSeverity Severity, byte* pDescription)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescription);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescription);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescription);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddApplicationMessage(MessageSeverity Severity, ref byte pDescription)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pDescriptionPtr = &pDescription)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescriptionPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescriptionPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescriptionPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddApplicationMessage(MessageSeverity Severity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDescription)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDescriptionPtr = (byte*) SilkMarshal.StringToPtr(pDescription, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescriptionPtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescriptionPtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageSeverity, byte*, int>)LpVtbl[29])(@this, Severity, pDescriptionPtr);
            }
            #endif
            SilkMarshal.Free((nint)pDescriptionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBreakOnCategory(MessageCategory Category, int bEnable)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, MessageCategory, int, int>)LpVtbl[30])(@this, Category, bEnable);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, MessageCategory, int, int>)LpVtbl[30])(@this, Category, bEnable);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageCategory, int, int>)LpVtbl[30])(@this, Category, bEnable);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBreakOnSeverity(MessageSeverity Severity, int bEnable)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, MessageSeverity, int, int>)LpVtbl[31])(@this, Severity, bEnable);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, MessageSeverity, int, int>)LpVtbl[31])(@this, Severity, bEnable);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageSeverity, int, int>)LpVtbl[31])(@this, Severity, bEnable);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBreakOnID(MessageID ID, int bEnable)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, MessageID, int, int>)LpVtbl[32])(@this, ID, bEnable);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, MessageID, int, int>)LpVtbl[32])(@this, ID, bEnable);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageID, int, int>)LpVtbl[32])(@this, ID, bEnable);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBreakOnCategory(MessageCategory Category)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, MessageCategory, int>)LpVtbl[33])(@this, Category);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, MessageCategory, int>)LpVtbl[33])(@this, Category);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageCategory, int>)LpVtbl[33])(@this, Category);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBreakOnSeverity(MessageSeverity Severity)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, MessageSeverity, int>)LpVtbl[34])(@this, Severity);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, MessageSeverity, int>)LpVtbl[34])(@this, Severity);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageSeverity, int>)LpVtbl[34])(@this, Severity);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBreakOnID(MessageID ID)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11InfoQueue*, MessageID, int>)LpVtbl[35])(@this, ID);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, MessageID, int>)LpVtbl[35])(@this, ID);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, MessageID, int>)LpVtbl[35])(@this, ID);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMuteDebugOutput(int bMute)
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11InfoQueue*, int, void>)LpVtbl[36])(@this, bMute);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, int, void>)LpVtbl[36])(@this, bMute);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11InfoQueue*, int, void>)LpVtbl[36])(@this, bMute);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMuteDebugOutput()
        {
            var @this = (ID3D11InfoQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11InfoQueue*, int>)LpVtbl[37])(@this);
            return ret;
        }

    }
}
