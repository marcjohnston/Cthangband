﻿// AngbandOS: 2022 Marc Johnston
//
// This game is released under the “Angband License”, defined as: “© 1997 Ben Harrison, James E.
// Wilson, Robert A. Koeneke This software may be copied and distributed for educational, research,
// and not for profit purposes provided that this copyright and statement are included in all such
// copies. Other copyrights may also apply.”

namespace AngbandOS.Core.GameCommands;

/// <summary>
/// Display a map of the area on screen
/// </summary>
[Serializable]
internal class ViewMapGameCommand : GameCommand
{
    private ViewMapGameCommand(Game game) : base(game) { } // This object is a singleton.

    public override char KeyChar => 'M';

    protected override string? ExecuteScriptName => nameof(ViewMapScript);
}
