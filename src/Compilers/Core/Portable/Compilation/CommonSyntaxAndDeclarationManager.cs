// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis
{
    internal abstract class CommonSyntaxAndDeclarationManager(
        ImmutableArray<SyntaxTree> externalSyntaxTrees,
        string scriptClassName,
        SourceReferenceResolver resolver,
        CommonMessageProvider messageProvider,
        bool isSubmission)
    {
        internal readonly ImmutableArray<SyntaxTree> ExternalSyntaxTrees = externalSyntaxTrees;
        internal readonly string ScriptClassName = scriptClassName ?? "";
        internal readonly SourceReferenceResolver Resolver = resolver;
        internal readonly CommonMessageProvider MessageProvider = messageProvider;
        internal readonly bool IsSubmission = isSubmission;
    }
}
