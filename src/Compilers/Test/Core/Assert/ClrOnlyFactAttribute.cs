// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Roslyn.Test.Utilities
{
    public enum ClrOnlyReason
    {
        Unknown,

        // The Mono version of ilasm doesn't have all of the features we need to run 
        // our tests.  In particular it doesn't appear to support the full range of 
        // modopt operators that our tests invoke.
        Ilasm,

        // Mono lists certain methods in a different order than the CLR.  For example
        // Equals, GetHashCode, ToString, etc ... which breaks our tests which hard
        // code the order. 
        MemberOrder,

        // Can't emit a PDB.
        Pdb,

        // The documentation comment compiler has a dependency on a resource in the 
        // System.Xml assembly.  This is a non-portable / implementation detail 
        // that Mono doesn't mirror.  We need to make this test more robust so it can
        // run on all runtimes. 
        //
        // See DocumentationCommentCompiler.GetDescription 
        DocumentationComment,

        // Can't sign. 
        Signing,

        Fusion,
    }

    /// <summary>
    /// Tests that can only be run on the Desktop CLR.
    /// </summary>
    public sealed class ClrOnlyFactAttribute : FactAttribute
    {
        public readonly ClrOnlyReason Reason;

        public ClrOnlyFactAttribute(ClrOnlyReason reason = ClrOnlyReason.Unknown)
        {
            Reason = reason;

            if (MonoHelpers.IsRunningOnMono())
            {
                Skip = GetSkipReason(Reason);
            }
        }

        private static string GetSkipReason(ClrOnlyReason reason)
        {
            return reason switch
            {
                ClrOnlyReason.Ilasm => "Mono ilasm doesn't support all of the features we need",
                ClrOnlyReason.MemberOrder => "Mono returns certain symbols in different order than we are expecting",
                ClrOnlyReason.Pdb => "Can't emit a PDB in this scenario",
                ClrOnlyReason.Signing => "Can't sign assemblies in this scenario",
                ClrOnlyReason.DocumentationComment => "Documentation comment compiler can't run this test on Mono",
                ClrOnlyReason.Fusion => "Fusion not available on Mono",
                _ => "Test supported only on CLR",
            };
        }
    }
}
