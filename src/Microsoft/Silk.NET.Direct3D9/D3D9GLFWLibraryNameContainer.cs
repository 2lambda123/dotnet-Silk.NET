// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;
using System.Linq;

namespace Silk.NET.Direct3D9
{
    /// <summary>
    /// Contains the library name of D3D9.
    /// </summary>
    internal class D3D9GLFWLibraryNameContainer : D3D9LibraryNameContainer
    {
        /// <inheritdoc />
        public override string[] Linux => base.Linux.Concat(new[] { "glfw-libdxvk_d3d9.so" }).ToArray();
    }
}
