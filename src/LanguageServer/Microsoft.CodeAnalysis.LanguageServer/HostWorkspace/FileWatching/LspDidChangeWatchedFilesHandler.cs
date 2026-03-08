// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Composition;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.LanguageServer.Handler;
using Microsoft.CommonLanguageServerProtocol.Framework;
using Roslyn.LanguageServer.Protocol;

namespace Microsoft.CodeAnalysis.LanguageServer.HostWorkspace.FileWatching;

[ExportCSharpVisualBasicStatelessLspService(typeof(LspDidChangeWatchedFilesHandler)), Shared]
[Method("workspace/didChangeWatchedFiles")]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class LspDidChangeWatchedFilesHandler() : ILspServiceNotificationHandler<DidChangeWatchedFilesParams>
{
    public bool MutatesSolutionState => false;
    public bool RequiresLSPSolution => false;

    async Task INotificationHandler<DidChangeWatchedFilesParams, RequestContext>.HandleNotificationAsync(DidChangeWatchedFilesParams request, RequestContext requestContext, CancellationToken cancellationToken)
    {
        NotificationRaised?.Invoke(this, request);
    }

    public event EventHandler<DidChangeWatchedFilesParams>? NotificationRaised;
}
