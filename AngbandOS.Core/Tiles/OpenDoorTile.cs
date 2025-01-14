// AngbandOS: 2022 Marc Johnston
//
// This game is released under the �Angband License�, defined as: �� 1997 Ben Harrison, James E.
// Wilson, Robert A. Koeneke This software may be copied and distributed for educational, research,
// and not for profit purposes provided that this copyright and statement are included in all such
// copies. Other copyrights may also apply.�

namespace AngbandOS.Core.Tiles;

[Serializable]
internal class OpenDoorTile : Tile
{
    private OpenDoorTile(Game game) : base(game) { } // This object is a singleton.
    protected override string SymbolName => nameof(SingleQuoteSymbol);
    public override ColorEnum Color => ColorEnum.BrightBrown;
    protected override string? AlterActionName => nameof(CloseAlterAction);
    public override string Description => "open door";
    public override bool DimsOutsideLOS => true;
    public override bool IsPassable => true;
    public override int MapPriority => 17;

    /// <summary>
    /// Returns true, because this tile is an open door.
    /// </summary>
    public override bool IsOpenDoor => true;
}
