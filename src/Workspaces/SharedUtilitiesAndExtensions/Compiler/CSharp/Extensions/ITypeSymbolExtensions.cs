// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Shared.Extensions;

namespace Microsoft.CodeAnalysis.CSharp.Extensions;

internal static partial class ITypeSymbolExtensions
{
    public static bool IsIntrinsicType(this ITypeSymbol typeSymbol)
    {
        return typeSymbol.SpecialType switch
        {
            SpecialType.System_Boolean or SpecialType.System_Char or SpecialType.System_SByte or SpecialType.System_Int16 or SpecialType.System_Int32 or SpecialType.System_Int64 or SpecialType.System_Byte or SpecialType.System_UInt16 or SpecialType.System_UInt32 or SpecialType.System_UInt64 or SpecialType.System_Single or SpecialType.System_Double or SpecialType.System_Decimal => true,
            _ => false,
        };
    }

    public static bool TryGetPrimaryConstructor(this INamedTypeSymbol typeSymbol, [NotNullWhen(true)] out IMethodSymbol? primaryConstructor)
    {
        if (typeSymbol.TypeKind is TypeKind.Class or TypeKind.Struct)
        {
            Debug.Assert(typeSymbol.GetParameters().IsDefaultOrEmpty, "If GetParameters extension handles record, we can remove the handling here.");

            // A bit hacky to determine the parameters of primary constructor associated with a given record.
            // Simplifying is tracked by: https://github.com/dotnet/roslyn/issues/53092. Note: When the issue is
            // handled, we can remove the logic here and handle things in GetParameters extension. BUT if GetParameters
            // extension method gets updated to handle records, we need to test EVERY usage of the extension method and
            // make sure the change is applicable to all these usages.

            primaryConstructor = typeSymbol.InstanceConstructors.FirstOrDefault(
                c => c.DeclaringSyntaxReferences.FirstOrDefault()?.GetSyntax() is TypeDeclarationSyntax);
            return primaryConstructor is not null;
        }

        primaryConstructor = null;
        return false;
    }
}
