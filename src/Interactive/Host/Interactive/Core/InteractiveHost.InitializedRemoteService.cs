// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Interactive
{
    internal partial class InteractiveHost
    {
        private readonly struct InitializedRemoteService(InteractiveHost.RemoteService service, RemoteExecutionResult initializationResult)
        {
            public readonly RemoteService? Service = service;
            public readonly RemoteExecutionResult InitializationResult = initializationResult;
        }
    }
}
