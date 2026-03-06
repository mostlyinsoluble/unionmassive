// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    internal static class OperationTestExtensions
    {
        public static bool MustHaveNullType(this IOperation operation)
        {
            return operation.Kind switch
            {
                // TODO: Expand to cover all operations that must always have null type.
                OperationKind.ArrayInitializer or OperationKind.Argument => true,
                _ => false,
            };
        }
    }
}
