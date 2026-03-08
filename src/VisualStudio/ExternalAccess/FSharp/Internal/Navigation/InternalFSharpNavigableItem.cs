// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.ExternalAccess.FSharp.Navigation;
using Microsoft.CodeAnalysis.Navigation;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.ExternalAccess.FSharp.Internal.Navigation;

internal class InternalFSharpNavigableItem(FSharpNavigableItem item) : INavigableItem
{
    private readonly INavigableItem.NavigableDocument _navigableDocument = INavigableItem.NavigableDocument.FromDocument(item.Document);

    public Glyph Glyph { get; } = FSharpGlyphHelpers.ConvertTo(item.Glyph);

    public ImmutableArray<TaggedText> DisplayTaggedParts { get; } = item.DisplayTaggedParts;

    public bool DisplayFileLocation => true;

    public bool IsImplicitlyDeclared => false;

    public Document Document { get; } = item.Document;

    INavigableItem.NavigableDocument INavigableItem.Document => _navigableDocument;

    public TextSpan SourceSpan { get; } = item.SourceSpan;

    public bool IsStale => false;

    public ImmutableArray<INavigableItem> ChildItems => [];
}
