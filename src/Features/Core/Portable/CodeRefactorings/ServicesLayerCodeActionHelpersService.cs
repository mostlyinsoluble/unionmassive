// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Composition;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Host.Mef;

namespace Microsoft.CodeAnalysis.CodeRefactorings;

[ExportWorkspaceServiceFactory(typeof(ICodeRefactoringHelpersService), ServiceLayer.Default), Shared]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class ServicesLayerCodeActionHelpersService() : IWorkspaceServiceFactory
{
    public IWorkspaceService CreateService(HostWorkspaceServices workspaceServices)
        => new CodeActionHelpersService();

    private sealed class CodeActionHelpersService : ICodeRefactoringHelpersService
    {
        public bool ActiveInlineRenameSession => false;
    }
}
