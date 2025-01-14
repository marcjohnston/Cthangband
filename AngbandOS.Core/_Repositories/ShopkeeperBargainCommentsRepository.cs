﻿// AngbandOS: 2022 Marc Johnston
//
// This game is released under the “Angband License”, defined as: “© 1997 Ben Harrison, James E.
// Wilson, Robert A. Koeneke This software may be copied and distributed for educational, research,
// and not for profit purposes provided that this copyright and statement are included in all such
// copies. Other copyrights may also apply.”

namespace AngbandOS.Core.Repositories;

[Serializable]
internal class ShopkeeperBargainCommentsRepository : StringsRepository
{
    public ShopkeeperBargainCommentsRepository(Game game) : base(game) { }

    /// <summary>
    /// Returns ShopkeeperBargainComments as the name of this string list repository.
    /// </summary>
    public override string Name => "ShopkeeperBargainComments";

    public override void Load(GameConfiguration configuration)
    {
        if (configuration.ShopkeeperBargainComments == null)
        {
            Add("Yipee!",
                "I think I'll retire!",
                "The shopkeeper jumps for joy.",
                "The shopkeeper smiles gleefully."
                );
        }
        else
        {
            Add(configuration.ShopkeeperBargainComments);
        }
    }
}