// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.EmbeddedLanguages.VirtualChars;

namespace Microsoft.CodeAnalysis.EmbeddedLanguages.Common;

internal abstract class EmbeddedSyntaxTree<TSyntaxKind, TSyntaxNode, TCompilationUnitSyntax>(
    VirtualCharSequence text,
    TCompilationUnitSyntax root,
    ImmutableArray<EmbeddedDiagnostic> diagnostics)
    where TSyntaxKind : struct
    where TSyntaxNode : EmbeddedSyntaxNode<TSyntaxKind, TSyntaxNode>
    where TCompilationUnitSyntax : TSyntaxNode
{
    public readonly VirtualCharSequence Text = text;
    public readonly TCompilationUnitSyntax Root = root;
    public readonly ImmutableArray<EmbeddedDiagnostic> Diagnostics = diagnostics;
}
