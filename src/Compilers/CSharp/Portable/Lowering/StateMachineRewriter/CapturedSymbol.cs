// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class CapturedSymbolReplacement(bool isReusable)
    {
        public readonly bool IsReusable = isReusable;

        /// <summary>
        /// Rewrite the replacement expression for the hoisted local so all synthesized field are accessed as members
        /// of the appropriate frame.
        /// </summary>
        public abstract BoundExpression Replacement<TArg>(SyntaxNode node, Func<NamedTypeSymbol, TArg, BoundExpression> makeFrame, TArg arg);
    }

    internal sealed class CapturedToFrameSymbolReplacement(LambdaCapturedVariable hoistedField, bool isReusable) : CapturedSymbolReplacement(isReusable)
    {
        public readonly LambdaCapturedVariable HoistedField = hoistedField;

        public override BoundExpression Replacement<TArg>(SyntaxNode node, Func<NamedTypeSymbol, TArg, BoundExpression> makeFrame, TArg arg)
        {
            var frame = makeFrame(this.HoistedField.ContainingType, arg);
            var field = this.HoistedField.AsMember((NamedTypeSymbol)frame.Type);
            return new BoundFieldAccess(node, frame, field, constantValueOpt: null);
        }
    }

    internal sealed class CapturedToStateMachineFieldReplacement(StateMachineFieldSymbol hoistedField, bool isReusable) : CapturedSymbolReplacement(isReusable)
    {
        public readonly StateMachineFieldSymbol HoistedField = hoistedField;

        public override BoundExpression Replacement<TArg>(SyntaxNode node, Func<NamedTypeSymbol, TArg, BoundExpression> makeFrame, TArg arg)
        {
            var frame = makeFrame(this.HoistedField.ContainingType, arg);
            var field = this.HoistedField.AsMember((NamedTypeSymbol)frame.Type);
            return new BoundFieldAccess(node, frame, field, constantValueOpt: null);
        }
    }

    internal sealed class CapturedToExpressionSymbolReplacement<THoistedSymbolType>(BoundExpression replacement, ImmutableArray<THoistedSymbolType> hoistedSymbols, bool isReusable) : CapturedSymbolReplacement(isReusable)
        where THoistedSymbolType : Symbol
    {
        private readonly BoundExpression _replacement = replacement;
        public readonly ImmutableArray<THoistedSymbolType> HoistedSymbols = hoistedSymbols;

        public override BoundExpression Replacement<TArg>(SyntaxNode node, Func<NamedTypeSymbol, TArg, BoundExpression> makeFrame, TArg arg)
        {
            // By returning the same replacement each time, it is possible we
            // are constructing a DAG instead of a tree for the translation.
            // Because the bound trees are immutable that is usually harmless.
            return _replacement;
        }
    }
}
