// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.ExternalAccess.FSharp.Editor;

internal readonly struct FSharpInlineRenameReplacement(FSharpInlineRenameReplacementKind kind, TextSpan originalSpan, TextSpan newSpan)
{
    public FSharpInlineRenameReplacementKind Kind { get; } = kind;
    public TextSpan OriginalSpan { get; } = originalSpan;
    public TextSpan NewSpan { get; } = newSpan;
}
