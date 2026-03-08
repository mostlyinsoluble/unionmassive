// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Composition;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeActions.WorkspaceServices;
using Microsoft.CodeAnalysis.ExternalAccess.OmniSharp.CodeRefactorings.WorkspaceServices;
using Microsoft.CodeAnalysis.Host.Mef;

namespace Microsoft.CodeAnalysis.ExternalAccess.OmniSharp.Internal.CodeRefactorings.WorkspaceServices;

[Shared]
[ExportWorkspaceService(typeof(ISymbolRenamedCodeActionOperationFactoryWorkspaceService))]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class OmniSharpSymbolRenamedCodeActionOperationFactoryWorkspaceService(IOmniSharpSymbolRenamedCodeActionOperationFactoryWorkspaceService service) : ISymbolRenamedCodeActionOperationFactoryWorkspaceService
{
    private readonly IOmniSharpSymbolRenamedCodeActionOperationFactoryWorkspaceService _service = service;

    public CodeActionOperation CreateSymbolRenamedOperation(ISymbol symbol, string newName, Solution startingSolution, Solution updatedSolution)
    {
        return _service.CreateSymbolRenamedOperation(symbol, newName, startingSolution, updatedSolution);
    }
}
