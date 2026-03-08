// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Composition;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Host.Mef;

namespace AnalyzerRunner
{
    [ExportWorkspaceService(typeof(IWorkspaceConfigurationService), ServiceLayer.Host), Shared]
    [method: ImportingConstructor]
    [method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
    internal sealed class AnalyzerRunnerWorkspaceConfigurationService() : IWorkspaceConfigurationService
    {
        public WorkspaceConfigurationOptions Options { get; set; } = WorkspaceConfigurationOptions.Default;
    }
}
