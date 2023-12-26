using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class MonDisplay : MonoBehaviour
{
    [SerializeField] private RawImage box;
    [SerializeField] private Image monSprite;
    [SerializeField] private TextMeshProUGUI monName;
    [SerializeField] private Image monStatus;
    [SerializeField] private Transform healthBar;
    [SerializeField] private TextMeshProUGUI hpMax;
    [SerializeField] private TextMeshProUGUI hpCurrent;
    [SerializeField] private TextMeshProUGUI eligibilityText;

    private static Color unselectedColor = new(184f / 255f, 180f / 255f, 1);
    private static Color selectedColor = new(90f / 255f, 84f / 255f, 1);
    private static Color movingColor = new(112f / 255f, 1, 174f / 255f);

    public bool ineligible;
    private static Color ineligibleSelected = new(160f / 255f, 160f / 255f, 160f / 255f);
    private static Color ineligibleUnselected = new(220f / 255f, 220f / 255f, 220f / 255f);

    public bool selected;
    public bool moving;
    public Pokemon mon;

    public void UpdateDisplay()
    {
        if (!mon.exists)
        {
            box.gameObject.SetActive(false);
            return;
        }
        box.gameObject.SetActive(true);
        monSprite.sprite = mon.SpeciesData.Icon1;
        monName.text = mon.MonName;
        monStatus.sprite = mon.status.ToSprite();
        healthBar.localScale = new((float)mon.HP / mon.hpMax, 1, 1);
        hpMax.text = mon.hpMax.ToString();
        hpCurrent.text = mon.HP.ToString();
    }

    public void GoToMoving()
    {
        selected = false;
        moving = true;
        box.color = movingColor;
    }

    public void ShowEligibilityText()
    {
        eligibilityText.gameObject.SetActive(true);
        eligibilityText.text = ineligible ? "ø" : "!";
        eligibilityText.color = ineligible ? new(1, 0, 0) : new(0.2f, 1, 0.05f);
    }

    public void Select()
    {
        selected = true;
        box.color = ineligible ? ineligibleSelected : selectedColor;
    }

    public void Deselect()
    {
        selected = false;
        moving = false;
        box.color = ineligible ? ineligibleUnselected : unselectedColor;
        monSprite.sprite = mon.SpeciesData.Icon1;
    }

    public IEnumerator Heal(int amount, DataStore<int> store)
    {
        int realAmount = Mathf.Min(amount, mon.hpMax - mon.HP);
        int initialAmount = mon.HP;
        float targetTime = Mathf.Min(0.3f, Mathf.Sqrt(realAmount) * 0.1f);
        float baseTime = Time.time;
        while (Time.time < baseTime + targetTime)
        {
            mon.HP = (int)(initialAmount + (realAmount * (Time.time - baseTime) / targetTime));
            healthBar.localScale = new((float)mon.HP / mon.hpMax, 1, 1);
            hpCurrent.text = mon.HP.ToString();
            yield return null;
        }
        mon.HP = initialAmount + realAmount;
        store.Data = realAmount;
    }

    public void Update()
    {
        if (selected)
            if (Time.time % 0.36 < 0.18) monSprite.sprite = mon.SpeciesData.Icon2;
            else monSprite.sprite = mon.SpeciesData.Icon1;
    }
}