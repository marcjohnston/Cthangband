﻿// AngbandOS: 2022 Marc Johnston
//
// This game is released under the “Angband License”, defined as: “© 1997 Ben Harrison, James E.
// Wilson, Robert A. Koeneke This software may be copied and distributed for educational, research,
// and not for profit purposes provided that this copyright and statement are included in all such
// copies. Other copyrights may also apply.”

namespace AngbandOS.Core.GameCommands;

/// <summary>
/// Activate an artifact or similar
/// </summary>
/// <param name="itemIndex">
/// The inventory index of the item to be activated, or -999 to select item
/// </param>
[Serializable]
internal class ActivateGameCommand : GameCommand
{
    private ActivateGameCommand(Game game) : base(game) { } // This object is a singleton.

    public override char KeyChar => 'A';

    public override int? Repeat => 0;

    protected override string? ExecuteScriptName => nameof(ActivateScript);
}

