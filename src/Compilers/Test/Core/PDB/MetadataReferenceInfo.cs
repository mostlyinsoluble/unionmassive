// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Xunit;

namespace Roslyn.Test.Utilities.PDB
{
    internal readonly struct MetadataReferenceInfo(
        int timestamp,
        int imageSize,
        string name,
        Guid mvid,
        ImmutableArray<string> externAliases,
        MetadataImageKind kind,
        bool embedInteropTypes)
    {
        public readonly int Timestamp = timestamp;
        public readonly int ImageSize = imageSize;
        public readonly string Name = name;
        public readonly Guid Mvid = mvid;
        public readonly ImmutableArray<string> ExternAliases = externAliases;
        public readonly MetadataImageKind Kind = kind;
        public readonly bool EmbedInteropTypes = embedInteropTypes;

        internal void AssertEqual(MetadataReferenceInfo other)
        {
            Assert.Equal(Name, other.Name);
            Assert.Equal(Timestamp, other.Timestamp);
            Assert.Equal(ImageSize, other.ImageSize);
            Assert.Equal(Mvid, other.Mvid);
            Assert.Equal(ExternAliases, other.ExternAliases);
            Assert.Equal(Kind, other.Kind);
            Assert.Equal(EmbedInteropTypes, other.EmbedInteropTypes);
        }
    }
}
