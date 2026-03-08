// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Composition;

namespace Microsoft.CodeAnalysis.ExternalAccess.UnitTesting.SolutionCrawler;

[MetadataAttribute]
[AttributeUsage(AttributeTargets.Class)]
internal sealed class ExportUnitTestingIncrementalAnalyzerProviderAttribute(string name, string[] workspaceKinds) : ExportAttribute(typeof(IUnitTestingIncrementalAnalyzerProvider))
{
    public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name));
    public string[] WorkspaceKinds { get; } = workspaceKinds;
}
