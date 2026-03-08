// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal readonly struct BoundPatternBinding(BoundExpression variableAccess, BoundDagTemp tempContainingValue)
    {
        public readonly BoundExpression VariableAccess = variableAccess;
        public readonly BoundDagTemp TempContainingValue = tempContainingValue;

        public override string ToString()
        {
            return GetDebuggerDisplay();
        }
        internal string GetDebuggerDisplay()
        {
            return $"({VariableAccess.GetDebuggerDisplay()} = {TempContainingValue.GetDebuggerDisplay()})";
        }
    }
}
