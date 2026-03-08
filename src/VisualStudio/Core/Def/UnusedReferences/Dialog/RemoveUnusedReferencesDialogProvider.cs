// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Composition;
using Microsoft.CodeAnalysis.Host.Mef;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.UnusedReferences.Dialog;

[Export(typeof(RemoveUnusedReferencesDialogProvider)), Shared]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class RemoveUnusedReferencesDialogProvider(UnusedReferencesTableProvider tableProvider)
{
    private readonly UnusedReferencesTableProvider _tableProvider = tableProvider;

    public RemoveUnusedReferencesDialog CreateDialog() => new(_tableProvider);
}
