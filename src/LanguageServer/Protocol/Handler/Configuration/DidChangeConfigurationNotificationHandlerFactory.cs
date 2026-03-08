// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Composition;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.Options;
using Microsoft.CommonLanguageServerProtocol.Framework;

namespace Microsoft.CodeAnalysis.LanguageServer.Handler.Configuration;

[ExportCSharpVisualBasicLspServiceFactory(typeof(DidChangeConfigurationNotificationHandler)), Shared]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class DidChangeConfigurationNotificationHandlerFactory(
    IGlobalOptionService globalOptionService) : ILspServiceFactory
{
    private readonly IGlobalOptionService _globalOptionService = globalOptionService;

    public ILspService CreateILspService(LspServices lspServices, WellKnownLspServerKinds serverKind)
    {
        var clientManager = lspServices.GetRequiredService<IClientLanguageServerManager>();
        var lspLogger = lspServices.GetRequiredService<AbstractLspLogger>();
        return new DidChangeConfigurationNotificationHandler(lspLogger, _globalOptionService, clientManager);
    }
}
