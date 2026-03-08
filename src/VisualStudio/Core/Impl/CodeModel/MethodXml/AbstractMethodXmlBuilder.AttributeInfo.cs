// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.VisualStudio.LanguageServices.Implementation.CodeModel.MethodXml;

internal abstract partial class AbstractMethodXmlBuilder
{
    private readonly struct AttributeInfo(string name, string value)
    {
        public static readonly AttributeInfo Empty = new();

        public readonly string Name = name;
        public readonly string Value = value;

        public bool IsEmpty
        {
            get
            {
                return this.Name == null
                    && this.Value == null;
            }
        }
    }
}
