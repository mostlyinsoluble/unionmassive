// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Analyzer.Utilities;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow.PointsToAnalysis;

namespace Microsoft.CodeAnalysis.FlowAnalysis.DataFlow
{
    /// <summary>
    /// Contains information about an argument passed to interprocedural analysis.
    /// </summary>
    public sealed class ArgumentInfo<TAbstractAnalysisValue>(
        IOperation operation,
        AnalysisEntity? analysisEntity,
        PointsToAbstractValue instanceLocation,
        TAbstractAnalysisValue value) : CacheBasedEquatable<ArgumentInfo<TAbstractAnalysisValue>>
    {
        public IOperation Operation { get; } = operation;
        // Can be null for allocations.
        public AnalysisEntity? AnalysisEntity { get; } = analysisEntity;
        public PointsToAbstractValue InstanceLocation { get; } = instanceLocation;
        public TAbstractAnalysisValue Value { get; } = value;

        protected override void ComputeHashCodeParts(ref RoslynHashCode hashCode)
        {
            hashCode.Add(Operation.GetHashCode());
            hashCode.Add(AnalysisEntity.GetHashCodeOrDefault());
            hashCode.Add(InstanceLocation.GetHashCode());
            hashCode.Add(Value?.GetHashCode() ?? 0);
        }

        protected override bool ComputeEqualsByHashCodeParts(CacheBasedEquatable<ArgumentInfo<TAbstractAnalysisValue>> obj)
        {
            var other = (ArgumentInfo<TAbstractAnalysisValue>)obj;
            return Operation.GetHashCode() == other.Operation.GetHashCode()
                && AnalysisEntity.GetHashCodeOrDefault() == other.AnalysisEntity.GetHashCodeOrDefault()
                && InstanceLocation.GetHashCode() == other.InstanceLocation.GetHashCode()
                && (Value?.GetHashCode() ?? 0) == (other.Value?.GetHashCode() ?? 0);
        }
    }
}
