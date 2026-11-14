// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;
using System.Diagnostics;

namespace LyricsExtension;

internal sealed partial class LyricsExtensionPage : ListPage
{
    public LyricsExtensionPage()
    {
        Icon = IconHelpers.FromRelativePath("Assets\\StoreLogo.png");
        Title = "Spotify Lyrics";
        Name = "Open";
    }

    public override IListItem[] GetItems()
    {
        var command = new OpenUrlCommand("https://github.com/BestFansi");
        var showMessageCommand = new ShowMessageCommand();

        Debug.Write("Debug message from GetItems");

        return [
            new ListItem(command)
        {
            Title = "Open my Github main page",
        },
            new ListItem(showMessageCommand),
        ];
    }
}
