// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Composition;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.LanguageServer;
using Microsoft.CodeAnalysis.LanguageServer.Handler;
using LSP = Roslyn.LanguageServer.Protocol;

namespace Microsoft.CodeAnalysis.ExternalAccess.Xaml;

[ExportCSharpVisualBasicLspServiceFactory(typeof(OnInitializedService)), Shared]
[method: ImportingConstructor]
[method: Obsolete(StringConstants.ImportingConstructorMessage, error: true)]
internal sealed class OnInitializedServiceFactory(
    [Import(AllowDefault = true)] IInitializationService? initializationService,
    [Import(AllowDefault = true)] IOnInitializedService? onInitializedService) : ILspServiceFactory
{
#pragma warning disable CS0618 // Type or member is obsolete
    private readonly IInitializationService? _initializationService = initializationService;
#pragma warning restore CS0618 // Type or member is obsolete
    private readonly IOnInitializedService? _onInitializedService = onInitializedService;

    public ILspService CreateILspService(LspServices lspServices, WellKnownLspServerKinds serverKind)
    {
        var clientLanguageServerManager = lspServices.GetRequiredService<IClientLanguageServerManager>();

        return new OnInitializedService(_initializationService, _onInitializedService, clientLanguageServerManager);
    }

    private class OnInitializedService : ILspService, IOnInitialized
    {
#pragma warning disable CS0618 // Type or member is obsolete
        private readonly IInitializationService? _initializationService;
#pragma warning restore CS0618 // Type or member is obsolete
        private readonly IOnInitializedService? _onInitializedService;
        private readonly IClientLanguageServerManager _clientLanguageServerManager;

#pragma warning disable CS0618 // Type or member is obsolete
        public OnInitializedService(IInitializationService? initializationService, IOnInitializedService? onInitializedService, IClientLanguageServerManager clientLanguageServerManager)
#pragma warning restore CS0618 // Type or member is obsolete
        {
            _initializationService = initializationService;
            _onInitializedService = onInitializedService;
            _clientLanguageServerManager = clientLanguageServerManager;
        }

        public async Task OnInitializedAsync(LSP.ClientCapabilities clientCapabilities, RequestContext context, CancellationToken cancellationToken)
        {
            if (_initializationService is not null)
            {
                await _initializationService.OnInitializedAsync(new ClientRequestManager(_clientLanguageServerManager), new ClientCapabilityProvider(clientCapabilities), cancellationToken).ConfigureAwait(false);
            }

            if (_onInitializedService is not null)
            {
                await _onInitializedService.OnInitializedAsync(new ClientRequestManager(_clientLanguageServerManager), clientCapabilities, cancellationToken).ConfigureAwait(false);
            }
        }

        private class ClientRequestManager(IClientLanguageServerManager clientLanguageServerManager) : IClientRequestManager
        {
            private readonly IClientLanguageServerManager _clientLanguageServerManager = clientLanguageServerManager;

            public Task<TResponse> SendRequestAsync<TParams, TResponse>(string methodName, TParams @params, CancellationToken cancellationToken)
                => _clientLanguageServerManager.SendRequestAsync<TParams, TResponse>(methodName, @params, cancellationToken);

            public ValueTask SendRequestAsync(string methodName, CancellationToken cancellationToken)
                => _clientLanguageServerManager.SendRequestAsync(methodName, cancellationToken);

            public ValueTask SendRequestAsync<TParams>(string methodName, TParams @params, CancellationToken cancellationToken)
                => _clientLanguageServerManager.SendRequestAsync<TParams>(methodName, @params, cancellationToken);
        }
    }
}
