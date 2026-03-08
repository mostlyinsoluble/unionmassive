// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Roslyn.Test.Utilities
{
    internal class TestAnalyzerReference(string? fullPath = null, string? display = null, object? id = null) : AnalyzerReference
    {
        private readonly string? _fullPath = fullPath;
        private readonly string? _display = display;
        private readonly object? _id = id;

        public override string Display => _display ?? throw new NotImplementedException();
        public override string FullPath => _fullPath ?? throw new NotImplementedException();
        public override object Id => _id ?? throw new NotImplementedException();

        public override ImmutableArray<DiagnosticAnalyzer> GetAnalyzers(string language) => throw new NotImplementedException();
        public override ImmutableArray<DiagnosticAnalyzer> GetAnalyzersForAllLanguages() => throw new NotImplementedException();
    }
}
