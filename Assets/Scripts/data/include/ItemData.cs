using System;
public class ItemData
{
    public string itemName;
    public int price;
    public ItemType type;
    public ItemSubdata itemData;

}

[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
public struct ItemSubdata
{
    [System.Runtime.InteropServices.FieldOffset(0)]
    public ushort fieldEffect;
    [System.Runtime.InteropServices.FieldOffset(4)]
    public ushort fieldEffectData;
    [System.Runtime.InteropServices.FieldOffset(6)]
    public ushort battleEffect;
    [System.Runtime.InteropServices.FieldOffset(8)]
    public ushort battleEffectData;
    [System.Runtime.InteropServices.FieldOffset(10)]
    public ushort heldEffect;
    [System.Runtime.InteropServices.FieldOffset(12)]
    public byte heldEffectData;
    [System.Runtime.InteropServices.FieldOffset(0)]
    public byte tmID;
    [System.Runtime.InteropServices.FieldOffset(0)]
    public byte keyItemID;
    [System.Runtime.InteropServices.FieldOffset(0)]
    public SpeciesID originalSpecies;
    [System.Runtime.InteropServices.FieldOffset(2)]
    public SpeciesID destinationSpecies;

    public static ItemSubdata NormalItem(ushort fieldEffect, ushort fieldEffectData,
        ushort battleEffect, ushort battleEffectData, ushort heldEffect, byte heldEffectData)
    {
        ItemSubdata subdata = new()
        {
            fieldEffect = fieldEffect,
            fieldEffectData = fieldEffectData,
            battleEffect = battleEffect,
            battleEffectData = battleEffectData,
            heldEffect = heldEffect,
            heldEffectData = heldEffectData
        };
        return subdata;
    }

    public static ItemSubdata TM(byte tmID)
    {
        ItemSubdata subdata = new()
        {
            tmID = tmID
        };
        return subdata;
    }

    public static ItemSubdata KeyItem(byte keyItemID)
    {
        ItemSubdata subdata = new()
        {
            keyItemID = keyItemID
        };
        return subdata;
    }

    public static ItemSubdata MegaStone(SpeciesID originalSpecies, SpeciesID destinationSpecies)
    {
        ItemSubdata subdata = new()
        {
            originalSpecies = originalSpecies,
            destinationSpecies = destinationSpecies
        };
        return subdata;
    }
}