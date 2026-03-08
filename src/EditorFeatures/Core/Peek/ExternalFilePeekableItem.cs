// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.Language.Intellisense;

namespace Microsoft.CodeAnalysis.Editor.Implementation.Peek;

internal sealed class ExternalFilePeekableItem(
    FileLinePositionSpan span,
    IPeekRelationship relationship,
    IPeekResultFactory peekResultFactory) : PeekableItem(peekResultFactory)
{
    private readonly FileLinePositionSpan _span = span;
    private readonly IPeekRelationship _relationship = relationship;

    public override IEnumerable<IPeekRelationship> Relationships
        => [_relationship];

    public override IPeekResultSource GetOrCreateResultSource(string relationshipName)
        => new ResultSource(this);

    private sealed class ResultSource(ExternalFilePeekableItem peekableItem) : IPeekResultSource
    {
        private readonly ExternalFilePeekableItem _peekableItem = peekableItem;

        public void FindResults(string relationshipName, IPeekResultCollection resultCollection, CancellationToken cancellationToken, IFindPeekResultsCallback callback)
        {
            if (relationshipName != _peekableItem._relationship.Name)
            {
                return;
            }

            resultCollection.Add(PeekHelpers.CreateDocumentPeekResult(_peekableItem._span.Path, _peekableItem._span.Span, _peekableItem._span.Span, _peekableItem.PeekResultFactory));
        }
    }
}
