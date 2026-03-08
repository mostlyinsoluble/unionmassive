// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Editor.EditorConfigSettings.Data;

namespace Microsoft.VisualStudio.LanguageServices.EditorConfigSettings.CodeStyle.View;

internal sealed class CodeStyleValueViewModel(CodeStyleSetting setting)
{
    private readonly CodeStyleSetting _setting = setting;

    public string[] Values => _setting.GetValueDescriptions();

    public string SelectedValue
    {
        get
        {
            field ??= _setting.GetCurrentValueDescription();

            return field;
        }
        set;
    }

    public string ToolTip => ServicesVSResources.Value;

    public static string AutomationName => ServicesVSResources.Value;

    public void SelectionChanged(int selectedIndex)
        => _setting.ChangeValue(selectedIndex);
}
