// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSwapchainKHR")]
    public unsafe partial struct SwapchainKHR
    {
        public SwapchainKHR
        (
            ulong? handle = null
        )
        {
            fixed (SwapchainKHR* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (handle is not null)
            {
                Handle = handle.Value;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "")]
        public ulong Handle;
    }
}
