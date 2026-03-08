// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Composition;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.Shared.TestHooks;

namespace Microsoft.CodeAnalysis.ExternalAccess.Razor
{
    [Export(typeof(IRazorAsynchronousOperationListenerProviderAccessor))]
    [Shared]
    [method: ImportingConstructor]
    [method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
    internal sealed class RazorAsynchronousOperationListenerProviderAccessor(
        IAsynchronousOperationListenerProvider implementation) : IRazorAsynchronousOperationListenerProviderAccessor
    {
        private readonly IAsynchronousOperationListenerProvider _implementation = implementation;

        public RazorAsynchronousOperationListenerWrapper GetListener(string featureName)
        {
            var inner = _implementation.GetListener(featureName);
            var razorListener = new RazorAsynchronousOperationListenerWrapper(inner);

            return razorListener;
        }
    }
}
