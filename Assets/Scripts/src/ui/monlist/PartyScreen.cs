using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using static BagController;
using System.Collections.Generic;
using static Player;

public class PartyScreen : MonoBehaviour
{
    [SerializeField] private MonDisplay[] displays = new MonDisplay[6];
    [SerializeField] private RawImage exit;
    [SerializeField] private Announcer announcer;
    [SerializeField] private AudioSource audioSource;

    private int selectedMon;

    private int movingMon;

    private bool itemPrompt;

    private bool done;

    private static Color exitSelected = new(1, 110f / 255f, 110f / 255f);
    private static Color exitUnselected = new(1, 220f / 255f, 220f / 255f);

    private const int exitNumber = 255;

    private Pokemon CurrentMon => displays[selectedMon].mon;

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


    public void Init()
    {
        player.SortParty();
        for (int i = 0; i < 6; i++)
        {
            displays[i].mon = player.Party[i];
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
                if (evolution.Method is EvolutionMethod.EvolutionItem && evolution.Data == (int)player.bagResult)
                {
                    eligible = true;
                }
            }
            displays[i].ineligible = !eligible;
            displays[i].ShowEligibilityText();
        }
    }

    public IEnumerator DoPartyScreen(bool prompt, int firstSelection = 0, bool doAnnouncement = false, string announcement = null)
    {
        Init();
        itemPrompt = prompt;
        if (prompt && player.bagResult.FieldEffect() is FieldEffect.Evolution &&
            player.bagOutcome == BagOutcome.Use) CheckEvoEligibility();
        selectedMon = firstSelection;
        UpdateDisplays();
        if (doAnnouncement) yield return AnnounceAndReturn(announcement);
        while (!done) yield return null;
    }

    private IEnumerator NoEffect => AnnounceAndReturn("It wouldn't have any effect.").DoAtEnd(() => state = State.Active);
    private void UseResultItem()
    {
        if (player.UseItem(player.bagResult)) ReturnWithNothing();
        else state = State.Active;
    }

    private IEnumerator DoHeal()
    {
        state = State.Busy;
        DataStore<int> amount = new();
        yield return displays[selectedMon].Heal(player.bagResult.FieldEffectIntensity(), amount);
        yield return AnnounceAndReturn(CurrentMon.MonName + " was healed by " + amount.Data + " HP.");
        UseResultItem();
    }

    private IEnumerator DoAbilityCapsule()
    {
        state = State.Busy;
        if (CurrentMon.SpeciesData.abilities[0] == CurrentMon.SpeciesData.abilities[1] || CurrentMon.whichAbility is 2)
        {
            yield return NoEffect;
        }
        else
        {
            CurrentMon.whichAbility = 1 - CurrentMon.whichAbility;
            yield return AnnounceAndReturn(CurrentMon.MonName + "'s ability was changed to " + CurrentMon.GetAbility.Name() + ".");
            UseResultItem();
        }
    }

    private IEnumerator DoAbilityPatch()
    {
        state = State.Busy;
        if (CurrentMon.SpeciesData.abilities[0] == CurrentMon.SpeciesData.abilities[2])
            yield return NoEffect;
        else
        {
            var random = new System.Random();
            CurrentMon.whichAbility = CurrentMon.whichAbility is 2 ? random.Next(2) : 2;
            CurrentMon.whichAbility = 1 - CurrentMon.whichAbility;
            yield return AnnounceAndReturn(CurrentMon.MonName + "'s ability was changed to " + CurrentMon.GetAbility.Name() + ".");
            UseResultItem();
        }
    }

    private IEnumerator DoMint()
    {
        Nature nature = (Nature)player.bagResult.FieldEffectIntensity();
        state = State.Busy;
        if (CurrentMon.Nature == nature) yield return NoEffect;
        else
        {
            CurrentMon.mintedNature = nature;
            yield return AnnounceAndReturn($"{CurrentMon.MonName}'s nature was changed to {nature.Name()}.");
            UseResultItem();
        }
    }

    private IEnumerator DoHealStatus()
    {
        Status status = (Status)player.bagResult.FieldEffectIntensity();
        state = State.Busy;
        if (status is Status.Any || CurrentMon.status == status ||
            (status is Status.Poison && CurrentMon.status is Status.ToxicPoison))
        {
            CurrentMon.status = Status.None;
            displays[selectedMon].UpdateDisplay();
            yield return AnnounceAndReturn(CurrentMon.MonName + status.HealString());
            UseResultItem();
        }
        else yield return NoEffect;
    }

    private IEnumerator DoFullRestore()
    {
        bool didAnything = false;
        if (CurrentMon.hp < CurrentMon.hpMax)
        {
            int amount = CurrentMon.hpMax - CurrentMon.hp;
            DataStore<int> store = new();
            yield return displays[selectedMon].Heal(amount, store);
            yield return AnnounceAndReturn(CurrentMon.MonName + " was healed by " + store.Data + " HP.");
            didAnything = true;
        }
        if (CurrentMon.status != Status.None)
        {
            Status status = CurrentMon.status;
            CurrentMon.status = Status.None;
            displays[selectedMon].UpdateDisplay();
            yield return AnnounceAndReturn(CurrentMon.MonName + status.HealString());
            didAnything = true;
        }
        if (didAnything)
        {
            UseResultItem();
        }
        else yield return NoEffect;
    }

    private IEnumerator DoFeather()
    {
        Stat stat = (Stat)player.bagResult.FieldEffectIntensity();
        state = State.Busy;
        if (CurrentMon.ApplyFeather(stat))
        {
            yield return AnnounceAndReturn($"{CurrentMon.MonName}'s {stat.Name()} was increased slightly.");
            UseResultItem();
        }
        else yield return NoEffect;
    }

    private IEnumerator DoVitamin()
    {
        Stat stat = (Stat)player.bagResult.FieldEffectIntensity();
        state = State.Busy;
        if (CurrentMon.ApplyVitamin(stat))
        {
            yield return AnnounceAndReturn($"{CurrentMon.MonName}'s {stat.Name()} was increased.");
            UseResultItem();
        }
        else yield return NoEffect;
    }

    private IEnumerator DoPPUp(bool max)
    {
        state = State.Busy;
        DataStore<int> store = new();
        store.Data = 63;
        yield return MoveSelectScreen.DoMoveSelectScreen(CurrentMon, store);
        if (store.Data is 63)
        {
            state = State.Active;
        }
        else
        {
            if (CurrentMon.UsePPUp(store.Data, max))
            {
                yield return AnnounceAndReturn($"{CurrentMon.MonName}'s " +
                    $"{CurrentMon.MoveIDs[store.Data].Data().name} had its PP " +
                    $"increased" + (max ?
                    " to the maximum." : $" by {CurrentMon.MoveIDs[store.Data].Data().pp / 5}."));
                UseResultItem();
            }
            else yield return NoEffect;
        }
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
                case GiveItem when CurrentMon.item is ItemID.None:
                case TakeItem when CurrentMon.item is not ItemID.None:
                case MoveMon when player.MonsInParty > 1:
                    possibleChoices.Add(choice);
                    continue;
                default: continue;
            }
        }
        audioSource.PlayOneShot(SFX.Select);
        yield return ChoiceMenu.DoChoiceMenu(player, possibleChoices, 0,
            result, displays[selectedMon].transform, new(-40, goingDown ? 15 : -15),
            new(1, goingDown ? 1 : 0), exit.gameObject);
        switch (result.Data)
        {
            case CloseMenu:
            default:
                state = State.Active;
                break;
            case GetSummary:
                yield return SummaryScreen.Create(player, selectedMon);
                SummaryScreen screen = FindObjectOfType<SummaryScreen>();
                while (screen != null) yield return null;
                state = State.Active;
                break;
            case TakeItem:
                ItemID item = CurrentMon.item;
                CurrentMon.CheckTransformationEnd(CurrentMon.item);
                CurrentMon.item = ItemID.None;
                displays[selectedMon].UpdateDisplay();
                yield return AnnounceAndReturn("Took the " + item.Data().itemName + " from " + CurrentMon.MonName + ".");
                if (!item.IsZCrystal()) player.AddItem(item);
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
        player.partyScreenOutcome = PartyScreenOutcome.None;
        done = true;
    }

    private void CacheAndReturn(PartyScreenOutcome outcome)
    {
        player.partyScreenOutcome = outcome;
        player.cachedScreenData = new PartyBoxCachedData() { currentMon = selectedMon };
        done = true;
    }

    public void Update()
    {
        switch (state)
        {
            case State.Active or State.Moving:
                if (Input.GetKeyDown(KeyCode.DownArrow) && selectedMon != exitNumber)
                {
                    if (player.MonsInParty > selectedMon + 2)
                        Select(selectedMon + 2);
                    else if (player.MonsInParty == selectedMon + 2 && (selectedMon & 1) == 1)
                        Select(selectedMon + 1);
                    else
                        GoToExit();
                }
                else if (Input.GetKeyDown(KeyCode.UpArrow) && selectedMon > 1)
                {
                    if (selectedMon is exitNumber)
                        Select(player.MonsInParty - 1);
                    else
                        Select(selectedMon - 2);
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow) &&
                    0 < selectedMon)
                {
                    if (selectedMon is not exitNumber)
                    {
                        Select(selectedMon - 1);
                    }
                    else
                    {
                        Select(player.MonsInParty - 1);
                    }
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow) && selectedMon != exitNumber)
                {
                    if (selectedMon + 1 == player.MonsInParty)
                        GoToExit();
                    else
                        Select(selectedMon + 1);
                }
                else if (Input.GetKeyDown(KeyCode.Return))
                {
                    if (selectedMon is exitNumber)
                    {
                        ReturnWithNothing();
                        player.audioSource.PlayOneShot(SFX.Select);
                    }
                    else if (state is State.Active)
                    {
                        if (itemPrompt)
                        {
                            switch (player.bagOutcome)
                            {
                                case BagOutcome.Use:
                                    if (displays[selectedMon].ineligible) return;
                                    switch (player.bagResult.FieldEffect())
                                    {
                                        case FieldEffect.None:
                                            break;
                                        case FieldEffect.Heal:
                                            StartCoroutine(DoHeal());
                                            break;
                                        case FieldEffect.HealStatus:
                                            StartCoroutine(DoHealStatus());
                                            break;
                                        case FieldEffect.FullRestore:
                                            StartCoroutine(DoFullRestore());
                                            break;
                                        case FieldEffect.TM:
                                            break;
                                        case FieldEffect.Evolution:
                                            player.audioSource.PlayOneShot(SFX.Select);
                                            player.partyScreenOutcome = PartyScreenOutcome.Evo;
                                            player.partyScreenResult = selectedMon;
                                            done = true;
                                            break;
                                        case FieldEffect.AbilityCapsule:
                                            StartCoroutine(DoAbilityCapsule());
                                            break;
                                        case FieldEffect.AbilityPatch:
                                            StartCoroutine(DoAbilityPatch());
                                            break;
                                        case FieldEffect.Mint:
                                            StartCoroutine(DoMint());
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
                                        case FieldEffect.Feather:
                                            StartCoroutine(DoFeather());
                                            break;
                                        case FieldEffect.Vitamin:
                                            StartCoroutine(DoVitamin());
                                            break;
                                        case FieldEffect.PPUp:
                                            StartCoroutine(DoPPUp(false));
                                            break;
                                        case FieldEffect.PPMax:
                                            StartCoroutine(DoPPUp(true));
                                            break;
                                    }
                                    break;
                                case BagOutcome.Give:
                                    if (CurrentMon.item != ItemID.None)
                                    {
                                        StartCoroutine(AnnounceAndReturn(
                                            CurrentMon.MonName +
                                            " is already holding an item!"));
                                        return;
                                    }
                                    else
                                    {
                                        CurrentMon.item = player.bagResult;
                                        CurrentMon.CheckTransformation();
                                        displays[selectedMon].UpdateDisplay();
                                        if (!player.bagResult.IsZCrystal()) player.UseItem(player.bagResult);
                                        StartCoroutine(AnnounceAndReturn("The " +
                                            player.bagResult.Data().itemName +
                                            " was given to " +
                                            CurrentMon.MonName +
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
                            (player.Party[selectedMon], player.Party[movingMon]) = (player.Party[movingMon], player.Party[selectedMon]);
                            Init();
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