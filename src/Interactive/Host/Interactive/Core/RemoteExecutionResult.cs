// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Interactive
{
    internal readonly struct RemoteExecutionResult(
        bool success,
        ImmutableArray<string> sourcePaths,
        ImmutableArray<string> referencePaths,
        string workingDirectory,
        RemoteInitializationResult? initializationResult)
    {
        internal sealed class Data
        {
            public bool Success;
            public string[] SourcePaths = null!;
            public string[] ReferencePaths = null!;
            public string WorkingDirectory = null!;
            public RemoteInitializationResult.Data? InitializationResult;

            public RemoteExecutionResult Deserialize()
                => new RemoteExecutionResult(
                    Success,
                    [.. SourcePaths],
                    [.. ReferencePaths],
                    WorkingDirectory,
                    InitializationResult?.Deserialize());
        }

        public readonly bool Success = success;

        /// <summary>
        /// New value of source search paths after execution.
        /// </summary>
        public readonly ImmutableArray<string> SourcePaths = sourcePaths;

        /// <summary>
        /// New value of reference search paths after execution.
        /// </summary>
        public readonly ImmutableArray<string> ReferencePaths = referencePaths;

        /// <summary>
        /// New value of working directory in the remote process after execution.
        /// </summary>
        public readonly string WorkingDirectory = workingDirectory;

        public readonly RemoteInitializationResult? InitializationResult = initializationResult;

        public Data Serialize()
            => new Data()
            {
                Success = Success,
                SourcePaths = [.. SourcePaths],
                ReferencePaths = [.. ReferencePaths],
                WorkingDirectory = WorkingDirectory,
                InitializationResult = InitializationResult?.Serialize(),
            };
    }
}
