using System;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public abstract class ItemData
{
    public string itemName;
    public int price;
    public ItemType type;
    public string graphicsPath;
    public int flingPower = 30;
    public MoveEffect flingEffect = MoveEffect.None;
    public abstract int[] ItemSubdata { get; }

    public Texture2D ItemSprite => Resources.Load<Texture2D>("Sprites/Items/" + graphicsPath);
}

public class AbstractItem : ItemData //subdata length 0
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
        heldEffectIntensity,
    };
    public HeldItem()
    {
        type = ItemType.HeldItem;
    }
}

public class PlateItem : HeldItem //subdata length 3
{
    public Type plateType;
    public override int[] ItemSubdata => new int[3]
    {
        (int)heldEffect,
        heldEffectIntensity,
        (int)plateType,
    };
    public PlateItem()
    {
        type = ItemType.Plate;
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
        fieldEffectIntensity,
    };
}

public class PokeBall : ItemData //subdata length 3
{
    public BallCatchType ballType;
    public BallBehavior ballBehavior = BallBehavior.None;
    public int catchRateModifier; //Multiplied by 10
    public override int[] ItemSubdata => new int[3]
    {
        (int)ballType,
        (int)ballBehavior,
        catchRateModifier
    };
    public PokeBall()
    {
        type = ItemType.PokeBall;
        flingPower = 0;
    }
}

public class Berry : ItemData //subdata length 8
{
    public HeldEffect heldEffect;
    public int heldEffectIntensity;
    public BattleItemEffect battleEffect;
    public int battleEffectIntensity;
    public FieldEffect fieldEffect;
    public int fieldEffectIntensity;
    public BerryEffect berryEffect;
    public int hoursToGrow;
    public override int[] ItemSubdata => new int[8]
    {
        (int)heldEffect,
        heldEffectIntensity,
        (int)battleEffect,
        battleEffectIntensity,
        (int)fieldEffect,
        fieldEffectIntensity,
        (int)berryEffect,
        hoursToGrow,
    };
    public Berry()
    {
        type = ItemType.Berry;
        flingPower = 10;
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
        flingPower = 0;
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
        flingPower = 80;
    }
}

public class ZCrystalGeneric : ItemData //subdata length 3
{
    public Type moveType;
    public MoveID zMovePhysical;
    public MoveID zMoveSpecial;
    public override int[] ItemSubdata => new int[3]
    {
        (int)moveType,
        (int)zMovePhysical,
        (int)zMoveSpecial
    };
    public ZCrystalGeneric()
    {
        type = ItemType.ZCrystalGeneric;
        flingPower = 0;
    }
}

public class ZCrystalSpecific : ItemData //subdata length 3
{
    public SpeciesID user;
    public MoveID baseMove;
    public MoveID zMove;
    public override int[] ItemSubdata => new int[3]
    {
        (int)user,
        (int)baseMove,
        (int)zMove
    };
    public ZCrystalSpecific()
    {
        type = ItemType.ZCrystalSpecific;
        flingPower = 0;
    }
}

public class ZCrystalMultipleSpecies : ItemData //subdata length 2, plus extra list
{
    public MoveID baseMove;
    public MoveID zMove;
    public SpeciesID[] users;
    public override int[] ItemSubdata => new int[2]
    {
        (int)baseMove,
        (int)zMove
    };
    public ZCrystalMultipleSpecies()
    {
        type = ItemType.ZCrystalMultipleSpecies;
        flingPower = 0;
    }
}

public class KeyItem : ItemData //subdata length 1
{
    public Flag flag;
    public override int[] ItemSubdata => new int[1] { (int)flag };
    public KeyItem()
    {
        type = ItemType.KeyItem;
        flingPower = 0;
    }
}

public class HoldToTransform : ItemData //subdata length 2
{
    public SpeciesID baseSpecies;
    public SpeciesID transformedSpecies;
    public override int[] ItemSubdata => new int[2]
    {
        (int)baseSpecies,
        (int)transformedSpecies
    };
    public HoldToTransform()
    {
        type = ItemType.HoldToTransform;
    }
}

public static class ItemUtils
{
    public static HeldEffect HeldEffect(this ItemID item)
    {
        switch (Item.ItemTable[(int)item].type)
        {
            case ItemType.HeldItem:
            case ItemType.HeldFieldItem:
            case ItemType.Berry:
                return (HeldEffect)Item.ItemTable[(int)item].ItemSubdata[0];
            default:
                return global::HeldEffect.None;
        }
    }
    public static int HeldEffectIntensity(this ItemID item)
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
    public static FieldEffect FieldEffect(this ItemID item)
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
            case ItemType.TM:
                return global::FieldEffect.TM;
            default:
                return global::FieldEffect.None;
        }
    }
    public static int FieldEffectIntensity(this ItemID item)
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

    public static BerryEffect BerryEffect(this ItemID item)
    {
        switch (Item.ItemTable[(int)item].type)
        {
            case ItemType.Berry:
                return (BerryEffect)Item.ItemTable[(int)item].ItemSubdata[6];
            default:
                return global::BerryEffect.None;
        }
    }

    public static SpeciesID MegaStoneUser(this ItemID item)
    {
        switch (Item.ItemTable[(int)item].type)
        {
            case ItemType.MegaStone:
                return (SpeciesID)Item.ItemTable[(int)item].ItemSubdata[0];
            default:
                return SpeciesID.Missingno;
        }
    }

    public static Type PlateType(this ItemID item)
    {
        switch (item.Data().type)
        {
            case ItemType.Plate:
                return (Type)item.Data().ItemSubdata[2];
            default:
                return Type.Typeless;
        }
    }

    public static Type ZMoveType(this ItemID item)
    {
        switch (item.Data().type)
        {
            case ItemType.ZCrystalGeneric:
                return (Type)item.Data().ItemSubdata[0];
            default:
                return Type.Typeless;
        }
    }

    public static SpeciesID ZMoveUser(this ItemID item)
    {
        switch (item.Data().type)
        {
            case ItemType.ZCrystalSpecific:
                return (SpeciesID)item.Data().ItemSubdata[0];
            default:
                return SpeciesID.Missingno;
        }
    }

    public static MoveID ZMoveBase(this ItemID item)
    {
        switch (item.Data().type)
        {
            case ItemType.ZCrystalSpecific:
                return (MoveID)item.Data().ItemSubdata[1];
            case ItemType.ZCrystalMultipleSpecies:
                return (MoveID)item.Data().ItemSubdata[0];
            default:
                return MoveID.None;
        }
    }

    public static MoveID ZMoveResult(this ItemID item, bool physical)
    {
        switch (item.Data().type)
        {
            case ItemType.ZCrystalGeneric:
                return (MoveID)item.Data().ItemSubdata[physical ? 1 : 2];
            case ItemType.ZCrystalSpecific:
                return (MoveID)item.Data().ItemSubdata[2];
            case ItemType.ZCrystalMultipleSpecies:
                return (MoveID)item.Data().ItemSubdata[1];
            default:
                return MoveID.None;
        }
    }

    public static BallCatchType BallCatchType(this ItemID item)
    {
        switch (item.Data().type)
        {
            case ItemType.PokeBall:
                return (BallCatchType)item.Data().ItemSubdata[0];
            default: return global::BallCatchType.NotBall;
        }
    }

    public static BallBehavior BallBehavior(this ItemID item)
    {
        switch (item.Data().type)
        {
            case ItemType.PokeBall:
                return (BallBehavior)item.Data().ItemSubdata[1];
            default: return global::BallBehavior.None;
        }
    }

    public static float CatchRateModifier(this ItemID item)
    {
        switch (item.Data().type)
        {
            case ItemType.PokeBall:
                return item.Data().ItemSubdata[2] / 10.0F;
            default: return 0;
        }
    }

    public static bool IsZCrystal(this ItemID item) => item.Data().type is
        ItemType.ZCrystalGeneric or ItemType.ZCrystalSpecific or
        ItemType.ZCrystalMultipleSpecies;
    public static bool CanBeStolen(ItemID item) =>
        item.Data().type is ItemType.FieldItem or ItemType.BattleItem or ItemType.Medicine
        or ItemType.AbstractItem;

    public static ItemData Data(this ItemID item) => Item.ItemTable[(int)item];
    public static Sprite Sprite(this ItemID item) => UnityEngine.Sprite.Create(
        Resources.Load<Texture2D>("Sprites/Items/" + item.Data().graphicsPath),
        new(0F, 0F, 24F, 24F), StaticValues.defPivot);
}