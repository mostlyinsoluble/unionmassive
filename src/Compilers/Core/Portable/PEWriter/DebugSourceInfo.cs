// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Immutable;

namespace Microsoft.Cci
{
    /// <summary>
    /// Represents the portion of a <see cref="DebugSourceDocument"/> that are derived
    /// from the source document content, and which can be computed asynchronously.
    /// </summary>
    internal readonly struct DebugSourceInfo(
        ImmutableArray<byte> checksum,
        Guid checksumAlgorithmId,
        ImmutableArray<byte> embeddedTextBlob = default)
    {
        /// <summary>
        /// The ID of the hash algorithm used.
        /// </summary>
        public readonly Guid ChecksumAlgorithmId = checksumAlgorithmId;

        /// <summary>
        /// The hash of the document content.
        /// </summary>
        public readonly ImmutableArray<byte> Checksum = checksum;

        /// <summary>
        /// The source text to embed in the PDB. (If any, otherwise default.)
        /// </summary>
        public readonly ImmutableArray<byte> EmbeddedTextBlob = embeddedTextBlob;

        public DebugSourceInfo(
            ImmutableArray<byte> checksum,
            SourceHashAlgorithm checksumAlgorithm,
            ImmutableArray<byte> embeddedTextBlob = default)
            : this(checksum, SourceHashAlgorithms.GetAlgorithmGuid(checksumAlgorithm), embeddedTextBlob)
        {
        }
    }
}
