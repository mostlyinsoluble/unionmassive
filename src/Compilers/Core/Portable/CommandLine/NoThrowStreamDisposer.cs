// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;
using Microsoft.CodeAnalysis;

namespace Roslyn.Utilities
{
    /// <summary>
    /// Catches exceptions thrown during disposal of the underlying stream and
    /// writes them to the given <see cref="TextWriter"/>. Check
    /// <see cref="HasFailedToDispose" /> after disposal to see if any
    /// exceptions were thrown during disposal.
    /// </summary>
    internal class NoThrowStreamDisposer(
        Stream stream,
        string filePath,
        DiagnosticBag diagnostics,
        CommonMessageProvider messageProvider) : IDisposable
    {
        private bool? _failed = null; // Nullable to assert that this is only checked after dispose
        private readonly string _filePath = filePath;
        private readonly DiagnosticBag _diagnostics = diagnostics;
        private readonly CommonMessageProvider _messageProvider = messageProvider;

        /// <summary>
        /// Underlying stream
        /// </summary>
        public Stream Stream { get; } = stream;

        /// <summary>
        /// True if and only if an exception was thrown during a call to <see cref="Dispose"/>
        /// </summary>
        public bool HasFailedToDispose
        {
            get
            {
                RoslynDebug.Assert(_failed != null);
                return _failed.GetValueOrDefault();
            }
        }

        public void Dispose()
        {
            RoslynDebug.Assert(_failed == null);
            try
            {
                Stream.Dispose();
                if (_failed == null)
                {
                    _failed = false;
                }
            }
            catch (Exception e)
            {
                _messageProvider.ReportStreamWriteException(e, _filePath, _diagnostics);
                // Record if any exceptions are thrown during dispose
                _failed = true;
            }
        }
    }
}
