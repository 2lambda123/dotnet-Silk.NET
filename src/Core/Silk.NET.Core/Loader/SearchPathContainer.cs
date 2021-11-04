// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Microsoft.DotNet.PlatformAbstractions;
using SRRuntimeEnvironment = System.Runtime.InteropServices.RuntimeEnvironment;
using PARuntimeEnvironment = Microsoft.DotNet.PlatformAbstractions.RuntimeEnvironment;

namespace Silk.NET.Core.Loader
{
    /// <summary>
    /// Contains the platform-specific search paths and names for a native library.
    /// </summary>
    public abstract class SearchPathContainer
    {
        /// <summary>
        /// Gets or sets the underlying platform (operating system) to use for search path resolution.
        /// </summary>
        public static UnderlyingPlatform Platform { get; set; } = RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
            ? RuntimeInformation.IsOSPlatform(OSPlatform.Create("ANDROID"))
                ? UnderlyingPlatform.Android // NOTE: This seems to work inconsistently. Recommend setting manually.
                : UnderlyingPlatform.Linux
            : RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? Environment.Is64BitProcess
                    ? UnderlyingPlatform.Windows64
                    : UnderlyingPlatform.Windows86
            : RuntimeInformation.IsOSPlatform(OSPlatform.OSX)
                ? RuntimeInformation.IsOSPlatform(OSPlatform.Create("IOS"))
                    ? UnderlyingPlatform.IOS // NOTE: This seems to work inconsistently. Recommend setting manually.
                    : UnderlyingPlatform.MacOS
            : RuntimeInformation.IsOSPlatform(OSPlatform.Create("BROWSER")) ? // NOTE: It's unclear how well this works. See https://github.com/dotnet/runtime/issues/33328
                    UnderlyingPlatform.Browser
            : UnderlyingPlatform.Unknown;

        /// <summary>
        /// Gets the library name to use on Windows 64-bit.
        /// </summary>
        public abstract string Windows64 { get; }

        /// <summary>
        /// Gets the library name to use on Windows 32-bit.
        /// </summary>
        public abstract string Windows86 { get; }

        /// <summary>
        /// Gets the library name to use on Linux.
        /// </summary>
        public abstract string Linux { get; }

        /// <summary>
        /// Gets the library name to use on MacOS.
        /// </summary>
        public abstract string MacOS { get; }

        /// <summary>
        /// Gets the library name to use in the Browser.
        /// </summary>
        public virtual string Browser => throw new NotImplementedException("No Browser library available");
        
        /// <summary>
        /// Gets the library name to use on Android.
        /// </summary>
        public virtual string Android => Linux;

        /// <summary>
        /// Gets the library name to use on iOS.
        /// </summary>
        public virtual string IOS => MacOS;

        /// <summary>
        /// Gets the library name to use on the current platform.
        /// </summary>
        /// <returns>The library name.</returns>
        public string GetLibraryName() => Platform switch
        {
            UnderlyingPlatform.Unknown => ThrowInvalidPlatform(),
            UnderlyingPlatform.Windows64 => Windows64,
            UnderlyingPlatform.Windows86 => Windows86,
            UnderlyingPlatform.Linux => Linux,
            UnderlyingPlatform.Android => Android,
            UnderlyingPlatform.MacOS => MacOS,
            UnderlyingPlatform.IOS => IOS,
            UnderlyingPlatform.Browser => Browser,
            _ => ThrowInvalidPlatform()
        };
        
        private static string ThrowInvalidPlatform()
        {
            throw new PlatformNotSupportedException("Invalid/unsupported operating system.");
        }
    }
}
