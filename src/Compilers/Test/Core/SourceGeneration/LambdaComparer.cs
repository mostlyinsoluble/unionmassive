// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Roslyn.Test.Utilities.TestGenerators
{
    public sealed class LambdaComparer<T>(Func<T?, T?, bool> equal, int? hashCode = null) : IEqualityComparer<T>
    {
        private readonly Func<T?, T?, bool> _equal = equal;
        private readonly int? _hashCode = hashCode;

        public bool Equals(T? x, T? y) => _equal(x, y);

        public int GetHashCode([DisallowNull] T obj) => _hashCode.HasValue ? _hashCode.Value : EqualityComparer<T>.Default.GetHashCode(obj);
    }
}
