// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_mem_alloc_flags_img")]
    public enum MemAllocFlagsImg : ulong
    {
        [NativeName("Name", "CL_MEM_ALLOC_RELAX_REQUIREMENTS_IMG")]
        MemAllocRelaxRequirementsImg = 0x1,
    }
}
