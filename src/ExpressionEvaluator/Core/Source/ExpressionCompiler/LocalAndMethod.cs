// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.Debugger.Evaluation.ClrCompilation;

namespace Microsoft.CodeAnalysis.ExpressionEvaluator
{
    /// <summary>
    /// The name of a local or argument and the name of
    /// the corresponding method to access that object.
    /// </summary>
    internal abstract class LocalAndMethod(string localName, string localDisplayName, string methodName, DkmClrCompilationResultFlags flags)
    {
        public readonly string LocalName = localName;
        public readonly string LocalDisplayName = localDisplayName;
        public readonly string MethodName = methodName;
        public readonly DkmClrCompilationResultFlags Flags = flags;

        public abstract Guid GetCustomTypeInfo(out ReadOnlyCollection<byte>? payload);
    }
}
