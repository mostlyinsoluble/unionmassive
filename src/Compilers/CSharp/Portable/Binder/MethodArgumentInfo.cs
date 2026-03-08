// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    /// <summary>
    /// Information about the arguments of a call that can turned into a BoundCall later without recalculating
    /// default arguments.
    /// </summary>
    internal sealed class MethodArgumentInfo(
        MethodSymbol method,
        ImmutableArray<BoundExpression> arguments,
        BitVector defaultArguments,
        bool expanded)
    {
        public readonly MethodSymbol Method = method;
        public readonly ImmutableArray<BoundExpression> Arguments = arguments;
        public readonly BitVector DefaultArguments = defaultArguments;
        public readonly bool Expanded = expanded;

        public static MethodArgumentInfo CreateParameterlessMethod(MethodSymbol method)
        {
            Debug.Assert(method.ParameterCount == 0);
            return new MethodArgumentInfo(method, arguments: ImmutableArray<BoundExpression>.Empty, defaultArguments: default, expanded: false);
        }
    }
}
