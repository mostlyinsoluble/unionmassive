// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Xunit.Harness
{
    using System.Reflection;
    using Xunit.Abstractions;
    using Xunit.Sdk;

    public class IdeTestFramework(IMessageSink diagnosticMessageSink) : XunitTestFramework(diagnosticMessageSink)
    {
        protected override ITestFrameworkExecutor CreateExecutor(AssemblyName assemblyName)
        {
            return new IdeTestFrameworkExecutor(assemblyName, SourceInformationProvider, DiagnosticMessageSink);
        }
    }
}
