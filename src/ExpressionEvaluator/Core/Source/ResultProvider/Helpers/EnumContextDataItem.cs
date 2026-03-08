// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.VisualStudio.Debugger;
using Microsoft.VisualStudio.Debugger.Evaluation;

namespace Microsoft.CodeAnalysis.ExpressionEvaluator
{
    internal sealed class EnumContextDataItem(DkmEvaluationResult result) : DkmDataItem
    {
        public readonly DkmEvaluationResult Result = result;
    }
}
