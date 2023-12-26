using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using static BagController;
using System.Collections.Generic;
using static Player;

public class PartyScreen : MonoBehaviour
{
    [SerializeField] private MonDisplay[] displays = new MonDisplay[6];
    [SerializeField] private RawImage exit;
    [SerializeField] private GameObject announcerPanel;
    [SerializeField] private TMPro.TextMeshProUGUI announcer;
    [SerializeField] private AudioSource audioSource;

    public Player p;

    private int selectedMon;

    private bool itemPrompt;

    private bool done;

    private static Color exitSelected = new(1, 110f/255f, 110f/255f);
    private static Color exitUnselected = new(1, 220f/255f, 220f/255f);

    private const int exitNumber = 255;

    private Pokemon currentMon => displays[selectedMon].mon;

    public enum PartyScreenOutcome
    {
        None,
        GiveItem,
        Evo
    }

    private enum State
    {
        Active,
        Busy,
        Announce
    }
    private State state;

    private const int CloseMenu = 1;
    private const int GetSummary = 2;
    private const int GiveItem = 4;
    private const int TakeItem = 8;

    private static (string, int)[] menuChoices = new (string, int)[]
    {
        ("Close", CloseMenu),
        ("Summary", GetSummary),
        ("Give", GiveItem),
        ("Take", TakeItem)
    };


    public void Init(Player player)
    {
        p = player;
        p.SortParty();
        for (int i = 0; i < 6; i++)
        {
            displays[i].mon = p.Party[i];
            Debug.Log(displays[i].mon.MonName);
        }
    }

    private void UpdateDisplays()
    {
        for (int i = 0; i < 6; i++)
        {
            displays[i].UpdateDisplay();
            //if (moving & i == movingMon) continue; //Todo: moving mons around the party
            if (i == selectedMon) displays[i].Select();
            else displays[i].Deselect();
        }
        exit.color = selectedMon is exitNumber ? exitSelected : exitUnselected;
    }

    private void Select(int i)
    {
        if (selectedMon is exitNumber)
            exit.color = exitUnselected;
        else
            displays[selectedMon].Deselect();
        selectedMon = i;
        displays[selectedMon].Select();
        audioSource.PlayOneShot(SFX.MoveCursor);
    }

    private void GoToExit()
    {
        displays[selectedMon].Deselect();
        selectedMon = exitNumber;
        exit.color = exitSelected;
        audioSource.PlayOneShot(SFX.MoveCursor);
    }

    private void CheckEvoEligibility()
    {
        for (int i = 0; i < 6; i++)
        {
            bool eligible = false;
            foreach (EvolutionData evolution in displays[i].mon.SpeciesData.evolution)
            {
                if (evolution.Method is EvolutionMethod.EvolutionItem && evolution.Data == (int)p.bagResult)
                {
                    eligible = true;
                }
            }
            displays[i].ineligible = !eligible;
            displays[i].ShowEligibilityText();
        }
    }

    public IEnumerator DoPartyScreen(Player player, bool prompt, int firstSelection = 0, bool doAnnouncement = false, string announcement = null)
    {
        Init(player);
        itemPrompt = prompt;
        if (prompt && player.bagResult.FieldEffect() is FieldEffect.Evolution &&
            player.bagOutcome == BagOutcome.Use) CheckEvoEligibility();
        selectedMon = firstSelection;
        UpdateDisplays();
        if (doAnnouncement) yield return AnnounceAndReturn(announcement);
        while (!done) yield return null;
    }

    private IEnumerator Announce(string announcement)
    {
        float targetTime;
        for (int i = 1; i <= announcement.Length; i++)
        {
            announcer.text = announcement[..i];
            targetTime = Time.time + 0.04F;
            while (Time.time < targetTime)
            {
                if (Input.GetKey(KeyCode.Return))
                    i = Mathf.Min(i + 1, announcement.Length - 1);
                yield return null;
            }
        }
        targetTime = Time.time + 3.0F;
        while (Time.time < targetTime)
        {
            if (Input.GetKeyDown(KeyCode.Return))
                break;
            yield return null;
        }
        announcer.text = "";
    }

    private IEnumerator DoHeal()
    {
        state = State.Busy;
        DataStore<int> amount = new();
        yield return displays[selectedMon].Heal(p.bagResult.FieldEffectIntensity(), amount);
        yield return AnnounceAndReturn(currentMon.MonName + " was healed by " + amount.Data + " HP.");
        if (p.UseItem(p.bagResult)) ReturnWithNothing();
        else state = State.Active;
    }

    private IEnumerator AnnounceAndReturn(string announcement)
    {
        State previousState = state;
        state = State.Announce;
        announcerPanel.SetActive(true);
        yield return Announce(announcement);
        state = previousState;
        announcerPanel.SetActive(false);
    }

    private IEnumerator DoChoiceMenu()
    {
        state = State.Busy;
        DataStore<int> result = new();
        bool goingDown = selectedMon < 4;
        List<(string, int)> possibleChoices = new();
        foreach ((string name, int data) choice in menuChoices)
        {
            switch (choice.data)
            {
                case CloseMenu:
                case GetSummary:
                case GiveItem when currentMon.item is ItemID.None:
                case TakeItem when currentMon.item is not ItemID.None:
                    possibleChoices.Add(choice);
                    continue;
                default: continue;
            }
        }
        yield return ChoiceMenu.DoChoiceMenu(p, possibleChoices, 0,
            result, displays[selectedMon].transform, new(-40, goingDown ? 15 : -15), new(1, goingDown ? 1 : 0));
        switch (result.Data)
        {
            case CloseMenu:
            default:
                audioSource.PlayOneShot(SFX.Select);
                state = State.Active;
                break;
            case GetSummary:
                yield return SummaryScreen.Create(p, selectedMon);
                SummaryScreen screen = FindObjectOfType<SummaryScreen>();
                while (screen != null) yield return null;
                state = State.Active;
                break;
            case TakeItem:
                yield return AnnounceAndReturn("Took the " + currentMon.item.Data().itemName + " from " + currentMon.MonName + ".");
                if (!currentMon.item.IsZCrystal()) p.AddItem(currentMon.item);
                currentMon.item = ItemID.None;
                state = State.Active;
                break;
            case GiveItem:
                CacheAndReturn(PartyScreenOutcome.GiveItem);
                break;
        }
    }

    private void ReturnWithNothing()
    {
        p.partyScreenOutcome = PartyScreenOutcome.None;
        done = true;
    }

    private void CacheAndReturn(PartyScreenOutcome outcome)
    {
        p.partyScreenOutcome = outcome;
        p.cachedScreenData = new PartyScreenCachedData() { currentMon = selectedMon };
        done = true;
    }

    public void Update()
    {
        switch (state)
        {
            case State.Active:
                if (Input.GetKeyDown(KeyCode.DownArrow) && selectedMon != exitNumber)
                {
                    if (p.monsInParty > selectedMon + 2)
                        Select(selectedMon + 2);
                    else if (p.monsInParty == selectedMon + 2 && (selectedMon & 1) == 1)
                        Select(selectedMon + 1);
                    else
                        GoToExit();
                }
                else if (Input.GetKeyDown(KeyCode.UpArrow) && selectedMon > 1)
                {
                    if (selectedMon is exitNumber)
                        Select(p.monsInParty - 1);
                    else
                        Select(selectedMon - 2);
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow) &&
                    0 < selectedMon && selectedMon is not exitNumber)
                {
                    Select(selectedMon - 1);
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow) && selectedMon != exitNumber)
                {
                    if (selectedMon + 1 == p.monsInParty)
                        GoToExit();
                    else
                        Select(selectedMon + 1);
                }
                else if (Input.GetKeyDown(KeyCode.Return))
                {
                    if (selectedMon is exitNumber)
                    {
                        ReturnWithNothing();
                        p.audioSource.PlayOneShot(SFX.Select);
                    }
                    else if (itemPrompt)
                    {
                        switch (p.bagOutcome) {
                            case BagOutcome.Use:
                                if (displays[selectedMon].ineligible) return;
                                switch (p.bagResult.FieldEffect())
                                {
                                    case FieldEffect.None:
                                        break;
                                    case FieldEffect.Heal:
                                        StartCoroutine(DoHeal());
                                        break;
                                    case FieldEffect.TM:
                                        break;
                                    case FieldEffect.Evolution:
                                        p.audioSource.PlayOneShot(SFX.Select);
                                        p.partyScreenOutcome = PartyScreenOutcome.Evo;
                                        p.partyScreenResult = selectedMon;
                                        done = true;
                                        break;
                                    case FieldEffect.HPEVDown10:
                                        break;
                                    case FieldEffect.AttackEVDown10:
                                        break;
                                    case FieldEffect.DefenseEVDown10:
                                        break;
                                    case FieldEffect.SpAtkEVDown10:
                                        break;
                                    case FieldEffect.SpDefEVDown10:
                                        break;
                                    case FieldEffect.SpeedEVDown10:
                                        break;
                                }
                                break;
                            case BagOutcome.Give:
                                if (currentMon.item != ItemID.None)
                                {
                                    StartCoroutine(AnnounceAndReturn(
                                        currentMon.MonName +
                                        " is already holding an item!"));
                                    return;
                                }
                                else
                                {
                                    currentMon.item = p.bagResult;
                                    if (!p.bagResult.IsZCrystal()) p.UseItem(p.bagResult);
                                    StartCoroutine(AnnounceAndReturn("The " +
                                        p.bagResult.Data().itemName +
                                        " was given to " +
                                        currentMon.MonName +
                                        " to hold.").DoAtEnd(ReturnWithNothing));
                                }
                                break;
                    }
                    }
                    else
                    {
                        StartCoroutine(DoChoiceMenu());
                    }
                }
                break;
        }
    }

}