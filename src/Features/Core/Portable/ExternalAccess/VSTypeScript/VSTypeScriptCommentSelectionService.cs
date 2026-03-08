// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Composition;
using Microsoft.CodeAnalysis.CommentSelection;
using Microsoft.CodeAnalysis.Host.Mef;

namespace Microsoft.CodeAnalysis.ExternalAccess.VSTypeScript;

[ExportLanguageService(typeof(ICommentSelectionService), InternalLanguageNames.TypeScript), Shared]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class VSTypeScriptCommentSelectionService() : ICommentSelectionService
{
    public CommentSelectionInfo GetInfo()
        => new(
            supportsSingleLineComment: true,
            supportsBlockComment: true,
            singleLineCommentString: "//",
            blockCommentStartString: "/*",
            blockCommentEndString: "*/");
}
