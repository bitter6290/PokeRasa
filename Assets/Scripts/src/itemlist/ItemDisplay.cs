using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    [SerializeField]
    private RawImage itemSprite;
    [SerializeField]
    private TextMeshProUGUI itemName;
    [SerializeField]
    private TextMeshProUGUI itemNumber;
    [SerializeField]
    private RawImage background;

    [SerializeField]
    private Color unselectedColor;
    [SerializeField]
    private Color selectedColor;

    public bool selected = false;

    public bool isCloseBag = false;

    public ItemCachedData cachedData;

    public void UpdateDisplay()
    {
        if (isCloseBag)
        {
            itemSprite.texture = null;
            itemName.text = "Close Bag";
            itemNumber.text = string.Empty;
        }
        else
        {
            itemSprite.texture = cachedData.itemSprite;
            itemName.text = cachedData.itemName;
            itemNumber.text = "x" + cachedData.itemNumber;
        }
        background.color = selected ? selectedColor : unselectedColor;
    }

    public void ToggleSelect()
    {
        selected = !selected;
        background.color = selected ? selectedColor : unselectedColor;
    }
}