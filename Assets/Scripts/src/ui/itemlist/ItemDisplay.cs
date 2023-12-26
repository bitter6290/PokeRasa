using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI itemName;
    [SerializeField]
    private TextMeshProUGUI itemNumber;
    [SerializeField]
    private TextMeshProUGUI x;
    [SerializeField]
    private RawImage background;

    [SerializeField]
    private Color unselectedColor;
    [SerializeField]
    private Color selectedColor;

    public bool selected = false;

    public bool isCloseBag = false;

    public ItemID item;
    public Player p;

    public void UpdateDisplay()
    {
        x.enabled = true;
        if (item is ItemID.CloseBag)
        {
            itemName.text = "Close Bag";
            itemNumber.text = string.Empty;
            x.enabled = false;
        }
        else
        {
            itemName.text = item.Data().itemName;
            itemNumber.text = p.Bag[item].ToString();
            x.enabled = item.Data().type is not ItemType.KeyItem;
        }
        background.color = selected ? selectedColor : unselectedColor;
    }

    public void Nullify()
    {
        itemName.text = string.Empty;
        itemNumber.text = string.Empty;
        background.color = unselectedColor;
        x.enabled = false;
        selected = false;
    }

    public void UpdateDisplay(ItemID item)
    {
        this.item = item;
        UpdateDisplay();
    }

    public void ToggleSelect()
    {
        selected = !selected;
        background.color = selected ? selectedColor : unselectedColor;
    }
}