// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Composition;
using Microsoft.CodeAnalysis.AddPackage;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Host.Mef;

namespace Microsoft.CodeAnalysis.CSharp.AddPackage;

[ExportCodeFixProvider(LanguageNames.CSharp, Name = PredefinedCodeFixProviderNames.AddPackage), Shared]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class CSharpAddSpecificPackageCodeFixProvider() : AbstractAddSpecificPackageCodeFixProvider
{
    private const string CS8179 = nameof(CS8179); // Predefined type 'System.ValueTuple`2' is not defined or imported

    public override ImmutableArray<string> FixableDiagnosticIds
        => [CS8179];

    protected override string GetAssemblyName(string id)
    {
        return id switch
        {
            CS8179 => "System.ValueTuple",
            _ => null,
        };
    }
}
