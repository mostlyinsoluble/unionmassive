// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Options;
using Microsoft.VisualStudio.LanguageServices.Implementation.Utilities;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.Options;

internal abstract class AbstractCheckBoxViewModel(IOption2 option, string description, string truePreview, string falsePreview, AbstractOptionPreviewViewModel info) : AbstractNotifyPropertyChanged
{
    private readonly string _truePreview = truePreview;
    private readonly string _falsePreview = falsePreview;
    protected bool _isChecked;

    protected AbstractOptionPreviewViewModel Info { get; } = info;
    public IOption2 Option { get; } = option;
    public string Description { get; set; } = description;

    internal virtual string GetPreview() => _isChecked ? _truePreview : _falsePreview;

    public AbstractCheckBoxViewModel(IOption2 option, string description, string preview, AbstractOptionPreviewViewModel info)
        : this(option, description, preview, preview, info)
    {
    }

    public abstract bool IsChecked { get; set; }
}
