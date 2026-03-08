// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Threading.Tasks;
using Microsoft.CodeAnalysis.ErrorReporting;
using Microsoft.CodeAnalysis.Navigation;
using Microsoft.CodeAnalysis.Shared.TestHooks;
using Microsoft.CodeAnalysis.Text;
using Microsoft.VisualStudio.Language.CallHierarchy;
using Microsoft.VisualStudio.LanguageServices;

namespace Microsoft.CodeAnalysis.Editor.Implementation.CallHierarchy;

internal sealed class CallHierarchyDetail(
    CallHierarchyProvider provider,
    Location location,
    Workspace workspace) : ICallHierarchyItemDetails
{
    private readonly CallHierarchyProvider _provider = provider;
    private readonly TextSpan _span = location.SourceSpan;
    private readonly DocumentId _documentId = workspace.CurrentSolution.GetDocumentId(location.SourceTree);
    private readonly Workspace _workspace = workspace;

    private static string ComputeText(Location location)
    {
        var lineSpan = location.GetLineSpan();
        var start = location.SourceTree.GetText().Lines[lineSpan.StartLinePosition.Line].Start;
        var end = location.SourceTree.GetText().Lines[lineSpan.EndLinePosition.Line].End;
        return location.SourceTree.GetText().GetSubText(TextSpan.FromBounds(start, end)).ToString();
    }

    public string File { get; } = location.SourceTree.FilePath;
    public string Text { get; } = ComputeText(location);
    public bool SupportsNavigateTo => true;

    public int EndColumn { get; } = location.GetLineSpan().Span.End.Character;
    public int EndLine { get; } = location.GetLineSpan().EndLinePosition.Line;
    public int StartColumn { get; } = location.GetLineSpan().StartLinePosition.Character;
    public int StartLine { get; } = location.GetLineSpan().StartLinePosition.Line;

    public void NavigateTo()
    {
        var token = _provider.AsyncListener.BeginAsyncOperation(nameof(NavigateTo));
        NavigateToAsync().ReportNonFatalErrorAsync().CompletesAsyncOperation(token);
    }

    private async Task NavigateToAsync()
    {
        using var context = _provider.ThreadOperationExecutor.BeginExecute(
            EditorFeaturesResources.Call_Hierarchy, ServicesVSResources.Navigating, allowCancellation: true, showProgress: false);

        var solution = _workspace.CurrentSolution;
        var document = solution.GetDocument(_documentId);

        if (document == null)
            return;

        var navigator = _workspace.Services.GetService<IDocumentNavigationService>();
        await navigator.TryNavigateToSpanAsync(
            _provider.ThreadingContext, _workspace, document.Id, _span,
            new NavigationOptions(PreferProvisionalTab: true, ActivateTab: false),
            context.UserCancellationToken).ConfigureAwait(false);
    }
}
