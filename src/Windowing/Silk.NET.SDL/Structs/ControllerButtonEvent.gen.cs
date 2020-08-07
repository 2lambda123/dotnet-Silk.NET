// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_ControllerButtonEvent")]
    public unsafe partial struct ControllerButtonEvent
    {
        public ControllerButtonEvent
        (
            uint type = default,
            uint timestamp = default,
            int which = default,
            byte button = default,
            byte state = default,
            byte padding1 = default,
            byte padding2 = default
        )
        {
            Type = type;
            Timestamp = timestamp;
            Which = which;
            Button = button;
            State = state;
            Padding1 = padding1;
            Padding2 = padding2;
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "timestamp")]
        public uint Timestamp;

        [NativeName("Type", "SDL_JoystickID")]
        [NativeName("Type.Name", "SDL_JoystickID")]
        [NativeName("Name", "which")]
        public int Which;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "button")]
        public byte Button;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "state")]
        public byte State;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "padding1")]
        public byte Padding1;

        [NativeName("Type", "Uint8")]
        [NativeName("Type.Name", "Uint8")]
        [NativeName("Name", "padding2")]
        public byte Padding2;
    }
}
