using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static TMCase.Eligibility;

public class TMMonDisplay : MonoBehaviour
{
    private static Color green = new(146F/255F, 243F/255F, 165F/255F);
    private static Color greenSelected = new(0, 173F/255F, 31F/255F);
    private static Color red = new(243F/255F, 146F/255F, 146F/255F);
    private static Color redSelected = new(207F/255F, 2F/255F, 0);
    private static Color yellow = new(1,249/255F,57F/255F);
    private static Color yellowSelected = new(195F/255F, 189F/255F, 3F/255F);
    private static Color grey = new(180F/255F, 180F/255F, 180F/255F);
    [SerializeField] private GameObject dataParent;
    [SerializeField] private TextMeshProUGUI monName;
    [SerializeField] private TextMeshProUGUI ableSymbol;
    [SerializeField] private Image monIcon;
    [SerializeField] private RawImage box;

    private SpeciesID currentSpecies;
    private TMCase.Eligibility eligibility;
    public TMCase.Eligibility Eligibility => eligibility;
    private bool selected;
    private Pokemon mon;
    public Pokemon Mon => mon;


    public void Adopt(Pokemon mon)
    {
        currentSpecies = mon.species;
        monIcon.sprite = currentSpecies.Data().graphics.icon1;
        monName.text = mon.MonName;
        this.mon = mon;
    }

    public void Disable() => box.gameObject.SetActive(false);
    public void SetAble(TMCase.Eligibility eligibility)
    {
        ableSymbol.text = eligibility switch
        {
            Unable or Knows => "Ø",
            Able => "!",
            _ => "?"
        };
        box.color = eligibility switch
        {
            Unable => red,
            Able => green,
            Knows => yellow,
            _ => grey
        };
        this.eligibility = eligibility;
    }
    public void SetSelected(bool selected)
    {
        this.selected = selected;
        box.color = (eligibility, selected) switch
        {
            (Unable, false) => red,
            (Unable, true) => redSelected,
            (Able, false) => green,
            (Able, true) => greenSelected,
            (Knows, false) => yellow,
            (Knows, true) => yellowSelected,
            _ => grey
        };
        if (!selected) monIcon.sprite = currentSpecies.Data().graphics.icon1;
    }
    public void Grey()
    {
        box.color = grey;
        eligibility = Unable;
        ableSymbol.text = string.Empty;
    }

    public void Update()
    {
        if (selected) monIcon.sprite = Time.time % 0.3F > 0.15F
            ? currentSpecies.Data().graphics.icon1
            : currentSpecies.Data().graphics.icon2;
    }
}