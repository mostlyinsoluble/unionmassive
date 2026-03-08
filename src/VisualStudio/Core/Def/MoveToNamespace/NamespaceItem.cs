// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.VisualStudio.LanguageServices.Implementation.MoveToNamespace;

internal sealed class NamespaceItem(bool isFromHistory, string @namespace)
{
    public string Namespace { get; } = @namespace;
    public bool IsFromHistory { get; } = isFromHistory;

    public override string ToString() => Namespace;
}
