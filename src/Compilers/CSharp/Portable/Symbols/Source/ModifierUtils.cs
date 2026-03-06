// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class ModifierUtils
    {
        internal static DeclarationModifiers MakeAndCheckNonTypeMemberModifiers(
            bool isOrdinaryMethod,
            bool isForInterfaceMember,
            SyntaxTokenList modifiers,
            DeclarationModifiers defaultAccess,
            DeclarationModifiers allowedModifiers,
            Location errorLocation,
            BindingDiagnosticBag diagnostics,
            out bool modifierErrors,
            out bool hasExplicitAccessModifier)
        {
            var result = modifiers.ToDeclarationModifiers(isForTypeDeclaration: false, diagnostics.DiagnosticBag ?? new DiagnosticBag(), isOrdinaryMethod: isOrdinaryMethod);
            result = CheckModifiers(isForTypeDeclaration: false, isForInterfaceMember, result, allowedModifiers, errorLocation, diagnostics, modifiers, out modifierErrors);
            hasExplicitAccessModifier = (result & DeclarationModifiers.AccessibilityMask) != 0;
            if (!hasExplicitAccessModifier)
                result |= defaultAccess;

            return result;
        }

        internal static DeclarationModifiers CheckModifiers(
            bool isForTypeDeclaration,
            bool isForInterfaceMember,
            DeclarationModifiers modifiers,
            DeclarationModifiers allowedModifiers,
            Location errorLocation,
            BindingDiagnosticBag diagnostics,
            SyntaxTokenList? modifierTokens,
            out bool modifierErrors)
        {
            Debug.Assert(!isForTypeDeclaration || !isForInterfaceMember);

            modifierErrors = false;
            DeclarationModifiers reportStaticNotVirtualForModifiers = DeclarationModifiers.None;

            if (isForTypeDeclaration)
            {
                Debug.Assert((allowedModifiers & (DeclarationModifiers.Override | DeclarationModifiers.Virtual)) == 0);
            }
            else if ((modifiers & allowedModifiers & DeclarationModifiers.Static) != 0)
            {
                if (isForInterfaceMember)
                {
                    reportStaticNotVirtualForModifiers = allowedModifiers & DeclarationModifiers.Override;
                }
                else
                {
                    reportStaticNotVirtualForModifiers = allowedModifiers & (DeclarationModifiers.Abstract | DeclarationModifiers.Override | DeclarationModifiers.Virtual);
                }

                allowedModifiers &= ~reportStaticNotVirtualForModifiers;
            }

            DeclarationModifiers errorModifiers = modifiers & ~allowedModifiers;
            DeclarationModifiers result = modifiers & allowedModifiers;

            while (errorModifiers != DeclarationModifiers.None)
            {
                DeclarationModifiers oneError = errorModifiers & ~(errorModifiers - 1);
                Debug.Assert(oneError != DeclarationModifiers.None);
                errorModifiers &= ~oneError;

                switch (oneError)
                {
                    case DeclarationModifiers.Partial:
                        // Provide a specialized error message in the case of partial.
                        ReportPartialError(errorLocation, diagnostics, modifierTokens);
                        break;

                    case DeclarationModifiers.Abstract:
                    case DeclarationModifiers.Override:
                    case DeclarationModifiers.Virtual:
                        if ((reportStaticNotVirtualForModifiers & oneError) == 0)
                        {
                            goto default;
                        }

                        diagnostics.Add(ErrorCode.ERR_StaticNotVirtual, errorLocation, ModifierUtils.ConvertSingleModifierToSyntaxText(oneError));
                        break;

                    default:
                        diagnostics.Add(ErrorCode.ERR_BadMemberFlag, errorLocation, ConvertSingleModifierToSyntaxText(oneError));
                        break;
                }

                modifierErrors = true;
            }

            return result;
        }

        private static void ReportPartialError(Location errorLocation, BindingDiagnosticBag diagnostics, SyntaxTokenList? modifierTokens)
        {
            // If we can find the 'partial' token, report it on that.
            if (modifierTokens != null)
            {
                var partialToken = modifierTokens.Value.FirstOrDefault(SyntaxKind.PartialKeyword);
                if (partialToken != default)
                {
                    diagnostics.Add(ErrorCode.ERR_PartialMisplaced, partialToken.GetLocation());
                    return;
                }
            }

            diagnostics.Add(ErrorCode.ERR_PartialMisplaced, errorLocation);
        }

        internal static void ReportDefaultInterfaceImplementationModifiers(
            bool hasBody,
            DeclarationModifiers modifiers,
            DeclarationModifiers defaultInterfaceImplementationModifiers,
            Location errorLocation,
            BindingDiagnosticBag diagnostics)
        {
            if ((modifiers & defaultInterfaceImplementationModifiers) != 0)
            {
                if ((modifiers & defaultInterfaceImplementationModifiers & DeclarationModifiers.Static) != 0 &&
                    (modifiers & defaultInterfaceImplementationModifiers & (DeclarationModifiers.Sealed | DeclarationModifiers.Abstract | DeclarationModifiers.Virtual)) != 0)
                {
                    var reportModifiers = DeclarationModifiers.Sealed | DeclarationModifiers.Abstract | DeclarationModifiers.Virtual;
                    if ((modifiers & defaultInterfaceImplementationModifiers & DeclarationModifiers.Sealed) != 0 &&
                        (modifiers & defaultInterfaceImplementationModifiers & (DeclarationModifiers.Abstract | DeclarationModifiers.Virtual)) != 0)
                    {
                        diagnostics.Add(ErrorCode.ERR_BadMemberFlag, errorLocation, ConvertSingleModifierToSyntaxText(DeclarationModifiers.Sealed));
                        reportModifiers &= ~DeclarationModifiers.Sealed;
                    }

                    return; // below we will either ask for an earlier version of the language, or will not report anything
                }
            }
        }

        internal static DeclarationModifiers AdjustModifiersForAnInterfaceMember(DeclarationModifiers mods, bool hasBody, bool isExplicitInterfaceImplementation, bool forMethod)
        {
            // Interface partial non-method members are implicitly public and virtual just like their non-partial counterparts.
            // Interface partial methods are implicitly private and not virtual (this is a spec violation but being preserved to avoid breaks).
            bool notPartialOrNewPartialBehavior = (mods & DeclarationModifiers.Partial) == 0 || !forMethod;

            if ((mods & DeclarationModifiers.AccessibilityMask) == 0)
            {
                if (!isExplicitInterfaceImplementation && notPartialOrNewPartialBehavior)
                {
                    mods |= DeclarationModifiers.Public;
                }
                else
                {
                    mods |= DeclarationModifiers.Private;
                }
            }

            if (isExplicitInterfaceImplementation)
            {
                if ((mods & DeclarationModifiers.Abstract) != 0)
                {
                    mods |= DeclarationModifiers.Sealed;
                }
            }
            else if ((mods & DeclarationModifiers.Static) != 0)
            {
                mods &= ~DeclarationModifiers.Sealed;
            }
            else if ((mods & (DeclarationModifiers.Private | DeclarationModifiers.Virtual | DeclarationModifiers.Abstract)) == 0 && notPartialOrNewPartialBehavior)
            {
                Debug.Assert(!isExplicitInterfaceImplementation);

                if (hasBody || (mods & (DeclarationModifiers.Extern | DeclarationModifiers.Partial | DeclarationModifiers.Sealed)) != 0)
                {
                    if ((mods & DeclarationModifiers.Sealed) == 0)
                    {
                        mods |= DeclarationModifiers.Virtual;
                    }
                    else
                    {
                        mods &= ~DeclarationModifiers.Sealed;
                    }
                }
                else
                {
                    mods |= DeclarationModifiers.Abstract;
                }
            }

            return mods;
        }

        internal static string ConvertSingleModifierToSyntaxText(DeclarationModifiers modifier)
        {
            return modifier switch
            {
                DeclarationModifiers.Abstract => SyntaxFacts.GetText(SyntaxKind.AbstractKeyword),
                DeclarationModifiers.Sealed => SyntaxFacts.GetText(SyntaxKind.SealedKeyword),
                DeclarationModifiers.Static => SyntaxFacts.GetText(SyntaxKind.StaticKeyword),
                DeclarationModifiers.New => SyntaxFacts.GetText(SyntaxKind.NewKeyword),
                DeclarationModifiers.Public => SyntaxFacts.GetText(SyntaxKind.PublicKeyword),
                DeclarationModifiers.Protected => SyntaxFacts.GetText(SyntaxKind.ProtectedKeyword),
                DeclarationModifiers.Internal => SyntaxFacts.GetText(SyntaxKind.InternalKeyword),
                DeclarationModifiers.ProtectedInternal => SyntaxFacts.GetText(SyntaxKind.ProtectedKeyword) + " " + SyntaxFacts.GetText(SyntaxKind.InternalKeyword),
                DeclarationModifiers.Private => SyntaxFacts.GetText(SyntaxKind.PrivateKeyword),
                DeclarationModifiers.PrivateProtected => SyntaxFacts.GetText(SyntaxKind.PrivateKeyword) + " " + SyntaxFacts.GetText(SyntaxKind.ProtectedKeyword),
                DeclarationModifiers.ReadOnly => SyntaxFacts.GetText(SyntaxKind.ReadOnlyKeyword),
                DeclarationModifiers.Const => SyntaxFacts.GetText(SyntaxKind.ConstKeyword),
                DeclarationModifiers.Volatile => SyntaxFacts.GetText(SyntaxKind.VolatileKeyword),
                DeclarationModifiers.Extern => SyntaxFacts.GetText(SyntaxKind.ExternKeyword),
                DeclarationModifiers.Partial => SyntaxFacts.GetText(SyntaxKind.PartialKeyword),
                DeclarationModifiers.Unsafe => SyntaxFacts.GetText(SyntaxKind.UnsafeKeyword),
                DeclarationModifiers.Fixed => SyntaxFacts.GetText(SyntaxKind.FixedKeyword),
                DeclarationModifiers.Virtual => SyntaxFacts.GetText(SyntaxKind.VirtualKeyword),
                DeclarationModifiers.Override => SyntaxFacts.GetText(SyntaxKind.OverrideKeyword),
                DeclarationModifiers.Async => SyntaxFacts.GetText(SyntaxKind.AsyncKeyword),
                DeclarationModifiers.Ref => SyntaxFacts.GetText(SyntaxKind.RefKeyword),
                DeclarationModifiers.Required => SyntaxFacts.GetText(SyntaxKind.RequiredKeyword),
                DeclarationModifiers.Scoped => SyntaxFacts.GetText(SyntaxKind.ScopedKeyword),
                DeclarationModifiers.File => SyntaxFacts.GetText(SyntaxKind.FileKeyword),
                _ => throw ExceptionUtilities.UnexpectedValue(modifier),
            };
        }

        private static DeclarationModifiers ToDeclarationModifier(SyntaxKind kind)
        {
            return kind switch
            {
                SyntaxKind.AbstractKeyword => DeclarationModifiers.Abstract,
                SyntaxKind.AsyncKeyword => DeclarationModifiers.Async,
                SyntaxKind.SealedKeyword => DeclarationModifiers.Sealed,
                SyntaxKind.StaticKeyword => DeclarationModifiers.Static,
                SyntaxKind.NewKeyword => DeclarationModifiers.New,
                SyntaxKind.PublicKeyword => DeclarationModifiers.Public,
                SyntaxKind.ProtectedKeyword => DeclarationModifiers.Protected,
                SyntaxKind.InternalKeyword => DeclarationModifiers.Internal,
                SyntaxKind.PrivateKeyword => DeclarationModifiers.Private,
                SyntaxKind.ExternKeyword => DeclarationModifiers.Extern,
                SyntaxKind.ReadOnlyKeyword => DeclarationModifiers.ReadOnly,
                SyntaxKind.PartialKeyword => DeclarationModifiers.Partial,
                SyntaxKind.UnsafeKeyword => DeclarationModifiers.Unsafe,
                SyntaxKind.VirtualKeyword => DeclarationModifiers.Virtual,
                SyntaxKind.OverrideKeyword => DeclarationModifiers.Override,
                SyntaxKind.ConstKeyword => DeclarationModifiers.Const,
                SyntaxKind.FixedKeyword => DeclarationModifiers.Fixed,
                SyntaxKind.VolatileKeyword => DeclarationModifiers.Volatile,
                SyntaxKind.RefKeyword => DeclarationModifiers.Ref,
                SyntaxKind.RequiredKeyword => DeclarationModifiers.Required,
                SyntaxKind.ScopedKeyword => DeclarationModifiers.Scoped,
                SyntaxKind.FileKeyword => DeclarationModifiers.File,
                _ => throw ExceptionUtilities.UnexpectedValue(kind),
            };
        }

        public static void CheckForDuplicateModifiers(
            SyntaxTokenList modifiers,
            DiagnosticBag diagnostics)
        {
            GetDeclarationModifiersAndCheckForDuplicateModifiers(modifiers, diagnostics);
        }

        private static DeclarationModifiers GetDeclarationModifiersAndCheckForDuplicateModifiers(
            SyntaxTokenList modifiers,
            DiagnosticBag diagnostics)
        {
            var allModifiers = DeclarationModifiers.None;

            var seenNoDuplicates = true;
            foreach (var modifierToken in modifiers)
            {
                var thisModifier = ToDeclarationModifier(modifierToken.ContextualKind());
                ReportDuplicateModifiers(
                    modifierToken,
                    thisModifier,
                    allModifiers,
                    ref seenNoDuplicates,
                    diagnostics);

                allModifiers |= thisModifier;
            }

            return allModifiers;
        }

        public static DeclarationModifiers ToDeclarationModifiers(
            this SyntaxTokenList modifiers, bool isForTypeDeclaration, DiagnosticBag diagnostics, bool isOrdinaryMethod = false)
        {
            var result = GetDeclarationModifiersAndCheckForDuplicateModifiers(modifiers, diagnostics);
            if ((result & DeclarationModifiers.Partial) == DeclarationModifiers.Partial)
            {
                var i = modifiers.IndexOf(SyntaxKind.PartialKeyword);
                var modifier = modifiers[i];

                // `partial` must always be the last modifier according to the language.  However, there was a bug
                // where we allowed `partial async` at the end of modifiers on methods. We keep this behavior for
                // backcompat.
                var isLast = i == modifiers.Count - 1;
                var isPartialAsyncMethod = isOrdinaryMethod && i == modifiers.Count - 2 && modifiers[i + 1].ContextualKind() is SyntaxKind.AsyncKeyword;
                if (!isLast && !isPartialAsyncMethod)
                {
                    diagnostics.Add(
                        ErrorCode.ERR_PartialMisplaced,
                        modifier.GetLocation());
                }
            }

            switch (result & DeclarationModifiers.AccessibilityMask)
            {
                case DeclarationModifiers.Protected | DeclarationModifiers.Internal:
                    // the two keywords "protected" and "internal" together are treated as one modifier.
                    result &= ~DeclarationModifiers.AccessibilityMask;
                    result |= DeclarationModifiers.ProtectedInternal;
                    break;

                case DeclarationModifiers.Private | DeclarationModifiers.Protected:
                    // the two keywords "private" and "protected" together are treated as one modifier.
                    result &= ~DeclarationModifiers.AccessibilityMask;
                    result |= DeclarationModifiers.PrivateProtected;
                    break;
            }

            return result;
        }

        private static void ReportDuplicateModifiers(
            SyntaxToken modifierToken,
            DeclarationModifiers modifierKind,
            DeclarationModifiers allModifiers,
            ref bool seenNoDuplicates,
            DiagnosticBag diagnostics)
        {
            if ((allModifiers & modifierKind) != 0)
            {
                if (seenNoDuplicates)
                {
                    diagnostics.Add(
                        ErrorCode.ERR_DuplicateModifier,
                        modifierToken.GetLocation(),
                        SyntaxFacts.GetText(modifierToken.Kind()));
                    seenNoDuplicates = false;
                }
            }
        }

        internal static bool CheckAccessibility(DeclarationModifiers modifiers, Symbol symbol, bool isExplicitInterfaceImplementation, BindingDiagnosticBag diagnostics, Location errorLocation)
        {
            if (!IsValidAccessibility(modifiers))
            {
                // error CS0107: More than one protection modifier
                diagnostics.Add(ErrorCode.ERR_BadMemberProtection, errorLocation);
                return true;
            }

            if ((modifiers & DeclarationModifiers.Required) != 0)
            {
                var useSiteInfo = new CompoundUseSiteInfo<AssemblySymbol>(futureDestination: diagnostics, assemblyBeingBuilt: symbol.ContainingAssembly);
                bool reportedError = false;

                switch (symbol)
                {
                    case FieldSymbol when !symbol.IsAsRestrictive(symbol.ContainingType, ref useSiteInfo):
                    case PropertySymbol { SetMethod: { } method } when !method.IsAsRestrictive(symbol.ContainingType, ref useSiteInfo):
                        // Required member '{0}' cannot be less visible or have a setter less visible than the containing type '{1}'.
                        diagnostics.Add(ErrorCode.ERR_RequiredMemberCannotBeLessVisibleThanContainingType, errorLocation, symbol, symbol.ContainingType);
                        reportedError = true;
                        break;
                    case PropertySymbol { SetMethod: null }:
                    case FieldSymbol when (modifiers & DeclarationModifiers.ReadOnly) != 0:
                        // Required member '{0}' must be settable.
                        diagnostics.Add(ErrorCode.ERR_RequiredMemberMustBeSettable, errorLocation, symbol);
                        reportedError = true;
                        break;
                }

                diagnostics.Add(errorLocation, useSiteInfo);
                return reportedError;
            }

            return false;
        }

        // Returns declared accessibility.
        // In a case of bogus accessibility (i.e. "public private"), defaults to public.
        internal static Accessibility EffectiveAccessibility(DeclarationModifiers modifiers)
        {
            return (modifiers & DeclarationModifiers.AccessibilityMask) switch
            {
                DeclarationModifiers.None => Accessibility.NotApplicable,// for explicit interface implementation
                DeclarationModifiers.Private => Accessibility.Private,
                DeclarationModifiers.Protected => Accessibility.Protected,
                DeclarationModifiers.Internal => Accessibility.Internal,
                DeclarationModifiers.Public => Accessibility.Public,
                DeclarationModifiers.ProtectedInternal => Accessibility.ProtectedOrInternal,
                DeclarationModifiers.PrivateProtected => Accessibility.ProtectedAndInternal,
                _ => Accessibility.Public,// This happens when you have a mix of accessibilities.
                                          //
                                          // i.e.: public private void Goo()
            };
        }

        internal static bool IsValidAccessibility(DeclarationModifiers modifiers)
        {
            return (modifiers & DeclarationModifiers.AccessibilityMask) switch
            {
                DeclarationModifiers.None or DeclarationModifiers.Private or DeclarationModifiers.Protected or DeclarationModifiers.Internal or DeclarationModifiers.Public or DeclarationModifiers.ProtectedInternal or DeclarationModifiers.PrivateProtected => true,
                _ => false,// This happens when you have a mix of accessibilities.
                           //
                           // i.e.: public private void Goo()
            };
        }
    }
}
