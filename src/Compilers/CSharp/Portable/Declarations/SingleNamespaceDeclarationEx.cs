// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class SingleNamespaceDeclarationEx(
        string name, bool hasUsings, bool hasExternAliases,
        SyntaxReference syntaxReference, SourceLocation nameLocation,
        ImmutableArray<SingleNamespaceOrTypeDeclaration> children,
        ImmutableArray<Diagnostic> diagnostics) : SingleNamespaceDeclaration(name, syntaxReference, nameLocation, children, diagnostics)
    {
        private readonly bool _hasUsings = hasUsings;
        private readonly bool _hasExternAliases = hasExternAliases;

        public override bool HasUsings
        {
            get
            {
                return _hasUsings;
            }
        }

        public override bool HasExternAliases
        {
            get
            {
                return _hasExternAliases;
            }
        }
    }
}
