// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Windows.Media;
using Microsoft.VisualStudio.Language.CallHierarchy;

namespace Microsoft.CodeAnalysis.Editor.Implementation.CallHierarchy;

internal sealed class FieldInitializerItem(string name, string sortText, ImageSource displayGlyph, IEnumerable<CallHierarchyDetail> details) : ICallHierarchyNameItem
{
    public IEnumerable<ICallHierarchyItemDetails> Details { get; } = details;

    public ImageSource DisplayGlyph { get; } = displayGlyph;

    public string Name { get; } = name;

    public string SortText { get; } = sortText;
}
