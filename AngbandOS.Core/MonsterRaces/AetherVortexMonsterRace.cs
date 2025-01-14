// AngbandOS: 2022 Marc Johnston
//
// This game is released under the �Angband License�, defined as: �� 1997 Ben Harrison, James E.
// Wilson, Robert A. Koeneke This software may be copied and distributed for educational, research,
// and not for profit purposes provided that this copyright and statement are included in all such
// copies. Other copyrights may also apply.�

namespace AngbandOS.Core.MonsterRaces;

[Serializable]
internal class AetherVortexMonsterRace : MonsterRace
{
    protected AetherVortexMonsterRace(Game game) : base(game) { }

    protected override string[]? SpellNames =>new string[] {
        nameof(AcidBreatheBallMonsterSpell),
        nameof(ChaosBreatheBallMonsterSpell),
        nameof(ColdBreatheBallMonsterSpell),
        nameof(ConfusionBreatheBallMonsterSpell),
        nameof(DarkBreatheBallMonsterSpell),
        nameof(LightningBreatheBallMonsterSpell),
        nameof(FireBreatheBallMonsterSpell),
        nameof(ForceBreatheBallMonsterSpell),
        nameof(GravityBreatheBallMonsterSpell),
        nameof(InertiaBreatheBallMonsterSpell),
        nameof(LightBreatheBallMonsterSpell),
        nameof(NetherBreatheBallMonsterSpell),
        nameof(NexusBreatheBallMonsterSpell),
        nameof(PlasmaBreatheBallMonsterSpell),
        nameof(PoisonBreatheBallMonsterSpell),
        nameof(ShardsBreatheBallMonsterSpell),
        nameof(SoundBreatheBallMonsterSpell),
        nameof(TimeBreatheBallMonsterSpell)
    };

    protected override string SymbolName => nameof(LowerVSymbol);
    public override ColorEnum Color => ColorEnum.BrightGrey;
    
    public override int ArmorClass => 40;
    protected override (string, string?, int, int)[]? AttackDefinitions => new (string, string?, int, int)[]
    {
        (nameof(EngulfAttack), nameof(ElectricityAttackEffect), 5, 5),
        (nameof(EngulfAttack), nameof(FireAttackEffect), 3, 3),
        (nameof(EngulfAttack), nameof(AcidAttackEffect), 3, 3),
        (nameof(EngulfAttack), nameof(ColdAttackEffect), 3, 3)
    };
    public override bool AttrAny => true;
    public override bool AttrMulti => true;
    public override bool BashDoor => true;
    public override string Description => "An awesome vortex of pure magic, power radiates from its frame.";
    public override bool EmptyMind => true;
    public override bool FireAura => true;
    public override bool ForceSleep => true;
    public override int FreqInate => 6;
    public override int FreqSpell => 6;
    public override string FriendlyName => "Aether vortex";
    public override int Hdice => 32;
    public override int Hside => 20;
    public override bool ImmuneAcid => true;
    public override bool ImmuneCold => true;
    public override bool ImmuneConfusion => true;
    public override bool ImmuneFear => true;
    public override bool ImmuneFire => true;
    public override bool ImmuneLightning => true;
    public override bool ImmunePoison => true;
    public override bool ImmuneSleep => true;
    public override int LevelFound => 55;
    public override bool LightningAura => true;
    public override int Mexp => 4500;
    public override bool Nonliving => true;
    public override int NoticeRange => 100;
    public override bool Powerful => true;
    public override bool RandomMove25 => true;
    public override bool RandomMove50 => true;
    public override int Rarity => 2;
    public override bool ResistNether => true;
    public override bool ResistNexus => true;
    public override bool ResistPlasma => true;
    public override int Sleep => 0;
    public override int Speed => 130;
    public override string? MultilineName => "Aether\nvortex";
}
