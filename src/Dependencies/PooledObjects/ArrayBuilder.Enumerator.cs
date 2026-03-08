// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

namespace Microsoft.CodeAnalysis.PooledObjects
{
    internal partial class ArrayBuilder<T>
    {
        /// <summary>
        /// struct enumerator used in foreach.
        /// </summary>
        internal struct Enumerator(ArrayBuilder<T> builder)
        {
            private readonly ArrayBuilder<T> _builder = builder;
            private int _index = -1;

            public readonly T Current
            {
                get
                {
                    return _builder[_index];
                }
            }

            public bool MoveNext()
            {
                _index++;
                return _index < _builder.Count;
            }
        }
    }
}
