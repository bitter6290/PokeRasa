using UnityEngine;
public readonly struct ItemCachedData
{
    public readonly ItemID item;
    public readonly string itemName;
    public readonly string itemNumber;
    public readonly ItemType itemType;
    public readonly Texture2D itemSprite;

    public ItemCachedData(Player p, ItemID item)
    {
        this.item = item;
        itemName = item.Data().itemName;
        itemNumber = p.Bag[item].ToString();
        itemSprite = item.Data().ItemSprite;
        itemType = item.Data().type;
    }
}