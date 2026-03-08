// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel.Composition;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editor;
using Microsoft.CodeAnalysis.Editor.Host;
using Microsoft.CodeAnalysis.Editor.Shared.Utilities;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.Options;
using Microsoft.CodeAnalysis.Shared.TestHooks;
using Microsoft.CodeAnalysis.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.InheritanceMargin;

[Export(typeof(IWpfTextViewMarginProvider))]
[ContentType(ContentTypeNames.CSharpContentType)]
[ContentType(ContentTypeNames.VisualBasicContentType)]
[Name(nameof(InheritanceMarginViewMarginProvider))]
// Place our margin inside Left Selection Margin Container. And keep it to the left-most location.
[MarginContainer(PredefinedMarginNames.LeftSelection)]
[Order(After = DefaultOrderings.Lowest)]
[TextViewRole(PredefinedTextViewRoles.Document)]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class InheritanceMarginViewMarginProvider(
    VisualStudioWorkspace workspace,
    IThreadingContext threadingContext,
    IStreamingFindUsagesPresenter streamingFindUsagesPresenter,
    ClassificationTypeMap classificationTypeMap,
    IClassificationFormatMapService classificationFormatMapService,
    IUIThreadOperationExecutor operationExecutor,
    IViewTagAggregatorFactoryService tagAggregatorFactoryService,
    IEditorFormatMapService editorFormatMapService,
    IGlobalOptionService globalOptions,
    IAsynchronousOperationListenerProvider listenerProvider) : IWpfTextViewMarginProvider
{
    private readonly Workspace _workspace = workspace;
    private readonly IViewTagAggregatorFactoryService _tagAggregatorFactoryService = tagAggregatorFactoryService;
    private readonly IThreadingContext _threadingContext = threadingContext;
    private readonly IStreamingFindUsagesPresenter _streamingFindUsagesPresenter = streamingFindUsagesPresenter;
    private readonly IClassificationFormatMapService _classificationFormatMapService = classificationFormatMapService;
    private readonly ClassificationTypeMap _classificationTypeMap = classificationTypeMap;
    private readonly IUIThreadOperationExecutor _operationExecutor = operationExecutor;
    private readonly IEditorFormatMapService _editorFormatMapService = editorFormatMapService;
    private readonly IAsynchronousOperationListenerProvider _listenerProvider = listenerProvider;
    private readonly IGlobalOptionService _globalOptions = globalOptions;

    public IWpfTextViewMargin? CreateMargin(IWpfTextViewHost wpfTextViewHost, IWpfTextViewMargin marginContainer)
    {
        var textView = wpfTextViewHost.TextView;
        var tagAggregator = _tagAggregatorFactoryService.CreateTagAggregator<InheritanceMarginTag>(textView);
        var editorFormatMap = _editorFormatMapService.GetEditorFormatMap(textView);

        var document = wpfTextViewHost.TextView.TextBuffer.CurrentSnapshot.GetOpenDocumentInCurrentContextWithChanges();
        if (document == null)
        {
            return null;
        }

        var listener = _listenerProvider.GetListener(FeatureAttribute.InheritanceMargin);
        return new InheritanceMarginViewMargin(
            _workspace,
            textView,
            _threadingContext,
            _streamingFindUsagesPresenter,
            _operationExecutor,
            _classificationFormatMapService.GetClassificationFormatMap("tooltip"),
            _classificationTypeMap,
            tagAggregator,
            editorFormatMap,
            _globalOptions,
            listener,
            document.Project.Language);
    }
}
