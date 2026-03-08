// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Xunit.OutOfProcess
{
    using Xunit.Harness;
    using Xunit.InProcess;

    internal abstract class OutOfProcComponent(VisualStudioInstance visualStudioInstance)
    {
        protected VisualStudioInstance VisualStudioInstance
        {
            get;
        } = visualStudioInstance;

        internal static TInProcComponent CreateInProcComponent<TInProcComponent>(VisualStudioInstance visualStudioInstance)
            where TInProcComponent : InProcComponent
        {
            return visualStudioInstance.ExecuteInHostProcess<TInProcComponent>(type: typeof(TInProcComponent), methodName: "Create");
        }
    }
}
