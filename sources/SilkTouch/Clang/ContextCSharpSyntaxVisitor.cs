// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// A <see cref="ContextCSharpSyntaxVisitor"/> with metadata for the current <see cref="SyntaxContext"/> Visit method
/// </summary>
public class ContextCSharpSyntaxVisitor : CSharpSyntaxVisitor
{
    /// <summary>
    /// The current type being visited
    /// </summary>
    public IBaseTypeContext? CurrentContext { get; internal set; }

    /// <summary>
    /// The list of the namespaces being used
    /// </summary>
    public List<string> Usings { get; internal set; } = [];

    /// <summary>
    /// The current Namespace being visited
    /// </summary>
    public INamespaceContext? CurrentNamespaceContext { get; internal set; }

    /// <summary>
    /// The top-level namespace context (global context)
    /// </summary>
    public INamespaceContext? TopNamespaceContext { get; internal set; }

    /// <summary>
    /// The namespace of the current context
    /// </summary>
    public string CurrentNamespace => CurrentNamespaceContext?.FullNamespace ?? string.Empty;

    /// <summary>
    /// The currently SyntaxContext
    /// </summary>
    public SyntaxContext? Context { get; internal set; }

    /// <summary>
    /// The file that is currently being editted
    /// </summary>
    public string File { get; internal set; } = string.Empty;

    /// <summary>
    /// Called when a file is started being worked on
    /// </summary>
    /// <param name="fileName"></param>
    public virtual void OnFileStarted(string fileName) { }

    /// <summary>
    /// Called when a file is finished being worked on
    /// </summary>
    /// <param name="fileName"></param>
    public virtual void OnFileFinished(string fileName) { }

    /// <summary>
    /// Whether or not this file should be skipped upon visiting
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public virtual bool ShouldSkipFile(string fileName) { return false; }
}
