// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CodeStyle;
using Microsoft.VisualStudio.Imaging.Interop;

namespace Microsoft.VisualStudio.LanguageServices.Implementation.Options;

/// <summary>
/// Represents a view model for <see cref="NotificationOption"/>
/// </summary>
internal sealed class NotificationOptionViewModel(NotificationOption2 notification, ImageMoniker moniker)
{
    public ImageMoniker Moniker { get; } = moniker;

    public string Name { get; } = notification.Severity.GetDisplayString();

    public NotificationOption2 Notification { get; } = notification;
}
