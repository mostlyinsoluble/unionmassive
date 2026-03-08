// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Globalization;

namespace Microsoft.CodeAnalysis.Scripting.Hosting
{
    internal readonly struct CommonPrimitiveFormatterOptions(
        int numberRadix,
        bool includeCodePoints,
        bool quoteStringsAndCharacters,
        bool escapeNonPrintableCharacters,
        CultureInfo cultureInfo)
    {
        /// <remarks>
        /// Since <see cref="CommonPrimitiveFormatter"/> is an extension point, we don't
        /// perform any validation on <see cref="NumberRadix"/> - it's up to the individual
        /// subtype.
        /// </remarks>
        public int NumberRadix { get; } = numberRadix;
        public bool IncludeCharacterCodePoints { get; } = includeCodePoints;
        public bool QuoteStringsAndCharacters { get; } = quoteStringsAndCharacters;
        public bool EscapeNonPrintableCharacters { get; } = escapeNonPrintableCharacters;
        public CultureInfo CultureInfo { get; } = cultureInfo;
    }
}
