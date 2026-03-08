// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json.Serialization;

namespace Microsoft.CodeAnalysis.LanguageServer.Handler.DebugConfiguration;

internal sealed class ProjectDebugConfiguration(string projectPath, string outputPath, string projectName, bool targetsDotnetCore, bool isExe, string? solutionPath)
{
    [JsonPropertyName("projectPath")]
    public string ProjectPath { get; } = projectPath;

    [JsonPropertyName("outputPath")]
    public string OutputPath { get; } = outputPath;

    [JsonPropertyName("projectName")]
    public string ProjectName { get; } = projectName;

    [JsonPropertyName("targetsDotnetCore")]
    public bool TargetsDotnetCore { get; } = targetsDotnetCore;

    [JsonPropertyName("isExe")]
    public bool IsExe { get; } = isExe;

    [JsonPropertyName("solutionPath")]
    public string? SolutionPath { get; } = solutionPath;
}
