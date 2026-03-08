// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    /// <summary>
    /// State machine interface method implementation.
    /// </summary>
    internal abstract class SynthesizedStateMachineMethod(
        string name,
        MethodSymbol interfaceMethod,
        StateMachineTypeSymbol stateMachineType,
        PropertySymbol associatedProperty,
        bool generateDebugInfo,
        bool hasMethodBodyDependency) : SynthesizedImplementationMethod(interfaceMethod, stateMachineType, name, generateDebugInfo, associatedProperty), ISynthesizedMethodBodyImplementationSymbol
    {
        private readonly bool _hasMethodBodyDependency = hasMethodBodyDependency;

        public StateMachineTypeSymbol StateMachineType
        {
            get { return (StateMachineTypeSymbol)ContainingSymbol; }
        }

        public bool HasMethodBodyDependency
        {
            get { return _hasMethodBodyDependency; }
        }

        IMethodSymbolInternal ISynthesizedMethodBodyImplementationSymbol.Method
        {
            get { return StateMachineType.KickoffMethod; }
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            return this.StateMachineType.KickoffMethod.CalculateLocalSyntaxOffset(localPosition, localTree);
        }
    }

    /// <summary>
    /// Represents a state machine MoveNext method.
    /// Handles special behavior around inheriting some attributes from the original async/iterator method.
    /// </summary>
    internal sealed class SynthesizedStateMachineMoveNextMethod(MethodSymbol interfaceMethod, StateMachineTypeSymbol stateMachineType) : SynthesizedStateMachineMethod(WellKnownMemberNames.MoveNextMethodName, interfaceMethod, stateMachineType, null, generateDebugInfo: true, hasMethodBodyDependency: true)
    {
        private ImmutableArray<CSharpAttributeData> _attributes;

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            if (_attributes.IsDefault)
            {
                Debug.Assert(base.GetAttributes().Length == 0);

                ArrayBuilder<CSharpAttributeData> builder = null;

                // Inherit some attributes from the kickoff method
                var kickoffMethod = StateMachineType.KickoffMethod;
                foreach (var attribute in kickoffMethod.GetAttributes())
                {
                    if (attribute.IsTargetAttribute(AttributeDescription.DebuggerHiddenAttribute) ||
                        attribute.IsTargetAttribute(AttributeDescription.DebuggerNonUserCodeAttribute) ||
                        attribute.IsTargetAttribute(AttributeDescription.DebuggerStepperBoundaryAttribute) ||
                        attribute.IsTargetAttribute(AttributeDescription.DebuggerStepThroughAttribute))
                    {
                        if (builder == null)
                        {
                            builder = ArrayBuilder<CSharpAttributeData>.GetInstance(4); // only 4 different attributes are inherited at the moment
                        }

                        builder.Add(attribute);
                    }
                }

                ImmutableInterlocked.InterlockedCompareExchange(ref _attributes,
                                                                builder == null ? ImmutableArray<CSharpAttributeData>.Empty : builder.ToImmutableAndFree(),
                                                                default);
            }

            return _attributes;
        }
    }

    /// <summary>
    /// Represents a state machine method other than a MoveNext method.
    /// All such methods are considered debugger hidden. 
    /// </summary>
    internal sealed class SynthesizedStateMachineDebuggerHiddenMethod(
        string name,
        MethodSymbol interfaceMethod,
        StateMachineTypeSymbol stateMachineType,
        PropertySymbol associatedProperty,
        bool hasMethodBodyDependency) : SynthesizedStateMachineMethod(name, interfaceMethod, stateMachineType, associatedProperty, generateDebugInfo: false, hasMethodBodyDependency: hasMethodBodyDependency)
    {
        internal sealed override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<CSharpAttributeData> attributes)
        {
            var compilation = this.DeclaringCompilation;
            AddSynthesizedAttribute(ref attributes, compilation.TrySynthesizeAttribute(WellKnownMember.System_Diagnostics_DebuggerHiddenAttribute__ctor));

            base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
        }
    }
}
