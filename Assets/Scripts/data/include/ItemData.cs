using System;
public abstract class ItemData
{
    public string itemName;
    public int price;
    public ItemType type;
    public abstract int[] ItemSubdata { get; }
}

public class AbstractItem : ItemData
{
    public override int[] ItemSubdata => new int[0];
    public AbstractItem()
    {
        type = ItemType.AbstractItem;
    }
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

public class HeldItem : ItemData //subdata length 2
{
    public HeldEffect heldEffect;
    public int heldEffectIntensity;
    public override int[] ItemSubdata => new int[2]
    {
        (int)heldEffect,
        heldEffectIntensity
    };
    public HeldItem()
    {
        type = ItemType.HeldItem;
    }
}

public class HeldFieldItem : ItemData //subdata length 4
{
    public HeldEffect heldEffect;
    public int heldEffectIntensity;
    public FieldEffect fieldEffect;
    public int fieldEffectIntensity;
    public override int[] ItemSubdata => new int[4]
    {
        (int)heldEffect,
        heldEffectIntensity,
        (int)fieldEffect,
        fieldEffectIntensity
    };
}

public class Berry : ItemData //subdata length 7
{
    public HeldEffect heldEffect;
    public int heldEffectIntensity;
    public BattleItemEffect battleEffect;
    public int battleEffectIntensity;
    public FieldEffect fieldEffect;
    public int fieldEffectIntensity;
    public int hoursToGrow;
    public override int[] ItemSubdata => new int[7]
    {
        (int)heldEffect,
        heldEffectIntensity,
        (int)battleEffect,
        battleEffectIntensity,
        (int)fieldEffect,
        fieldEffectIntensity,
        hoursToGrow
    };
    public Berry()
    {
        type = ItemType.Berry;
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

public static class ItemUtils
{
    public static HeldEffect heldEffect(this ItemID item)
    {
        switch (Item.ItemTable[(int)item].type)
        {
            case ItemType.HeldItem:
            case ItemType.HeldFieldItem:
            case ItemType.Berry:
                return (HeldEffect)Item.ItemTable[(int)item].ItemSubdata[0];
            default:
                return HeldEffect.None;
        }
    }
    public static int heldEffectIntensity(this ItemID item)
    {
        switch (Item.ItemTable[(int)item].type)
        {
            case ItemType.HeldItem:
            case ItemType.HeldFieldItem:
            case ItemType.Berry:
                return Item.ItemTable[(int)item].ItemSubdata[1];
            default:
                return 0;
        }
    }
    public static FieldEffect fieldEffect(this ItemID item)
    {
        switch (Item.ItemTable[(int)item].type)
        {
            case ItemType.FieldItem:
            case ItemType.Medicine:
                return (FieldEffect)Item.ItemTable[(int)item].ItemSubdata[0];
            case ItemType.HeldFieldItem:
                return (FieldEffect)Item.ItemTable[(int)item].ItemSubdata[2];
            case ItemType.Berry:
                return (FieldEffect)Item.ItemTable[(int)item].ItemSubdata[4];
            default:
                return FieldEffect.None;
        }
    }
    public static int fieldEffectIntensity(this ItemID item)
    {
        switch (Item.ItemTable[(int)item].type)
        {
            case ItemType.FieldItem:
            case ItemType.Medicine:
                return Item.ItemTable[(int)item].ItemSubdata[1];
            case ItemType.HeldFieldItem:
                return Item.ItemTable[(int)item].ItemSubdata[3];
            case ItemType.Berry:
                return Item.ItemTable[(int)item].ItemSubdata[5];
            default:
                return 0;
        }
    }

    public static SpeciesID megaStoneUser(this ItemID item)
    {
        switch (Item.ItemTable[(int)item].type)
        {
            case ItemType.MegaStone:
                return (SpeciesID)Item.ItemTable[(int)item].ItemSubdata[0];
            default:
                return SpeciesID.Missingno;
        }
    }

    public static ItemData Data(this ItemID item) => Item.ItemTable[(int)item];
}