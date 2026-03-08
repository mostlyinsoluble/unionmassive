// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.IO;
using Microsoft.CodeAnalysis;

namespace Roslyn.Test.Utilities
{
    public class TestMetadataReference(Metadata metadata = null, string fullPath = null, string display = null) : PortableExecutableReference(MetadataReferenceProperties.Assembly, fullPath)
    {
        private readonly Metadata _metadata = metadata;
        private readonly string _display = display;

        public override string Display
        {
            get
            {
                return _display;
            }
        }

        protected override DocumentationProvider CreateDocumentationProvider()
        {
            return DocumentationProvider.Default;
        }

        protected override Metadata GetMetadataImpl()
        {
            if (_metadata == null)
            {
                throw new FileNotFoundException();
            }

            return _metadata;
        }

        protected override PortableExecutableReference WithPropertiesImpl(MetadataReferenceProperties properties)
        {
            throw new NotImplementedException();
        }
    }

    public class TestImageReference(ImmutableArray<byte> metadataBytes, string display) : PortableExecutableReference(MetadataReferenceProperties.Assembly)
    {
        private readonly ImmutableArray<byte> _metadataBytes = metadataBytes;
        private readonly string _display = display;

        public TestImageReference(byte[] metadataBytes, string display)
            : this(ImmutableArray.Create(metadataBytes), display)
        {
        }

        public override string Display
        {
            get
            {
                return _display;
            }
        }

        protected override DocumentationProvider CreateDocumentationProvider()
        {
            return DocumentationProvider.Default;
        }

        protected override Metadata GetMetadataImpl()
        {
            return AssemblyMetadata.CreateFromImage(_metadataBytes);
        }

        protected override PortableExecutableReference WithPropertiesImpl(MetadataReferenceProperties properties)
        {
            throw new NotImplementedException();
        }
    }
}
