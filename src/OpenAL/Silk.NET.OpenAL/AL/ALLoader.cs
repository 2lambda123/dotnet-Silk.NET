// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using AdvancedDLSupport;
using AdvancedDLSupport.Loaders;
using Silk.NET.Core.Loader;

namespace Silk.NET.OpenAL
{
    public class ALLoader : ISymbolLoader
    {
        public ALLoader(bool alc)
        {
            _alc = alc;
        }
        
        [NativeSymbols]
        public interface IInternalAL
        {
            [NativeSymbol("alcGetProcAddress")]
            IntPtr GetContextProcAddress(string proc);
            [NativeSymbol("alGetProcAddress")]
            IntPtr GetProcAddress(string proc);
        }

        private static IInternalAL _al = new NativeLibraryBuilder(LibraryLoader.Options).ActivateInterface<IInternalAL>
        (
            new OpenALLibraryNameContainer().GetLibraryName()
        );

        private bool _alc;

        public IntPtr LoadSymbol(IntPtr library, string symbolName)
        {
            IntPtr sym;
            try
            {
                sym = PlatformLoaderBase.PlatformLoader.LoadSymbol(library, symbolName);
            }
            catch
            {
                // do nothing
            }

            if (sym != IntPtr.Zero)
            {
                return sym;
            }

            if (!_alc)
            {
                sym = _al.GetProcAddress(symbolName);

                if (sym != IntPtr.Zero)
                {
                    return sym;
                }
            }
            else
            {

                sym = _al.GetContextProcAddress(symbolName);

                if (sym != IntPtr.Zero)
                {
                    return sym;
                }
            }

            throw new EntryPointNotFoundException();
        }
    }
}
