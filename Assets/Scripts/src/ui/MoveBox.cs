using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static MenuManager;

public class MoveBox : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI moveName;
    [SerializeField]
    private TextMeshProUGUI movePp;
    [SerializeField]
    private RawImage moveBox;
    [SerializeField]
    private RawImage selectBox;

    public void Adopt(Pokemon mon, int slot)
    {
        if (mon.MoveIDs[slot] is MoveID.None)
        {
            gameObject.SetActive(false);
            return;
        }
        gameObject.SetActive(true);
        MoveData move = mon.MoveIDs[slot].Data();
        moveName.text = move.name;
        moveName.color = move.type.TextColor();
        movePp.text = LeadingZero(mon.PP[slot].ToString()) + " / " + LeadingZero(mon.MaxPP[slot].ToString());
    }

    public void SetSelected(bool selected) => selectBox.enabled = selected;
}