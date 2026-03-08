// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Design;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.VisualStudio.Shell;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.SolutionExplorer;

[Export(typeof(IAnalyzerNodeSetup))]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class AnalyzerNodeSetup(
    AnalyzerItemsTracker analyzerTracker,
    AnalyzersCommandHandler analyzerCommandHandler) : IAnalyzerNodeSetup
{
    private readonly AnalyzerItemsTracker _analyzerTracker = analyzerTracker;
    private readonly AnalyzersCommandHandler _analyzerCommandHandler = analyzerCommandHandler;

    public async Task InitializeAsync(IAsyncServiceProvider serviceProvider, CancellationToken cancellationToken)
    {
        await _analyzerTracker.RegisterAsync(serviceProvider, cancellationToken).ConfigureAwait(false);
        await _analyzerCommandHandler.InitializeAsync(
            await serviceProvider.GetServiceAsync<IMenuCommandService, IMenuCommandService>(throwOnFailure: false, cancellationToken).ConfigureAwait(false),
            cancellationToken).ConfigureAwait(false);
    }

    public void Unregister()
    {
        _analyzerTracker.Unregister();
    }
}
