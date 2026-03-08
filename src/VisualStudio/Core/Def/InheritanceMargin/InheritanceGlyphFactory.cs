// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editor.Host;
using Microsoft.CodeAnalysis.Editor.Shared.Utilities;
using Microsoft.CodeAnalysis.InheritanceMargin;
using Microsoft.CodeAnalysis.Options;
using Microsoft.CodeAnalysis.Shared.TestHooks;
using Microsoft.CodeAnalysis.Text;
using Microsoft.VisualStudio.LanguageServices.Implementation.InheritanceMargin.MarginGlyph;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Formatting;
using Microsoft.VisualStudio.Utilities;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.InheritanceMargin;

/// <summary>
/// GlyphFactory provides the InheritanceMargin shows in IndicatorMargin. (Margin shared with breakpoint)
/// </summary>
internal sealed class InheritanceGlyphFactory(
    Workspace workspace,
    IThreadingContext threadingContext,
    IStreamingFindUsagesPresenter streamingFindUsagesPresenter,
    ClassificationTypeMap classificationTypeMap,
    IClassificationFormatMap classificationFormatMap,
    IUIThreadOperationExecutor operationExecutor,
    IWpfTextView textView,
    IGlobalOptionService globalOptions,
    IAsynchronousOperationListener listener) : IGlyphFactory
{
    private readonly Workspace _workspace = workspace;
    private readonly IThreadingContext _threadingContext = threadingContext;
    private readonly IStreamingFindUsagesPresenter _streamingFindUsagesPresenter = streamingFindUsagesPresenter;
    private readonly ClassificationTypeMap _classificationTypeMap = classificationTypeMap;
    private readonly IClassificationFormatMap _classificationFormatMap = classificationFormatMap;
    private readonly IUIThreadOperationExecutor _operationExecutor = operationExecutor;
    private readonly IWpfTextView _textView = textView;
    private readonly IAsynchronousOperationListener _listener = listener;
    private readonly IGlobalOptionService _globalOptions = globalOptions;

    public UIElement? GenerateGlyph(IWpfTextViewLine line, IGlyphTag tag)
    {
        if (tag is not InheritanceMarginTag inheritanceMarginTag)
        {
            return null;
        }

        // The life cycle of the glyphs in Indicator Margin is controlled by the editor,
        // so in order to get the glyphs removed when FeatureOnOffOptions.InheritanceMarginCombinedWithIndicatorMargin is off,
        // we need
        // 1. Generate tags when this option changes.
        // 2. Always return null here to force the editor to remove the glyphs.
        if (!_globalOptions.GetOption(InheritanceMarginOptionsStorage.InheritanceMarginCombinedWithIndicatorMargin))
        {
            return null;
        }

        if (_textView.TextBuffer.GetWorkspace() == null)
        {
            return null;
        }

        var membersOnLine = inheritanceMarginTag.MembersOnLine;
        Contract.ThrowIfTrue(membersOnLine.IsEmpty);
        return new InheritanceMarginGlyph(
            _workspace,
            _threadingContext,
            _streamingFindUsagesPresenter,
            _classificationTypeMap,
            _classificationFormatMap,
            _operationExecutor,
            inheritanceMarginTag,
            _textView,
            _listener);
    }
}
