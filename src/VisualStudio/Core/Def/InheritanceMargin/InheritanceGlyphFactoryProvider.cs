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
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.InheritanceMargin;

[Export(typeof(IGlyphFactoryProvider))]
[Name(nameof(InheritanceGlyphFactoryProvider))]
[ContentType(ContentTypeNames.RoslynContentType)]
[TagType(typeof(InheritanceMarginTag))]
// This would ensure the margin is clickable.
[Order(After = "VsTextMarker")]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class InheritanceGlyphFactoryProvider(
    VisualStudioWorkspace workspace,
    IThreadingContext threadingContext,
    IStreamingFindUsagesPresenter streamingFindUsagesPresenter,
    ClassificationTypeMap classificationTypeMap,
    IClassificationFormatMapService classificationFormatMapService,
    IUIThreadOperationExecutor operationExecutor,
    IGlobalOptionService globalOptions,
    IAsynchronousOperationListenerProvider listenerProvider) : IGlyphFactoryProvider
{
    private readonly Workspace _workspace = workspace;
    private readonly IThreadingContext _threadingContext = threadingContext;
    private readonly IStreamingFindUsagesPresenter _streamingFindUsagesPresenter = streamingFindUsagesPresenter;
    private readonly ClassificationTypeMap _classificationTypeMap = classificationTypeMap;
    private readonly IClassificationFormatMapService _classificationFormatMapService = classificationFormatMapService;
    private readonly IUIThreadOperationExecutor _operationExecutor = operationExecutor;
    private readonly IAsynchronousOperationListener _listener = listenerProvider.GetListener(FeatureAttribute.InheritanceMargin);
    private readonly IGlobalOptionService _globalOptions = globalOptions;

    public IGlyphFactory GetGlyphFactory(IWpfTextView view, IWpfTextViewMargin margin)
    {
        return new InheritanceGlyphFactory(
            _workspace,
            _threadingContext,
            _streamingFindUsagesPresenter,
            _classificationTypeMap,
            _classificationFormatMapService.GetClassificationFormatMap("tooltip"),
            _operationExecutor,
            view,
            _globalOptions,
            _listener);
    }
}
