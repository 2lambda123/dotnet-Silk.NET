// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;

namespace Silk.NET.Input.Common
{
    /// <summary>
    /// Represents a joystick device with a set amount of axes, buttons, and hats.
    /// </summary>
    public interface IJoystick : IInputDevice
    {
        /// <summary>
        /// A list of all axes supported by this joystick.
        /// </summary>
        IReadOnlyCollection<Axis> Axes { get; }
        
        /// <summary>
        /// A list of all buttons supported by this joystick.
        /// </summary>
        IReadOnlyCollection<Button> Buttons { get; }
        
        /// <summary>
        /// A list of all hats supported by this joystick.
        /// </summary>
        IReadOnlyCollection<Hat> Hats { get; }
        
        /// <summary>
        /// The deadzone to use for this joystick's axes.
        /// </summary>
        Deadzone Deadzone { get; set; }
        
        /// <summary>
        /// Called when a button on this joystick is pressed.
        /// </summary>
        event Action<IJoystick, Button> ButtonDown;
        
        /// <summary>
        /// Called when a button on this joystick is released.
        /// </summary>
        event Action<IJoystick, Button> ButtonUp;
        
        /// <summary>
        /// Called when an axis on this joystick is moved.
        /// </summary>
        event Action<IJoystick, Axis> AxisMoved;
        
        /// <summary>
        /// Called when a hat on this joystick is moved.
        /// </summary>
        event Action<IJoystick, Hat> HatMoved;
    }
}