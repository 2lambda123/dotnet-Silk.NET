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

namespace Silk.NET.WindowsCodecs
{
    [Guid("ec5ec8a9-c395-4314-9c77-54d7a935ff70")]
    [NativeName("Name", "IWICImagingFactory")]
    public unsafe partial struct IWICImagingFactory : IComVtbl<IWICImagingFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("ec5ec8a9-c395-4314-9c77-54d7a935ff70");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICImagingFactory val)
            => Unsafe.As<IWICImagingFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICImagingFactory
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
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilename, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilename, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFilenamePtr = &wzFilename)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFilenamePtr = &wzFilename)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFilenamePtr = &wzFilename)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoder);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFilenamePtr = &wzFilename)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, byte*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
            SilkMarshal.Free((nint)wzFilenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, byte*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
            }
            SilkMarshal.Free((nint)wzFilenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, byte*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoder);
            }
            SilkMarshal.Free((nint)wzFilenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, byte*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
                }
            }
            SilkMarshal.Free((nint)wzFilenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStream, pguidVendor, metadataOptions, ppIDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStream, pguidVendor, metadataOptions, ppIDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStream, pguidVendorPtr, metadataOptions, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStream, pguidVendorPtr, metadataOptions, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStreamPtr, pguidVendor, metadataOptions, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStreamPtr, pguidVendor, metadataOptions, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStreamPtr, pguidVendorPtr, metadataOptions, ppIDecoder);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStreamPtr, pguidVendorPtr, metadataOptions, ppIDecoderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFileHandle(nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, nuint, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[5])(@this, hFile, pguidVendor, metadataOptions, ppIDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFileHandle(nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, nuint, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[5])(@this, hFile, pguidVendor, metadataOptions, ppIDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFileHandle(nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, nuint, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[5])(@this, hFile, pguidVendorPtr, metadataOptions, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFileHandle(nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, nuint, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[5])(@this, hFile, pguidVendorPtr, metadataOptions, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComponentInfo(Guid* clsidComponent, IWICComponentInfo** ppIInfo)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, IWICComponentInfo**, int>)@this->LpVtbl[6])(@this, clsidComponent, ppIInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComponentInfo(Guid* clsidComponent, ref IWICComponentInfo* ppIInfo)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICComponentInfo** ppIInfoPtr = &ppIInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, IWICComponentInfo**, int>)@this->LpVtbl[6])(@this, clsidComponent, ppIInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComponentInfo(ref Guid clsidComponent, IWICComponentInfo** ppIInfo)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidComponentPtr = &clsidComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, IWICComponentInfo**, int>)@this->LpVtbl[6])(@this, clsidComponentPtr, ppIInfo);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComponentInfo(ref Guid clsidComponent, ref IWICComponentInfo* ppIInfo)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidComponentPtr = &clsidComponent)
            {
                fixed (IWICComponentInfo** ppIInfoPtr = &ppIInfo)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, IWICComponentInfo**, int>)@this->LpVtbl[6])(@this, clsidComponentPtr, ppIInfoPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormat, pguidVendor, ppIDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormat, pguidVendor, ppIDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormat, pguidVendorPtr, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormat, pguidVendorPtr, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormatPtr, pguidVendor, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormatPtr, pguidVendor, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormatPtr, pguidVendorPtr, ppIDecoder);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormatPtr, pguidVendorPtr, ppIDecoderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormat, pguidVendor, ppIEncoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapEncoder** ppIEncoderPtr = &ppIEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormat, pguidVendor, ppIEncoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICBitmapEncoder** ppIEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormat, pguidVendorPtr, ppIEncoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapEncoder** ppIEncoderPtr = &ppIEncoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormat, pguidVendorPtr, ppIEncoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormatPtr, pguidVendor, ppIEncoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (IWICBitmapEncoder** ppIEncoderPtr = &ppIEncoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormatPtr, pguidVendor, ppIEncoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICBitmapEncoder** ppIEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormatPtr, pguidVendorPtr, ppIEncoder);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICBitmapEncoder** ppIEncoderPtr = &ppIEncoder)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormatPtr, pguidVendorPtr, ppIEncoderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePalette(IWICPalette** ppIPalette)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICPalette**, int>)@this->LpVtbl[9])(@this, ppIPalette);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePalette(ref IWICPalette* ppIPalette)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette** ppIPalettePtr = &ppIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICPalette**, int>)@this->LpVtbl[9])(@this, ppIPalettePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFormatConverter(IWICFormatConverter** ppIFormatConverter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICFormatConverter**, int>)@this->LpVtbl[10])(@this, ppIFormatConverter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFormatConverter(ref IWICFormatConverter* ppIFormatConverter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICFormatConverter** ppIFormatConverterPtr = &ppIFormatConverter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICFormatConverter**, int>)@this->LpVtbl[10])(@this, ppIFormatConverterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapScaler**, int>)@this->LpVtbl[11])(@this, ppIBitmapScaler);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapScaler(ref IWICBitmapScaler* ppIBitmapScaler)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapScaler** ppIBitmapScalerPtr = &ppIBitmapScaler)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapScaler**, int>)@this->LpVtbl[11])(@this, ppIBitmapScalerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapClipper**, int>)@this->LpVtbl[12])(@this, ppIBitmapClipper);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapClipper(ref IWICBitmapClipper* ppIBitmapClipper)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapClipper** ppIBitmapClipperPtr = &ppIBitmapClipper)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapClipper**, int>)@this->LpVtbl[12])(@this, ppIBitmapClipperPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFlipRotator**, int>)@this->LpVtbl[13])(@this, ppIBitmapFlipRotator);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFlipRotator(ref IWICBitmapFlipRotator* ppIBitmapFlipRotator)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFlipRotator** ppIBitmapFlipRotatorPtr = &ppIBitmapFlipRotator)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFlipRotator**, int>)@this->LpVtbl[13])(@this, ppIBitmapFlipRotatorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStream(IWICStream** ppIWICStream)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICStream**, int>)@this->LpVtbl[14])(@this, ppIWICStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStream(ref IWICStream* ppIWICStream)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICStream** ppIWICStreamPtr = &ppIWICStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICStream**, int>)@this->LpVtbl[14])(@this, ppIWICStreamPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(IWICColorContext** ppIWICColorContext)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICColorContext**, int>)@this->LpVtbl[15])(@this, ppIWICColorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ref IWICColorContext* ppIWICColorContext)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext** ppIWICColorContextPtr = &ppIWICColorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICColorContext**, int>)@this->LpVtbl[15])(@this, ppIWICColorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorTransformer(IWICColorTransform** ppIWICColorTransform)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICColorTransform**, int>)@this->LpVtbl[16])(@this, ppIWICColorTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorTransformer(ref IWICColorTransform* ppIWICColorTransform)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorTransform** ppIWICColorTransformPtr = &ppIWICColorTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICColorTransform**, int>)@this->LpVtbl[16])(@this, ppIWICColorTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(uint uiWidth, uint uiHeight, Guid* pixelFormat, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[17])(@this, uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(uint uiWidth, uint uiHeight, Guid* pixelFormat, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[17])(@this, uiWidth, uiHeight, pixelFormat, option, ppIBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(uint uiWidth, uint uiHeight, ref Guid pixelFormat, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[17])(@this, uiWidth, uiHeight, pixelFormatPtr, option, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(uint uiWidth, uint uiHeight, ref Guid pixelFormat, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[17])(@this, uiWidth, uiHeight, pixelFormatPtr, option, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[18])(@this, pIBitmapSource, option, ppIBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[18])(@this, pIBitmapSource, option, ppIBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSource(ref IWICBitmapSource pIBitmapSource, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[18])(@this, pIBitmapSourcePtr, option, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSource(ref IWICBitmapSource pIBitmapSource, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[18])(@this, pIBitmapSourcePtr, option, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)@this->LpVtbl[19])(@this, pIBitmapSource, x, y, width, height, ppIBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)@this->LpVtbl[19])(@this, pIBitmapSource, x, y, width, height, ppIBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSourceRect(ref IWICBitmapSource pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)@this->LpVtbl[19])(@this, pIBitmapSourcePtr, x, y, width, height, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSourceRect(ref IWICBitmapSource pIBitmapSource, uint x, uint y, uint width, uint height, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)@this->LpVtbl[19])(@this, pIBitmapSourcePtr, x, y, width, height, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBufferPtr, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBufferPtr, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBufferPtr, ppIBitmap);
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBufferPtr, ppIBitmapPtr);
            }
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBuffer, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBufferPtr, ppIBitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBufferPtr, ppIBitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBufferPtr, ppIBitmap);
            SilkMarshal.Free((nint)pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBufferPtr, ppIBitmapPtr);
                }
            SilkMarshal.Free((nint)pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP(IntPtr* hBitmap, IntPtr* hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr*, IntPtr*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmap, hPalette, options, ppIBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP(IntPtr* hBitmap, IntPtr* hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr*, IntPtr*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmap, hPalette, options, ppIBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP(IntPtr* hBitmap, ref IntPtr hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IntPtr* hPalettePtr = &hPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr*, IntPtr*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmap, hPalettePtr, options, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP(IntPtr* hBitmap, ref IntPtr hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IntPtr* hPalettePtr = &hPalette)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr*, IntPtr*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmap, hPalettePtr, options, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP(ref IntPtr hBitmap, IntPtr* hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IntPtr* hBitmapPtr = &hBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr*, IntPtr*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmapPtr, hPalette, options, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP(ref IntPtr hBitmap, IntPtr* hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IntPtr* hBitmapPtr = &hBitmap)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr*, IntPtr*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmapPtr, hPalette, options, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP(ref IntPtr hBitmap, ref IntPtr hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IntPtr* hBitmapPtr = &hBitmap)
            {
                fixed (IntPtr* hPalettePtr = &hPalette)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr*, IntPtr*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmapPtr, hPalettePtr, options, ppIBitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP(ref IntPtr hBitmap, ref IntPtr hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IntPtr* hBitmapPtr = &hBitmap)
            {
                fixed (IntPtr* hPalettePtr = &hPalette)
                {
                    fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr*, IntPtr*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmapPtr, hPalettePtr, options, ppIBitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHICON(IntPtr* hIcon, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr*, IWICBitmap**, int>)@this->LpVtbl[22])(@this, hIcon, ppIBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHICON(IntPtr* hIcon, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr*, IWICBitmap**, int>)@this->LpVtbl[22])(@this, hIcon, ppIBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHICON(ref IntPtr hIcon, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IntPtr* hIconPtr = &hIcon)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr*, IWICBitmap**, int>)@this->LpVtbl[22])(@this, hIconPtr, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHICON(ref IntPtr hIcon, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IntPtr* hIconPtr = &hIcon)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IntPtr*, IWICBitmap**, int>)@this->LpVtbl[22])(@this, hIconPtr, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComponentEnumerator(uint componentTypes, uint options, Silk.NET.Core.Win32Extras.IEnumUnknown** ppIEnumUnknown)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Silk.NET.Core.Win32Extras.IEnumUnknown**, int>)@this->LpVtbl[23])(@this, componentTypes, options, ppIEnumUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComponentEnumerator(uint componentTypes, uint options, ref Silk.NET.Core.Win32Extras.IEnumUnknown* ppIEnumUnknown)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IEnumUnknown** ppIEnumUnknownPtr = &ppIEnumUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, uint, uint, Silk.NET.Core.Win32Extras.IEnumUnknown**, int>)@this->LpVtbl[23])(@this, componentTypes, options, ppIEnumUnknownPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[24])(@this, pIDecoder, ppIFastEncoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICFastMetadataEncoder** ppIFastEncoderPtr = &ppIFastEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[24])(@this, pIDecoder, ppIFastEncoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromDecoder(ref IWICBitmapDecoder pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoder* pIDecoderPtr = &pIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[24])(@this, pIDecoderPtr, ppIFastEncoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromDecoder(ref IWICBitmapDecoder pIDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoder* pIDecoderPtr = &pIDecoder)
            {
                fixed (IWICFastMetadataEncoder** ppIFastEncoderPtr = &ppIFastEncoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[24])(@this, pIDecoderPtr, ppIFastEncoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[25])(@this, pIFrameDecoder, ppIFastEncoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICFastMetadataEncoder** ppIFastEncoderPtr = &ppIFastEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[25])(@this, pIFrameDecoder, ppIFastEncoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromFrameDecode(ref IWICBitmapFrameDecode pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameDecode* pIFrameDecoderPtr = &pIFrameDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[25])(@this, pIFrameDecoderPtr, ppIFastEncoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromFrameDecode(ref IWICBitmapFrameDecode pIFrameDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameDecode* pIFrameDecoderPtr = &pIFrameDecoder)
            {
                fixed (IWICFastMetadataEncoder** ppIFastEncoderPtr = &ppIFastEncoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[25])(@this, pIFrameDecoderPtr, ppIFastEncoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormat, pguidVendor, ppIQueryWriter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormat, pguidVendor, ppIQueryWriterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormat, pguidVendorPtr, ppIQueryWriter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormat, pguidVendorPtr, ppIQueryWriterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormatPtr, pguidVendor, ppIQueryWriter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormatPtr, pguidVendor, ppIQueryWriterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormatPtr, pguidVendorPtr, ppIQueryWriter);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormatPtr, pguidVendorPtr, ppIQueryWriterPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReader, pguidVendor, ppIQueryWriter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReader, pguidVendor, ppIQueryWriterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReader, pguidVendorPtr, ppIQueryWriter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReader, pguidVendorPtr, ppIQueryWriterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryReader* pIQueryReaderPtr = &pIQueryReader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReaderPtr, pguidVendor, ppIQueryWriter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryReader* pIQueryReaderPtr = &pIQueryReader)
            {
                fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReaderPtr, pguidVendor, ppIQueryWriterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryReader* pIQueryReaderPtr = &pIQueryReader)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReaderPtr, pguidVendorPtr, ppIQueryWriter);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryReader* pIQueryReaderPtr = &pIQueryReader)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICImagingFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReaderPtr, pguidVendorPtr, ppIQueryWriterPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFilename(wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFilename(wzFilename, in pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFilename(in wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoderFromFilename<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFilename(in wzFilename, in pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFilename(wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoderFromFilename<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFilename(wzFilename, in pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream<TI0, TI1>(ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI1> ppIDecoder) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI1>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromStream((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream<TI0>(ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromStream((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pguidVendor, metadataOptions, ref ppIDecoder);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoderFromStream<TI0, TI1>(ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI1> ppIDecoder) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI1>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromStream((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, in pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream<TI0>(ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromStream((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, in pguidVendor, metadataOptions, ref ppIDecoder);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream<TI0>(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromStream(ref pIStream, pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoderFromStream<TI0>(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromStream(ref pIStream, in pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFileHandle<TI0>(nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFileHandle(hFile, pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoderFromFileHandle<TI0>(nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFileHandle(hFile, in pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateComponentInfo<TI0>(out ComPtr<TI0> ppIInfo) where TI0 : unmanaged, IComVtbl<IWICComponentInfo>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIInfo = default;
            return @this->CreateComponentInfo(SilkMarshal.GuidPtrOf<TI0>(), (IWICComponentInfo**) ppIInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateComponentInfo<TI0>(ref Guid clsidComponent, ref ComPtr<TI0> ppIInfo) where TI0 : unmanaged, IComVtbl<IWICComponentInfo>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateComponentInfo(ref clsidComponent, (IWICComponentInfo**) ppIInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder<TI0>(Guid* guidContainerFormat, out ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIDecoder = default;
            return @this->CreateDecoder(guidContainerFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder<TI0>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoder(guidContainerFormat, in pguidVendor, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoder<TI0>(ref Guid guidContainerFormat, out ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIDecoder = default;
            return @this->CreateDecoder(ref guidContainerFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoder<TI0>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoder(ref guidContainerFormat, in pguidVendor, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder<TI0>(Guid* guidContainerFormat, out ComPtr<TI0> ppIEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIEncoder = default;
            return @this->CreateEncoder(guidContainerFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICBitmapEncoder**) ppIEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder<TI0>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEncoder(guidContainerFormat, in pguidVendor, (IWICBitmapEncoder**) ppIEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEncoder<TI0>(ref Guid guidContainerFormat, out ComPtr<TI0> ppIEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIEncoder = default;
            return @this->CreateEncoder(ref guidContainerFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICBitmapEncoder**) ppIEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEncoder<TI0>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEncoder(ref guidContainerFormat, in pguidVendor, (IWICBitmapEncoder**) ppIEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreatePalette<TI0>(ref ComPtr<TI0> ppIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePalette((IWICPalette**) ppIPalette.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFormatConverter<TI0>(ref ComPtr<TI0> ppIFormatConverter) where TI0 : unmanaged, IComVtbl<IWICFormatConverter>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFormatConverter((IWICFormatConverter**) ppIFormatConverter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapScaler<TI0>(ref ComPtr<TI0> ppIBitmapScaler) where TI0 : unmanaged, IComVtbl<IWICBitmapScaler>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapScaler((IWICBitmapScaler**) ppIBitmapScaler.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapClipper<TI0>(ref ComPtr<TI0> ppIBitmapClipper) where TI0 : unmanaged, IComVtbl<IWICBitmapClipper>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapClipper((IWICBitmapClipper**) ppIBitmapClipper.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFlipRotator<TI0>(ref ComPtr<TI0> ppIBitmapFlipRotator) where TI0 : unmanaged, IComVtbl<IWICBitmapFlipRotator>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFlipRotator((IWICBitmapFlipRotator**) ppIBitmapFlipRotator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateStream<TI0>(ref ComPtr<TI0> ppIWICStream) where TI0 : unmanaged, IComVtbl<IWICStream>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStream((IWICStream**) ppIWICStream.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateColorContext<TI0>(ref ComPtr<TI0> ppIWICColorContext) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateColorContext((IWICColorContext**) ppIWICColorContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateColorTransformer<TI0>(ref ComPtr<TI0> ppIWICColorTransform) where TI0 : unmanaged, IComVtbl<IWICColorTransform>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateColorTransformer((IWICColorTransform**) ppIWICColorTransform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap<TI0>(uint uiWidth, uint uiHeight, Guid* pixelFormat, BitmapCreateCacheOption option, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmap(uiWidth, uiHeight, pixelFormat, option, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmap<TI0>(uint uiWidth, uint uiHeight, ref Guid pixelFormat, BitmapCreateCacheOption option, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmap(uiWidth, uiHeight, ref pixelFormat, option, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromSource<TI0, TI1>(ComPtr<TI0> pIBitmapSource, BitmapCreateCacheOption option, ref ComPtr<TI1> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI1>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromSource((IWICBitmapSource*) pIBitmapSource.Handle, option, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSource<TI0>(ComPtr<TI0> pIBitmapSource, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromSource((IWICBitmapSource*) pIBitmapSource.Handle, option, ref ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromSource<TI0>(ref IWICBitmapSource pIBitmapSource, BitmapCreateCacheOption option, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromSource(ref pIBitmapSource, option, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromSourceRect<TI0, TI1>(ComPtr<TI0> pIBitmapSource, uint x, uint y, uint width, uint height, ref ComPtr<TI1> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI1>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromSourceRect((IWICBitmapSource*) pIBitmapSource.Handle, x, y, width, height, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSourceRect<TI0>(ComPtr<TI0> pIBitmapSource, uint x, uint y, uint width, uint height, ref IWICBitmap* ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromSourceRect((IWICBitmapSource*) pIBitmapSource.Handle, x, y, width, height, ref ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromSourceRect<TI0>(ref IWICBitmapSource pIBitmapSource, uint x, uint y, uint width, uint height, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromSourceRect(ref pIBitmapSource, x, y, width, height, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory<TI0>(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromMemory(uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory<TI0>(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromMemory(uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, ref pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory<TI0>(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromMemory(uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory<TI0>(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat, cbStride, cbBufferSize, pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromMemory<TI0>(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat, cbStride, cbBufferSize, ref pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromMemory<TI0>(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat, cbStride, cbBufferSize, pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP<TI0>(IntPtr* hBitmap, IntPtr* hPalette, BitmapAlphaChannelOption options, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromHBITMAP(hBitmap, hPalette, options, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP<TI0>(IntPtr* hBitmap, ref IntPtr hPalette, BitmapAlphaChannelOption options, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromHBITMAP(hBitmap, ref hPalette, options, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP<TI0>(ref IntPtr hBitmap, IntPtr* hPalette, BitmapAlphaChannelOption options, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromHBITMAP(ref hBitmap, hPalette, options, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromHBITMAP<TI0>(ref IntPtr hBitmap, ref IntPtr hPalette, BitmapAlphaChannelOption options, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromHBITMAP(ref hBitmap, ref hPalette, options, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHICON<TI0>(IntPtr* hIcon, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromHICON(hIcon, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromHICON<TI0>(ref IntPtr hIcon, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromHICON(ref hIcon, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFastMetadataEncoderFromDecoder<TI0, TI1>(ComPtr<TI0> pIDecoder, ref ComPtr<TI1> ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICFastMetadataEncoder>, IComVtbl<TI1>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFastMetadataEncoderFromDecoder((IWICBitmapDecoder*) pIDecoder.Handle, (IWICFastMetadataEncoder**) ppIFastEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromDecoder<TI0>(ComPtr<TI0> pIDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFastMetadataEncoderFromDecoder((IWICBitmapDecoder*) pIDecoder.Handle, ref ppIFastEncoder);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFastMetadataEncoderFromDecoder<TI0>(ref IWICBitmapDecoder pIDecoder, ref ComPtr<TI0> ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICFastMetadataEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFastMetadataEncoderFromDecoder(ref pIDecoder, (IWICFastMetadataEncoder**) ppIFastEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFastMetadataEncoderFromFrameDecode<TI0, TI1>(ComPtr<TI0> pIFrameDecoder, ref ComPtr<TI1> ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameDecode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICFastMetadataEncoder>, IComVtbl<TI1>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFastMetadataEncoderFromFrameDecode((IWICBitmapFrameDecode*) pIFrameDecoder.Handle, (IWICFastMetadataEncoder**) ppIFastEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromFrameDecode<TI0>(ComPtr<TI0> pIFrameDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameDecode>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFastMetadataEncoderFromFrameDecode((IWICBitmapFrameDecode*) pIFrameDecoder.Handle, ref ppIFastEncoder);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFastMetadataEncoderFromFrameDecode<TI0>(ref IWICBitmapFrameDecode pIFrameDecoder, ref ComPtr<TI0> ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICFastMetadataEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFastMetadataEncoderFromFrameDecode(ref pIFrameDecoder, (IWICFastMetadataEncoder**) ppIFastEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter<TI0>(Guid* guidMetadataFormat, out ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIQueryWriter = default;
            return @this->CreateQueryWriter(guidMetadataFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter<TI0>(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriter(guidMetadataFormat, in pguidVendor, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriter<TI0>(ref Guid guidMetadataFormat, out ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIQueryWriter = default;
            return @this->CreateQueryWriter(ref guidMetadataFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriter<TI0>(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriter(ref guidMetadataFormat, in pguidVendor, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriterFromReader<TI0, TI1>(ComPtr<TI0> pIQueryReader, out ComPtr<TI1> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI1>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIQueryWriter = default;
            return @this->CreateQueryWriterFromReader((IWICMetadataQueryReader*) pIQueryReader.Handle, SilkMarshal.GuidPtrOf<TI1>(), (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader<TI0>(ComPtr<TI0> pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriterFromReader((IWICMetadataQueryReader*) pIQueryReader.Handle, pguidVendor, ref ppIQueryWriter);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriterFromReader<TI0, TI1>(ComPtr<TI0> pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI1> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI1>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriterFromReader((IWICMetadataQueryReader*) pIQueryReader.Handle, in pguidVendor, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader<TI0>(ComPtr<TI0> pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriterFromReader((IWICMetadataQueryReader*) pIQueryReader.Handle, in pguidVendor, ref ppIQueryWriter);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriterFromReader<TI0>(ref IWICMetadataQueryReader pIQueryReader, out ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIQueryWriter = default;
            return @this->CreateQueryWriterFromReader(ref pIQueryReader, SilkMarshal.GuidPtrOf<TI0>(), (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriterFromReader<TI0>(ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriterFromReader(ref pIQueryReader, in pguidVendor, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateComponentInfo<TI0>() where TI0 : unmanaged, IComVtbl<IWICComponentInfo>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateComponentInfo(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateDecoder<TI0>(Guid* guidContainerFormat) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateDecoder(guidContainerFormat, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateDecoder<TI0>(ref Guid guidContainerFormat) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateDecoder(ref guidContainerFormat, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateEncoder<TI0>(Guid* guidContainerFormat) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateEncoder(guidContainerFormat, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateEncoder<TI0>(ref Guid guidContainerFormat) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateEncoder(ref guidContainerFormat, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateQueryWriter<TI0>(Guid* guidMetadataFormat) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateQueryWriter(guidMetadataFormat, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateQueryWriter<TI0>(ref Guid guidMetadataFormat) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateQueryWriter(ref guidMetadataFormat, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateQueryWriterFromReader<TI0, TI1>(ComPtr<TI0> pIQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI1>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateQueryWriterFromReader(pIQueryReader, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateQueryWriterFromReader<TI0>(ref IWICMetadataQueryReader pIQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICImagingFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateQueryWriterFromReader(ref pIQueryReader, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
