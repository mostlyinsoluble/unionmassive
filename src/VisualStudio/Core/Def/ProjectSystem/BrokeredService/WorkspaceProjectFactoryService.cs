// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Remote.ProjectSystem;

namespace Microsoft.VisualStudio.LanguageServices.ProjectSystem.BrokeredService;

internal sealed class WorkspaceProjectFactoryService(IWorkspaceProjectContextFactory workspaceProjectContextFactory) : IWorkspaceProjectFactoryService
{
    private readonly IWorkspaceProjectContextFactory _workspaceProjectContextFactory = workspaceProjectContextFactory;

    public async Task<IWorkspaceProject> CreateAndAddProjectAsync(WorkspaceProjectCreationInfo creationInfo, CancellationToken cancellationToken)
    {
        var project = await _workspaceProjectContextFactory.CreateProjectContextAsync(
            Guid.NewGuid(), // TODO: figure out some other side-channel way of communicating this
            creationInfo.DisplayName,
            creationInfo.Language,
            new EvaluationDataShim(creationInfo.BuildSystemProperties),
            hostObject: null, // TODO: figure out some other side-channel way of communicating this
            cancellationToken).ConfigureAwait(false);

        return new WorkspaceProject(project);
    }

    public Task<IReadOnlyCollection<string>> GetSupportedBuildSystemPropertiesAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult((IReadOnlyCollection<string>)_workspaceProjectContextFactory.EvaluationItemNames);
    }

    private sealed class EvaluationDataShim(IReadOnlyDictionary<string, string> buildSystemProperties) : EvaluationData
    {
        private readonly IReadOnlyDictionary<string, string> _buildSystemProperties = buildSystemProperties;

        public override string GetPropertyValue(string name)
        {
            return _buildSystemProperties.TryGetValue(name, out var value) ? value : "";
        }
    }
}
