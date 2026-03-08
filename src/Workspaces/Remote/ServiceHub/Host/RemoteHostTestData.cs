// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.Remote;

/// <summary>
/// Test hook used to pass test data to remote services.
/// </summary>
internal sealed class RemoteHostTestData(RemoteWorkspaceManager workspaceManager, bool isInProc)
{
    public readonly RemoteWorkspaceManager WorkspaceManager = workspaceManager;
    public readonly bool IsInProc = isInProc;
}
