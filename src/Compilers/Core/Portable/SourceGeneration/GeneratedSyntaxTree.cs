// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// A syntax tree created by a <see cref="ISourceGenerator"/>
    /// </summary>
    internal readonly struct GeneratedSyntaxTree(string hintName, SourceText text, SyntaxTree tree)
    {
        public SourceText Text { get; } = text;

        public string HintName { get; } = hintName;

        public SyntaxTree Tree { get; } = tree;
    }
}
