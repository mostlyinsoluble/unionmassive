// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.CodeAnalysis.Editor.Shared.Utilities;
using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Shell.Interop;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.Library;

internal abstract partial class AbstractLibraryManager(Guid libraryGuid, IComponentModel componentModel, IServiceProvider serviceProvider) : IVsCoTaskMemFreeMyStrings
{
    internal readonly Guid LibraryGuid = libraryGuid;

    public readonly IThreadingContext ThreadingContext = componentModel.GetService<IThreadingContext>();
    public readonly IComponentModel ComponentModel = componentModel;
    public readonly IServiceProvider ServiceProvider = serviceProvider;
}
