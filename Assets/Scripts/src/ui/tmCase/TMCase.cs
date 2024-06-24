using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TMCase : MonoBehaviour
{
    const int listEntries = 8;
    [SerializeField] private TMMonDisplay[] monDisplays = new TMMonDisplay[6];
    [SerializeField] private TMListDisplay[] listDisplays = new TMListDisplay[listEntries];
    [SerializeField] private Announcer announcer;
    [SerializeField] private RawImage itemIcon;
    [SerializeField] private TextMeshProUGUI moveName;
    [SerializeField] private RawImage typeBox;
    [SerializeField] private TextMeshProUGUI typeText;
    [SerializeField] private Image moveType;
    [SerializeField] private TextMeshProUGUI power;
    [SerializeField] private TextMeshProUGUI accuracy;
    [SerializeField] private TextMeshProUGUI number;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private GameObject dataParent;

    [SerializeField] private Sprite physical;
    [SerializeField] private Sprite special;
    [SerializeField] private Sprite status;

    private int monsInParty;
    private List<TMID> tms;

    public bool done;

    private enum State
    {
        List,
        MonScreen,
        Announce,
        Busy,
    }

    public enum Eligibility
    {
        Able,
        Unable,
        Knows
    }

    private State state;
    private int selectedMon;
    private int currentOffset;
    private int currentPosition;
    private int currentSelection => currentOffset + currentPosition;
    private TMID currentTM => tms[currentSelection];
    private Eligibility[] eligibility = new Eligibility[6];

    private void ListToMonScreen()
    {
        state = State.MonScreen;
        selectedMon = 0;
        monDisplays[0].SetSelected(true);
    }

    private void MonScreenToList()
    {
        state = State.List;
        monDisplays[selectedMon].SetSelected(false);
    }

    private void UpdateDisplays()
    {
        bool empty = false;
        for (int i = 0; i < listEntries; i++)
        {
            if (empty) 
            {
                listDisplays[i].Nullify();
                continue;
            }
            if (tms[currentOffset + i] is TMID.Close)
            {
                empty = true;
            }
            listDisplays[i].UpdateDisplay(tms[currentOffset + i]);
        }
    }

    private IEnumerator Announce(string announcement, bool persist)
    {
        announcer.gameObject.SetActive(true);
        State state = this.state;
        this.state = State.Announce;
        yield return announcer.Announce(announcement, persist);
        if (!persist) announcer.gameObject.SetActive(false);
        this.state = state;
    }

    private void SelectMon(int selection)
    {
        monDisplays[selectedMon].SetSelected(false);
        selectedMon = selection;
        monDisplays[selectedMon].SetSelected(true);
    }

    private void SelectTM(TMID tm)
    {
        if (tm is TMID.Count)
        {
            for (int i = 0; i < monsInParty; i++)
            {
                monDisplays[i].Grey();
            }
            dataParent.SetActive(false);
            return;
        }
        else
        {
            UpdateEligibility();
            dataParent.SetActive(true);
            MoveData move = tm.Move().Data();
            itemIcon.texture = move.type.TMTexture();
            moveName.text = move.name;
            typeBox.color = move.type.Color();
            typeText.text = move.type.Name();
            typeText.color = move.type.TextColor();
            moveType.sprite = move.power == 0 ? status :
                                move.physical ? physical : special;
            power.text = move.power is 0 or 1 ? "--" : move.power.ToString();
            accuracy.text = move.accuracy is 101 ? "--" : move.accuracy.ToString();
            number.text = tm >= TMID.HMStart ? "HM " + (tm - TMID.HMStart + 1).ToString().LeadingZero1() : "No. " + ((int)tm).ToString().LeadingZero1();
            description.text = move.moveDesc;
        }
    }

    private void UpdateEligibility()
    {
        for (int i = 0; i < monsInParty; i++)
            {
                eligibility[i] =
                    Player.player.Party[i].SpeciesData.tmLearnset.learnableTMs[(int)currentTM] ?
                        Player.player.Party[i].HasMove(currentTM.Move()) ?
                            Eligibility.Knows :
                            Eligibility.Able
                        : Eligibility.Unable;
                monDisplays[i].SetAble(eligibility[i]);
            }
    }

    private IEnumerator QueryMon()
    {
        state = State.Busy;
        switch(monDisplays[selectedMon].Eligibility)
        {
            case Eligibility.Able:
                yield return Player.player.Party[selectedMon].TryAddMove(currentTM.Move(), Announce, Player.player, announcer.transform,
                        1.5F, new(-140,47));
                UpdateEligibility();
                announcer.gameObject.SetActive(false);
                break;
            case Eligibility.Unable:
                yield return Announce($"{Player.player.Party[selectedMon].MonName} can't learn {currentTM.Move().Data().name}!", false);
                break;
            case Eligibility.Knows:
                yield return Announce($"{Player.player.Party[selectedMon].MonName} already knows {currentTM.Move().Data().name}!", false);
                break;
        }
        state = State.MonScreen;
    }
    

    public IEnumerator DoTMCase()
    {
        state = State.List;
        while (!done) yield return null;
    }


    public void Start()
    {
        monsInParty = Player.player.MonsInParty;
        for (int i = 0; i < 6; i++)
        {
            if (i < monsInParty)
            {
                monDisplays[i].Adopt(Player.player.Party[i]);
            }
            else monDisplays[i].Disable();
        }
        tms = new();
        for (int i = 0; i < (int)TMID.Count; i++)
        {
            if (Player.player.TM[i]) tms.Add((TMID)i);
        }
        tms.Add(TMID.Count);
        state = State.Busy;
        currentOffset = 0;
        currentPosition = 0;
        UpdateDisplays();
        listDisplays[0].ToggleSelect();
        SelectTM(tms[0]);
    }

    public void Update()
    {
        switch (state)
        {
            case State.List:
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (currentTM != TMID.Close)
                    {
                        Player.player.audioSource.PlayOneShot(SFX.MoveCursor);
                        if (currentPosition is listEntries - 1)
                        {
                            currentOffset++;
                            UpdateDisplays();
                            SelectTM(currentTM);
                        }
                        else
                        {
                            listDisplays[currentPosition].ToggleSelect();
                            currentPosition++;
                            listDisplays[currentPosition].ToggleSelect();
                            SelectTM(currentTM);
                        }
                    }
                }
                else if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (currentPosition > 0)
                    {
                        Player.player.audioSource.PlayOneShot(SFX.MoveCursor);
                        listDisplays[currentPosition].ToggleSelect();
                        currentPosition--;
                        listDisplays[currentPosition].ToggleSelect();
                        SelectTM(currentTM);
                    }
                    else if (currentOffset > 0)
                    {
                        currentOffset--;
                        UpdateDisplays();
                        SelectTM(currentTM);
                    }
                }
                else if (Input.GetKeyDown(KeyCode.Return))
                {
                    Player.player.audioSource.PlayOneShot(SFX.Select);
                    if (currentTM is TMID.Close)
                    {
                        done = true;
                        return;
                    }
                    ListToMonScreen();
                }
                else if (Input.GetKeyDown(KeyCode.Delete) || Input.GetKeyDown(KeyCode.Backspace)) done = true;
                break;
            case State.MonScreen:
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (selectedMon > 1)
                    {
                        Player.player.audioSource.PlayOneShot(SFX.MoveCursor);
                        SelectMon(selectedMon - 2);
                    }
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (selectedMon < Player.player.MonsInParty - 2)
                    {
                        Player.player.audioSource.PlayOneShot(SFX.MoveCursor);
                        SelectMon(selectedMon + 2);
                    }
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    if (selectedMon > 0)
                    {
                        Player.player.audioSource.PlayOneShot(SFX.MoveCursor);
                        SelectMon(selectedMon - 1);
                    }
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    if (selectedMon < Player.player.MonsInParty - 1)
                    {
                        Player.player.audioSource.PlayOneShot(SFX.MoveCursor);
                        SelectMon(selectedMon + 1);
                    }
                    else
                    {
                        Player.player.audioSource.PlayOneShot(SFX.MoveCursor);
                        MonScreenToList();
                    }
                }
                else if (Input.GetKeyDown(KeyCode.Return))
                {
                    Player.player.audioSource.PlayOneShot(SFX.Select);
                    StartCoroutine(QueryMon());
                }
                else if (Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.Delete))
                {
                    Player.player.audioSource.PlayOneShot(SFX.Select);
                    MonScreenToList();
                }
                break;
        }
    }

}
