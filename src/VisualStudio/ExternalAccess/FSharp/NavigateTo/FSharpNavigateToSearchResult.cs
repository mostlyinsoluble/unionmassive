// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.ExternalAccess.FSharp.Navigation;

namespace Microsoft.CodeAnalysis.ExternalAccess.FSharp.NavigateTo;

internal class FSharpNavigateToSearchResult(
    string additionalInformation,
    string kind,
    FSharpNavigateToMatchKind matchKind,
    string name,
    FSharpNavigableItem navigateItem)
{
    public string AdditionalInformation { get; } = additionalInformation;

    public string Kind { get; } = kind;

    public FSharpNavigateToMatchKind MatchKind { get; } = matchKind;

    public string Name { get; } = name;

    public FSharpNavigableItem NavigableItem { get; } = navigateItem;
}
