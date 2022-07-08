// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="FieldSymbol"/>. A field is simply a named location that can hold some type.
/// </summary>
/// <param name="Type">The <see cref="ExternalTypeReference"/> of the data stored in this field</param>
/// <param name="Identifier">The Identifier of this field</param>
/// <seealso cref="MemberSymbol"/>
public sealed record FieldSymbol(ExternalTypeReference Type, IdentifierSymbol Identifier) : MemberSymbol;
