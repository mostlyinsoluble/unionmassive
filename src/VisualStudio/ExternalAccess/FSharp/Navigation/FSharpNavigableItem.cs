// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.ExternalAccess.FSharp.Navigation;

internal class FSharpNavigableItem(FSharpGlyph glyph, ImmutableArray<TaggedText> displayTaggedParts, Document document, TextSpan sourceSpan)
{
    public FSharpGlyph Glyph { get; } = glyph;

    public ImmutableArray<TaggedText> DisplayTaggedParts { get; } = displayTaggedParts;

    public Document Document { get; } = document;

    public TextSpan SourceSpan { get; } = sourceSpan;
}
