// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Threading;
using Microsoft.CodeAnalysis.SignatureHelp;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Text;

namespace Microsoft.CodeAnalysis.Editor.Implementation.IntelliSense.SignatureHelp.Presentation;

internal sealed class Parameter(
    Signature signature,
    SignatureHelpParameter parameter,
    string content,
    int index,
    int prettyPrintedIndex) : IParameter
{
    private readonly SignatureHelpParameter _parameter = parameter;
    private string _documentation;
    private readonly int _contentLength = content.Length;
    private readonly int _index = index;
    private readonly int _prettyPrintedIndex = prettyPrintedIndex;

    public string Documentation => _documentation ??= _parameter.DocumentationFactory(CancellationToken.None).GetFullText();
    public string Name => _parameter.Name;
    public Span Locus => new(_index, _contentLength);
    public Span PrettyPrintedLocus => new(_prettyPrintedIndex, _contentLength);
    public ISignature Signature { get; } = signature;
}
