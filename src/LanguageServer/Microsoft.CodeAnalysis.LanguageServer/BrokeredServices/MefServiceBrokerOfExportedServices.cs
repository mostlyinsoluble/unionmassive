// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Composition;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.VisualStudio.Shell.ServiceBroker;
using Microsoft.VisualStudio.Utilities.ServiceBroker;

namespace Microsoft.CodeAnalysis.LanguageServer.BrokeredServices;

[Export, Shared]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class MefServiceBrokerOfExportedServices() : ServiceBrokerOfExportedServices
{
    private Task<GlobalBrokeredServiceContainer>? _containerTask;

    public void SetContainer(GlobalBrokeredServiceContainer container)
    {
        _containerTask = Task.FromResult(container);
    }

    protected override Task<GlobalBrokeredServiceContainer> GetBrokeredServiceContainerAsync(CancellationToken cancellationToken)
    {
        Contract.ThrowIfNull(_containerTask, $"{nameof(SetContainer)} should have already been called.");
        return _containerTask;
    }
}
