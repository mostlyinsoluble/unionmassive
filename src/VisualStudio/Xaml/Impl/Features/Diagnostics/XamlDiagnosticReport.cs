// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.VisualStudio.LanguageServices.Xaml.Features.Diagnostics;

internal sealed class XamlDiagnosticReport(string? resultId = null, ImmutableArray<XamlDiagnostic>? diagnostics = null)
{
    public string? ResultId { get; set; } = resultId;
    public ImmutableArray<XamlDiagnostic>? Diagnostics { get; set; } = diagnostics;
}
