// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.ComponentModel.Composition;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.VisualStudio.LanguageServices.ExternalAccess.VSTypeScript.Api;

namespace Microsoft.VisualStudio.LanguageServices.LiveShare.Client.ExternalAccess.VSTypeScript;

[Export(typeof(IVsTypeScriptRemoteLanguageServiceWorkspaceAccessor))]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class VSTypeScriptRemoteLanguageServiceWorkspaceAccessor(RemoteLanguageServiceWorkspace remoteLanguageServiceWorkspace) : IVsTypeScriptRemoteLanguageServiceWorkspaceAccessor
{
    private readonly RemoteLanguageServiceWorkspace _remoteLanguageServiceWorkspace = remoteLanguageServiceWorkspace;

    CodeAnalysis.Workspace IVsTypeScriptRemoteLanguageServiceWorkspaceAccessor.RemoteLanguageServiceWorkspace => _remoteLanguageServiceWorkspace;
}
