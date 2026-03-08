// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Shared.Extensions;
using Microsoft.VisualStudio.LanguageServices.Implementation.Utilities;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.Library.ObjectBrowser.Lists;

internal abstract class SymbolListItem(ProjectId projectId, ISymbol symbol, string displayText, string fullNameText, string searchText, bool isHidden) : ObjectListItem(projectId, symbol.GetGlyph().GetStandardGlyphGroup(), symbol.GetGlyph().GetStandardGlyphItem(), isHidden)
{
    private readonly SymbolKey _symbolKey = symbol.GetSymbolKey();
    private readonly string _displayText = displayText;
    private readonly string _fullNameText = fullNameText;
    private readonly string _searchText = searchText;

    private readonly bool _supportsGoToDefinition = symbol.Kind != SymbolKind.Namespace;
    private readonly bool _supportsFindAllReferences = symbol.Kind != SymbolKind.Namespace;

    public Accessibility Accessibility { get; } = symbol.DeclaredAccessibility;

    public override string DisplayText
    {
        get { return _displayText; }
    }

    public override string FullNameText
    {
        get { return _fullNameText; }
    }

    public override string SearchText
    {
        get { return _searchText; }
    }

    public override bool SupportsGoToDefinition
    {
        get { return _supportsGoToDefinition; }
    }

    public override bool SupportsFindAllReferences
    {
        get { return _supportsFindAllReferences; }
    }

    public ISymbol ResolveSymbol(Compilation compilation)
        => _symbolKey.Resolve(compilation, ignoreAssemblyKey: false).Symbol;
}
