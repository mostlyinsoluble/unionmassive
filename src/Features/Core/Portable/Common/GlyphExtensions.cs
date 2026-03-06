// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.FindSymbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Shared.Extensions;
using Microsoft.CodeAnalysis.Tags;

namespace Microsoft.CodeAnalysis;

internal static class GlyphExtensions
{
    public static ImmutableArray<Glyph> GetGlyphs(this ImmutableArray<string> tags)
        => GetGlyphs(tags.AsSpan());

    public static ImmutableArray<Glyph> GetGlyphs(this ReadOnlySpan<string> tags)
    {
        using var _ = ArrayBuilder<Glyph>.GetInstance(tags.Length, out var builder);

        foreach (var tag in tags)
        {
            var glyph = GetGlyph(tag, tags);
            if (glyph != Glyph.None)
                builder.Add(glyph);
        }

        return builder.ToImmutableAndClear();
    }

    public static Glyph GetFirstGlyph(this ImmutableArray<string> tags)
        => tags.AsSpan().GetFirstGlyph();

    public static Glyph GetFirstGlyph(this ReadOnlySpan<string> tags)
    {
        foreach (var tag in tags)
        {
            var glyph = GetGlyph(tag, tags);
            if (glyph != Glyph.None)
                return glyph;
        }

        return Glyph.None;
    }

    private static Glyph GetGlyph(string tag, ReadOnlySpan<string> allTags)
    {
        return tag switch
        {
            WellKnownTags.Assembly => Glyph.Assembly,
            WellKnownTags.File => allTags.Contains(LanguageNames.VisualBasic) ? Glyph.BasicFile : Glyph.CSharpFile,
            WellKnownTags.Project => allTags.Contains(LanguageNames.VisualBasic) ? Glyph.BasicProject : Glyph.CSharpProject,
            WellKnownTags.Class => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.ClassProtected,
                Accessibility.Private => Glyph.ClassPrivate,
                Accessibility.Internal => Glyph.ClassInternal,
                _ => Glyph.ClassPublic,
            },
            WellKnownTags.Constant => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.ConstantProtected,
                Accessibility.Private => Glyph.ConstantPrivate,
                Accessibility.Internal => Glyph.ConstantInternal,
                _ => Glyph.ConstantPublic,
            },
            WellKnownTags.Delegate => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.DelegateProtected,
                Accessibility.Private => Glyph.DelegatePrivate,
                Accessibility.Internal => Glyph.DelegateInternal,
                _ => Glyph.DelegatePublic,
            },
            WellKnownTags.Enum => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.EnumProtected,
                Accessibility.Private => Glyph.EnumPrivate,
                Accessibility.Internal => Glyph.EnumInternal,
                _ => Glyph.EnumPublic,
            },
            WellKnownTags.EnumMember => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.EnumMemberProtected,
                Accessibility.Private => Glyph.EnumMemberPrivate,
                Accessibility.Internal => Glyph.EnumMemberInternal,
                _ => Glyph.EnumMemberPublic,
            },
            WellKnownTags.Error => Glyph.Error,
            WellKnownTags.Event => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.EventProtected,
                Accessibility.Private => Glyph.EventPrivate,
                Accessibility.Internal => Glyph.EventInternal,
                _ => Glyph.EventPublic,
            },
            WellKnownTags.ExtensionMethod => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.ExtensionMethodProtected,
                Accessibility.Private => Glyph.ExtensionMethodPrivate,
                Accessibility.Internal => Glyph.ExtensionMethodInternal,
                _ => Glyph.ExtensionMethodPublic,
            },
            WellKnownTags.Field => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.FieldProtected,
                Accessibility.Private => Glyph.FieldPrivate,
                Accessibility.Internal => Glyph.FieldInternal,
                _ => Glyph.FieldPublic,
            },
            WellKnownTags.Interface => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.InterfaceProtected,
                Accessibility.Private => Glyph.InterfacePrivate,
                Accessibility.Internal => Glyph.InterfaceInternal,
                _ => Glyph.InterfacePublic,
            },
            WellKnownTags.TargetTypeMatch => Glyph.TargetTypeMatch,
            WellKnownTags.Intrinsic => Glyph.Intrinsic,
            WellKnownTags.Keyword => Glyph.Keyword,
            WellKnownTags.Label => Glyph.Label,
            WellKnownTags.Local => Glyph.Local,
            WellKnownTags.Namespace => Glyph.Namespace,
            WellKnownTags.Method => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.MethodProtected,
                Accessibility.Private => Glyph.MethodPrivate,
                Accessibility.Internal => Glyph.MethodInternal,
                _ => Glyph.MethodPublic,
            },
            WellKnownTags.Module => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.ModuleProtected,
                Accessibility.Private => Glyph.ModulePrivate,
                Accessibility.Internal => Glyph.ModuleInternal,
                _ => Glyph.ModulePublic,
            },
            WellKnownTags.Folder => Glyph.OpenFolder,
            WellKnownTags.Operator => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.OperatorProtected,
                Accessibility.Private => Glyph.OperatorPrivate,
                Accessibility.Internal => Glyph.OperatorInternal,
                _ => Glyph.OperatorPublic,
            },
            WellKnownTags.Parameter => Glyph.Parameter,
            WellKnownTags.Property => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.PropertyProtected,
                Accessibility.Private => Glyph.PropertyPrivate,
                Accessibility.Internal => Glyph.PropertyInternal,
                _ => Glyph.PropertyPublic,
            },
            WellKnownTags.RangeVariable => Glyph.RangeVariable,
            WellKnownTags.Reference => Glyph.Reference,
            WellKnownTags.NuGet => Glyph.NuGet,
            WellKnownTags.Structure => GetAccessibility(allTags) switch
            {
                Accessibility.Protected => Glyph.StructureProtected,
                Accessibility.Private => Glyph.StructurePrivate,
                Accessibility.Internal => Glyph.StructureInternal,
                _ => Glyph.StructurePublic,
            },
            WellKnownTags.TypeParameter => Glyph.TypeParameter,
            WellKnownTags.Snippet => Glyph.Snippet,
            WellKnownTags.Warning => Glyph.CompletionWarning,
            WellKnownTags.StatusInformation => Glyph.StatusInformation,
            WellKnownTags.Copilot => Glyph.Copilot,
            _ => Glyph.None,
        };
    }

    public static Accessibility GetAccessibility(ImmutableArray<string> tags)
        => GetAccessibility(tags.AsSpan());

    public static Accessibility GetAccessibility(ReadOnlySpan<string> tags)
    {
        foreach (var tag in tags)
        {
            switch (tag)
            {
                case WellKnownTags.Public:
                    return Accessibility.Public;
                case WellKnownTags.Protected:
                    return Accessibility.Protected;
                case WellKnownTags.Internal:
                    return Accessibility.Internal;
                case WellKnownTags.Private:
                    return Accessibility.Private;
            }
        }

        return Accessibility.NotApplicable;
    }

    public static Glyph GetGlyph(DeclaredSymbolInfoKind kind, Accessibility accessibility)
    {
        // Glyphs are stored in this order:
        //  ClassPublic,
        //  ClassProtected,
        //  ClassPrivate,
        //  ClassInternal,

        var rawGlyph = GetPublicGlyph(kind);

        switch (accessibility)
        {
            case Accessibility.Private:
                rawGlyph += (Glyph.ClassPrivate - Glyph.ClassPublic);
                break;
            case Accessibility.Internal:
                rawGlyph += (Glyph.ClassInternal - Glyph.ClassPublic);
                break;
            case Accessibility.Protected:
            case Accessibility.ProtectedOrInternal:
            case Accessibility.ProtectedAndInternal:
                rawGlyph += (Glyph.ClassProtected - Glyph.ClassPublic);
                break;
        }

        return rawGlyph;
    }

    private static Glyph GetPublicGlyph(DeclaredSymbolInfoKind kind)
        => kind switch
        {
            DeclaredSymbolInfoKind.Class => Glyph.ClassPublic,
            DeclaredSymbolInfoKind.Constant => Glyph.ConstantPublic,
            DeclaredSymbolInfoKind.Constructor => Glyph.MethodPublic,
            DeclaredSymbolInfoKind.Delegate => Glyph.DelegatePublic,
            DeclaredSymbolInfoKind.Enum => Glyph.EnumPublic,
            DeclaredSymbolInfoKind.EnumMember => Glyph.EnumMemberPublic,
            DeclaredSymbolInfoKind.Event => Glyph.EventPublic,
            DeclaredSymbolInfoKind.ExtensionMethod => Glyph.ExtensionMethodPublic,
            DeclaredSymbolInfoKind.Field => Glyph.FieldPublic,
            DeclaredSymbolInfoKind.Indexer => Glyph.PropertyPublic,
            DeclaredSymbolInfoKind.Interface => Glyph.InterfacePublic,
            DeclaredSymbolInfoKind.Method => Glyph.MethodPublic,
            DeclaredSymbolInfoKind.Module => Glyph.ModulePublic,
            DeclaredSymbolInfoKind.Operator => Glyph.OperatorPublic,
            DeclaredSymbolInfoKind.Property => Glyph.PropertyPublic,
            DeclaredSymbolInfoKind.Struct => Glyph.StructurePublic,
            DeclaredSymbolInfoKind.RecordStruct => Glyph.StructurePublic,
            _ => Glyph.ClassPublic,
        };
}
