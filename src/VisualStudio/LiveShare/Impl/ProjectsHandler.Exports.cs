// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.ComponentModel.Composition;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.VisualStudio.LanguageServices.LiveShare.CustomProtocol;
using Microsoft.VisualStudio.LiveShare.LanguageServices;

namespace Microsoft.VisualStudio.LanguageServices.LiveShare;

[ExportLspRequestHandler(LiveShareConstants.RoslynContractName, RoslynMethods.ProjectsName)]
[Obsolete("Used for backwards compatibility with old liveshare clients.")]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class RoslynProjectsHandler() : ProjectsHandler
{
}

[ExportLspRequestHandler(LiveShareConstants.CSharpContractName, RoslynMethods.ProjectsName)]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class CSharpProjectsHandler() : ProjectsHandler
{
}

[ExportLspRequestHandler(LiveShareConstants.VisualBasicContractName, RoslynMethods.ProjectsName)]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class VisualBasicProjectsHandler() : ProjectsHandler
{
}

[ExportLspRequestHandler(LiveShareConstants.TypeScriptContractName, RoslynMethods.ProjectsName)]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class TypeScriptProjectsHandler() : ProjectsHandler
{
}
