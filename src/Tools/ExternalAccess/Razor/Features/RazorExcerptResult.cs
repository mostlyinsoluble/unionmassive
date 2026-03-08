// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Classification;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.ExternalAccess.Razor
{
    internal readonly struct RazorExcerptResult(SourceText content, TextSpan mappedSpan, ImmutableArray<ClassifiedSpan> classifiedSpans, Document document, TextSpan span)
    {
        public readonly SourceText Content = content;

        public readonly TextSpan MappedSpan = mappedSpan;

        public readonly ImmutableArray<ClassifiedSpan> ClassifiedSpans = classifiedSpans;

        public readonly Document Document = document;

        public readonly TextSpan Span = span;
    }
}
