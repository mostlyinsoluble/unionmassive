// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class LazyUseSiteDiagnosticsInfoForNullableType : LazyDiagnosticInfo
    {
        private readonly TypeWithAnnotations _possiblyNullableTypeSymbol;

        internal LazyUseSiteDiagnosticsInfoForNullableType(TypeWithAnnotations possiblyNullableTypeSymbol) => _possiblyNullableTypeSymbol = possiblyNullableTypeSymbol;

        private LazyUseSiteDiagnosticsInfoForNullableType(LazyUseSiteDiagnosticsInfoForNullableType original, DiagnosticSeverity severity) : base(original, severity) => _possiblyNullableTypeSymbol = original._possiblyNullableTypeSymbol;

        protected override DiagnosticInfo GetInstanceWithSeverityCore(DiagnosticSeverity severity)
        {
            return new LazyUseSiteDiagnosticsInfoForNullableType(this, severity);
        }

        protected override DiagnosticInfo? ResolveInfo()
            => !_possiblyNullableTypeSymbol.IsNullableType() ? null :
                _possiblyNullableTypeSymbol.Type.OriginalDefinition.GetUseSiteInfo().DiagnosticInfo;
    }
}
