// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Composition;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeActions.WorkspaceServices;
using Microsoft.CodeAnalysis.Host.Mef;

namespace Microsoft.CodeAnalysis.Editor.UnitTests.Workspaces;

[ExportWorkspaceService(typeof(IAddMetadataReferenceCodeActionOperationFactoryWorkspaceService), ServiceLayer.Test), Shared, PartNotDiscoverable]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
public sealed class TestAddMetadataReferenceCodeActionOperationFactoryWorkspaceService() : IAddMetadataReferenceCodeActionOperationFactoryWorkspaceService
{
    public CodeActionOperation CreateAddMetadataReferenceOperation(ProjectId projectId, AssemblyIdentity assemblyIdentity)
        => new Operation(projectId, assemblyIdentity);

    public class Operation(ProjectId projectId, AssemblyIdentity assemblyIdentity) : CodeActionOperation
    {
        public readonly ProjectId ProjectId = projectId;
        public readonly AssemblyIdentity AssemblyIdentity = assemblyIdentity;
    }
}
