// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Text;

namespace Roslyn.Test.Utilities
{
    internal sealed partial class SourceWithMarkedNodes
    {
        internal readonly struct MarkedSpan(TextSpan markedSyntax, TextSpan matchedSpan, string tagName, int syntaxKind, int id, int parentId)
        {
            public readonly TextSpan MarkedSyntax = markedSyntax;
            public readonly TextSpan MatchedSpan = matchedSpan;
            public readonly string TagName = tagName;
            public readonly int SyntaxKind = syntaxKind;
            public readonly int Id = id;
            public readonly int ParentId = parentId;
        }
    }
}
