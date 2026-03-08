// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    /// <summary>
    /// A representation of a property symbol that is intended only to be used for comparison purposes
    /// (esp in PropertySignatureComparer).
    /// </summary>
    internal sealed class SignatureOnlyPropertySymbol(
        string name,
        TypeSymbol containingType,
        ImmutableArray<ParameterSymbol> parameters,
        RefKind refKind,
        TypeWithAnnotations type,
        ImmutableArray<CustomModifier> refCustomModifiers,
        bool isStatic,
        ImmutableArray<PropertySymbol> explicitInterfaceImplementations) : PropertySymbol
    {
        private readonly string _name = name;
        private readonly TypeSymbol _containingType = containingType;
        private readonly ImmutableArray<ParameterSymbol> _parameters = parameters;
        private readonly RefKind _refKind = refKind;
        private readonly TypeWithAnnotations _type = type;
        private readonly ImmutableArray<CustomModifier> _refCustomModifiers = refCustomModifiers;
        private readonly bool _isStatic = isStatic;
        private readonly ImmutableArray<PropertySymbol> _explicitInterfaceImplementations = explicitInterfaceImplementations.NullToEmpty();

        public override RefKind RefKind { get { return _refKind; } }

        public override TypeWithAnnotations TypeWithAnnotations { get { return _type; } }

        public override ImmutableArray<CustomModifier> RefCustomModifiers { get { return _refCustomModifiers; } }

        public override bool IsStatic { get { return _isStatic; } }

        public override ImmutableArray<ParameterSymbol> Parameters { get { return _parameters; } }

        public override ImmutableArray<PropertySymbol> ExplicitInterfaceImplementations { get { return _explicitInterfaceImplementations; } }

        public override Symbol ContainingSymbol { get { return _containingType; } }

        public override string Name { get { return _name; } }

        internal sealed override bool HasUnscopedRefAttribute => false;

        #region Not used by PropertySignatureComparer

        internal override bool HasSpecialName { get { throw ExceptionUtilities.Unreachable(); } }

        internal override Cci.CallingConvention CallingConvention { get { throw ExceptionUtilities.Unreachable(); } }

        public override ImmutableArray<Location> Locations { get { throw ExceptionUtilities.Unreachable(); } }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences { get { throw ExceptionUtilities.Unreachable(); } }

        public override Accessibility DeclaredAccessibility { get { throw ExceptionUtilities.Unreachable(); } }

        public override bool IsVirtual { get { throw ExceptionUtilities.Unreachable(); } }

        public override bool IsOverride => false;

        public override bool IsAbstract { get { throw ExceptionUtilities.Unreachable(); } }

        public override bool IsSealed { get { throw ExceptionUtilities.Unreachable(); } }

        public override bool IsExtern { get { throw ExceptionUtilities.Unreachable(); } }

        internal override bool IsRequired => throw ExceptionUtilities.Unreachable();

        internal override ObsoleteAttributeData ObsoleteAttributeData { get { throw ExceptionUtilities.Unreachable(); } }

        public override AssemblySymbol ContainingAssembly { get { throw ExceptionUtilities.Unreachable(); } }

        internal override ModuleSymbol ContainingModule { get { throw ExceptionUtilities.Unreachable(); } }

        internal override bool MustCallMethodsDirectly { get { throw ExceptionUtilities.Unreachable(); } }

        public override MethodSymbol SetMethod { get { throw ExceptionUtilities.Unreachable(); } }

        public override MethodSymbol GetMethod { get { throw ExceptionUtilities.Unreachable(); } }

        public override bool IsIndexer { get { throw ExceptionUtilities.Unreachable(); } }

        internal override int TryGetOverloadResolutionPriority() => throw ExceptionUtilities.Unreachable();

        internal override CallerUnsafeMode CallerUnsafeMode => throw ExceptionUtilities.Unreachable();

        #endregion Not used by PropertySignatureComparer
    }
}
