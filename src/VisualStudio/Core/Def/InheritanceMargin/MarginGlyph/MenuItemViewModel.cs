// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.VisualStudio.Imaging.Interop;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.InheritanceMargin.MarginGlyph;

internal abstract class MenuItemViewModel(string displayContent, ImageMoniker imageMoniker)
{
    /// <summary>
    /// Display content for the target.
    /// </summary>
    public string DisplayContent { get; } = displayContent;

    /// <summary>
    /// ImageMoniker shown in the menu.
    /// </summary>
    public ImageMoniker ImageMoniker { get; } = imageMoniker;

    /// <summary>
    /// AutomationName for the MenuItem.
    /// </summary>
    public string AutomationName { get; } = displayContent;
}
