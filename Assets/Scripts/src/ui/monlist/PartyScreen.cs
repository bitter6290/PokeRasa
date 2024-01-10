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
    [SerializeField] private Announcer announcer;
    [SerializeField] private AudioSource audioSource;

    public Player p;

    private int selectedMon;

    private int movingMon;

    private bool itemPrompt;

    private bool done;

    private static Color exitSelected = new(1, 110f / 255f, 110f / 255f);
    private static Color exitUnselected = new(1, 220f / 255f, 220f / 255f);

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
        Moving,
        Announce
    }
    private State state;

    private const int CloseMenu = 1;
    private const int GetSummary = 2;
    private const int GiveItem = 4;
    private const int TakeItem = 8;
    private const int MoveMon = 16;

    private static (string, int)[] menuChoices = new (string, int)[]
    {
        ("Close", CloseMenu),
        ("Summary", GetSummary),
        ("Give", GiveItem),
        ("Take", TakeItem),
        ("Move", MoveMon)
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
            if (state is State.Moving & i == movingMon) displays[i].GoToMoving();
            if (i == selectedMon) displays[i].Select();
            else displays[i].Deselect();
        }
        exit.color = selectedMon is exitNumber ? exitSelected : exitUnselected;
    }

    private void Select(int i, bool playSound = true)
    {
        if (selectedMon is exitNumber)
            exit.color = exitUnselected;
        else
        {
            if (selectedMon != movingMon || state is not State.Moving)
                displays[selectedMon].Deselect();
            else
                displays[selectedMon].GoToMoving();
        }
        selectedMon = i;
        displays[selectedMon].Select();
        if (playSound) audioSource.PlayOneShot(SFX.MoveCursor);
    }

    private void GoToExit()
    {
        if (state is not State.Moving || selectedMon != movingMon)
            displays[selectedMon].Deselect();
        else
            displays[selectedMon].GoToMoving();
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
        yield return announcer.AnnounceAndDisappear(announcement);
        state = previousState;
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
                case MoveMon when p.monsInParty > 1:
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
            case MoveMon:
                state = State.Moving;
                movingMon = selectedMon;
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
        p.cachedScreenData = new PartyBoxCachedData() { currentMon = selectedMon };
        done = true;
    }

    public void Update()
    {
        switch (state)
        {
            case State.Active or State.Moving:
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
                    else if (state is State.Active)
                    {
                        if (itemPrompt)
                        {
                            switch (p.bagOutcome)
                            {
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
                    else //state is State.Moving
                    {
                        state = State.Active;
                        if (selectedMon != movingMon)
                        {
                            (p.Party[selectedMon], p.Party[movingMon]) = (p.Party[movingMon], p.Party[selectedMon]);
                            Init(p);
                            UpdateDisplays();
                        }
                        audioSource.PlayOneShot(SFX.Select);
                        Select(selectedMon, false);
                        break;
                    }
                }
                break;
        }
    }

}