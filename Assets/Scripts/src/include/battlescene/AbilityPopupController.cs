using System.Collections;
using TMPro;
using UnityEngine;

public class AbilityPopupController : MonoBehaviour
{
    public GameObject popup;
    public TextMeshProUGUI monName;
    public TextMeshProUGUI abilityName;
    public bool whichSide;
    public Vector2 defaultPosition;

    public IEnumerator Summon(string monName, string abilityName)
    {
        this.monName.text = monName + "'s";
        this.abilityName.text = abilityName;
        yield return AnimUtils.Slide(popup.transform, new Vector2(whichSide ? 3.0F : -3.0F, 0.0F), 0.2F);
        popup.transform.position = defaultPosition + new Vector2(whichSide ? 3.0F : -3.0F, 0.0F);
    }

    public IEnumerator Dismiss()
    {
        yield return AnimUtils.Slide(popup.transform, new Vector2(whichSide ? -3.0F : 3.0F, 0.0F), 0.2F);
        popup.transform.position = defaultPosition;
    }

    public IEnumerator ChangeAbility(string newAbilityName)
    {
        float baseTime = Time.time;
        float endTime = baseTime + 0.2F;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) * 5;
            abilityName.color = new(progress, progress, progress);
            yield return null;
        }
        abilityName.color = Color.white;
        abilityName.text = newAbilityName;
        baseTime = Time.time;
        endTime = baseTime + 0.2F;
        while (Time.time < endTime)
        {
            float progress = 1 - ((Time.time - baseTime) * 5);
            abilityName.color = new(progress, progress, progress);
            yield return null;
        }
        abilityName.color = Color.black;
    }

    public void Update()
    {

    }
}