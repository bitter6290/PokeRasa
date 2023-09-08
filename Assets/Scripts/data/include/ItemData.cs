using System;
public abstract class ItemData
{
    public string itemName;
    public int price;
    public ItemType type;
    public abstract int[] ItemSubdata { get; }
}

public class FieldItem : ItemData //subdata length 2
{
    public FieldEffect fieldEffect;
    public int fieldEffectIntensity;
    public override int[] ItemSubdata => new int[2]
        {
            (int)fieldEffect,
            fieldEffectIntensity,
        };

    public FieldItem()
    {
        type = ItemType.FieldItem;
    }

}

public class BattleItem : ItemData //subdata length 2
{
    public BattleItemEffect battleEffect;
    public int battleEffectIntensity;
    public override int[] ItemSubdata => new int[2]
        {
            (int)battleEffect,
            battleEffectIntensity,
        };
    public BattleItem()
    {
        type = ItemType.BattleItem;
    }
}

public class Medicine : ItemData //subdata length 4
{
    public FieldEffect fieldEffect;
    public int fieldEffectIntensity;
    public BattleItemEffect battleEffect;
    public int battleEffectIntensity;
    public override int[] ItemSubdata => new int[4]
        {
            (int)fieldEffect,
            fieldEffectIntensity,
            (int)battleEffect,
            battleEffectIntensity,
        };
    public Medicine()
    {
        type = ItemType.Medicine;
    }
}

public class TM : ItemData //subdata length 1
{
    public TMID TMID;
    public override int[] ItemSubdata => new int[1] { (int)TMID };
    public TM()
    {
        type = ItemType.TM;
    }
}

public class MegaStone : ItemData //subdata length 2
{
    public SpeciesID originalSpecies;
    public SpeciesID destinationSpecies;
    public override int[] ItemSubdata => new int[2]
    {
        (int)originalSpecies,
        (int)destinationSpecies,
    };
    public MegaStone()
    {
        type = ItemType.MegaStone;
    }
}

public class KeyItem : ItemData //subdata length 1
{
    public int KeyItemID;
    public override int[] ItemSubdata => new int[1] { KeyItemID };
    public KeyItem()
    {
        type = ItemType.KeyItem;
    }
}