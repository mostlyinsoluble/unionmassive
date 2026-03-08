// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Roslyn.Utilities;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.CodeModel;

internal readonly struct GlobalNodeKey(SyntaxNodeKey nodeKey, SyntaxPath path)
{
    public readonly SyntaxNodeKey NodeKey = nodeKey;
    public readonly SyntaxPath Path = path;
}
