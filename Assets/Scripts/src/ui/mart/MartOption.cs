using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MartOption : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI itemName;
    [SerializeField]
    private TextMeshProUGUI itemPrice;
    [SerializeField]
    private RawImage itemIcon;

    public void Adopt(ItemID item)
    {
        if (item is ItemID.CloseBag)
        {
            itemName.text = "Cancel";
            itemPrice.enabled = false;
            itemIcon.enabled = false;
        }
        else
        {
            itemName.text = item.Data().itemName;
            itemPrice.enabled = true;
            itemPrice.text = item.Data().price.ToString();
            itemIcon.enabled = true;
            itemIcon.texture = item.Data().ItemSprite;
        }
    }

    public void SetActive(bool active) => gameObject.SetActive(active);
}