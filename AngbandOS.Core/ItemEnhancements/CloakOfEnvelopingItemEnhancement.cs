// AngbandOS: 2022 Marc Johnston
//
// This game is released under the �Angband License�, defined as: �� 1997 Ben Harrison, James E.
// Wilson, Robert A. Koeneke This software may be copied and distributed for educational, research,
// and not for profit purposes provided that this copyright and statement are included in all such
// copies. Other copyrights may also apply.�

namespace AngbandOS.Core.ItemEnhancements;

[Serializable]
internal class CloakOfEnvelopingItemEnhancement : ItemEnhancement
{
    private CloakOfEnvelopingItemEnhancement(Game game) : base(game) { } // This object is a singleton.
    public override int? Value => 0;
    public override string? FriendlyName => "of Enveloping";
    protected override string? BonusDamageRollExpression => "1d10";
    protected override string? BonusHitRollExpression => "1d10";
    public override int TreasureRating => 0;
    public override bool ShowMods => true;
}
