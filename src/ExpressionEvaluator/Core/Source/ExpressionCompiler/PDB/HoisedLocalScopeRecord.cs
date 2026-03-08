// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.ExpressionEvaluator
{
    internal readonly struct HoistedLocalScopeRecord(int startOffset, int length)
    {
        public readonly int StartOffset = startOffset;
        public readonly int Length = length;
    }
}
