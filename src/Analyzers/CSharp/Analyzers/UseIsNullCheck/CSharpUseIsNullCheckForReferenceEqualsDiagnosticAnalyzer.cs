// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.LanguageService;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.LanguageService;
using Microsoft.CodeAnalysis.UseIsNullCheck;

namespace Microsoft.CodeAnalysis.CSharp.UseIsNullCheck;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
internal sealed class CSharpUseIsNullCheckForReferenceEqualsDiagnosticAnalyzer : AbstractUseIsNullCheckForReferenceEqualsDiagnosticAnalyzer<SyntaxKind>
{
    public CSharpUseIsNullCheckForReferenceEqualsDiagnosticAnalyzer()
        : base(CSharpAnalyzersResources.Use_is_null_check)
    {
    }

    protected override ISyntaxFacts GetSyntaxFacts()
        => CSharpSyntaxFacts.Instance;
}
