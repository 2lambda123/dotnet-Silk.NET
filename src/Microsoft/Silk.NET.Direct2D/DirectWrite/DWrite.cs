using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using static Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    public partial class DWrite
    {
        public static DWrite GetApi()
        {
             return new(CreateDefaultContext(new DWriteLibraryNameContainer().GetLibraryNames()));
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<DWrite>
        {
            throw new NotImplementedException();
        }

        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }
    }
}

