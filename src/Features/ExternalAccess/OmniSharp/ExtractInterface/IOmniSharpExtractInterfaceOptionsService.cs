// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.ExternalAccess.OmniSharp.ExtractInterface;

internal interface IOmniSharpExtractInterfaceOptionsService
{
    // OmniSharp only uses these two arguments from the full IExtractInterfaceOptionsService
    OmniSharpExtractInterfaceOptionsResult GetExtractInterfaceOptions(
        List<ISymbol> extractableMembers,
        string defaultInterfaceName);
}

internal class OmniSharpExtractInterfaceOptionsResult(bool isCancelled, ImmutableArray<ISymbol> includedMembers, string interfaceName, string fileName, OmniSharpExtractInterfaceOptionsResult.OmniSharpExtractLocation location)
{
    public enum OmniSharpExtractLocation
    {
        SameFile,
        NewFile
    }

    public bool IsCancelled { get; } = isCancelled;
    public ImmutableArray<ISymbol> IncludedMembers { get; } = includedMembers;
    public string InterfaceName { get; } = interfaceName;
    public string FileName { get; } = fileName;
    public OmniSharpExtractLocation Location { get; } = location;
}
