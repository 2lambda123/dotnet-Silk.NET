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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_WIN32_FIND_DATAA")]
    public unsafe partial struct Win32FindDataa
    {
        public Win32FindDataa
        (
            int? dwFileAttributes = null,
            Silk.NET.Core.Win32Extras.Filetime? ftCreationTime = null,
            Silk.NET.Core.Win32Extras.Filetime? ftLastAccessTime = null,
            Silk.NET.Core.Win32Extras.Filetime? ftLastWriteTime = null,
            int? nFileSizeHigh = null,
            int? nFileSizeLow = null,
            int? dwReserved0 = null,
            int? dwReserved1 = null
        ) : this()
        {
            if (dwFileAttributes is not null)
            {
                DwFileAttributes = dwFileAttributes.Value;
            }

            if (ftCreationTime is not null)
            {
                FtCreationTime = ftCreationTime.Value;
            }

            if (ftLastAccessTime is not null)
            {
                FtLastAccessTime = ftLastAccessTime.Value;
            }

            if (ftLastWriteTime is not null)
            {
                FtLastWriteTime = ftLastWriteTime.Value;
            }

            if (nFileSizeHigh is not null)
            {
                NFileSizeHigh = nFileSizeHigh.Value;
            }

            if (nFileSizeLow is not null)
            {
                NFileSizeLow = nFileSizeLow.Value;
            }

            if (dwReserved0 is not null)
            {
                DwReserved0 = dwReserved0.Value;
            }

            if (dwReserved1 is not null)
            {
                DwReserved1 = dwReserved1.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwFileAttributes")]
        public int DwFileAttributes;

        [NativeName("Type", "FILETIME")]
        [NativeName("Type.Name", "FILETIME")]
        [NativeName("Name", "ftCreationTime")]
        public Silk.NET.Core.Win32Extras.Filetime FtCreationTime;

        [NativeName("Type", "FILETIME")]
        [NativeName("Type.Name", "FILETIME")]
        [NativeName("Name", "ftLastAccessTime")]
        public Silk.NET.Core.Win32Extras.Filetime FtLastAccessTime;

        [NativeName("Type", "FILETIME")]
        [NativeName("Type.Name", "FILETIME")]
        [NativeName("Name", "ftLastWriteTime")]
        public Silk.NET.Core.Win32Extras.Filetime FtLastWriteTime;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "nFileSizeHigh")]
        public int NFileSizeHigh;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "nFileSizeLow")]
        public int NFileSizeLow;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwReserved0")]
        public int DwReserved0;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwReserved1")]
        public int DwReserved1;
        [NativeName("Type", "CHAR [260]")]
        [NativeName("Type.Name", "CHAR [260]")]
        [NativeName("Name", "cFileName")]
        public fixed byte CFileName[260];
        [NativeName("Type", "CHAR [14]")]
        [NativeName("Type.Name", "CHAR [14]")]
        [NativeName("Name", "cAlternateFileName")]
        public fixed byte CAlternateFileName[14];
    }
}
