// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.ComponentModel.Composition;
using Microsoft.CodeAnalysis.Editor.Shared.Utilities;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace Microsoft.CodeAnalysis.Editor.Implementation.IntelliSense.SignatureHelp.Presentation;

[Export(typeof(IClassifierProvider))]
[ContentType(ContentTypeNames.CSharpSignatureHelpContentType)]
[ContentType(ContentTypeNames.VisualBasicSignatureHelpContentType)]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed partial class SignatureHelpClassifierProvider(ClassificationTypeMap typeMap) : IClassifierProvider
{
    private readonly ClassificationTypeMap _typeMap = typeMap;

    public IClassifier GetClassifier(ITextBuffer subjectBuffer)
    {
        return subjectBuffer.Properties.GetOrCreateSingletonProperty<IClassifier>(
            () => new SignatureHelpClassifier(subjectBuffer, _typeMap));
    }
}
