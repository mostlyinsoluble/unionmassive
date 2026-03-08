// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.Operations;

namespace Microsoft.CodeAnalysis.FlowAnalysis
{
    internal partial class ControlFlowGraphBuilder
    {
        private class InterpolatedStringHandlerArgumentsContext(ImmutableArray<IInterpolatedStringHandlerCreationOperation> applicableCreationOperations, int startingStackDepth, bool hasReceiver)
        {
            public readonly ImmutableArray<IInterpolatedStringHandlerCreationOperation> ApplicableCreationOperations = applicableCreationOperations;
            public readonly int StartingStackDepth = startingStackDepth;
            public readonly bool HasReceiver = hasReceiver;
        }

        private class InterpolatedStringHandlerCreationContext(IInterpolatedStringHandlerCreationOperation applicableCreationOperation, int maximumStackDepth, int handlerPlaceholder, int outParameterPlaceholder)
        {
            public readonly IInterpolatedStringHandlerCreationOperation ApplicableCreationOperation = applicableCreationOperation;
            public readonly int MaximumStackDepth = maximumStackDepth;
            public readonly int HandlerPlaceholder = handlerPlaceholder;
            public readonly int OutPlaceholder = outParameterPlaceholder;
        }

        [Conditional("DEBUG")]
        [MemberNotNull(nameof(_currentInterpolatedStringHandlerCreationContext))]
        private void AssertContainingContextIsForThisCreation(IOperation placeholderOperation, bool assertArgumentContext)
        {
            Debug.Assert(_currentInterpolatedStringHandlerCreationContext != null);
            Debug.Assert(placeholderOperation is IInstanceReferenceOperation { ReferenceKind: InstanceReferenceKind.InterpolatedStringHandler } or IInterpolatedStringHandlerArgumentPlaceholderOperation);

            IOperation? operation = placeholderOperation.Parent;
            while (operation is not (null or IInterpolatedStringHandlerCreationOperation))
            {
                operation = operation.Parent;
            }

            Debug.Assert(operation != null);
            Debug.Assert(_currentInterpolatedStringHandlerCreationContext.ApplicableCreationOperation == operation);

            // Note: _currentInterpolatedStringHandlerArgumentContext may be null in error scenarios
            // (for example, indexer with no setter in object initializer where the handler creation is visited
            // as a child of an InvalidOperation rather than through VisitAndPushArguments).
            // If a new test triggers this assert because a different ancestor has the error, it will likely be fine to just add
            // that case to the assert.
            if (assertArgumentContext)
            {
                if (_currentInterpolatedStringHandlerArgumentContext != null)
                {
                    Debug.Assert(_currentInterpolatedStringHandlerArgumentContext.ApplicableCreationOperations.Contains((IInterpolatedStringHandlerCreationOperation)operation));
                }
                else
                {
                    Debug.Assert(placeholderOperation.Parent!.Parent is IObjectCreationOperation objectCreation && objectCreation.HasErrors(_compilation));
                }
            }
        }
    }
}
