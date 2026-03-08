// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Editor.Implementation.IntelliSense.SignatureHelp;
using Microsoft.CodeAnalysis.Editor.Options;
using Microsoft.CodeAnalysis.Editor.Shared.Extensions;
using Microsoft.CodeAnalysis.Editor.Shared.Utilities;
using Microsoft.CodeAnalysis.Options;
using Microsoft.VisualStudio.Text.Editor.Commanding;
using Microsoft.VisualStudio.Text.Editor.Commanding.Commands;

namespace Microsoft.CodeAnalysis.Editor.CommandHandlers;

internal abstract class AbstractSignatureHelpCommandHandler(
    IThreadingContext threadingContext,
    SignatureHelpControllerProvider controllerProvider,
    IGlobalOptionService globalOptions)
{
    protected readonly IThreadingContext ThreadingContext = threadingContext;
    private readonly SignatureHelpControllerProvider _controllerProvider = controllerProvider;
    private readonly IGlobalOptionService _globalOptions = globalOptions;

    protected bool TryGetController(EditorCommandArgs args, out Controller controller)
    {
        this.ThreadingContext.ThrowIfNotOnUIThread();

        // If args is `InvokeSignatureHelpCommandArgs` then sig help was explicitly invoked by the user and should
        // be shown whether or not the option is set.
        var languageName = args.SubjectBuffer.GetLanguageName();
        if (args is not InvokeSignatureHelpCommandArgs &&
            languageName != null &&
            !_globalOptions.GetOption(SignatureHelpViewOptionsStorage.ShowSignatureHelp, languageName))
        {
            controller = null;
            return false;
        }

        controller = _controllerProvider.GetController(args.TextView, args.SubjectBuffer);
        return controller is not null;
    }
}
