// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Host.Mef;

internal sealed class OrderableLanguageDocumentMetadata(string name, string language, TextDocumentKind documentKind, string documentExtension, IEnumerable<string> after, IEnumerable<string> before) : OrderableLanguageMetadata(name, language, after, before)
{
    public TextDocumentKind DocumentKind { get; } = documentKind;
    public string DocumentExtension { get; } = documentExtension;
}
