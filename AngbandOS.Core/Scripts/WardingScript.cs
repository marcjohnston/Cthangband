﻿// AngbandOS: 2022 Marc Johnston
//
// This game is released under the “Angband License”, defined as: “© 1997 Ben Harrison, James E.
// Wilson, Robert A. Koeneke This software may be copied and distributed for educational, research,
// and not for profit purposes provided that this copyright and statement are included in all such
// copies. Other copyrights may also apply.”

namespace AngbandOS.Core.Scripts;

[Serializable]
internal class WardingScript : Script, IScript, ICastSpellScript
{
    private WardingScript(Game game) : base(game) { }

    public void ExecuteCastSpellScript(Spell spell)
    {
        ExecuteScript();
    }

    /// <summary>
    /// Executes the script.
    /// </summary>
    /// <returns></returns>
    public void ExecuteScript()
    {
        Game.RunScript(nameof(ElderSignScript));
        Projectile projectile = Game.SingletonRepository.Get<Projectile>(nameof(MakeElderSignProjectile));
        projectile.Fire(0, 1, Game.MapY.IntValue, Game.MapX.IntValue, 0, grid: true, item: true, jump: false, beam: false, thru: false, hide: false, kill: false, stop: false);
    }
}
