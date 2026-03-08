// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Composition;
using Microsoft.CodeAnalysis.Editor;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Utilities;

namespace Microsoft.CodeAnalysis.Text.Implementation.TextBufferFactoryService;

[Export(typeof(ITextBufferCloneService)), Shared]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class TextBufferCloneService(
    ITextBufferFactoryService3 textBufferFactoryService,
    IContentTypeRegistryService contentTypeRegistryService) : ITextBufferCloneService
{
    private readonly ITextBufferFactoryService3 _textBufferFactoryService = textBufferFactoryService;
    private readonly IContentType _roslynContentType = contentTypeRegistryService.GetContentType(ContentTypeNames.RoslynContentType);
    private readonly IContentType _unknownContentType = contentTypeRegistryService.UnknownContentType;

    public ITextBuffer CloneWithUnknownContentType(SnapshotSpan span)
        => _textBufferFactoryService.CreateTextBuffer(span, _unknownContentType);

    public ITextBuffer CloneWithUnknownContentType(ITextImage textImage)
        => Clone(textImage, _unknownContentType);

    public ITextBuffer CloneWithRoslynContentType(SourceText sourceText)
        => Clone(sourceText, _roslynContentType);

    public ITextBuffer Clone(SourceText sourceText, IContentType contentType)
    {
        // see whether we can do it cheaply
        var textImage = sourceText.TryFindCorrespondingEditorTextImage();
        if (textImage != null)
        {
            return Clone(textImage, contentType);
        }

        // we can't, so do it more expensive way
        return _textBufferFactoryService.CreateTextBuffer(sourceText.ToString(), contentType);
    }

    private ITextBuffer Clone(ITextImage textImage, IContentType contentType)
        => _textBufferFactoryService.CreateTextBuffer(textImage, contentType);
}
