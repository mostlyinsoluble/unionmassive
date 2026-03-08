// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Composition;
using Microsoft.CodeAnalysis.Editor.Shared.Utilities;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.Shared.TestHooks;
using Microsoft.CodeAnalysis.Workspaces.ProjectSystem;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.ProjectSystem;

[ExportWorkspaceServiceFactory(typeof(IRuleSetManager), ServiceLayer.Host), Shared]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class VisualStudioRuleSetManagerFactory(
    IThreadingContext threadingContext,
    FileChangeWatcherProvider fileChangeWatcherProvider,
    IAsynchronousOperationListenerProvider listenerProvider) : IWorkspaceServiceFactory
{
    private readonly IThreadingContext _threadingContext = threadingContext;
    private readonly FileChangeWatcherProvider _fileChangeWatcherProvider = fileChangeWatcherProvider;
    private readonly IAsynchronousOperationListener _listener = listenerProvider.GetListener(FeatureAttribute.RuleSetEditor);

    public IWorkspaceService CreateService(HostWorkspaceServices workspaceServices)
        => new VisualStudioRuleSetManager(_threadingContext, _fileChangeWatcherProvider.Watcher, _listener);
}
