// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Remote;

namespace Microsoft.CodeAnalysis.ExternalAccess.Pythia.Api;

internal sealed class PythiaRemoteServiceCallbackDispatcherRegistry(IEnumerable<(Type serviceType, PythiaRemoteServiceCallbackDispatcher dispatcher)> lazyDispatchers) : IRemoteServiceCallbackDispatcherProvider
{
    public static readonly PythiaRemoteServiceCallbackDispatcherRegistry Empty = new([]);

    private readonly ImmutableDictionary<Type, PythiaRemoteServiceCallbackDispatcher> _lazyDispatchers = lazyDispatchers.ToImmutableDictionary(e => e.serviceType, e => e.dispatcher);

    IRemoteServiceCallbackDispatcher IRemoteServiceCallbackDispatcherProvider.GetDispatcher(Type serviceType)
        => _lazyDispatchers[serviceType];
}
