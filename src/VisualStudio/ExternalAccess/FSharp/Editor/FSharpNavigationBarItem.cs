// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.Text;
using Microsoft.VisualStudio.Text;

namespace Microsoft.CodeAnalysis.ExternalAccess.FSharp.Editor;

internal class FSharpNavigationBarItem(
    string text,
    FSharpGlyph glyph,
    IList<TextSpan> spans,
    IList<FSharpNavigationBarItem> childItems = null,
    int indent = 0,
    bool bolded = false,
    bool grayed = false)
{
    public string Text { get; } = text;
    public FSharpGlyph Glyph { get; } = glyph;
    public bool Bolded { get; } = bolded;
    public bool Grayed { get; } = grayed;
    public int Indent { get; } = indent;
    public IList<FSharpNavigationBarItem> ChildItems { get; } = childItems ?? SpecializedCollections.EmptyList<FSharpNavigationBarItem>();

    public IList<TextSpan> Spans { get; internal set; } = spans;
    internal IList<ITrackingSpan> TrackingSpans { get; set; }
}
