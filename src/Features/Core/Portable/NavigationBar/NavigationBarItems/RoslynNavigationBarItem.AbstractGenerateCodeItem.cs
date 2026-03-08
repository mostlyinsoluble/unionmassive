// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.NavigationBar;

internal abstract partial class RoslynNavigationBarItem
{
    public abstract class AbstractGenerateCodeItem(RoslynNavigationBarItemKind kind, string text, Glyph glyph, SymbolKey destinationTypeSymbolKey) : RoslynNavigationBarItem(kind, text, glyph, bolded: false, grayed: false, indent: 0, childItems: default), IEquatable<AbstractGenerateCodeItem>
    {
        public readonly SymbolKey DestinationTypeSymbolKey = destinationTypeSymbolKey;

        public abstract override bool Equals(object? obj);
        public abstract override int GetHashCode();

        public bool Equals(AbstractGenerateCodeItem? other)
            => base.Equals(other) &&
               DestinationTypeSymbolKey.Equals(other.DestinationTypeSymbolKey);
    }
}
