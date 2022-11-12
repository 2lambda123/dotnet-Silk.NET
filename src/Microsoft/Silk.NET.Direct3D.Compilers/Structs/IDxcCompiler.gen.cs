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

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("8c210bf3-011f-4422-8d70-6f9acb8db617")]
    [NativeName("Name", "IDxcCompiler")]
    public unsafe partial struct IDxcCompiler : IComVtbl<IDxcCompiler>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("8c210bf3-011f-4422-8d70-6f9acb8db617");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcCompiler val)
            => Unsafe.As<IDxcCompiler, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcCompiler
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
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pEntryPointPtr = &pEntryPoint)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                {
                                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                    {
                                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                {
                                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                    {
                                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                {
                                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                    {
                                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                {
                                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                    {
                                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                {
                                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                    {
                                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (char** pArgumentsPtr = &pArguments)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (char** pArgumentsPtr = &pArguments)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (char** pArgumentsPtr = &pArguments)
                            {
                                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (char** pArgumentsPtr = &pArguments)
                            {
                                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                {
                                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                    {
                                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (char** pArgumentsPtr = &pArguments)
                            {
                                fixed (Define* pDefinesPtr = &pDefines)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (char** pArgumentsPtr = &pArguments)
                            {
                                fixed (Define* pDefinesPtr = &pDefines)
                                {
                                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                    {
                                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (char** pArgumentsPtr = &pArguments)
                            {
                                fixed (Define* pDefinesPtr = &pDefines)
                                {
                                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                    {
                                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (nint* pEntryPointPtr = &pEntryPoint)
                    {
                        fixed (nint* pTargetProfilePtr = &pTargetProfile)
                        {
                            fixed (char** pArgumentsPtr = &pArguments)
                            {
                                fixed (Define* pDefinesPtr = &pDefines)
                                {
                                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                                    {
                                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                        {
                                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, nint*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSourcePtr, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceNamePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceName, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArguments, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArguments, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandler, ppResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArgumentsPtr, argCount, pDefines, defineCount, pIncludeHandlerPtr, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResult);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandler, ppResultPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResult);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (nint* pSourceNamePtr = &pSourceName)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcIncludeHandler* pIncludeHandlerPtr = &pIncludeHandler)
                            {
                                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, nint*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSourcePtr, pSourceNamePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, pIncludeHandlerPtr, ppResultPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble(IDxcBlob* pSource, IDxcBlobEncoding** ppDisassembly)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pSource, ppDisassembly);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble(IDxcBlob* pSource, ref IDxcBlobEncoding* ppDisassembly)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** ppDisassemblyPtr = &ppDisassembly)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pSource, ppDisassemblyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble(ref IDxcBlob pSource, IDxcBlobEncoding** ppDisassembly)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pSourcePtr, ppDisassembly);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble(ref IDxcBlob pSource, ref IDxcBlobEncoding* ppDisassembly)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
                fixed (IDxcBlobEncoding** ppDisassemblyPtr = &ppDisassembly)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pSourcePtr, ppDisassemblyPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile((IDxcBlob*) pSource.Handle, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] nint* pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] nint* pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in nint pEntryPoint, [Flow(FlowDirection.In)] in nint pTargetProfile, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Compile(ref pSource, in pSourceName, in pEntryPoint, in pTargetProfile, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, pSourceName, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, pSourceName, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, pSourceName, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, in pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, in pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, in pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, in pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, in pSourceName, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, in pSourceName, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, in pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(pSource, in pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1, TI2>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref ComPtr<TI2> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI2>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI1> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ComPtr<TI0> pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess((IDxcBlob*) pSource.Handle, in pSourceName, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, pSourceName, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, pSourceName, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, pSourceName, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, pSourceName, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, pSourceName, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] nint* pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, pSourceName, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, in pDefines, defineCount, pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] string[] pArgumentsSa, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pArguments = (char**) SilkMarshal.StringArrayToPtr(pArgumentsSa);
            var ret = @this->Preprocess(ref pSource, in pSourceName, pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, ref ppResult);
            SilkMarshal.CopyPtrToStringArray((nint) pArguments, pArgumentsSa);
            SilkMarshal.Free((nint) pArguments);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, in pSourceName, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, in pSourceName, in pArguments, argCount, pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, in pSourceName, in pArguments, argCount, pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0, TI1>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, in pSourceName, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ComPtr<TI0> pIncludeHandler, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcIncludeHandler>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, in pSourceName, in pArguments, argCount, in pDefines, defineCount, (IDxcIncludeHandler*) pIncludeHandler.Handle, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess<TI0>(ref IDxcBlob pSource, [Flow(FlowDirection.In)] in nint pSourceName, [Flow(FlowDirection.In)] in char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcIncludeHandler pIncludeHandler, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Preprocess(ref pSource, in pSourceName, in pArguments, argCount, in pDefines, defineCount, ref pIncludeHandler, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Disassemble<TI0, TI1>(ComPtr<TI0> pSource, ref ComPtr<TI1> ppDisassembly) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI1>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Disassemble((IDxcBlob*) pSource.Handle, (IDxcBlobEncoding**) ppDisassembly.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble<TI0>(ComPtr<TI0> pSource, ref IDxcBlobEncoding* ppDisassembly) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Disassemble((IDxcBlob*) pSource.Handle, ref ppDisassembly);
        }

        /// <summary>To be documented.</summary>
        public readonly int Disassemble<TI0>(ref IDxcBlob pSource, ref ComPtr<TI0> ppDisassembly) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Disassemble(ref pSource, (IDxcBlobEncoding**) ppDisassembly.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcCompiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
