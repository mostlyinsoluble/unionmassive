// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Composition;
using Microsoft.CodeAnalysis.Editor.Shared.Utilities;
using Microsoft.CodeAnalysis.Editor.Undo;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text.Operations;
using Microsoft.VisualStudio.TextManager.Interop;

namespace Microsoft.VisualStudio.LanguageServices.Implementation;

using Workspace = Microsoft.CodeAnalysis.Workspace;

/// <summary>
/// A service that provide a way to undo operations applied to the workspace
/// </summary>
[ExportWorkspaceServiceFactory(typeof(IGlobalUndoService), ServiceLayer.Host), Shared]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed partial class GlobalUndoServiceFactory(
    IThreadingContext threadingContext,
    ITextUndoHistoryRegistry undoHistoryRegistry,
    SVsServiceProvider serviceProvider,
    Lazy<VisualStudioWorkspace> workspace) : IWorkspaceServiceFactory
{
    private readonly GlobalUndoService _singleton = new GlobalUndoService(threadingContext, undoHistoryRegistry, serviceProvider, workspace);

    public IWorkspaceService CreateService(HostWorkspaceServices workspaceServices)
        => _singleton;

    private sealed class GlobalUndoService(IThreadingContext threadingContext, ITextUndoHistoryRegistry undoHistoryRegistry, SVsServiceProvider serviceProvider, Lazy<VisualStudioWorkspace> lazyVSWorkspace) : IGlobalUndoService
    {
        private readonly IThreadingContext _threadingContext = threadingContext;
        private readonly ITextUndoHistoryRegistry _undoHistoryRegistry = undoHistoryRegistry;
        private readonly IVsLinkedUndoTransactionManager _undoManager = (IVsLinkedUndoTransactionManager)serviceProvider.GetService(typeof(SVsLinkedUndoTransactionManager));
        private readonly Lazy<VisualStudioWorkspace> _lazyVSWorkspace = lazyVSWorkspace;
        internal int ActiveTransactions;

        public bool CanUndo(Workspace workspace)
        {
            // only primary workspace supports global undo
            return _lazyVSWorkspace.Value == workspace;
        }

        public IWorkspaceGlobalUndoTransaction OpenGlobalUndoTransaction(Workspace workspace, string description)
        {
            if (!CanUndo(workspace))
            {
                throw new ArgumentException(ServicesVSResources.given_workspace_doesn_t_support_undo);
            }

            var transaction = new WorkspaceUndoTransaction(_threadingContext, _undoHistoryRegistry, _undoManager, workspace, description, this);
            ActiveTransactions++;
            return transaction;
        }

        public bool IsGlobalTransactionOpen(Workspace workspace)
            => ActiveTransactions > 0;
    }
}
