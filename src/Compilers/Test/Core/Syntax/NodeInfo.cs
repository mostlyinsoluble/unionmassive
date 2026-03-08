// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
    //Contains the information about a SyntaxNode that is difficult to get from a variable
    //just typed as SyntaxNode. This is name/type/value information for all fields and children.
    public partial class NodeInfo(string className, NodeInfo.FieldInfo[] fieldInfos)
    {
        private readonly string _className = className;
        private readonly FieldInfo[] _fieldInfos = fieldInfos;
        private static readonly FieldInfo[] s_emptyFieldInfos = { };

        public string ClassName
        {
            get
            {
                return _className;
            }
        }

        public FieldInfo[] FieldInfos
        {
            get
            {
                if (_fieldInfos == null)
                {
                    return s_emptyFieldInfos;
                }
                else
                {
                    return _fieldInfos;
                }
            }
        }
    }
}
