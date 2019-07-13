// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    /// <summary>
    /// Represents a joystick button.
    /// </summary>
    public struct Button
    {
        /// <summary>
        /// The name of this button. Only guaranteed to be valid if this comes from an <see cref="IGamepad"/>.
        /// </summary>
        public ButtonName Name { get; }
        
        /// <summary>
        /// The index of this button. Use this if this button comes from an <see cref="IJoystick"/>.
        /// </summary>
        public int Index { get; }
        
        /// <summary>
        /// Whether or not this button is currently pressed.
        /// </summary>
        public bool Pressed { get; }

        public Button(ButtonName name, int index, bool pressed)
        {
            Name = name;
            Index = index;
            Pressed = pressed;
        }
    }
}