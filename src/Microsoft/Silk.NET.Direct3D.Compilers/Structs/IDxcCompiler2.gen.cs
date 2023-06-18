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
    [Guid("a005a9d9-b8bb-4594-b5c9-0e633bec4d37")]
    [NativeName("Name", "IDxcCompiler2")]
    public unsafe partial struct IDxcCompiler2 : IComVtbl<IDxcCompiler2>, IComVtbl<IDxcCompiler>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a005a9d9-b8bb-4594-b5c9-0e633bec4d37");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDxcCompiler(IDxcCompiler2 val)
            => Unsafe.As<IDxcCompiler2, IDxcCompiler>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcCompiler2 val)
            => Unsafe.As<IDxcCompiler2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcCompiler2
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
            var @this = (IDxcCompiler2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcCompiler2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcCompiler2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Compile(IDxcBlob* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, IDxcBlob*, char*, char*, char*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Preprocess(IDxcBlob* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcCompiler2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, IDxcBlob*, char*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Disassemble(IDxcBlob* pSource, IDxcBlobEncoding** ppDisassembly)
        {
            var @this = (IDxcCompiler2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, IDxcBlob*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pSource, ppDisassembly);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileWithDebug(IDxcBlob* pSource, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult, char** ppDebugBlobName, IDxcBlob** ppDebugBlob)
        {
            var @this = (IDxcCompiler2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcCompiler2*, IDxcBlob*, char*, char*, char*, char**, uint, Define*, uint, IDxcIncludeHandler*, IDxcOperationResult**, char**, IDxcBlob**, int>)@this->LpVtbl[6])(@this, pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult, ppDebugBlobName, ppDebugBlob);
            return ret;
        }

    }
}
