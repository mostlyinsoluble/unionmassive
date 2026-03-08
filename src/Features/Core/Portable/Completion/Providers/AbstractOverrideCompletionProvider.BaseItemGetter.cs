// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Shared.Extensions;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Completion.Providers;

internal abstract partial class AbstractMemberInsertingCompletionProvider
{
    protected abstract class AbstractItemGetter<TProvider>(
        TProvider provider,
        Document document,
        int position,
        SourceText text,
        SyntaxTree syntaxTree,
        int startLineNumber,
        CancellationToken cancellationToken)
        where TProvider : AbstractMemberInsertingCompletionProvider
    {
        protected static readonly SymbolDisplayFormat DefaultNameFormat = SymbolDisplayFormats.NameFormat
            .WithParameterOptions(
                SymbolDisplayParameterOptions.IncludeDefaultValue |
                SymbolDisplayParameterOptions.IncludeExtensionThis |
                SymbolDisplayParameterOptions.IncludeType |
                SymbolDisplayParameterOptions.IncludeName |
                SymbolDisplayParameterOptions.IncludeParamsRefOut)
            .AddMiscellaneousOptions(SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier);

        protected readonly CancellationToken CancellationToken = cancellationToken;
        protected readonly int Position = position;
        protected readonly TProvider Provider = provider;

        protected readonly Document Document = document;
        protected readonly SourceText Text = text;
        protected readonly SyntaxTree SyntaxTree = syntaxTree;
        protected readonly int StartLineNumber = startLineNumber;

        public abstract Task<ImmutableArray<CompletionItem>> GetItemsAsync();

        protected bool IsOnStartLine(int position)
            => Text.Lines.IndexOf(position) == StartLineNumber;
    }
}
