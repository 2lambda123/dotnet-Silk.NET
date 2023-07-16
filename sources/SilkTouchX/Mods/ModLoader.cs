﻿using System;
using Microsoft.Extensions.DependencyInjection;

namespace SilkTouchX.Mods;

/// <summary>
/// Loads <see cref="IMod"/>s based on strings contained within the configuration file.
/// </summary>
public class ModLoader
{
    /// <summary>
    /// Gets a mod from the given name/string.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns>The loaded mod if the mod was found, null otherwise.</returns>
    public static Type? LoadModByName(string name) => null;
}
