// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.Preview;

internal abstract partial class ReferenceChange : AbstractChange
{
    private sealed class AnalyzerReferenceChange(AnalyzerReference reference, ProjectId projectId, string projectName, bool isAdded, PreviewEngine engine) : ReferenceChange(projectId, projectName, isAdded, engine)
    {
        private readonly AnalyzerReference _reference = reference;

        internal override Solution AddToSolution(Solution solution)
            => solution.AddAnalyzerReference(this.ProjectId, _reference);

        internal override Solution RemoveFromSolution(Solution solution)
            => solution.RemoveAnalyzerReference(this.ProjectId, _reference);

        protected override string GetDisplayText()
        {
            var display = _reference.Display ?? ServicesVSResources.Unknown1;
            return string.Format(ServicesVSResources.Analyzer_reference_to_0_in_project_1, display, this.ProjectName);
        }
    }
}
