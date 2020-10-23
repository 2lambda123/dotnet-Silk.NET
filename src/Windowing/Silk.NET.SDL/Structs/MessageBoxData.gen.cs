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

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_MessageBoxData")]
    public unsafe partial struct MessageBoxData
    {
        public MessageBoxData
        (
            uint? flags = null,
            Window* window = null,
            byte* title = null,
            byte* message = null,
            int? numbuttons = null,
            MessageBoxButtonData* buttons = null,
            MessageBoxColorScheme* colorScheme = null
        )
        {
            fixed (MessageBoxData* @this = &this)
            {
                // all fields automatically initialized here
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (window is not null)
            {
                Window = window;
            }

            if (title is not null)
            {
                Title = title;
            }

            if (message is not null)
            {
                Message = message;
            }

            if (numbuttons is not null)
            {
                Numbuttons = numbuttons.Value;
            }

            if (buttons is not null)
            {
                Buttons = buttons;
            }

            if (colorScheme is not null)
            {
                ColorScheme = colorScheme;
            }
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "SDL_Window *")]
        [NativeName("Type.Name", "SDL_Window *")]
        [NativeName("Name", "window")]
        public Window* Window;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "title")]
        public byte* Title;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "message")]
        public byte* Message;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "numbuttons")]
        public int Numbuttons;

        [NativeName("Type", "const SDL_MessageBoxButtonData *")]
        [NativeName("Type.Name", "const SDL_MessageBoxButtonData *")]
        [NativeName("Name", "buttons")]
        public MessageBoxButtonData* Buttons;

        [NativeName("Type", "const SDL_MessageBoxColorScheme *")]
        [NativeName("Type.Name", "const SDL_MessageBoxColorScheme *")]
        [NativeName("Name", "colorScheme")]
        public MessageBoxColorScheme* ColorScheme;
    }
}
