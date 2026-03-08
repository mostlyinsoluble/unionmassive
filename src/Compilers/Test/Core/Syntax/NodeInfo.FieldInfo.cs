// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    public partial class NodeInfo
    {
        //Package of information containing the name, type, and value of a field on a syntax node.
        public class FieldInfo(string propertyName, Type fieldType, object value)
        {
            private readonly string _propertyName = propertyName;
            private readonly Type _fieldType = fieldType;
            private readonly object _value = value;
            public string PropertyName
            {
                get
                {
                    return _propertyName;
                }
            }

            public Type FieldType
            {
                get
                {
                    return _fieldType;
                }
            }

            public object Value
            {
                get
                {
                    return _value;
                }
            }
        }
    }
}
