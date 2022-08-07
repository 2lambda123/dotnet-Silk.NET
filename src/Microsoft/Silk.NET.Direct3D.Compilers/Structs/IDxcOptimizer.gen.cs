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
    [Guid("25740e2e-9cba-401b-9119-4fb42f39f270")]
    [NativeName("Name", "IDxcOptimizer")]
    public unsafe partial struct IDxcOptimizer : IComVtbl<IDxcOptimizer>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("25740e2e-9cba-401b-9119-4fb42f39f270");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcOptimizer val)
            => Unsafe.As<IDxcOptimizer, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcOptimizer
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
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailablePassCount(uint* pCount)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint*, int>)@this->LpVtbl[3])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAvailablePassCount(ref uint pCount)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint*, int>)@this->LpVtbl[3])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailablePass(uint index, IDxcOptimizerPass** ppResult)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)@this->LpVtbl[4])(@this, index, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailablePass(uint index, ref IDxcOptimizerPass* ppResult)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcOptimizerPass** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, uint, IDxcOptimizerPass**, int>)@this->LpVtbl[4])(@this, index, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputText);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModule, ppOutputTextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModulePtr, ppOutputText);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
            {
                fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptions, optionCount, pOutputModulePtr, ppOutputTextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppOptionsPtr = &ppOptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModule, ppOutputText);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppOptionsPtr = &ppOptions)
            {
                fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModule, ppOutputTextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppOptionsPtr = &ppOptions)
            {
                fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputText);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(IDxcBlob* pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppOptionsPtr = &ppOptions)
            {
                fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                {
                    fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlob, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputTextPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModule, ppOutputText);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModule, ppOutputTextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModulePtr, ppOutputText);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, char** ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                {
                    fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptions, optionCount, pOutputModulePtr, ppOutputTextPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (char** ppOptionsPtr = &ppOptions)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModule, ppOutputText);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, IDxcBlob** pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (char** ppOptionsPtr = &ppOptions)
                {
                    fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModule, ppOutputTextPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, IDxcBlobEncoding** ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (char** ppOptionsPtr = &ppOptions)
                {
                    fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputText);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RunOptimizer(ref IDxcBlob pBlob, ref char* ppOptions, uint optionCount, ref IDxcBlob* pOutputModule, ref IDxcBlobEncoding* ppOutputText)
        {
            var @this = (IDxcOptimizer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (char** ppOptionsPtr = &ppOptions)
                {
                    fixed (IDxcBlob** pOutputModulePtr = &pOutputModule)
                    {
                        fixed (IDxcBlobEncoding** ppOutputTextPtr = &ppOutputText)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizer*, IDxcBlob*, char**, uint, IDxcBlob**, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pBlobPtr, ppOptionsPtr, optionCount, pOutputModulePtr, ppOutputTextPtr);
                        }
                    }
                }
            }
            return ret;
        }

    }
}
