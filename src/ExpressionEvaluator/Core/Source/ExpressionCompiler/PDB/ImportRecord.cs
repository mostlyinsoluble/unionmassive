// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.ExpressionEvaluator
{
    internal readonly struct ImportRecord(
        ImportTargetKind targetKind,
        string? alias = null,
        ITypeSymbolInternal? targetType = null,
        string? targetString = null,
        IAssemblySymbolInternal? targetAssembly = null,
        string? targetAssemblyAlias = null)
    {
        public readonly ImportTargetKind TargetKind = targetKind;
        public readonly string? Alias = alias;

        // target type of a type import (C#)
        public readonly ITypeSymbolInternal? TargetType = targetType;

        // target of an import (type, namespace or XML namespace) that needs to be bound (C#, VB)
        public readonly string? TargetString = targetString;

        // target assembly of a namespace import (C#, Portable)
        public readonly IAssemblySymbolInternal? TargetAssembly = targetAssembly;

        // target assembly of a namespace import is identified by an extern alias which needs to be bound in the context (C#, native PDB)
        public readonly string? TargetAssemblyAlias = targetAssemblyAlias;
    }
}
