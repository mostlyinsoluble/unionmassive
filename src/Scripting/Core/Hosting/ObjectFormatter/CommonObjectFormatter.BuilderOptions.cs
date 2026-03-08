// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.Scripting.Hosting
{
    /// <summary>
    /// Object pretty printer.
    /// </summary>
    internal abstract partial class CommonObjectFormatter
    {
        /// <remarks>
        /// Internal for testing.
        /// </remarks>
        internal readonly struct BuilderOptions(string indentation, string newLine, string ellipsis, int maximumLineLength, int maximumOutputLength)
        {
            public readonly string Indentation = indentation;
            public readonly string NewLine = newLine;
            public readonly string Ellipsis = ellipsis;

            public readonly int MaximumLineLength = maximumLineLength;
            public readonly int MaximumOutputLength = maximumOutputLength;

            public BuilderOptions WithMaximumOutputLength(int maximumOutputLength)
            {
                return new BuilderOptions(
                    Indentation,
                    NewLine,
                    Ellipsis,
                    MaximumLineLength,
                    maximumOutputLength);
            }
        }
    }
}
