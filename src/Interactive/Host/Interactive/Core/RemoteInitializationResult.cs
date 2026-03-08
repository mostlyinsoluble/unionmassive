// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Interactive
{
    internal sealed class RemoteInitializationResult(string? initializationScript, ImmutableArray<string> metadataReferencePaths, ImmutableArray<string> imports)
    {
        internal sealed class Data
        {
            public string? ScriptPath;
            public string[] MetadataReferencePaths = null!;
            public string[] Imports = null!;

            public RemoteInitializationResult Deserialize()
                => new RemoteInitializationResult(
                    ScriptPath,
                    ImmutableArray.Create(MetadataReferencePaths),
                    ImmutableArray.Create(Imports));
        }

        /// <summary>
        /// Full path to the initialization script that has been executed as part of initialization process.
        /// </summary>
        public readonly string? ScriptPath = initializationScript;

        public readonly ImmutableArray<string> MetadataReferencePaths = metadataReferencePaths;

        public readonly ImmutableArray<string> Imports = imports;

        public Data Serialize()
            => new Data()
            {
                ScriptPath = ScriptPath,
                MetadataReferencePaths = [.. MetadataReferencePaths],
                Imports = [.. Imports],
            };
    }
}
