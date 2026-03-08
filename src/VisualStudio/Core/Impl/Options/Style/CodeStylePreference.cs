// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.VisualStudio.LanguageServices.Implementation.Options;

/// <summary>
/// Represents a single code style choice.
/// Typically, a code style offers a list of choices to choose from.
/// </summary>
internal sealed class CodeStylePreference(string name, bool isChecked)
{
    public string Name { get; set; } = name;
    public bool IsChecked { get; set; } = isChecked;
}
