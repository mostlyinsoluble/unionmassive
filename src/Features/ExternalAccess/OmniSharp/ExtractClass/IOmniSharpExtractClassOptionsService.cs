// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.ExternalAccess.OmniSharp.ExtractClass;

internal interface IOmniSharpExtractClassOptionsService
{
    OmniSharpExtractClassOptions? GetExtractClassOptions(Document document, INamedTypeSymbol originalType, ImmutableArray<ISymbol> selectedMembers);
}

internal sealed class OmniSharpExtractClassOptions(
    string fileName,
    string typeName,
    bool sameFile,
    ImmutableArray<OmniSharpExtractClassMemberAnalysisResult> memberAnalysisResults)
{
    public string FileName { get; } = fileName;
    public string TypeName { get; } = typeName;
    public bool SameFile { get; } = sameFile;
    public ImmutableArray<OmniSharpExtractClassMemberAnalysisResult> MemberAnalysisResults { get; } = memberAnalysisResults;
}
internal sealed class OmniSharpExtractClassMemberAnalysisResult(
    ISymbol member,
    bool makeAbstract)
{
    /// <summary>
    /// The member needs to be pulled up.
    /// </summary>
    public ISymbol Member { get; } = member;

    /// <summary>
    /// Whether to make the member abstract when added to the new class
    /// </summary>
    public bool MakeAbstract { get; } = makeAbstract;
}
