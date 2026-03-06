// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Windows.Media;
using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.Language.Intellisense;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.Utilities;

internal static class GlyphExtensions
{
    public static StandardGlyphGroup GetStandardGlyphGroup(this Glyph glyph)
    {
        return glyph switch
        {
            Glyph.Assembly => StandardGlyphGroup.GlyphAssembly,
            Glyph.BasicFile or Glyph.BasicProject => StandardGlyphGroup.GlyphVBProject,
            Glyph.ClassPublic or Glyph.ClassProtected or Glyph.ClassPrivate or Glyph.ClassInternal => StandardGlyphGroup.GlyphGroupClass,
            Glyph.ConstantPublic or Glyph.ConstantProtected or Glyph.ConstantPrivate or Glyph.ConstantInternal => StandardGlyphGroup.GlyphGroupConstant,
            Glyph.CSharpFile => StandardGlyphGroup.GlyphCSharpFile,
            Glyph.CSharpProject => StandardGlyphGroup.GlyphCoolProject,
            Glyph.DelegatePublic or Glyph.DelegateProtected or Glyph.DelegatePrivate or Glyph.DelegateInternal => StandardGlyphGroup.GlyphGroupDelegate,
            Glyph.EnumPublic or Glyph.EnumProtected or Glyph.EnumPrivate or Glyph.EnumInternal => StandardGlyphGroup.GlyphGroupEnum,
            Glyph.EnumMemberPublic or Glyph.EnumMemberProtected or Glyph.EnumMemberPrivate or Glyph.EnumMemberInternal => StandardGlyphGroup.GlyphGroupEnumMember,
            Glyph.Error => StandardGlyphGroup.GlyphGroupError,
            Glyph.ExtensionMethodPublic => StandardGlyphGroup.GlyphExtensionMethod,
            Glyph.ExtensionMethodProtected => StandardGlyphGroup.GlyphExtensionMethodProtected,
            Glyph.ExtensionMethodPrivate => StandardGlyphGroup.GlyphExtensionMethodPrivate,
            Glyph.ExtensionMethodInternal => StandardGlyphGroup.GlyphExtensionMethodInternal,
            Glyph.EventPublic or Glyph.EventProtected or Glyph.EventPrivate or Glyph.EventInternal => StandardGlyphGroup.GlyphGroupEvent,
            Glyph.FieldPublic or Glyph.FieldProtected or Glyph.FieldPrivate or Glyph.FieldInternal => StandardGlyphGroup.GlyphGroupField,
            Glyph.InterfacePublic or Glyph.InterfaceProtected or Glyph.InterfacePrivate or Glyph.InterfaceInternal => StandardGlyphGroup.GlyphGroupInterface,
            Glyph.Intrinsic => StandardGlyphGroup.GlyphGroupIntrinsic,
            Glyph.Keyword => StandardGlyphGroup.GlyphKeyword,
            Glyph.Label => StandardGlyphGroup.GlyphGroupIntrinsic,
            Glyph.Local => StandardGlyphGroup.GlyphGroupVariable,
            Glyph.Namespace => StandardGlyphGroup.GlyphGroupNamespace,
            Glyph.MethodPublic or Glyph.MethodProtected or Glyph.MethodPrivate or Glyph.MethodInternal => StandardGlyphGroup.GlyphGroupMethod,
            Glyph.ModulePublic or Glyph.ModuleProtected or Glyph.ModulePrivate or Glyph.ModuleInternal => StandardGlyphGroup.GlyphGroupModule,
            Glyph.OpenFolder => StandardGlyphGroup.GlyphOpenFolder,
            Glyph.OperatorPublic or Glyph.OperatorProtected or Glyph.OperatorPrivate or Glyph.OperatorInternal => StandardGlyphGroup.GlyphGroupOperator,
            Glyph.Parameter => StandardGlyphGroup.GlyphGroupVariable,
            Glyph.PropertyPublic or Glyph.PropertyProtected or Glyph.PropertyPrivate or Glyph.PropertyInternal => StandardGlyphGroup.GlyphGroupProperty,
            Glyph.RangeVariable => StandardGlyphGroup.GlyphGroupVariable,
            Glyph.Reference => StandardGlyphGroup.GlyphReference,
            Glyph.StructurePublic or Glyph.StructureProtected or Glyph.StructurePrivate or Glyph.StructureInternal => StandardGlyphGroup.GlyphGroupStruct,
            Glyph.TypeParameter => StandardGlyphGroup.GlyphGroupType,
            Glyph.Snippet => StandardGlyphGroup.GlyphCSharpExpansion,
            Glyph.CompletionWarning => StandardGlyphGroup.GlyphCompletionWarning,
            _ => throw new ArgumentException("glyph"),
        };
    }

    public static StandardGlyphItem GetStandardGlyphItem(this Glyph icon)
    {
        return icon switch
        {
            Glyph.ClassProtected or Glyph.ConstantProtected or Glyph.DelegateProtected or Glyph.EnumProtected or Glyph.EventProtected or Glyph.FieldProtected or Glyph.InterfaceProtected or Glyph.MethodProtected or Glyph.ModuleProtected or Glyph.PropertyProtected or Glyph.StructureProtected => StandardGlyphItem.GlyphItemProtected,
            Glyph.ClassPrivate or Glyph.ConstantPrivate or Glyph.DelegatePrivate or Glyph.EnumPrivate or Glyph.EventPrivate or Glyph.FieldPrivate or Glyph.InterfacePrivate or Glyph.MethodPrivate or Glyph.ModulePrivate or Glyph.PropertyPrivate or Glyph.StructurePrivate => StandardGlyphItem.GlyphItemPrivate,
            Glyph.ClassInternal or Glyph.ConstantInternal or Glyph.DelegateInternal or Glyph.EnumInternal or Glyph.EventInternal or Glyph.FieldInternal or Glyph.InterfaceInternal or Glyph.MethodInternal or Glyph.ModuleInternal or Glyph.PropertyInternal or Glyph.StructureInternal => StandardGlyphItem.GlyphItemFriend,
            _ => StandardGlyphItem.GlyphItemPublic,// We don't want any overlays
        };
    }

    public static ImageSource GetImageSource(this Glyph glyph, IGlyphService glyphService)
        => glyphService.GetGlyph(glyph.GetStandardGlyphGroup(), glyph.GetStandardGlyphItem());

    public static ushort GetGlyphIndex(this Glyph glyph)
    {
        var glyphGroup = glyph.GetStandardGlyphGroup();
        var glyphItem = glyph.GetStandardGlyphItem();

        return glyphGroup < StandardGlyphGroup.GlyphGroupError
            ? (ushort)((int)glyphGroup + (int)glyphItem)
            : (ushort)glyphGroup;
    }
}
