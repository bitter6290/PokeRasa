using System;
public class Item
{
    public static ItemData Venusaurite = new()
    {
        itemName = "Venusaurite",
        type = ItemType.MegaStone,
        price = 10000,
        itemData = ItemSubdata.MegaStone(SpeciesID.Ivysaur, SpeciesID.Venusaur) //Must change
    };

    public static ItemData[] ItemTable = new ItemData[ItemID.Count]
    {
        Venusaurite,
        Venusaurite,
        Venusaurite,
        Venusaurite,
        Venusaurite,
    };
}

