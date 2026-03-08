// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.MSBuild;

internal readonly struct DiagnosticReportingOptions(
    DiagnosticReportingMode onPathFailure,
    DiagnosticReportingMode onLoaderFailure)
{
    public DiagnosticReportingMode OnPathFailure { get; } = onPathFailure;
    public DiagnosticReportingMode OnLoaderFailure { get; } = onLoaderFailure;

    public static DiagnosticReportingOptions IgnoreAll { get; }
        = new DiagnosticReportingOptions(DiagnosticReportingMode.Ignore, DiagnosticReportingMode.Ignore);

    public static DiagnosticReportingOptions ThrowForAll { get; }
        = new DiagnosticReportingOptions(DiagnosticReportingMode.Throw, DiagnosticReportingMode.Throw);
}
