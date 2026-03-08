// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using Roslyn.Test.Utilities;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public sealed partial class CompilationVerifier
    {
        public sealed class EmitException(ImmutableArray<Diagnostic> diagnostics, string? directory) : Exception(ExceptionHelper.GetMessageFromResult(diagnostics, directory))
        {
            public ImmutableArray<Diagnostic> Diagnostics { get; } = diagnostics;
        }
    }
}
