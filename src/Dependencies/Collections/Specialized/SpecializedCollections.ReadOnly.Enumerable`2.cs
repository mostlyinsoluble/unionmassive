// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Collections
{
    internal partial class SpecializedCollections
    {
        private partial class ReadOnly
        {
            internal class Enumerable<TUnderlying, T>(TUnderlying underlying) : Enumerable<TUnderlying>(underlying), IEnumerable<T>
                where TUnderlying : IEnumerable<T>
            {
                public new IEnumerator<T> GetEnumerator()
                {
                    return this.Underlying.GetEnumerator();
                }
            }
        }
    }
}
