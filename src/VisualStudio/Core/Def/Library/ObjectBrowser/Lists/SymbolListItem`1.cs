// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.Library.ObjectBrowser.Lists;

internal abstract class SymbolListItem<TSymbol>(ProjectId projectId, TSymbol symbol, string displayText, string fullNameText, string searchText, bool isHidden) : SymbolListItem(projectId, symbol, displayText, fullNameText, searchText, isHidden)
    where TSymbol : ISymbol
{
    public TSymbol ResolveTypedSymbol(Compilation compilation)
        => (TSymbol)ResolveSymbol(compilation);
}
