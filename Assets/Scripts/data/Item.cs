using System;
public static class Item
{
    public static bool CanBeStolen(ItemID item) => ItemTable[(int)item].type is ItemType.FieldItem or ItemType.BattleItem or ItemType.Medicine;

    public static ItemData None = new()
    {
        itemName = "Error 901",
        type = ItemType.FieldItem,
        price = 100,
        itemData = ItemSubdata.NormalItem(FieldEffect.None, 0, BattleItemEffect.None, 0, HeldEffect.None, 0)
    };

    public static ItemData FireStone = new()
    {
        itemName = "Fire Stone",
        type = ItemType.FieldItem,
        price = 5000,
        itemData = ItemSubdata.NormalItem(FieldEffect.Evolution, 0, BattleItemEffect.None, 0, HeldEffect.None, 0)
    };

    public static ItemData WaterStone = new()
    {
        itemName = "Water Stone",
        type = ItemType.FieldItem,
        price = 5000,
        itemData = ItemSubdata.NormalItem(FieldEffect.Evolution, 0, BattleItemEffect.None, 0, HeldEffect.None, 0)
    };

    public static ItemData ThunderStone = new()
    {
        itemName = "Thunder Stone",
        type = ItemType.FieldItem,
        price = 5000,
        itemData = ItemSubdata.NormalItem(FieldEffect.Evolution, 0, BattleItemEffect.None, 0, HeldEffect.None, 0)
    };

    public static ItemData LeafStone = new()
    {
        itemName = "Leaf Stone",
        type = ItemType.FieldItem,
        price = 5000,
        itemData = ItemSubdata.NormalItem(FieldEffect.Evolution, 0, BattleItemEffect.None, 0, HeldEffect.None, 0)
    };

    public static ItemData MoonStone = new()
    {
        itemName = "Moon Stone",
        type = ItemType.FieldItem,
        price = 5000,
        itemData = ItemSubdata.NormalItem(FieldEffect.Evolution, 0, BattleItemEffect.None, 0, HeldEffect.None, 0)
    };

    public static ItemData SunStone = new()
    {
        itemName = "Sun Stone",
        type = ItemType.FieldItem,
        price = 5000,
        itemData = ItemSubdata.NormalItem(FieldEffect.Evolution, 0, BattleItemEffect.None, 0, HeldEffect.None, 0)
    };

    public static ItemData ShinyStone = new()
    {
        itemName = "Shiny Stone",
        type = ItemType.FieldItem,
        price = 5000,
        itemData = ItemSubdata.NormalItem(FieldEffect.Evolution, 0, BattleItemEffect.None, 0, HeldEffect.None, 0)
    };

    public static ItemData DawnStone = new()
    {
        itemName = "Dawn Stone",
        type = ItemType.FieldItem,
        price = 5000,
        itemData = ItemSubdata.NormalItem(FieldEffect.Evolution, 0, BattleItemEffect.None, 0, HeldEffect.None, 0)
    };

    public static ItemData DuskStone = new()
    {
        itemName = "Dusk Stone",
        type = ItemType.FieldItem,
        price = 5000,
        itemData = ItemSubdata.NormalItem(FieldEffect.Evolution, 0, BattleItemEffect.None, 0, HeldEffect.None, 0)
    };

    public static ItemData IceStone = new()
    {
        itemName = "Ice Stone",
        type = ItemType.FieldItem,
        price = 5000,
        itemData = ItemSubdata.NormalItem(FieldEffect.Evolution, 0, BattleItemEffect.None, 0, HeldEffect.None, 0)
    };

    public static ItemData Venusaurite = new()
    {
        itemName = "Venusaurite",
        type = ItemType.MegaStone,
        price = 10000,
        itemData = ItemSubdata.MegaStone(SpeciesID.Ivysaur, SpeciesID.Venusaur) //Must change
    };

    public static ItemData CharizarditeX = new()
    {
        itemName = "Charizardite X",
        type = ItemType.MegaStone,
        price = 10000,
        itemData = ItemSubdata.MegaStone(SpeciesID.Ivysaur, SpeciesID.Venusaur) //Must change
    };

    public static ItemData CharizarditeY = new()
    {
        itemName = "Charizardite Y",
        type = ItemType.MegaStone,
        price = 10000,
        itemData = ItemSubdata.MegaStone(SpeciesID.Ivysaur, SpeciesID.Venusaur) //Must change
    };

    public static ItemData Blastoisinite = new()
    {
        itemName = "Blastoisinite",
        type = ItemType.MegaStone,
        price = 10000,
        itemData = ItemSubdata.MegaStone(SpeciesID.Ivysaur, SpeciesID.Venusaur) //Must change
    };

    public static ItemData[] ItemTable = new ItemData[(int)ItemID.Count]
    {
    None,
    //Evolution items
    FireStone,
    WaterStone,
    ThunderStone,
    LeafStone,
    MoonStone,
    SunStone,
    ShinyStone,
    DuskStone,
    DawnStone,
    IceStone,
    //Mega stones
    Venusaurite,
    CharizarditeX,
    CharizarditeY,
    Blastoisinite,
    };
}

