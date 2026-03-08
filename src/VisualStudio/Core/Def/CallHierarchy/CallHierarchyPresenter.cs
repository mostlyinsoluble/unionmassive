// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.ComponentModel.Composition;
using Microsoft.CodeAnalysis.Editor.Host;
using Microsoft.CodeAnalysis.Editor.Implementation.CallHierarchy;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.VisualStudio.CallHierarchy.Package.Definitions;
using Microsoft.VisualStudio.Shell;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.CallHierarchy;

[Export(typeof(ICallHierarchyPresenter))]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class CallHierarchyPresenter(SVsServiceProvider serviceProvider) : ICallHierarchyPresenter
{
    private readonly IServiceProvider _serviceProvider = serviceProvider;

    public void PresentRoot(CallHierarchyItem root)
    {
        var callHierarchy = _serviceProvider.GetService(typeof(SCallHierarchy)) as ICallHierarchy;
        callHierarchy.ShowToolWindow();
        callHierarchy.AddRootItem(root);
    }
}
