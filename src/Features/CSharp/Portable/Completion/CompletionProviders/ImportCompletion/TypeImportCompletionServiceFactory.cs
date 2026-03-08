// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Composition;
using Microsoft.CodeAnalysis.Completion.Providers;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Host.Mef;

namespace Microsoft.CodeAnalysis.CSharp.Completion.Providers;

[ExportLanguageServiceFactory(typeof(ITypeImportCompletionService), LanguageNames.CSharp), Shared]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class TypeImportCompletionServiceFactory() : ILanguageServiceFactory
{
    public ILanguageService CreateLanguageService(HostLanguageServices languageServices)
        => new CSharpTypeImportCompletionService(languageServices.LanguageServices.SolutionServices);

    private sealed class CSharpTypeImportCompletionService(SolutionServices services) : AbstractTypeImportCompletionService(services)
    {
        protected override string GenericTypeSuffix
            => "<>";

        protected override bool IsCaseSensitive => true;

        protected override string Language => LanguageNames.CSharp;
    }
}
