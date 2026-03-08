// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.ComponentModel.Composition;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.Internal.VisualStudio.Shell.ErrorList;
using Microsoft.VisualStudio.Shell.TableControl;
using Microsoft.VisualStudio.Shell.TableManager;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.FindUsages;

internal static class RichNavOptions
{
    internal const string RichNavAvailableOptionName = "RichNavAvailable";
}

[Export(typeof(IScopeFilterFactory))]
[TableManagerIdentifier("FindAllReferences*")]
[TableManagerIdentifier("FindResults*")]
[Replaces(PredefinedScopeFilterNames.EntireSolutionScopeFilter)]
[Replaces(PredefinedScopeFilterNames.AllItemsScopeFilter)]
[DeferCreation(OptionName = RichNavOptions.RichNavAvailableOptionName)] // This factory will not be loaded unless this option is set to Boolean true
[DefaultScope]
[Name(PredefinedScopeFilterNames.LoadedSolutionScopeFilter)]
[Order(Before = PredefinedScopeFilterNames.AllItemsScopeFilter)]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class LoadedSolutionScopeFilterFactory() : IReplacingScopeFilterFactory
{
    public IErrorListFilterHandler CreateFilter(IWpfTableControl tableControl)
    {
        // We're only replacing an existing filter, and not creating a new one.
        return null;
    }

    public IErrorListFilterHandler ReplaceFilter(IWpfTableControl tableControl, string filterIdentifier)
    {
        if (filterIdentifier == PredefinedScopeFilterNames.AllItemsScopeFilter)
        {
            return new LoadedSolutionFilterHandler(ServicesVSResources.Loaded_items);
        }
        else if (filterIdentifier == PredefinedScopeFilterNames.EntireSolutionScopeFilter)
        {
            return new LoadedSolutionFilterHandler(ServicesVSResources.Loaded_solution);
        }

        return null; // Don't replace
    }
}

internal abstract class RoslynFilterHandler(int id, string displayName, ItemOrigin origin) : FilterHandlerBase
{
    private readonly ItemOrigin _origin = origin;

    public sealed override int FilterId { get; } = id;

    public sealed override string FilterDisplayName { get; } = displayName;

    public sealed override IEntryFilter GetFilter(out string displayText)
    {
        displayText = FilterDisplayName;
        return new ItemOriginFilter(_origin);
    }
}

internal sealed class LoadedSolutionFilterHandler(string displayName) : RoslynFilterHandler(LoadedSolutionFilterHandlerFilterId, displayName, ItemOrigin.ExactMetadata)
{
    private const int LoadedSolutionFilterHandlerFilterId = 20;
}

[Export(typeof(IScopeFilterFactory))]
[TableManagerIdentifier("FindAllReferences*")]
[TableManagerIdentifier("FindResults*")]
[DeferCreation(OptionName = RichNavOptions.RichNavAvailableOptionName)] // This factory will not be loaded unless this option is set to Boolean true
[Name(AllSourcesFilterHandlerFactory.AllSourcesScopeFilter)]
[Order(Before = PredefinedScopeFilterNames.EntireRepositoryScopeFilter)]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class AllSourcesFilterHandlerFactory() : IScopeFilterFactory
{
    private const string AllSourcesScopeFilter = "All Sources";

    public IErrorListFilterHandler CreateFilter(IWpfTableControl tableControl)
        => new AllSourcesFilterHandler();
}

internal sealed class AllSourcesFilterHandler : RoslynFilterHandler
{
    private const int AllSourcesFilterHandlerFilterId = 22;

    public AllSourcesFilterHandler()
        : base(AllSourcesFilterHandlerFilterId, ServicesVSResources.All_sources, ItemOrigin.IndexedInThirdParty)
    {
    }
}

[Export(typeof(IScopeFilterFactory))]
[TableManagerIdentifier("FindAllReferences*")]
[TableManagerIdentifier("FindResults*")]
[DeferCreation(OptionName = RichNavOptions.RichNavAvailableOptionName)] // This factory will not be loaded unless this option is set to Boolean true
[Name(PredefinedScopeFilterNames.EntireRepositoryScopeFilter)]
[Order(Before = PredefinedScopeFilterNames.LoadedSolutionScopeFilter)]
[method: ImportingConstructor]
[method: Obsolete(MefConstruction.ImportingConstructorMessage, error: true)]
internal sealed class EntireRepositoryFilterHandlerFactory() : IScopeFilterFactory
{
    public IErrorListFilterHandler CreateFilter(IWpfTableControl tableControl)
        => new EntireRepositoryFilterHandler();
}

internal sealed class EntireRepositoryFilterHandler : RoslynFilterHandler
{
    private const int EntireRepositoryFilterHandlerFilterId = 21;

    public EntireRepositoryFilterHandler()
        : base(EntireRepositoryFilterHandlerFilterId, ServicesVSResources.Entire_repository, ItemOrigin.IndexedInRepo)
    {
    }
}

internal sealed class ItemOriginFilter : IEntryFilter
{
    private readonly ItemOrigin _targetOrigin;

    internal ItemOriginFilter(ItemOrigin targetOrigin)
        => _targetOrigin = targetOrigin;

    public bool Match(ITableEntryHandle entry)
    {
        Requires.NotNull(entry, nameof(entry));

        if (entry.TryGetValue(StandardTableKeyNames.ItemOrigin, out ItemOrigin entryOrigin))
            return entryOrigin <= _targetOrigin;

        // For backwards compatibility, consider items without ItemOrigin to be ItemOrigin.Exact (always matched)
        return true;
    }
}
