using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TMListDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI itemName;
    [SerializeField]
    private TextMeshProUGUI itemNumber;
    [SerializeField]
    private TextMeshProUGUI no;
    [SerializeField]
    private RawImage background;

    [SerializeField]
    private Color unselectedColor;
    [SerializeField]
    private Color selectedColor;

    private bool selected = false;

    public TMID tm;
    public void UpdateDisplay()
    {
        no.enabled = true;
        if (tm is TMID.Count)
        {
            itemName.text = "Close";
            itemNumber.text = string.Empty;
            no.enabled = false;
        }
        else
        {
            itemName.text = tm.Move().Data().name;
            itemNumber.enabled = true;
            itemNumber.text = tm >= TMID.HMStart ? (tm - TMID.HMStart + 1).ToString().LeadingZero2() : ((int)tm + 1).ToString().LeadingZero2();
            no.text = tm >= TMID.HMStart ? "HM" : "No.";
            no.enabled = true;
        }
        background.color = selected ? selectedColor : unselectedColor;
    }

    public void Nullify()
    {
        gameObject.SetActive(false);
        selected = false;

    }

    public void UpdateDisplay(TMID tm)
    {
        gameObject.SetActive(true);
        this.tm = tm;
        UpdateDisplay();
    }

    public void ToggleSelect()
    {
        selected = !selected;
        background.color = selected ? selectedColor : unselectedColor;
    }

    public void SetSelected(bool selected)
    {
        if (this.selected != selected) ToggleSelect();
    }
}