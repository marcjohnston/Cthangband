// AngbandOS: 2022 Marc Johnston
//
// This game is released under the �Angband License�, defined as: �� 1997 Ben Harrison, James E.
// Wilson, Robert A. Koeneke This software may be copied and distributed for educational, research,
// and not for profit purposes provided that this copyright and statement are included in all such
// copies. Other copyrights may also apply.�

namespace AngbandOS.Core.ItemFactories;

[Serializable]
internal class IronSpikeItemFactory : ItemFactory
{
    private IronSpikeItemFactory(Game game) : base(game) { } // This object is a singleton.

    protected override string SymbolBindingKey => nameof(TildeSymbol);
    public override ColorEnum Color => ColorEnum.Black;
    public override string Name => "Iron Spike";

    public override int Cost => 1;
    public override int DamageDice => 1;
    public override int DamageSides => 1;
    protected override string? DescriptionSyntax => "Iron Spike~";
    public override int LevelNormallyFound => 1;
    public override (int level, int chance)[]? DepthsFoundAndChances => new (int, int)[]
    {
        (1, 1)
    };
    public override int Weight => 10;
    protected override string ItemClassBindingKey => nameof(SpikesItemClass);

    protected override (int, string)[]? MassProduceBindingTuples => new (int, string)[]
    {
        (500, "5d5-5")
    };

    public override int MakeObjectCount => Game.DiceRoll(6, 7);
    public override bool EasyKnow => true;
    public override bool CanSpikeDoorClosed => true;
    public override int PackSort => 37;
}
