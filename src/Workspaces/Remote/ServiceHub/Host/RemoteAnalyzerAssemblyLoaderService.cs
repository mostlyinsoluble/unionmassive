// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Composition;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Host.Mef;

namespace Microsoft.CodeAnalysis.Remote.Diagnostics;

/// <summary>
/// Customizes the path where to store shadow-copies of analyzer assemblies.
/// </summary>
[ExportWorkspaceService(typeof(IAnalyzerAssemblyLoaderProvider), [WorkspaceKind.RemoteWorkspace]), Shared]

<<<<<<< TODO: Unmerged change from project 'Microsoft.CodeAnalysis.Remote.ServiceHub (netstandard2.0)', Before:
internal sealed class RemoteAnalyzerAssemblyLoaderService : AbstractAnalyzerAssemblyLoaderProvider
{
=======
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class RemoteAnalyzerAssemblyLoaderService() : AbstractAnalyzerAssemblyLoaderProvider
{
>>>>>>> After
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class RemoteAnalyzerAssemblyLoaderService([ImportMany] IEnumerable<IAnalyzerAssemblyResolver> assemblyResolvers, [ImportMany] IEnumerable<IAnalyzerPathResolver> assemblyPathResolvers) : AbstractAnalyzerAssemblyLoaderProvider(assemblyResolvers, assemblyPathResolvers)
{

#pragma warning disable IDE02900 // primary constructor
#if NET
#else
#endif
}
