// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

extern alias SCRIPTING;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Text;
using Microsoft.VisualStudio.Composition;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editor.UnitTests.CodeActions;
using Microsoft.CodeAnalysis.Editor.UnitTests.Extensions;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.Notification;
using Microsoft.CodeAnalysis.Options;
using Microsoft.CodeAnalysis.Serialization;
using Microsoft.CodeAnalysis.UnitTests;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;
using RuntimeMetadataReferenceResolver = SCRIPTING::Microsoft.CodeAnalysis.Scripting.Hosting.RuntimeMetadataReferenceResolver;
using System.Collections.ObjectModel;
using System.IO;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.VisualBasic;
using Microsoft.CodeAnalysis.CSharp;
using Roslyn.Test.Utilities.TestGenerators;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace Microsoft.CodeAnalysis.Test.Utilities;

public class TestWorkspace : TestWorkspace<TestHostDocument, TestHostProject, TestHostSolution>
{
    public static string RootDirectory => TempRoot.Root;

    internal TestWorkspace(
        TestComposition? composition = null,
        string? workspaceKind = WorkspaceKind.Host,
        Guid solutionTelemetryId = default,
        bool disablePartialSolutions = true,
        bool ignoreUnchangeableDocumentsWhenApplyingChanges = true,
        WorkspaceConfigurationOptions? configurationOptions = null)
        : base(composition,
               workspaceKind,
               solutionTelemetryId,
               disablePartialSolutions,
               ignoreUnchangeableDocumentsWhenApplyingChanges,
               configurationOptions)
    {
    }

    internal TestWorkspace(
        ExportProvider exportProvider,
        string? workspaceKind = WorkspaceKind.Host,
        Guid solutionTelemetryId = default,
        bool disablePartialSolutions = true,
        bool ignoreUnchangeableDocumentsWhenApplyingChanges = true,
        WorkspaceConfigurationOptions? configurationOptions = null)
        : base(exportProvider,
               workspaceKind,
               solutionTelemetryId,
               disablePartialSolutions,
               ignoreUnchangeableDocumentsWhenApplyingChanges,
               configurationOptions)
    {
    }

    private protected override TestHostDocument CreateDocument(
        string text = "",
        string displayName = "",
        SourceCodeKind sourceCodeKind = SourceCodeKind.Regular,
        DocumentId? id = null,
        string? filePath = null,
        IReadOnlyList<string>? folders = null,
        ExportProvider? exportProvider = null,
        IDocumentServiceProvider? documentServiceProvider = null)
        => new(text, displayName, sourceCodeKind, id, filePath, folders, exportProvider, documentServiceProvider);

    private protected override TestHostDocument CreateDocument(
        ExportProvider exportProvider,
        HostLanguageServices? languageServiceProvider,
        string code,
        string name,
        string filePath,
        int? cursorPosition,
        IDictionary<string, ImmutableArray<TextSpan>> spans,
        SourceCodeKind sourceCodeKind = SourceCodeKind.Regular,
        IReadOnlyList<string>? folders = null,
        bool isLinkFile = false,
        IDocumentServiceProvider? documentServiceProvider = null,
        ISourceGenerator? generator = null)
        => new(exportProvider, languageServiceProvider, code, name, filePath, cursorPosition, spans, sourceCodeKind, folders, isLinkFile, documentServiceProvider, generator);

    private protected override TestHostProject CreateProject(
        HostLanguageServices languageServices,
        CompilationOptions? compilationOptions,
        ParseOptions? parseOptions,
        string assemblyName,
        string projectName,
        IList<MetadataReference>? references,
        IList<TestHostDocument> documents,
        IList<TestHostDocument>? additionalDocuments = null,
        IList<TestHostDocument>? analyzerConfigDocuments = null,
        Type? hostObjectType = null,
        bool isSubmission = false,
        string? filePath = null,
        IList<AnalyzerReference>? analyzerReferences = null,
        string? defaultNamespace = null)
        => new(languageServices,
               compilationOptions,
               parseOptions,
               assemblyName,
               projectName,
               references,
               documents,
               additionalDocuments,
               analyzerConfigDocuments,
               hostObjectType,
               isSubmission,
               filePath,
               analyzerReferences,
               defaultNamespace);

    private protected override TestHostSolution CreateSolution(TestHostProject[] projects)
        => new(projects);


    public static TestWorkspace Create(string xmlDefinition, bool openDocuments = false, TestComposition composition = null)
        => Create(XElement.Parse(xmlDefinition), openDocuments, composition);

    public static TestWorkspace CreateWorkspace(
        XElement workspaceElement,
        bool openDocuments = true,
        TestComposition composition = null,
        string workspaceKind = null)
    {
        return Create(workspaceElement, openDocuments, composition, workspaceKind);
    }

    internal static TestWorkspace Create(
        XElement workspaceElement,
        bool openDocuments = true,
        TestComposition composition = null,
        string workspaceKind = null,
        IDocumentServiceProvider documentServiceProvider = null,
        bool ignoreUnchangeableDocumentsWhenApplyingChanges = true)
    {
        var workspace = new TestWorkspace(composition, workspaceKind, ignoreUnchangeableDocumentsWhenApplyingChanges: ignoreUnchangeableDocumentsWhenApplyingChanges);
        workspace.InitializeDocuments(workspaceElement, openDocuments, documentServiceProvider);
        return workspace;
    }

    internal static TestWorkspace Create(
        XElement workspaceElement,
        ExportProvider exportProvider,
        bool openDocuments = true,
        string workspaceKind = null,
        IDocumentServiceProvider documentServiceProvider = null,
        bool ignoreUnchangeableDocumentsWhenApplyingChanges = true)
    {
        var workspace = new TestWorkspace(exportProvider, workspaceKind, ignoreUnchangeableDocumentsWhenApplyingChanges: ignoreUnchangeableDocumentsWhenApplyingChanges);
        workspace.InitializeDocuments(workspaceElement, openDocuments, documentServiceProvider);
        return workspace;
    }

    /// <summary>
    /// Creates a single buffer in a workspace.
    /// </summary>
    /// <param name="content">Lines of text, the buffer contents</param>
    internal static TestWorkspace Create(
        string language,
        CompilationOptions compilationOptions,
        ParseOptions parseOptions,
        string content)
    {
        return Create(language, compilationOptions, parseOptions, [content]);
    }

    /// <summary>
    /// Creates a single buffer in a workspace.
    /// </summary>
    /// <param name="content">Lines of text, the buffer contents</param>
    internal static TestWorkspace Create(
        string workspaceKind,
        string language,
        CompilationOptions compilationOptions,
        ParseOptions parseOptions,
        string content)
    {
        return Create(workspaceKind, language, compilationOptions, parseOptions, [content]);
    }

    /// <param name="files">Can pass in multiple file contents: files will be named test1.cs, test2.cs, etc.</param>
    internal static TestWorkspace Create(
        string workspaceKind,
        string language,
        CompilationOptions compilationOptions,
        ParseOptions parseOptions,
        params string[] files)
    {
        return Create(language, compilationOptions, parseOptions, files, workspaceKind: workspaceKind);
    }

    internal static TestWorkspace Create(
        string language,
        CompilationOptions compilationOptions,
        ParseOptions parseOptions,
        string[] files,
        string[] sourceGeneratedFiles = null,
        TestComposition composition = null,
        string[] metadataReferences = null,
        string workspaceKind = null,
        string extension = null,
        bool commonReferences = true,
        bool isMarkup = true,
        bool openDocuments = false,
        IDocumentServiceProvider documentServiceProvider = null)
    {
        var workspaceElement = CreateWorkspaceElement(language, compilationOptions, parseOptions, files, sourceGeneratedFiles, metadataReferences, extension, commonReferences, isMarkup);
        return Create(workspaceElement, openDocuments, composition, workspaceKind, documentServiceProvider);
    }

    internal static TestWorkspace CreateWithSingleEmptySourceFile(
        string language,
        CompilationOptions compilationOptions,
        ParseOptions parseOptions,
        TestComposition composition)
    {
        var documentElements = new[]
        {
            CreateDocumentElement(code: "", filePath: GetDefaultTestSourceDocumentName(index: 0, GetSourceFileExtension(language, parseOptions)), parseOptions: parseOptions)
        };

        var workspaceElement = CreateWorkspaceElement(
            CreateProjectElement("Test", language, commonReferences: true, parseOptions, compilationOptions, documentElements));

        return Create(workspaceElement, composition: composition);
    }

    #region C#

    public static TestWorkspace CreateCSharp(
        string file,
        ParseOptions parseOptions = null,
        CompilationOptions compilationOptions = null,
        TestComposition composition = null,
        string[] metadataReferences = null,
        bool isMarkup = true,
        bool openDocuments = false)
    {
        return CreateCSharp([file], [], parseOptions, compilationOptions, composition, metadataReferences, isMarkup, openDocuments);
    }

    public static TestWorkspace CreateCSharp(
        string[] files,
        string[] sourceGeneratedFiles = null,
        ParseOptions parseOptions = null,
        CompilationOptions compilationOptions = null,
        TestComposition composition = null,
        string[] metadataReferences = null,
        bool isMarkup = true,
        bool openDocuments = false)
    {
        return Create(LanguageNames.CSharp, compilationOptions, parseOptions, files, sourceGeneratedFiles, composition, metadataReferences, isMarkup: isMarkup, openDocuments: openDocuments);
    }

    #endregion

    #region VB

    public static TestWorkspace CreateVisualBasic(
        string file,
        ParseOptions parseOptions = null,
        CompilationOptions compilationOptions = null,
        TestComposition composition = null,
        string[] metadataReferences = null,
        bool openDocuments = false)
    {
        return CreateVisualBasic([file], [], parseOptions, compilationOptions, composition, metadataReferences, openDocuments);
    }

    public static TestWorkspace CreateVisualBasic(
        string[] files,
        string[] sourceGeneratedFiles = null,
        ParseOptions parseOptions = null,
        CompilationOptions compilationOptions = null,
        TestComposition composition = null,
        string[] metadataReferences = null,
        bool openDocuments = false)
    {
        return Create(LanguageNames.VisualBasic, compilationOptions, parseOptions, files, sourceGeneratedFiles, composition, metadataReferences, openDocuments: openDocuments);
    }

    #endregion
}

public abstract partial class TestWorkspace<TDocument, TProject, TSolution> : Workspace
    where TDocument : TestHostDocument
    where TProject : TestHostProject<TDocument>
    where TSolution : TestHostSolution<TDocument>
{
    public ExportProvider ExportProvider { get; }

    public bool CanApplyChangeDocument { get; set; }

    internal override bool CanChangeActiveContextDocument { get { return true; } }

    public IList<TProject> Projects { get; }
    public IList<TDocument> Documents { get; }
    public IList<TDocument> AdditionalDocuments { get; }
    public IList<TDocument> AnalyzerConfigDocuments { get; }
    public IList<TDocument> ProjectionDocuments { get; }
    internal IGlobalOptionService GlobalOptions { get; }

    internal override bool IgnoreUnchangeableDocumentsWhenApplyingChanges { get; }

    private readonly string _workspaceKind;

    internal TestWorkspace(
        TestComposition? composition = null,
        string? workspaceKind = WorkspaceKind.Host,
        Guid solutionTelemetryId = default,
        bool disablePartialSolutions = true,
        bool ignoreUnchangeableDocumentsWhenApplyingChanges = true,
        WorkspaceConfigurationOptions? configurationOptions = null)
        : this(
              (composition ?? FeaturesTestCompositions.Features).ExportProviderFactory.CreateExportProvider(),
              workspaceKind,
              solutionTelemetryId,
              disablePartialSolutions,
              ignoreUnchangeableDocumentsWhenApplyingChanges,
              configurationOptions)
    {
    }

    internal TestWorkspace(
        ExportProvider exportProvider,
        string? workspaceKind = WorkspaceKind.Host,
        Guid solutionTelemetryId = default,
        bool disablePartialSolutions = true,
        bool ignoreUnchangeableDocumentsWhenApplyingChanges = true,
        WorkspaceConfigurationOptions? configurationOptions = null)
        : base(VisualStudioMefHostServices.Create(exportProvider), workspaceKind ?? WorkspaceKind.Host)
    {
        this.ExportProvider = exportProvider;

        var partialSolutionsTestHook = Services.GetRequiredService<IWorkspacePartialSolutionsTestHook>();
        partialSolutionsTestHook.IsPartialSolutionDisabled = disablePartialSolutions;

        // configure workspace before creating any solutions:
        if (configurationOptions != null)
        {
            var workspaceConfigurationService = GetService<TestWorkspaceConfigurationService>();
            workspaceConfigurationService.Options = configurationOptions;
        }

        SetCurrentSolutionEx(CreateSolution(SolutionInfo.Create(SolutionId.CreateNewId(), VersionStamp.Create()).WithTelemetryId(solutionTelemetryId)));

        _workspaceKind = workspaceKind ?? WorkspaceKind.Host;
        this.Projects = [];
        this.Documents = [];
        this.AdditionalDocuments = [];
        this.AnalyzerConfigDocuments = [];
        this.ProjectionDocuments = [];

        this.CanApplyChangeDocument = true;
        this.IgnoreUnchangeableDocumentsWhenApplyingChanges = ignoreUnchangeableDocumentsWhenApplyingChanges;
        this.GlobalOptions = GetService<IGlobalOptionService>();

        if (Services.GetService<INotificationService>() is INotificationServiceCallback callback)
        {
            // Avoid showing dialogs in tests by default
            callback.NotificationCallback = (message, title, severity) =>
            {
                var severityText = severity switch
                {
                    NotificationSeverity.Information => "💡",
                    NotificationSeverity.Warning => "⚠",
                    _ => "❌"
                };

                var fullMessage = string.IsNullOrEmpty(title)
                    ? message
                    : $"{title}:{Environment.NewLine}{Environment.NewLine}{message}";

                throw new InvalidOperationException($"{severityText} {fullMessage}");
            };
        }
    }

    /// <summary>
    /// Use to set specified editorconfig options as <see cref="Solution.FallbackAnalyzerOptions"/>.
    /// </summary>
    public void SetAnalyzerFallbackOptions(string language, params (string name, string value)[] options)
    {
        SetCurrentSolution(
            s => s.WithFallbackAnalyzerOptions(s.FallbackAnalyzerOptions.SetItem(language,
                StructuredAnalyzerConfigOptions.Create(
                    new DictionaryAnalyzerConfigOptions(
                        options.Select(static o => KeyValuePair.Create(o.name, o.value)).ToImmutableDictionary())))),
            changeKind: WorkspaceChangeKind.SolutionChanged);
    }

    /// <summary>
    /// Use to set specified editorconfig options as <see cref="Solution.FallbackAnalyzerOptions"/>.
    /// </summary>
    internal void SetAnalyzerFallbackOptions(OptionsCollection? options)
    {
        if (options == null)
        {
            return;
        }

        SetCurrentSolution(
            s => s.WithFallbackAnalyzerOptions(s.FallbackAnalyzerOptions.SetItem(options.LanguageName, options.ToAnalyzerConfigOptions())),
            changeKind: WorkspaceChangeKind.SolutionChanged);
    }

    /// <summary>
    /// Use to set specified options both as global options and as <see cref="Solution.FallbackAnalyzerOptions"/>.
    /// Only editorconfig options listed in <paramref name="options"/> will be set to the latter.
    /// </summary>
    internal void SetAnalyzerFallbackAndGlobalOptions(OptionsCollection? options)
    {
        if (options == null)
        {
            return;
        }

        var configOptions = new OptionsCollection(options.LanguageName);
        configOptions.AddRange(options.Where(entry => entry.Key.Option.Definition.IsEditorConfigOption));
        SetAnalyzerFallbackOptions(configOptions);

        options.SetGlobalOptions(GlobalOptions);
    }

    private protected abstract TDocument CreateDocument(
        string text = "",
        string displayName = "",
        SourceCodeKind sourceCodeKind = SourceCodeKind.Regular,
        DocumentId? id = null,
        string? filePath = null,
        IReadOnlyList<string>? folders = null,
        ExportProvider? exportProvider = null,
        IDocumentServiceProvider? documentServiceProvider = null);

    private protected abstract TDocument CreateDocument(
        ExportProvider exportProvider,
        HostLanguageServices? languageServiceProvider,
        string code,
        string name,
        string filePath,
        int? cursorPosition,
        IDictionary<string, ImmutableArray<TextSpan>> spans,
        SourceCodeKind sourceCodeKind = SourceCodeKind.Regular,
        IReadOnlyList<string>? folders = null,
        bool isLinkFile = false,
        IDocumentServiceProvider? documentServiceProvider = null,
        ISourceGenerator? generator = null);

    private protected abstract TProject CreateProject(
        HostLanguageServices languageServices,
        CompilationOptions? compilationOptions,
        ParseOptions? parseOptions,
        string assemblyName,
        string projectName,
        IList<MetadataReference>? references,
        IList<TDocument> documents,
        IList<TDocument>? additionalDocuments = null,
        IList<TDocument>? analyzerConfigDocuments = null,
        Type? hostObjectType = null,
        bool isSubmission = false,
        string? filePath = null,
        IList<AnalyzerReference>? analyzerReferences = null,
        string? defaultNamespace = null);

    private protected abstract TSolution CreateSolution(TProject[] projects);

    public static string GetDefaultTestSourceDocumentName(int index, string extension)
       => "test" + (index + 1) + extension;

    public static string GetSourceFileExtension(string language, ParseOptions parseOptions)
    {
        if (language == LanguageNames.CSharp)
        {
            return parseOptions.Kind == SourceCodeKind.Regular
                ? CSharpExtension
                : CSharpScriptExtension;
        }
        else if (language == LanguageNames.VisualBasic)
        {
            return parseOptions.Kind == SourceCodeKind.Regular
                ? VisualBasicExtension
                : VisualBasicScriptExtension;
        }

        throw ExceptionUtilities.UnexpectedValue(language);
    }

    protected internal override bool PartialSemanticsEnabled => true;

    public TDocument DocumentWithCursor
        => Documents.Single(d => d.CursorPosition.HasValue && !d.IsLinkFile);

    public new void RegisterText(SourceTextContainer text)
        => base.RegisterText(text);

    internal void AddTestSolution(TSolution solution)
        => this.OnSolutionAdded(SolutionInfo.Create(solution.Id, solution.Version, solution.FilePath, projects: solution.Projects.Select(p => p.ToProjectInfo())));

    public void AddTestProject(TProject project)
    {
        if (!this.Projects.Contains(project))
        {
            this.Projects.Add(project);

            foreach (var doc in project.Documents)
            {
                this.Documents.Add(doc);
            }

            foreach (var doc in project.AdditionalDocuments)
            {
                this.AdditionalDocuments.Add(doc);
            }

            foreach (var doc in project.AnalyzerConfigDocuments)
            {
                this.AnalyzerConfigDocuments.Add(doc);
            }
        }

        this.OnProjectAdded(project.ToProjectInfo());
    }

    public new void OnProjectRemoved(ProjectId projectId)
        => base.OnProjectRemoved(projectId);

    public new void OnProjectReferenceAdded(ProjectId projectId, ProjectReference projectReference)
        => base.OnProjectReferenceAdded(projectId, projectReference);

    public new void OnProjectReferenceRemoved(ProjectId projectId, ProjectReference projectReference)
        => base.OnProjectReferenceRemoved(projectId, projectReference);

    public new void OnDocumentOpened(DocumentId documentId, SourceTextContainer textContainer, bool isCurrentContext = true)
        => base.OnDocumentOpened(documentId, textContainer, isCurrentContext);

    public new void OnParseOptionsChanged(ProjectId projectId, ParseOptions parseOptions)
        => base.OnParseOptionsChanged(projectId, parseOptions);

    public new void OnAnalyzerReferenceAdded(ProjectId projectId, AnalyzerReference analyzerReference)
        => base.OnAnalyzerReferenceAdded(projectId, analyzerReference);

    public void OnDocumentRemoved(DocumentId documentId, bool closeDocument = false)
    {
        if (closeDocument && this.IsDocumentOpen(documentId))
        {
            this.CloseDocument(documentId);
        }

        base.OnDocumentRemoved(documentId);
    }

    public new void OnDocumentSourceCodeKindChanged(DocumentId documentId, SourceCodeKind sourceCodeKind)
        => base.OnDocumentSourceCodeKindChanged(documentId, sourceCodeKind);

    public DocumentId? GetDocumentId(TDocument hostDocument)
    {
        if (!Documents.Contains(hostDocument) &&
            !AdditionalDocuments.Contains(hostDocument) &&
            !AnalyzerConfigDocuments.Contains(hostDocument))
        {
            return null;
        }

        return hostDocument.Id;
    }

    public TDocument? GetTestDocument(DocumentId documentId)
        => this.Documents.FirstOrDefault(d => d.Id == documentId);

    public TDocument? GetTestAdditionalDocument(DocumentId documentId)
        => this.AdditionalDocuments.FirstOrDefault(d => d.Id == documentId);

    public TDocument? GetTestAnalyzerConfigDocument(DocumentId documentId)
        => this.AnalyzerConfigDocuments.FirstOrDefault(d => d.Id == documentId);

    public TestHostProject<TDocument>? GetTestProject(DocumentId documentId)
        => GetTestProject(documentId.ProjectId);

    public TestHostProject<TDocument>? GetTestProject(ProjectId projectId)
        => this.Projects.FirstOrDefault(p => p.Id == projectId);

    public TServiceInterface GetService<TServiceInterface>()
        => ExportProvider.GetExportedValue<TServiceInterface>();

    public override bool CanApplyChange(ApplyChangesKind feature)
    {
        return feature switch
        {
            ApplyChangesKind.AddDocument or ApplyChangesKind.RemoveDocument => KindSupportsAddRemoveDocument(),
            ApplyChangesKind.RemoveProject => KindSupportsRemoveProject(),
            ApplyChangesKind.AddAdditionalDocument or ApplyChangesKind.RemoveAdditionalDocument or ApplyChangesKind.AddAnalyzerConfigDocument or ApplyChangesKind.RemoveAnalyzerConfigDocument or ApplyChangesKind.AddAnalyzerReference or ApplyChangesKind.RemoveAnalyzerReference or ApplyChangesKind.AddSolutionAnalyzerReference or ApplyChangesKind.RemoveSolutionAnalyzerReference => true,
            ApplyChangesKind.ChangeDocument or ApplyChangesKind.ChangeAdditionalDocument or ApplyChangesKind.ChangeAnalyzerConfigDocument or ApplyChangesKind.ChangeDocumentInfo => this.CanApplyChangeDocument,
            ApplyChangesKind.AddProjectReference or ApplyChangesKind.AddMetadataReference => true,
            _ => false,
        };
    }

    private bool KindSupportsAddRemoveDocument()
        => _workspaceKind switch
        {
            WorkspaceKind.MiscellaneousFiles => false,
            WorkspaceKind.Interactive => false,
            WorkspaceKind.SemanticSearch => false,
            _ => true
        };

    private bool KindSupportsRemoveProject()
        => _workspaceKind switch
        {
            WorkspaceKind.MiscellaneousFiles => false,
            WorkspaceKind.Interactive => false,
            WorkspaceKind.SemanticSearch => false,
            _ => true
        };

    protected override void ApplyDocumentAdded(DocumentInfo info, SourceText text)
    {
        var hostProject = this.GetTestProject(info.Id.ProjectId);
        Contract.ThrowIfNull(hostProject);

        var hostDocument = CreateDocument(
            text.ToString(), info.Name, info.SourceCodeKind,
            info.Id, info.FilePath, info.Folders, ExportProvider,
            info.DocumentServiceProvider);

        hostProject.AddDocument(hostDocument);
        this.OnDocumentAdded(hostDocument.ToDocumentInfo());
    }

    protected override void ApplyDocumentRemoved(DocumentId documentId)
    {
        var hostProject = this.GetTestProject(documentId.ProjectId);
        Contract.ThrowIfNull(hostProject);

        var hostDocument = this.GetTestDocument(documentId);
        Contract.ThrowIfNull(hostDocument);

        hostProject.RemoveDocument(hostDocument);
        this.OnDocumentRemoved(documentId, closeDocument: true);
    }

    protected override void ApplyAdditionalDocumentAdded(DocumentInfo info, SourceText text)
    {
        var hostProject = this.GetTestProject(info.Id.ProjectId);
        Contract.ThrowIfNull(hostProject);

        var hostDocument = CreateDocument(text.ToString(), info.Name, id: info.Id, filePath: info.FilePath, folders: info.Folders, exportProvider: ExportProvider);
        hostProject.AddAdditionalDocument(hostDocument);
        this.OnAdditionalDocumentAdded(hostDocument.ToDocumentInfo());
    }

    protected override void ApplyAdditionalDocumentRemoved(DocumentId documentId)
    {
        var hostProject = this.GetTestProject(documentId.ProjectId);
        Contract.ThrowIfNull(hostProject);

        var hostDocument = this.GetTestAdditionalDocument(documentId);
        if (hostDocument != null)
        {
            hostProject.RemoveAdditionalDocument(hostDocument);
        }

        this.OnAdditionalDocumentRemoved(documentId);
    }

    protected override void ApplyAnalyzerConfigDocumentAdded(DocumentInfo info, SourceText text)
    {
        var hostProject = this.GetTestProject(info.Id.ProjectId);
        Contract.ThrowIfNull(hostProject);

        var hostDocument = CreateDocument(text.ToString(), info.Name, id: info.Id, filePath: info.FilePath, folders: info.Folders, exportProvider: ExportProvider);
        hostProject.AddAnalyzerConfigDocument(hostDocument);
        this.OnAnalyzerConfigDocumentAdded(hostDocument.ToDocumentInfo());
    }

    protected override void ApplyAnalyzerConfigDocumentRemoved(DocumentId documentId)
    {
        var hostProject = this.GetTestProject(documentId.ProjectId);
        Contract.ThrowIfNull(hostProject);

        var hostDocument = this.GetTestAnalyzerConfigDocument(documentId);
        if (hostDocument != null)
        {
            hostProject.RemoveAnalyzerConfigDocument(hostDocument);
        }

        this.OnAnalyzerConfigDocumentRemoved(documentId);
    }

    protected override void ApplyProjectChanges(ProjectChanges projectChanges)
    {
        if (projectChanges.OldProject.FilePath != projectChanges.NewProject.FilePath)
        {
            var hostProject = this.GetTestProject(projectChanges.NewProject.Id);
            Contract.ThrowIfNull(hostProject);

            hostProject.OnProjectFilePathChanged(projectChanges.NewProject.FilePath);
            base.OnProjectNameChanged(projectChanges.NewProject.Id, projectChanges.NewProject.Name, projectChanges.NewProject.FilePath);
        }

        base.ApplyProjectChanges(projectChanges);
    }

    internal override void SetDocumentContext(DocumentId documentId)
        => OnDocumentContextUpdated(documentId);

    /// <summary>
    /// Overriding base impl so that when we close a document it goes back to the initial state when the test
    /// workspace was loaded, throwing away any changes made to the open version.
    /// </summary>
    internal override async ValueTask TryOnDocumentClosedAsync(DocumentId documentId, CancellationToken cancellationToken)
    {
        var testDocument = this.GetTestDocument(documentId);
        Contract.ThrowIfNull(testDocument);
        Contract.ThrowIfTrue(testDocument.IsSourceGenerated);

        this.OnDocumentClosedEx(documentId, testDocument.Loader, requireDocumentPresentAndOpen: false);
    }

    public override void CloseDocument(DocumentId documentId)
    {
        var testDocument = this.GetTestDocument(documentId);
        Contract.ThrowIfNull(testDocument);
        Contract.ThrowIfTrue(testDocument.IsSourceGenerated);
        Contract.ThrowIfFalse(IsDocumentOpen(documentId));

        this.OnDocumentClosed(documentId, testDocument.Loader);
    }

    public override void CloseAdditionalDocument(DocumentId documentId)
    {
        var testDocument = this.GetTestAdditionalDocument(documentId);
        Contract.ThrowIfNull(testDocument);
        Contract.ThrowIfTrue(testDocument.IsSourceGenerated);
        Contract.ThrowIfFalse(IsDocumentOpen(documentId));

        this.OnAdditionalDocumentClosed(documentId, testDocument.Loader);
    }

    public override void CloseAnalyzerConfigDocument(DocumentId documentId)
    {
        var testDocument = this.GetTestAnalyzerConfigDocument(documentId);
        Contract.ThrowIfNull(testDocument);
        Contract.ThrowIfTrue(testDocument.IsSourceGenerated);
        Contract.ThrowIfFalse(IsDocumentOpen(documentId));

        this.OnAnalyzerConfigDocumentClosed(documentId, testDocument.Loader);
    }

    public async Task CloseSourceGeneratedDocumentAsync(DocumentId documentId)
    {
        var testDocument = this.GetTestDocument(documentId);
        Contract.ThrowIfNull(testDocument);
        Contract.ThrowIfFalse(testDocument.IsSourceGenerated);
        Contract.ThrowIfFalse(IsDocumentOpen(documentId));

        var document = await CurrentSolution.GetSourceGeneratedDocumentAsync(documentId, CancellationToken.None);
        Contract.ThrowIfNull(document);
        OnSourceGeneratedDocumentClosed(document);
    }

    public Task ChangeDocumentAsync(DocumentId documentId, SourceText text)
    {
        return ChangeDocumentAsync(documentId, this.CurrentSolution.WithDocumentText(documentId, text));
    }

    public Task ChangeDocumentAsync(DocumentId documentId, Solution solution)
    {
        var (oldSolution, newSolution) = this.SetCurrentSolutionEx(solution);

        return this.RaiseWorkspaceChangedEventAsync(WorkspaceChangeKind.DocumentChanged, oldSolution, newSolution, documentId.ProjectId, documentId);
    }

    public Task AddDocumentAsync(DocumentInfo documentInfo)
    {
        var documentId = documentInfo.Id;

        var (oldSolution, newSolution) = this.SetCurrentSolutionEx(this.CurrentSolution.AddDocument(documentInfo));

        return this.RaiseWorkspaceChangedEventAsync(WorkspaceChangeKind.DocumentAdded, oldSolution, newSolution, documentId: documentId);
    }

    public void ChangeAdditionalDocument(DocumentId documentId, SourceText text)
    {
        var (oldSolution, newSolution) = this.SetCurrentSolutionEx(this.CurrentSolution.WithAdditionalDocumentText(documentId, text));

        this.RaiseWorkspaceChangedEventAsync(WorkspaceChangeKind.AdditionalDocumentChanged, oldSolution, newSolution, documentId.ProjectId, documentId);
    }

    public void ChangeAnalyzerConfigDocument(DocumentId documentId, SourceText text)
    {
        var (oldSolution, newSolution) = this.SetCurrentSolutionEx(this.CurrentSolution.WithAnalyzerConfigDocumentText(documentId, text));

        this.RaiseWorkspaceChangedEventAsync(WorkspaceChangeKind.AnalyzerConfigDocumentChanged, oldSolution, newSolution, documentId.ProjectId, documentId);
    }

    public Task ChangeProjectAsync(ProjectId projectId, Solution solution)
    {
        var (oldSolution, newSolution) = this.SetCurrentSolutionEx(solution);

        return this.RaiseWorkspaceChangedEventAsync(WorkspaceChangeKind.ProjectChanged, oldSolution, newSolution, projectId);
    }

    public new void ClearSolution()
        => base.ClearSolution();

    public Task ChangeSolutionAsync(Solution solution)
    {
        var (oldSolution, newSolution) = this.SetCurrentSolutionEx(solution);

        return this.RaiseWorkspaceChangedEventAsync(WorkspaceChangeKind.SolutionChanged, oldSolution, newSolution);
    }

    public override bool CanApplyParseOptionChange(ParseOptions oldOptions, ParseOptions newOptions, Project project)
        => true;

    internal override bool CanAddProjectReference(ProjectId referencingProject, ProjectId referencedProject)
        => true;

    internal void InitializeDocuments(
        string language,
        CompilationOptions? compilationOptions = null,
        ParseOptions? parseOptions = null,
        string[]? files = null,
        string[]? metadataReferences = null,
        string? extension = null,
        bool commonReferences = true,
        bool openDocuments = true,
        IDocumentServiceProvider? documentServiceProvider = null)
    {
        var workspaceElement = CreateWorkspaceElement(
            language,
            compilationOptions,
            parseOptions,
            files,
            sourceGeneratedFiles: [],
            metadataReferences,
            extension,
            commonReferences);

        InitializeDocuments(workspaceElement, openDocuments, documentServiceProvider);
    }

    internal void InitializeDocuments(
        XElement workspaceElement,
        bool openDocuments = true,
        IDocumentServiceProvider? documentServiceProvider = null)
    {
        if (workspaceElement.Name != WorkspaceElementName)
        {
            throw new ArgumentException();
        }

        var projectNameToTestHostProject = new Dictionary<string, TProject>();
        var projectElementToProjectName = new Dictionary<XElement, string>();
        var projectIdentifier = 0;
        var documentIdentifier = 0;

        foreach (var projectElement in workspaceElement.Elements(ProjectElementName))
        {
            var project = CreateProject(
                workspaceElement,
                projectElement,
                ExportProvider,
                documentServiceProvider,
                ref projectIdentifier,
                ref documentIdentifier);

            Assert.False(projectNameToTestHostProject.ContainsKey(project.Name), $"The workspace XML already contains a project with name {project.Name}");
            projectNameToTestHostProject.Add(project.Name, project);
            projectElementToProjectName.Add(projectElement, project.Name);
            Projects.Add(project);
        }

        var documentFilePaths = new HashSet<string>();
        foreach (var project in projectNameToTestHostProject.Values)
        {
            foreach (var document in project.Documents)
            {
                Assert.True(document.IsLinkFile || documentFilePaths.Add(document.FilePath!));

                Documents.Add(document);
            }
        }

        var submissions = CreateSubmissions(workspaceElement.Elements(SubmissionElementName), ExportProvider);

        foreach (var submission in submissions)
        {
            projectNameToTestHostProject.Add(submission.Name, submission);
            Documents.Add(submission.Documents.Single());
        }

        var solution = CreateSolution([.. projectNameToTestHostProject.Values]);
        AddTestSolution(solution);

        foreach (var projectElement in workspaceElement.Elements(ProjectElementName))
        {
            foreach (var projectReference in projectElement.Elements(ProjectReferenceElementName))
            {
                var fromName = projectElementToProjectName[projectElement];
                var toName = projectReference.Value;

                var fromProject = projectNameToTestHostProject[fromName];
                var toProject = projectNameToTestHostProject[toName];

                var aliases = projectReference.Attributes(AliasAttributeName).SelectAsArray(a => a.Value);

                OnProjectReferenceAdded(fromProject.Id, new ProjectReference(toProject.Id, aliases.Any() ? aliases : default));
            }
        }

        for (var i = 1; i < submissions.Count; i++)
        {
            if (submissions[i].CompilationOptions == null)
            {
                continue;
            }

            for (var j = i - 1; j >= 0; j--)
            {
                if (submissions[j].CompilationOptions != null)
                {
                    OnProjectReferenceAdded(submissions[i].Id, new ProjectReference(submissions[j].Id));
                    break;
                }
            }
        }

        if (openDocuments)
        {
            foreach (var project in projectNameToTestHostProject.Values)
            {
                foreach (var document in project.Documents)
                {
                    if (!document.IsSourceGenerated)
                    {
                        // This implicitly opens the document in the workspace by fetching the container.
                        document.Open();
                    }
                }
            }
        }
    }

    private IList<TProject> CreateSubmissions(
        IEnumerable<XElement> submissionElements,
        ExportProvider exportProvider)
    {
        var submissions = new List<TProject>();
        var submissionIndex = 0;

        foreach (var submissionElement in submissionElements)
        {
            var submissionName = "Submission" + (submissionIndex++);

            var languageName = GetLanguage(submissionElement);

            // The document
            var markupCode = submissionElement.NormalizedValue();
            MarkupTestFile.GetPositionAndSpans(markupCode,
                out var code, out var cursorPosition, out IDictionary<string, ImmutableArray<TextSpan>> spans);

            var languageServices = Services.GetLanguageServices(languageName);

            // The project

            var document = CreateDocument(exportProvider, languageServices, code, submissionName, submissionName, cursorPosition, spans, SourceCodeKind.Script);
            var documents = new List<TDocument> { document };

            if (languageName == NoCompilationConstants.LanguageName)
            {
                submissions.Add(
                    CreateProject(
                        languageServices,
                        compilationOptions: null,
                        parseOptions: null,
                        assemblyName: submissionName,
                        projectName: submissionName,
                        references: null,
                        documents: documents,
                        isSubmission: true));
                continue;
            }

            var metadataService = Services.GetRequiredService<IMetadataService>();
            var metadataResolver = RuntimeMetadataReferenceResolver.CreateCurrentPlatformResolver(createFromFileFunc: metadataService.GetReference);
            var syntaxFactory = languageServices.GetRequiredService<ISyntaxTreeFactoryService>();
            var compilationFactory = languageServices.GetRequiredService<ICompilationFactoryService>();
            var compilationOptions = compilationFactory.GetDefaultCompilationOptions()
                .WithOutputKind(OutputKind.DynamicallyLinkedLibrary)
                .WithMetadataReferenceResolver(metadataResolver);

            var parseOptions = syntaxFactory.GetDefaultParseOptions().WithKind(SourceCodeKind.Script);

            var references = CreateCommonReferences(submissionElement);

            var project = CreateProject(
                languageServices,
                compilationOptions,
                parseOptions,
                submissionName,
                submissionName,
                references,
                documents,
                isSubmission: true);

            submissions.Add(project);
        }

        return submissions;
    }

    public override bool TryApplyChanges(Solution newSolution)
    {
        var result = base.TryApplyChanges(newSolution);

        // Ensure that any in-memory analyzer references in this test workspace are known by the serializer service
        // so that we can validate OOP scenarios involving analyzers.
#pragma warning disable CA1416 // Validate platform compatibility
        SerializerService.TestAccessor.AddAnalyzerImageReferences(this.CurrentSolution.AnalyzerReferences);
#pragma warning restore CA1416 // Validate platform compatibility

        return result;
    }

    private const string CSharpExtension = ".cs";
    private const string CSharpScriptExtension = ".csx";
    private const string VisualBasicExtension = ".vb";
    private const string VisualBasicScriptExtension = ".vbx";

    private const string WorkspaceElementName = "Workspace";
    private const string ProjectElementName = "Project";
    private const string SubmissionElementName = "Submission";
    private const string MetadataReferenceElementName = "MetadataReference";
    private const string MetadataReferenceFromSourceElementName = "MetadataReferenceFromSource";
    private const string ProjectReferenceElementName = "ProjectReference";
    private const string CompilationOptionsElementName = "CompilationOptions";
    private const string RootNamespaceAttributeName = "RootNamespace";
    private const string OutputTypeAttributeName = "OutputType";
    private const string ReportDiagnosticAttributeName = "ReportDiagnostic";
    private const string CryptoKeyFileAttributeName = "CryptoKeyFile";
    private const string StrongNameProviderAttributeName = "StrongNameProvider";
    private const string DelaySignAttributeName = "DelaySign";
    private const string ParseOptionsElementName = "ParseOptions";
    private const string FeaturesAttributeName = "Features";
    private const string DocumentationModeAttributeName = "DocumentationMode";
    private const string DocumentElementName = "Document";
    private const string AdditionalDocumentElementName = "AdditionalDocument";
    private const string AnalyzerConfigDocumentElementName = "AnalyzerConfigDocument";
    private const string AnalyzerElementName = "Analyzer";
    private const string AssemblyNameAttributeName = "AssemblyName";
    private const string CommonReferencesAttributeName = "CommonReferences";
    private const string CommonReferencesWithoutValueTupleAttributeName = "CommonReferencesWithoutValueTuple";
    private const string CommonReferencesWinRTAttributeName = "CommonReferencesWinRT";
    private const string CommonReferencesNet45AttributeName = "CommonReferencesNet45";
    private const string CommonReferencesPortableAttributeName = "CommonReferencesPortable";
    private const string CommonReferencesNetCoreAppName = "CommonReferencesNetCoreApp";
    private const string CommonReferencesNet6Name = "CommonReferencesNet6";
    private const string CommonReferencesNet7Name = "CommonReferencesNet7";
    private const string CommonReferencesNet8Name = "CommonReferencesNet8";
    private const string CommonReferencesNet9Name = "CommonReferencesNet9";
    private const string CommonReferencesNetStandard20Name = "CommonReferencesNetStandard20";
    private const string CommonReferencesMinCorlibName = "CommonReferencesMinCorlib";
    private const string FilePathAttributeName = "FilePath";
    private const string FoldersAttributeName = "Folders";
    private const string KindAttributeName = "Kind";
    private const string LanguageAttributeName = "Language";
    private const string GlobalImportElementName = "GlobalImport";
    private const string IncludeXmlDocCommentsAttributeName = "IncludeXmlDocComments";
    private const string IsLinkFileAttributeName = "IsLinkFile";
    private const string LinkAssemblyNameAttributeName = "LinkAssemblyName";
    private const string LinkProjectNameAttributeName = "LinkProjectName";
    private const string LinkFilePathAttributeName = "LinkFilePath";
    private const string MarkupAttributeName = "Markup";
    private const string NormalizeAttributeName = "Normalize";
    private const string PreprocessorSymbolsAttributeName = "PreprocessorSymbols";
    private const string AnalyzerDisplayAttributeName = "Name";
    private const string AnalyzerFullPathAttributeName = "FullPath";
    private const string AliasAttributeName = "Alias";
    private const string ProjectNameAttribute = "Name";
    private const string CheckOverflowAttributeName = "CheckOverflow";
    private const string AllowUnsafeAttributeName = "AllowUnsafe";
    private const string OutputKindName = "OutputKind";
    private const string NullableAttributeName = "Nullable";
    private const string DocumentFromSourceGeneratorElementName = "DocumentFromSourceGenerator";

    /// <summary>
    /// This place-holder value is used to set a project's file path to be null.  It was explicitly chosen to be
    /// convoluted to avoid any accidental usage (e.g., what if I really wanted FilePath to be the string "null"?),
    /// obvious to anybody debugging that it is a special value, and invalid as an actual file path.
    /// </summary>
    public const string NullFilePath = "NullFilePath::{AFA13775-BB7D-4020-9E58-C68CF43D8A68}";

    private sealed class TestDocumentationProvider : DocumentationProvider
    {
        protected override string GetDocumentationForSymbol(string documentationMemberID, CultureInfo preferredCulture, CancellationToken cancellationToken = default)
            => string.Format("<member name='{0}'><summary>{0}</summary></member>", documentationMemberID);

        public override bool Equals(object obj)
            => ReferenceEquals(this, obj);

        public override int GetHashCode()
            => RuntimeHelpers.GetHashCode(this);
    }

    private TProject CreateProject(
        XElement workspaceElement,
        XElement projectElement,
        ExportProvider exportProvider,
        IDocumentServiceProvider documentServiceProvider,
        ref int projectId,
        ref int documentId)
    {
        AssertNoChildText(projectElement);

        var language = GetLanguage(projectElement);

        var assemblyName = GetAssemblyName(projectElement, ref projectId);

        string projectFilePath;

        var projectName = projectElement.Attribute(ProjectNameAttribute)?.Value ?? assemblyName;

        if (projectElement.Attribute(FilePathAttributeName) != null)
        {
            projectFilePath = projectElement.Attribute(FilePathAttributeName).Value;
            if (string.Compare(projectFilePath, NullFilePath, StringComparison.Ordinal) == 0)
            {
                // allow explicit null file path
                projectFilePath = null;
            }
        }
        else
        {
            projectFilePath = projectName +
                (language == LanguageNames.CSharp ? ".csproj" :
                 language == LanguageNames.VisualBasic ? ".vbproj" : ("." + language));
        }

        if (projectFilePath != null)
        {
            projectFilePath = PathUtilities.CombinePaths(TestWorkspace.RootDirectory, projectFilePath);
        }

        var projectOutputDir = AbstractTestHostProject.GetTestOutputDirectory(projectFilePath);

        var languageServices = Services.GetLanguageServices(language);

        var parseOptions = GetParseOptions(projectElement, language, languageServices);
        var compilationOptions = CreateCompilationOptions(projectElement, language, parseOptions);
        var rootNamespace = GetRootNamespace(compilationOptions, projectElement);

        var references = CreateReferenceList(projectElement);
        var analyzers = CreateAnalyzerList(projectElement);

        var documents = new List<TDocument>();
        var documentElements = projectElement.Elements(DocumentElementName).ToList();
        foreach (var documentElement in documentElements)
        {
            var document = CreateDocument(
                workspaceElement,
                documentElement,
                exportProvider,
                languageServices,
                documentServiceProvider,
                ref documentId);

            documents.Add(document);
        }

        SingleFileTestGenerator testGenerator = null;
        foreach (var sourceGeneratedDocumentElement in projectElement.Elements(DocumentFromSourceGeneratorElementName))
        {
            if (testGenerator is null)
            {
                testGenerator = new SingleFileTestGenerator();
                analyzers.Add(new TestGeneratorReference(testGenerator));
            }

            var name = GetFileName(sourceGeneratedDocumentElement, ref documentId);

            var markupCode = (bool?)sourceGeneratedDocumentElement.Attribute(NormalizeAttributeName) is false
                ? sourceGeneratedDocumentElement.Value
                : sourceGeneratedDocumentElement.NormalizedValue();
            MarkupTestFile.GetPositionAndSpans(markupCode,
                out var code, out var cursorPosition, out IDictionary<string, ImmutableArray<TextSpan>> spans);

            var documentFilePath = Path.Combine(projectOutputDir, "obj", typeof(SingleFileTestGenerator).Assembly.GetName().Name, typeof(SingleFileTestGenerator).FullName, name);
            var document = CreateDocument(exportProvider, languageServices, code, name, documentFilePath, cursorPosition, spans, generator: testGenerator);
            documents.Add(document);

            testGenerator.AddSource(code, name);
        }

        var additionalDocuments = new List<TDocument>();
        var additionalDocumentElements = projectElement.Elements(AdditionalDocumentElementName).ToList();
        foreach (var additionalDocumentElement in additionalDocumentElements)
        {
            var document = CreateDocument(
                workspaceElement,
                additionalDocumentElement,
                exportProvider,
                languageServices,
                documentServiceProvider,
                ref documentId);

            additionalDocuments.Add(document);
        }

        var analyzerConfigDocuments = new List<TDocument>();
        var analyzerConfigElements = projectElement.Elements(AnalyzerConfigDocumentElementName).ToList();
        foreach (var analyzerConfigElement in analyzerConfigElements)
        {
            var document = CreateDocument(
                workspaceElement,
                analyzerConfigElement,
                exportProvider,
                languageServices,
                documentServiceProvider,
                ref documentId);

            analyzerConfigDocuments.Add(document);
        }

        return CreateProject(languageServices, compilationOptions, parseOptions, assemblyName, projectName, references, documents, additionalDocuments, analyzerConfigDocuments, filePath: projectFilePath, analyzerReferences: analyzers, defaultNamespace: rootNamespace);
    }

    private static ParseOptions? GetParseOptions(XElement projectElement, string language, HostLanguageServices languageServices)
    {
        return language is LanguageNames.CSharp or LanguageNames.VisualBasic
            ? GetParseOptionsWorker(projectElement, language, languageServices)
            : null;
    }

    private static ParseOptions GetParseOptionsWorker(XElement projectElement, string language, HostLanguageServices languageServices)
    {
        ParseOptions? parseOptions;
        var preprocessorSymbolsAttribute = projectElement.Attribute(PreprocessorSymbolsAttributeName);
        if (preprocessorSymbolsAttribute != null)
        {
            parseOptions = GetPreProcessorParseOptions(language, preprocessorSymbolsAttribute);
        }
        else
        {
            parseOptions = languageServices.GetService<ISyntaxTreeFactoryService>()?.GetDefaultParseOptions();
        }

        parseOptions ??= language == LanguageNames.CSharp ? CSharpParseOptions.Default : VisualBasicParseOptions.Default;

        var featuresAttribute = projectElement.Attribute(FeaturesAttributeName);
        if (featuresAttribute != null)
        {
            parseOptions = GetParseOptionsWithFeatures(parseOptions, featuresAttribute);
        }

        var documentationMode = GetDocumentationMode(projectElement);
        if (documentationMode != null)
        {
            parseOptions = parseOptions.WithDocumentationMode(documentationMode.Value);
        }

        return parseOptions;
    }

    private static ParseOptions GetPreProcessorParseOptions(string language, XAttribute preprocessorSymbolsAttribute)
    {
        if (language == LanguageNames.CSharp)
        {
            return new CSharpParseOptions(preprocessorSymbols: preprocessorSymbolsAttribute.Value.Split(','));
        }
        else if (language == LanguageNames.VisualBasic)
        {
            return new VisualBasicParseOptions(preprocessorSymbols: preprocessorSymbolsAttribute.Value
                .Split(',').SelectAsArray(v => KeyValuePair.Create(v.Split('=').ElementAt(0), (object)v.Split('=').ElementAt(1))));
        }
        else
        {
            throw new ArgumentException("Unexpected language '{0}' for generating custom parse options.", language);
        }
    }

    private static ParseOptions GetParseOptionsWithFeatures(ParseOptions parseOptions, XAttribute featuresAttribute)
    {
        var entries = featuresAttribute.Value.Split(';');
        var features = entries.Select(x =>
        {
            var split = x.Split('=');

            var key = split[0];
            var value = split.Length == 2 ? split[1] : "true";

            return KeyValuePair.Create(key, value);
        });

        return parseOptions.WithFeatures(features);
    }

    private static DocumentationMode? GetDocumentationMode(XElement projectElement)
    {
        var documentationModeAttribute = projectElement.Attribute(DocumentationModeAttributeName);
        if (documentationModeAttribute != null)
        {
            return (DocumentationMode)Enum.Parse(typeof(DocumentationMode), documentationModeAttribute.Value);
        }
        else
        {
            return null;
        }
    }

    private string GetAssemblyName(XElement projectElement, ref int projectId)
    {
        var assemblyNameAttribute = projectElement.Attribute(AssemblyNameAttributeName);
        if (assemblyNameAttribute != null)
        {
            return assemblyNameAttribute.Value;
        }

        var language = GetLanguage(projectElement);

        projectId++;
        return language == LanguageNames.CSharp ? "CSharpAssembly" + projectId :
               language == LanguageNames.VisualBasic ? "VisualBasicAssembly" + projectId :
                                                        language + "Assembly" + projectId;
    }

    private string GetLanguage(XElement projectElement)
    {
        var languageAttribute = projectElement.Attribute(LanguageAttributeName);
        if (languageAttribute == null)
        {
            throw new ArgumentException($"{projectElement} is missing a {LanguageAttributeName} attribute.");
        }

        var languageName = languageAttribute.Value;

        if (!Services.SupportedLanguages.Contains(languageName))
        {
            throw new ArgumentException(string.Format("Language should be one of '{0}' and it is {1}",
                string.Join(", ", Services.SupportedLanguages),
                languageName));
        }

        return languageName;
    }

    private string GetRootNamespace(CompilationOptions compilationOptions, XElement projectElement)
    {
        var rootNamespaceAttribute = projectElement.Attribute(RootNamespaceAttributeName);

        if (GetLanguage(projectElement) == LanguageNames.VisualBasic)
        {
            // For VB tests, root namespace value must be defined in compilation options element,
            // it can't use the property in project element to avoid confusion.
            Assert.Null(rootNamespaceAttribute);

            var vbCompilationOptions = (VisualBasicCompilationOptions)compilationOptions;
            return vbCompilationOptions.RootNamespace;
        }

        // If it's not defined, default to "" (global namespace)
        return rootNamespaceAttribute?.Value ?? string.Empty;
    }

    private CompilationOptions CreateCompilationOptions(
        XElement projectElement,
        string language,
        ParseOptions parseOptions)
    {
        var compilationOptionsElement = projectElement.Element(CompilationOptionsElementName);
        return language is LanguageNames.CSharp or LanguageNames.VisualBasic
            ? CreateCompilationOptions(language, compilationOptionsElement, parseOptions)
            : null;
    }

    private CompilationOptions CreateCompilationOptions(string language, XElement compilationOptionsElement, ParseOptions parseOptions)
    {
        var rootNamespace = new VisualBasicCompilationOptions(OutputKind.ConsoleApplication).RootNamespace;
        var globalImports = new List<GlobalImport>();
        var reportDiagnostic = ReportDiagnostic.Default;
        var cryptoKeyFile = (string)null;
        var strongNameProvider = (StrongNameProvider)null;
        var delaySign = (bool?)null;
        var checkOverflow = false;
        var allowUnsafe = false;
        var outputKind = OutputKind.DynamicallyLinkedLibrary;
        var nullable = NullableContextOptions.Disable;

        if (compilationOptionsElement != null)
        {
            globalImports = [.. compilationOptionsElement.Elements(GlobalImportElementName).Select(x => GlobalImport.Parse(x.Value))];
            var rootNamespaceAttribute = compilationOptionsElement.Attribute(RootNamespaceAttributeName);
            if (rootNamespaceAttribute != null)
            {
                rootNamespace = rootNamespaceAttribute.Value;
            }

            var outputKindAttribute = compilationOptionsElement.Attribute(OutputKindName);
            if (outputKindAttribute != null)
            {
                outputKind = (OutputKind)Enum.Parse(typeof(OutputKind), outputKindAttribute.Value);
            }

            var checkOverflowAttribute = compilationOptionsElement.Attribute(CheckOverflowAttributeName);
            if (checkOverflowAttribute != null)
            {
                checkOverflow = (bool)checkOverflowAttribute;
            }

            var allowUnsafeAttribute = compilationOptionsElement.Attribute(AllowUnsafeAttributeName);
            if (allowUnsafeAttribute != null)
            {
                allowUnsafe = (bool)allowUnsafeAttribute;
            }

            var reportDiagnosticAttribute = compilationOptionsElement.Attribute(ReportDiagnosticAttributeName);
            if (reportDiagnosticAttribute != null)
            {
                reportDiagnostic = (ReportDiagnostic)Enum.Parse(typeof(ReportDiagnostic), (string)reportDiagnosticAttribute);
            }

            var cryptoKeyFileAttribute = compilationOptionsElement.Attribute(CryptoKeyFileAttributeName);
            if (cryptoKeyFileAttribute != null)
            {
                cryptoKeyFile = (string)cryptoKeyFileAttribute;
            }

            var strongNameProviderAttribute = compilationOptionsElement.Attribute(StrongNameProviderAttributeName);
            if (strongNameProviderAttribute != null)
            {
                var type = Type.GetType((string)strongNameProviderAttribute);
                // DesktopStrongNameProvider and SigningTestHelpers.VirtualizedStrongNameProvider do
                // not have a default constructor but constructors with optional parameters.
                // Activator.CreateInstance does not work with this.
                if (type == typeof(DesktopStrongNameProvider))
                {
                    strongNameProvider = SigningTestHelpers.DefaultDesktopStrongNameProvider;
                }
                else
                {
                    strongNameProvider = (StrongNameProvider)Activator.CreateInstance(type);
                }
            }

            var delaySignAttribute = compilationOptionsElement.Attribute(DelaySignAttributeName);
            if (delaySignAttribute != null)
            {
                delaySign = (bool)delaySignAttribute;
            }

            var nullableAttribute = compilationOptionsElement.Attribute(NullableAttributeName);
            if (nullableAttribute != null)
            {
                nullable = (NullableContextOptions)Enum.Parse(typeof(NullableContextOptions), nullableAttribute.Value);
            }

            var outputTypeAttribute = compilationOptionsElement.Attribute(OutputTypeAttributeName);
            if (outputTypeAttribute != null
                && outputTypeAttribute.Value == "WindowsRuntimeMetadata")
            {
                if (rootNamespaceAttribute == null)
                {
                    rootNamespace = new VisualBasicCompilationOptions(OutputKind.WindowsRuntimeMetadata).RootNamespace;
                }

                // VB needs Compilation.ParseOptions set (we do the same at the VS layer)
                return language == LanguageNames.CSharp
                   ? new CSharpCompilationOptions(OutputKind.WindowsRuntimeMetadata, allowUnsafe: allowUnsafe)
                   : new VisualBasicCompilationOptions(OutputKind.WindowsRuntimeMetadata).WithGlobalImports(globalImports).WithRootNamespace(rootNamespace)
                        .WithParseOptions((VisualBasicParseOptions)parseOptions ?? VisualBasicParseOptions.Default);
            }
        }
        else
        {
            // Add some common global imports by default for VB
            globalImports.Add(GlobalImport.Parse("System"));
            globalImports.Add(GlobalImport.Parse("System.Collections.Generic"));
            globalImports.Add(GlobalImport.Parse("System.Linq"));
        }

        // TODO: Allow these to be specified.
        var languageServices = Services.GetLanguageServices(language);
        var metadataService = Services.GetService<IMetadataService>();
        var compilationOptions = languageServices.GetService<ICompilationFactoryService>().GetDefaultCompilationOptions();
        compilationOptions = compilationOptions.WithOutputKind(outputKind)
                                               .WithGeneralDiagnosticOption(reportDiagnostic)
                                               .WithSourceReferenceResolver(SourceFileResolver.Default)
                                               .WithXmlReferenceResolver(XmlFileResolver.Default)
                                               .WithMetadataReferenceResolver(new WorkspaceMetadataFileReferenceResolver(metadataService, new RelativePathResolver([], null)))
                                               .WithAssemblyIdentityComparer(DesktopAssemblyIdentityComparer.Default)
                                               .WithCryptoKeyFile(cryptoKeyFile)
                                               .WithStrongNameProvider(strongNameProvider)
                                               .WithDelaySign(delaySign)
                                               .WithOverflowChecks(checkOverflow);

        if (language == LanguageNames.CSharp)
        {
            compilationOptions = ((CSharpCompilationOptions)compilationOptions).WithAllowUnsafe(allowUnsafe).WithNullableContextOptions(nullable);
        }

        if (language == LanguageNames.VisualBasic)
        {
            // VB needs Compilation.ParseOptions set (we do the same at the VS layer)
            compilationOptions = ((VisualBasicCompilationOptions)compilationOptions).WithRootNamespace(rootNamespace)
                                                                                    .WithGlobalImports(globalImports)
                                                                                    .WithParseOptions((VisualBasicParseOptions)parseOptions ??
                                                                                        VisualBasicParseOptions.Default);
        }

        return compilationOptions;
    }

    private TDocument CreateDocument(
        XElement workspaceElement,
        XElement documentElement,
        ExportProvider exportProvider,
        HostLanguageServices languageServiceProvider,
        IDocumentServiceProvider documentServiceProvider,
        ref int documentId)
    {
        var isLinkFileAttribute = documentElement.Attribute(IsLinkFileAttributeName);
        var isLinkFile = isLinkFileAttribute != null && ((bool?)isLinkFileAttribute).HasValue && ((bool?)isLinkFileAttribute).Value;
        if (isLinkFile)
        {
            // This is a linked file. Use the filePath and markup from the referenced document.

            var originalAssemblyName = documentElement.Attribute(LinkAssemblyNameAttributeName)?.Value;
            var originalProjectName = documentElement.Attribute(LinkProjectNameAttributeName)?.Value;

            if (originalAssemblyName == null && originalProjectName == null)
            {
                throw new ArgumentException($"Linked files must specify either a {LinkAssemblyNameAttributeName} or {LinkProjectNameAttributeName}");
            }

            var originalProject = workspaceElement.Elements(ProjectElementName).FirstOrDefault(p =>
            {
                if (originalAssemblyName != null)
                {
                    return p.Attribute(AssemblyNameAttributeName)?.Value == originalAssemblyName;
                }
                else
                {
                    return p.Attribute(ProjectNameAttribute)?.Value == originalProjectName;
                }
            });

            if (originalProject == null)
            {
                if (originalProjectName != null)
                {
                    throw new ArgumentException($"Linked file's {LinkProjectNameAttributeName} '{originalProjectName}' project not found.");
                }
                else
                {
                    throw new ArgumentException($"Linked file's {LinkAssemblyNameAttributeName} '{originalAssemblyName}' project not found.");
                }
            }

            var originalDocumentPath = documentElement.Attribute(LinkFilePathAttributeName)?.Value;

            if (originalDocumentPath == null)
            {
                throw new ArgumentException($"Linked files must specify a {LinkFilePathAttributeName}");
            }

            documentElement = originalProject.Elements(DocumentElementName).FirstOrDefault(d =>
            {
                return d.Attribute(FilePathAttributeName)?.Value == originalDocumentPath;
            });

            if (documentElement == null)
            {
                throw new ArgumentException($"Linked file's LinkFilePath '{originalDocumentPath}' file not found.");
            }
        }

        var markupCode = (bool?)documentElement.Attribute(NormalizeAttributeName) is false
            ? documentElement.Value
            : documentElement.NormalizedValue();

        var fileName = GetFileName(documentElement, ref documentId);

        var folders = GetFolders(documentElement);
        var optionsElement = documentElement.Element(ParseOptionsElementName);

        // TODO: Allow these to be specified.
        var codeKind = SourceCodeKind.Regular;
        if (optionsElement != null)
        {
            var attr = optionsElement.Attribute(KindAttributeName);
            codeKind = attr == null
                ? SourceCodeKind.Regular
                : (SourceCodeKind)Enum.Parse(typeof(SourceCodeKind), attr.Value);
        }

        var markupAttribute = documentElement.Attribute(MarkupAttributeName);
        var isMarkup = markupAttribute == null || (string)markupAttribute == "true" || (string)markupAttribute == "SpansOnly";

        string code;
        int? cursorPosition;
        ImmutableDictionary<string, ImmutableArray<TextSpan>> spans;

        if (isMarkup)
        {
            // if the caller doesn't want us caring about positions, then replace any $'s with a character unlikely
            // to ever show up in the doc naturally.  Then, after we convert things, change that character back. We
            // do this as a single character so that all the positions of the spans do not change.
            if ((string)markupAttribute == "SpansOnly")
                markupCode = markupCode.Replace("$", "\uD7FF");

            TestFileMarkupParser.GetPositionAndSpans(markupCode, out code, out cursorPosition, out spans);

            // if we were told SpansOnly then that means that $$ isn't actually a caret (but is something like a raw
            // interpolated string delimiter.  In that case, if we did see a $$ add it back it at the location we
            // found it, and set the cursor back to null as the test will be specifying that location manually
            // itself.
            if ((string)markupAttribute == "SpansOnly")
            {
                Contract.ThrowIfTrue(cursorPosition != null);
                code = code.Replace("\uD7FF", "$");
            }
        }
        else
        {
            code = markupCode;
            cursorPosition = null;
            spans = ImmutableDictionary<string, ImmutableArray<TextSpan>>.Empty;
        }

        var testDocumentServiceProvider = GetDocumentServiceProvider(documentElement);

        if (documentServiceProvider == null)
        {
            documentServiceProvider = testDocumentServiceProvider;
        }
        else if (testDocumentServiceProvider != null)
        {
            AssertEx.Fail($"The document attributes on file {fileName} conflicted");
        }

        var resolveFilePath = (bool?)documentElement.Attribute("ResolveFilePath");
        var filePath = resolveFilePath is null or true ? Path.Combine(TestWorkspace.RootDirectory, fileName) : fileName;

        return CreateDocument(
            exportProvider, languageServiceProvider, code, fileName, filePath, cursorPosition, spans, codeKind, folders, isLinkFile, documentServiceProvider);
    }
#nullable enable

    private static TestDocumentServiceProvider? GetDocumentServiceProvider(XElement documentElement)
    {
        var canApplyChange = (bool?)documentElement.Attribute("CanApplyChange");
        var supportDiagnostics = (bool?)documentElement.Attribute("SupportDiagnostics");

        if (canApplyChange == null && supportDiagnostics == null)
        {
            return null;
        }

        return new TestDocumentServiceProvider(
            canApplyChange ?? true,
            supportDiagnostics ?? true);
    }

#nullable disable

    private string GetFileName(XElement documentElement, ref int documentId)
    {
        var filePathAttribute = documentElement.Attribute(FilePathAttributeName);
        if (filePathAttribute != null)
        {
            return filePathAttribute.Value;
        }

        var language = GetLanguage(documentElement.Ancestors(ProjectElementName).Single());
        documentId++;
        var name = "Test" + documentId;
        return language == LanguageNames.CSharp ? name + ".cs" : name + ".vb";
    }

    private static IReadOnlyList<string> GetFolders(XElement documentElement)
    {
        var folderAttribute = documentElement.Attribute(FoldersAttributeName);
        if (folderAttribute == null)
        {
            return null;
        }

        var folderContainers = folderAttribute.Value.Split([PathUtilities.DirectorySeparatorChar], StringSplitOptions.RemoveEmptyEntries);
        return new ReadOnlyCollection<string>([.. folderContainers]);
    }

    /// <summary>
    /// Takes completely valid code, compiles it, and emits it to a MetadataReference without using
    /// the file system
    /// </summary>
    protected virtual (MetadataReference reference, ImmutableArray<byte> peImage) CreateMetadataReferenceFromSource(XElement projectElement, XElement referencedSource)
    {
        var compilation = CreateCompilation(referencedSource);

        var aliasElement = referencedSource.Attribute("Aliases")?.Value;
        var aliases = aliasElement != null ? aliasElement.Split(',').SelectAsArray(s => s.Trim()) : default;

        var includeXmlDocComments = false;
        var includeXmlDocCommentsAttribute = referencedSource.Attribute(IncludeXmlDocCommentsAttributeName);
        if (includeXmlDocCommentsAttribute != null &&
            ((bool?)includeXmlDocCommentsAttribute).HasValue &&
            ((bool?)includeXmlDocCommentsAttribute).Value)
        {
            includeXmlDocComments = true;
        }

        var image = compilation.EmitToArray();
        var metadataReference = MetadataReference.CreateFromImage(image, new MetadataReferenceProperties(aliases: aliases), includeXmlDocComments ? new DeferredDocumentationProvider(compilation) : null);
        return (metadataReference, image);
    }

    private Compilation CreateCompilation(XElement referencedSource)
    {
        AssertNoChildText(referencedSource);

        var languageName = GetLanguage(referencedSource);

        var assemblyName = "ReferencedAssembly";
        var assemblyNameAttribute = referencedSource.Attribute(AssemblyNameAttributeName);
        if (assemblyNameAttribute != null)
        {
            assemblyName = assemblyNameAttribute.Value;
        }

        var languageServices = Services.GetLanguageServices(languageName);
        var compilationFactory = languageServices.GetService<ICompilationFactoryService>();
        var options = compilationFactory.GetDefaultCompilationOptions().WithOutputKind(OutputKind.DynamicallyLinkedLibrary);

        var compilation = compilationFactory.CreateCompilation(assemblyName, options);

        var documentElements = referencedSource.Elements(DocumentElementName).ToList();
        var parseOptions = GetParseOptions(referencedSource, languageName, languageServices);

        foreach (var documentElement in documentElements)
        {
            compilation = compilation.AddSyntaxTrees(CreateSyntaxTree(parseOptions, documentElement.Value));
        }

        foreach (var reference in CreateReferenceList(referencedSource))
        {
            compilation = compilation.AddReferences(reference);
        }

        return compilation;
    }

    private static SyntaxTree CreateSyntaxTree(ParseOptions options, string referencedCode)
    {
        var sourceText = SourceText.From(referencedCode, encoding: null, SourceHashAlgorithms.Default);

        if (LanguageNames.CSharp == options.Language)
        {
            return CSharp.SyntaxFactory.ParseSyntaxTree(sourceText, options);
        }
        else
        {
            return VisualBasic.SyntaxFactory.ParseSyntaxTree(sourceText, options);
        }
    }

    private IList<MetadataReference> CreateReferenceList(XElement element)
    {
        var references = CreateCommonReferences(element);
        foreach (var reference in element.Elements(MetadataReferenceElementName))
        {
            // Read the image to an ImmutableArray<byte>, since the GC does a better job of tracking these than
            // Marshal.AllocHGlobal and thus knowing when it's necessary to run finalizers to clean up old Metadata
            // objects that are no longer in use. There are no public APIs available to directly dispose of these
            // images, so we are relying on GC running finalizers to avoid OutOfMemoryException during tests.
            var content = File.ReadAllBytes(reference.Value);
            references.Add(MetadataReference.CreateFromImage(content, filePath: reference.Value));
        }

        foreach (var metadataReferenceFromSource in element.Elements(MetadataReferenceFromSourceElementName))
        {
            references.Add(CreateMetadataReferenceFromSource(element, metadataReferenceFromSource).reference);
        }

        return references;
    }

    private static IList<AnalyzerReference> CreateAnalyzerList(XElement projectElement)
    {
        var analyzers = new List<AnalyzerReference>();
        foreach (var analyzer in projectElement.Elements(AnalyzerElementName))
        {
            analyzers.Add(
                new AnalyzerImageReference(
                    [],
                    display: (string)analyzer.Attribute(AnalyzerDisplayAttributeName),
                    fullPath: (string)analyzer.Attribute(AnalyzerFullPathAttributeName)));
        }

        return analyzers;
    }

    private IList<MetadataReference> CreateCommonReferences(XElement element)
    {
        var references = new List<MetadataReference>();

        var net45 = element.Attribute(CommonReferencesNet45AttributeName);
        if (net45 != null &&
            ((bool?)net45).HasValue &&
            ((bool?)net45).Value)
        {
            references = [TestBase.MscorlibRef_v4_0_30316_17626, TestBase.SystemRef_v4_0_30319_17929, TestBase.SystemCoreRef_v4_0_30319_17929, TestBase.SystemRuntimeSerializationRef_v4_0_30319_17929];
            if (GetLanguage(element) == LanguageNames.VisualBasic)
            {
                references.Add(TestBase.MsvbRef);
                references.Add(TestBase.SystemXmlRef);
                references.Add(TestBase.SystemXmlLinqRef);
            }
        }

        var commonReferencesAttribute = element.Attribute(CommonReferencesAttributeName);
        if (commonReferencesAttribute != null &&
            ((bool?)commonReferencesAttribute).HasValue &&
            ((bool?)commonReferencesAttribute).Value)
        {
            references = [TestBase.MscorlibRef_v46, TestBase.SystemRef_v46, TestBase.SystemCoreRef_v46, TestBase.ValueTupleRef, TestBase.SystemRuntimeFacadeRef];
            if (GetLanguage(element) == LanguageNames.VisualBasic)
            {
                references.Add(TestBase.MsvbRef_v4_0_30319_17929);
                references.Add(TestBase.SystemXmlRef);
                references.Add(TestBase.SystemXmlLinqRef);
            }
        }

        var commonReferencesWithoutValueTupleAttribute = element.Attribute(CommonReferencesWithoutValueTupleAttributeName);
        if (commonReferencesWithoutValueTupleAttribute != null &&
            ((bool?)commonReferencesWithoutValueTupleAttribute).HasValue &&
            ((bool?)commonReferencesWithoutValueTupleAttribute).Value)
        {
            references = [TestBase.MscorlibRef_v46, TestBase.SystemRef_v46, TestBase.SystemCoreRef_v46];
        }

        var winRT = element.Attribute(CommonReferencesWinRTAttributeName);
        if (winRT != null &&
            ((bool?)winRT).HasValue &&
            ((bool?)winRT).Value)
        {
            references = [.. TestBase.WinRtRefs];
            if (GetLanguage(element) == LanguageNames.VisualBasic)
            {
                references.Add(TestBase.MsvbRef_v4_0_30319_17929);
                references.Add(TestBase.SystemXmlRef);
                references.Add(TestBase.SystemXmlLinqRef);
            }
        }

        var portable = element.Attribute(CommonReferencesPortableAttributeName);
        if (portable != null &&
            ((bool?)portable).HasValue &&
            ((bool?)portable).Value)
        {
            references = [.. TestBase.PortableRefsMinimal];
        }

        var netcore30 = element.Attribute(CommonReferencesNetCoreAppName);
        if (netcore30 != null &&
            ((bool?)netcore30).HasValue &&
            ((bool?)netcore30).Value)
        {
            references = [.. NetCoreApp.References];
        }

        var netstandard20 = element.Attribute(CommonReferencesNetStandard20Name);
        if (netstandard20 != null &&
            ((bool?)netstandard20).HasValue &&
            ((bool?)netstandard20).Value)
        {
            references = [.. TargetFrameworkUtil.NetStandard20References];
        }

        var net6 = element.Attribute(CommonReferencesNet6Name);
        if (net6 != null &&
            ((bool?)net6).HasValue &&
            ((bool?)net6).Value)
        {
            references = [.. TargetFrameworkUtil.GetReferences(TargetFramework.Net60)];
        }

        var net7 = element.Attribute(CommonReferencesNet7Name);
        if (net7 != null &&
            ((bool?)net7).HasValue &&
            ((bool?)net7).Value)
        {
            references = [.. TargetFrameworkUtil.GetReferences(TargetFramework.Net70)];
        }

        var net8 = element.Attribute(CommonReferencesNet8Name);
        if (net8 != null &&
            ((bool?)net8).HasValue &&
            ((bool?)net8).Value)
        {
            references = [.. TargetFrameworkUtil.GetReferences(TargetFramework.Net80)];
        }

        var net9 = element.Attribute(CommonReferencesNet9Name);
        if (net9 != null &&
            ((bool?)net9).HasValue &&
            ((bool?)net9).Value)
        {
            references = [.. TargetFrameworkUtil.GetReferences(TargetFramework.Net90)];
        }

        var mincorlib = element.Attribute(CommonReferencesMinCorlibName);
        if (mincorlib != null &&
            ((bool?)mincorlib).HasValue &&
            ((bool?)mincorlib).Value)
        {
            references = [TestBase.MinCorlibRef];
        }

        return references;
    }

    public static bool IsWorkspaceElement(string text)
        => text.TrimStart('\r', '\n', ' ').StartsWith("<Workspace>", StringComparison.Ordinal);

    private static void AssertNoChildText(XElement element)
    {
        foreach (var node in element.Nodes())
        {
            if (node is XText text && !string.IsNullOrWhiteSpace(text.Value))
            {
                throw new Exception($"Element {element} has child text that isn't recognized. The XML syntax is invalid.");
            }
        }
    }
}
