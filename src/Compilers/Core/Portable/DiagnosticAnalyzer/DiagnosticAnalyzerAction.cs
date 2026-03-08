// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Operations;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal abstract class AnalyzerAction
    {
        internal DiagnosticAnalyzer Analyzer { get; }

        internal AnalyzerAction(DiagnosticAnalyzer analyzer) => Analyzer = analyzer;
    }

    internal sealed class SymbolAnalyzerAction(Action<SymbolAnalysisContext> action, ImmutableArray<SymbolKind> kinds, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer)
    {
        public Action<SymbolAnalysisContext> Action { get; } = action;
        public ImmutableArray<SymbolKind> Kinds { get; } = kinds;
    }

    internal sealed class SymbolStartAnalyzerAction(Action<SymbolStartAnalysisContext> action, SymbolKind kind, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer)
    {
        public Action<SymbolStartAnalysisContext> Action { get; } = action;
        public SymbolKind Kind { get; } = kind;
    }

    internal sealed class SymbolEndAnalyzerAction(Action<SymbolAnalysisContext> action, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer)
    {
        public Action<SymbolAnalysisContext> Action { get; } = action;
    }

    internal sealed class SyntaxNodeAnalyzerAction<TLanguageKindEnum>(Action<SyntaxNodeAnalysisContext> action, ImmutableArray<TLanguageKindEnum> kinds, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer) where TLanguageKindEnum : struct
    {
        public Action<SyntaxNodeAnalysisContext> Action { get; } = action;
        public ImmutableArray<TLanguageKindEnum> Kinds { get; } = kinds;
    }

    internal sealed class OperationBlockStartAnalyzerAction(Action<OperationBlockStartAnalysisContext> action, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer)
    {
        public Action<OperationBlockStartAnalysisContext> Action { get; } = action;
    }

    internal sealed class OperationBlockAnalyzerAction(Action<OperationBlockAnalysisContext> action, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer)
    {
        public Action<OperationBlockAnalysisContext> Action { get; } = action;
    }

    internal sealed class OperationAnalyzerAction(Action<OperationAnalysisContext> action, ImmutableArray<OperationKind> kinds, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer)
    {
        public Action<OperationAnalysisContext> Action { get; } = action;
        public ImmutableArray<OperationKind> Kinds { get; } = kinds;
    }

    internal sealed class CompilationStartAnalyzerAction(Action<CompilationStartAnalysisContext> action, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer)
    {
        public Action<CompilationStartAnalysisContext> Action { get; } = action;
    }

    internal sealed class CompilationAnalyzerAction(Action<CompilationAnalysisContext> action, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer)
    {
        public Action<CompilationAnalysisContext> Action { get; } = action;
    }

    internal sealed class SemanticModelAnalyzerAction(Action<SemanticModelAnalysisContext> action, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer)
    {
        public Action<SemanticModelAnalysisContext> Action { get; } = action;
    }

    internal sealed class SyntaxTreeAnalyzerAction(Action<SyntaxTreeAnalysisContext> action, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer)
    {
        public Action<SyntaxTreeAnalysisContext> Action { get; } = action;
    }

    internal sealed class AdditionalFileAnalyzerAction(Action<AdditionalFileAnalysisContext> action, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer)
    {
        public Action<AdditionalFileAnalysisContext> Action { get; } = action;
    }

    internal sealed class CodeBlockStartAnalyzerAction<TLanguageKindEnum>(Action<CodeBlockStartAnalysisContext<TLanguageKindEnum>> action, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer) where TLanguageKindEnum : struct
    {
        public Action<CodeBlockStartAnalysisContext<TLanguageKindEnum>> Action { get; } = action;
    }

    internal sealed class CodeBlockAnalyzerAction(Action<CodeBlockAnalysisContext> action, DiagnosticAnalyzer analyzer) : AnalyzerAction(analyzer)
    {
        public Action<CodeBlockAnalysisContext> Action { get; } = action;
    }
}
