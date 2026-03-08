// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.MetadataReader.PortableInterop;

#nullable enable

namespace Microsoft.VisualStudio.Debugger.Clr
{
    /// <summary>
    /// Wrapper around a <see cref="Microsoft.MetadataReader.IMetadataImport"/> interface
    /// reference that provides a easy way to release the reference to the underlying
    /// COM object. Instances of this struct should always be disposed.
    /// </summary>
    /// <remarks>
    /// Creates a new instance of <see cref="DkmMetadataImportHolder"/>.
    /// </remarks>
    /// <param name="value">[In] Implementation of IMetadataImport to wrap</param>
    public readonly struct DkmMetadataImportHolder(IMetadataImport value) : IDisposable
    {
        /// <summary>
        /// The underlying IMetaDataImport interface reference
        /// </summary>
        public IMetadataImport PortableValue { get; } = value ?? throw new ArgumentNullException(nameof(value));

        void IDisposable.Dispose()
        {
            // Mock implementation does nothing
        }
    }
}
