// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.Operations
{
    internal class ForToLoopOperationUserDefinedInfo(IBinaryOperation addition, IBinaryOperation subtraction, IOperation lessThanOrEqual, IOperation greaterThanOrEqual)
    {
        public readonly IBinaryOperation Addition = addition;
        public readonly IBinaryOperation Subtraction = subtraction;
        public readonly IOperation LessThanOrEqual = lessThanOrEqual;
        public readonly IOperation GreaterThanOrEqual = greaterThanOrEqual;
    }
}
