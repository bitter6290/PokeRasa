using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Collections;
using System.Collections.Generic;

public class BoxScreen : MonoBehaviour
{
    public enum BoxScreenOutcome
    {
        None,
        Give
    }
    [Serializable]
    public struct InfoDisplay
    {
        [SerializeField]
        private Image monSprite;
        [SerializeField]
        private GameObject parentObject;
        [SerializeField]
        private TextMeshProUGUI monName;
        [SerializeField]
        private TextMeshProUGUI speciesText;
        [SerializeField]
        private RawImage type1Image;
        [SerializeField]
        private TextMeshProUGUI type1Text;
        [SerializeField]
        private RawImage type2Image;
        [SerializeField]
        private TextMeshProUGUI type2Text;
        [SerializeField]
        private TextMeshProUGUI levelText;
        [SerializeField]
        private Transform xpBar;
        [SerializeField]
        private RawImage itemIcon;
        [SerializeField]
        private TextMeshProUGUI itemName;

        public void Adopt(Pokemon mon)
        {
            parentObject.SetActive(true);
            monSprite.sprite = mon.SpeciesData.FrontSprite1;
            monName.text = mon.MonName;
            speciesText.text = mon.SpeciesData.pokedexData.number + " / " + mon.SpeciesData.speciesName;
            type1Image.color = mon.SpeciesData.type1.Color();
            type1Text.text = mon.SpeciesData.type1.Name();
            type1Text.color = mon.SpeciesData.type1.TextColor();
            if (mon.SpeciesData.type1 == mon.SpeciesData.type2)
            {
                type2Image.enabled = false;
                type2Text.enabled = false;
            }
            else
            {
                type2Image.enabled = true;
                type2Text.enabled = true;
                type2Image.color = mon.SpeciesData.type2.Color();
                type2Text.text = mon.SpeciesData.type2.Name();
                type2Text.color = mon.SpeciesData.type2.TextColor();
            }
            if (mon.item is ItemID.None)
            {
                itemIcon.enabled = false;
                itemName.enabled = false;
            }
            else
            {
                itemIcon.enabled = true;
                itemName.enabled = true;
                itemIcon.texture = mon.item.Data().ItemSprite;
                itemName.text = mon.item.Data().itemName;
            }
            levelText.text = "Lv. " + mon.level;
            xpBar.localScale = new(mon.LevelProgress, 1, 1);
        }

        public void Disable() => parentObject.SetActive(false);
    }

    public struct MonAddress
    {
        public const int Party = 1 << 30;
        public int boxNumber;
        public int position;
    }

    private enum State
    {
        Active,
        Moving,
        Busy
    }

    /*
	 * Structure for GetSprite:
	 * 0-41: Box Sprites
	 * 42-47: Party Sprites
	 * leftButton: Left Arrow
	 * rightButton: Right Arrow
	 * cancelButton: Back Button
	 * +64: Previous Box
	 * +128: Next Box
	*/
    public Player p;
    [SerializeField]
    private TextMeshProUGUI boxName;
    [SerializeField]
    private Image[] boxSprites = new Image[42];
    [SerializeField]
    private Image[] partySprites = new Image[6];
    [SerializeField]
    private Transform leftArrow;
    [SerializeField]
    private Transform rightArrow;
    [SerializeField]
    private RawImage exitButton;
    [SerializeField]
    private Transform cursor;

    [SerializeField]
    private Announcer announcer;

    [SerializeField]
    private GameObject guiParent;

    [SerializeField]
    private Color exitUnselectedColor;
    [SerializeField]
    private Color exitSelectedColor;

    private Box CurrentBox => p.boxes[p.currentBox];

    private int selection;

    private const float arrowOffset = 0.1F;
    private Vector3 leftArrowPos;
    private Vector3 leftArrowPos2;
    private Vector3 rightArrowPos;
    private Vector3 rightArrowPos2;

    [SerializeField]
    private InfoDisplay infoDisplay;

    private const int leftArrowID = 48;
    private const int rightArrowID = 49;
    private const int exitID = 50;
    private const int noMove = 255;

    private MonAddress movingAddress;

    [SerializeField]
    private GameObject movingBar;
    [SerializeField]
    private Image movingBarSprite;
    [SerializeField]
    private TextMeshProUGUI movingBarName;

    private State state;

    private bool done;

    private Transform GetSprite(int index) => index switch
    {
        < 42 => boxSprites[index].transform,
        < 48 => partySprites[index - 42].transform,
        leftArrowID => leftArrow,
        rightArrowID => rightArrow,
        exitID => exitButton.transform,
        _ => null,
    };

    private Image GetMonSprite(int index) => index switch
    {
        < 42 => boxSprites[index],
        < 48 => partySprites[index - 42],
        _ => null
    };

    private Pokemon GetPokemon(int index) => index switch
    {
        < 42 => CurrentBox.pokemon[index],
        < 48 => p.Party[index - 42],
        _ => Pokemon.EmptyMon
    };

    private Pokemon GetPokemon(MonAddress address)
    {
        if (address.boxNumber is MonAddress.Party) return p.Party[address.position];
        else return p.boxes[address.boxNumber].pokemon[address.position];
    }

    private void SetPokemon(int index, Pokemon mon)
    {
        if (index < 42) CurrentBox.pokemon[index] = mon;
        else if (index < 48) p.Party[index - 42] = mon;
    }

    private void SetPokemon(MonAddress address, Pokemon mon)
    {
        if (address.boxNumber is MonAddress.Party) p.Party[address.position] = mon;
        else p.boxes[address.boxNumber].pokemon[address.position] = mon;
    }

    private bool IsMovingMonOnScreen => movingAddress.boxNumber is MonAddress.Party ||
        movingAddress.boxNumber == p.currentBox;

    private Image MovingMonSprite => movingAddress.boxNumber is MonAddress.Party ?
        partySprites[movingAddress.position] : boxSprites[movingAddress.position];

    private MonAddress GetSelectionAddress()
    {
        if (selection > 41) return new() { boxNumber = MonAddress.Party, position = selection - 42 };
        else return new() { boxNumber = p.currentBox, position = selection };
    }

    public void Activate() => state = State.Active;

    private int MoveUp(int index) => index switch
    {
        < 4 => leftArrowID,
        < 7 => rightArrowID,
        < 42 => index - 7,
        42 => exitID,
        < 48 => index - 1,
        _ => noMove
    };

    private int MoveDown(int index) => index switch
    {
        < 35 => index + 7,
        < 42 or 47 => index,
        < 47 => index + 1,
        leftArrowID => 0,
        rightArrowID => 6,
        exitID => 42,
        _ => noMove
    };

    private int MoveLeft(int index) => index switch
    {
        < 42 => index % 7 is 0 ? index + 64 : index - 1,
        < 48 => 6 + ((index - 42) * 7),
        leftArrowID => 112,
        rightArrowID => leftArrowID,
        exitID => rightArrowID,
        _ => noMove
    };

    private int MoveRight(int index) => index switch
    {
        < 42 => index % 7 is 6 ? (index / 7) + 42 : index + 1,
        < 48 => index + 128,
        leftArrowID => rightArrowID,
        rightArrowID => exitID,
        _ => noMove
    };

    private int Move(Direction dir) => dir switch
    {
        Direction.N => MoveUp(selection),
        Direction.S => MoveDown(selection),
        Direction.W => MoveLeft(selection),
        Direction.E => MoveRight(selection),
        _ => throw new Exception("Passed bad argument to BoxScreen.Move")
    };

    private void ChangeSelection(Direction dir)
    {
        int index = Move(dir);
        if (index == 255) return;
        p.audioSource.PlayOneShot(SFX.MoveCursor);
        if (index > 128)
        {
            p.currentBox++;
            if (p.currentBox >= p.boxes.Count) p.currentBox = 0;
            UpdateSprites();
            index -= 128;
        }
        else if (index > 64)
        {
            p.currentBox--;
            if (p.currentBox < 0) p.currentBox = p.boxes.Count - 1;
            UpdateSprites();
            index -= 64;
        }
        Deselect(selection);
        Select(index);
    }

    private void Select(int index)
    {
        cursor.position = GetSprite(index).position;
        if (index is exitID) exitButton.color = exitSelectedColor;
        selection = index;
        Pokemon mon = GetPokemon(index);
        if (mon.exists) infoDisplay.Adopt(mon);
        else infoDisplay.Disable();
    }

    private void Deselect(int index)
    {
        GetSprite(index).localScale = Vector3.one;
        switch (index)
        {
            case < 42 when GetPokemon(index).exists:
                boxSprites[index].sprite = GetPokemon(index).SpeciesData.Icon1;
                break;
            case leftArrowID:
                leftArrow.position = leftArrowPos;
                break;
            case rightArrowID:
                rightArrow.position = rightArrowPos;
                break;
            case exitID:
                exitButton.color = exitUnselectedColor;
                break;
            default:
                break;
        }
    }

    private void StartMove()
    {
        movingAddress = GetSelectionAddress();
        state = State.Moving;
    }

    private void FinishMove()
    {
        state = State.Active;
        MonAddress address = GetSelectionAddress();
        if (movingAddress.boxNumber == address.boxNumber &&
            movingAddress.position == address.position) return;
        Pokemon cachedMon = GetPokemon(movingAddress);
        SetPokemon(movingAddress, GetPokemon(address));
        SetPokemon(address, cachedMon);
        InitSprites();
    }

    private void UpdateSprites()
    {
        boxName.text = CurrentBox.boxName;
        for (int i = 0; i < 42; i++)
        {
            if (CurrentBox.pokemon[i].exists)
            {
                boxSprites[i].sprite = CurrentBox.pokemon[i].SpeciesData.Icon1;
                boxSprites[i].enabled = true;
            }
            else boxSprites[i].enabled = false;
        }
        if (state is State.Moving && !IsMovingMonOnScreen) ActivateMovingBar();
        else movingBar.SetActive(false);
    }

    private void ActivateMovingBar()
    {
        movingBar.SetActive(true);
        movingBarName.text = GetPokemon(movingAddress).MonName;
    }

    private void InitSprites()
    {
        p.SortParty();
        for (int i = 0; i < 6; i++)
        {
            if (p.Party[i].exists)
            {
                partySprites[i].sprite = p.Party[i].SpeciesData.Icon1;
                partySprites[i].enabled = true;
            }
            else partySprites[i].enabled = false;
        }
        UpdateSprites();
    }

    public IEnumerator DoBoxScreen()
    {
        p.boxGiving = false;
        state = State.Active;
        Select(0);
        while (!done) yield return null;
    }

    public IEnumerator GiveAndDoBoxScreen()
    {
        p.boxGiving = false;
        Select(((Player.PartyBoxCachedData)p.cachedScreenData).currentMon);
        state = State.Busy;
        yield return announcer.AnnounceAndDisappear("Gave " + GetPokemon(selection).MonName +
            " the " + GetPokemon(selection).item.Data().itemName + " to hold.");
        state = State.Active;
        while (!done) yield return null;
    }

    private const int MenuCancel = 0;
    private const int MenuMove = 1;
    private const int MenuRelease = 2;
    private const int MenuGive = 3;
    private const int MenuTake = 4;
    private const int MenuSummary = 5;

    private List<(string, int)> GetMenuOptions(Pokemon mon)
    {
        List<(string, int)> result = new()
        {
            ("Cancel", MenuCancel),
            ("Move", MenuMove),
            mon.item is ItemID.None ? ("Give", MenuGive) : ("Take", MenuTake),
            ("Release", MenuRelease),
            ("Summary", MenuSummary)
        };
        return result;
    }

    private Vector2 GetMenuPivot(int position)
    {
        int y = position is < 21 or 42 or 43 or 44 ? 1 : 0;
        int x = position is < 42 && position % 7 < 3 ? 0 : 1;
        return new(x, y);
    }

    private Vector2 GetMenuPosition(int position)
    {
        if (position is < 42 && position % 7 < 3) return new(0.5f, 0.5f);
        else return new(-0.5f, 0.5f);
    }

    private IEnumerator HandleReturn()
    {
        switch (selection)
        {
            case exitID when state is State.Active:
                state = State.Busy;
                done = true;
                p.audioSource.PlayOneShot(SFX.Select);
                yield break;
            case exitID when state is State.Moving:
                state = State.Active;
                UpdateSprites();
                p.audioSource.PlayOneShot(SFX.Select);
                yield break;
            case < 48 when GetPokemon(selection).exists && state is State.Active:
                p.audioSource.PlayOneShot(SFX.Select);
                state = State.Busy;
                DataStore<int> dataStore = new();
                yield return ChoiceMenu.DoChoiceMenu(p, GetMenuOptions(GetPokemon(selection)),
                    MenuCancel, dataStore, GetSprite(selection), GetMenuPosition(selection),
                    GetMenuPivot(selection), guiParent);
                switch (dataStore.Data)
                {
                    case MenuCancel:
                        state = State.Active;
                        yield break;
                    case MenuSummary:
                        yield return SummaryScreen.Create(p, GetPokemon(selection), this);
                        yield break;
                    case MenuMove:
                        StartMove();
                        yield break;
                    case MenuRelease:
                        if (selection is 42 && p.monsInParty is 1)
                        {
                            yield return announcer.AnnounceAndDisappear("You can't release your last Pokémon!");
                            state = State.Active;
                        }
                        else
                        {
                            announcer.gameObject.SetActive(true);
                            yield return announcer.Announce("Really release " + GetPokemon(selection).MonName + "?", false);
                            yield return ChoiceMenu.DoChoiceMenu(p, ScriptUtils.binaryChoice, 0, dataStore,
                                GetSprite(selection), new(-0.5f, 0.5f), GetMenuPivot(selection), guiParent);
                            switch (dataStore.Data)
                            {
                                case 0:
                                    announcer.gameObject.SetActive(false);
                                    state = State.Active;
                                    break;
                                case 1:
                                    StartCoroutine(AnimUtils.Grow(GetSprite(selection), 0, 1.0F));
                                    float targetTime = Time.time + 1.0F;
                                    yield return announcer.AnnounceAndDisappear("Goodbye, " +
                                        GetPokemon(selection).MonName + "!");
                                    while (Time.time < targetTime) yield return null;
                                    SetPokemon(selection, Pokemon.EmptyMon);
                                    GetSprite(selection).localScale = Vector3.one;
                                    InitSprites();
                                    infoDisplay.Disable();
                                    state = State.Active;
                                    break;
                            }
                        }
                        break;
                    case MenuTake:
                        ItemID item = GetPokemon(selection).item;
                        p.audioSource.PlayOneShot(SFX.Select);
                        p.GetItem(item, 1);
                        GetPokemon(selection).item = ItemID.None;
                        GetPokemon(selection).CheckTransformationEnd(item);
                        infoDisplay.Adopt(GetPokemon(selection));
                        yield return announcer.AnnounceAndDisappear("Received " +
                            item.Data().itemName + " from " + GetPokemon(selection).MonName + ".");
                        state = State.Active;
                        break;
                    case MenuGive:
                        p.cachedScreenData = new Player.PartyBoxCachedData() { currentMon = selection };
                        p.boxGiveTarget = GetPokemon(selection);
                        p.boxGiving = true;
                        done = true;
                        yield break;
                }
                yield break;
            case < 48 when state is State.Moving:
                p.audioSource.PlayOneShot(SFX.Select);
                if (movingAddress.boxNumber is not MonAddress.Party ||
                    p.monsInParty > 1 || GetPokemon(selection).exists)
                    FinishMove();
                else
                {
                    yield return announcer.AnnounceAndDisappear(
                        "You can't put away the last Pokémon in your party!");
                    state = State.Active;
                }
                yield break;
            case leftArrowID:
                p.audioSource.PlayOneShot(SFX.MoveCursor);
                p.currentBox--;
                if (p.currentBox < 0) p.currentBox = p.boxes.Count - 1;
                UpdateSprites();
                yield break;
            case rightArrowID:
                p.audioSource.PlayOneShot(SFX.MoveCursor);
                p.currentBox++;
                if (p.currentBox >= p.boxes.Count) p.currentBox = 0;
                UpdateSprites();
                yield break;
        }
    }

    // Use this for initialization
    public void Start()
    {
        InitSprites();
        leftArrowPos = leftArrow.position;
        rightArrowPos = rightArrow.position;
    }

    // Update is called once per frame
    public void Update()
    {
        float yCoord;
        switch (selection)
        {
            case < 48 when GetPokemon(selection).exists:
                GetMonSprite(selection).sprite = Time.time % 0.36 > 0.18
                    ? GetPokemon(selection).SpeciesData.Icon2
                    : GetPokemon(selection).SpeciesData.Icon1;
                break;
            case leftArrowID:
                yCoord = leftArrowPos.y - (Time.time % 0.36 > 0.18 ? 0.1F : 0);
                leftArrow.position = new(leftArrowPos.x, yCoord, leftArrowPos.z);
                break;
            case rightArrowID:
                yCoord = rightArrowPos.y - (Time.time % 0.36 > 0.18 ? 0.1F : 0);
                rightArrow.position = new(rightArrowPos.x, yCoord, leftArrowPos.z);
                break;
        }
        if (state is State.Moving)
        {
            if (IsMovingMonOnScreen) MovingMonSprite.sprite = Time.time % 0.36 > 0.18
                    ? GetPokemon(movingAddress).SpeciesData.Icon2
                    : GetPokemon(movingAddress).SpeciesData.Icon1;
            else movingBarSprite.sprite = Time.time % 0.36 > 0.18
                    ? GetPokemon(movingAddress).SpeciesData.Icon2
                    : GetPokemon(movingAddress).SpeciesData.Icon1;
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                state = State.Active;
                movingBar.SetActive(false);
                if (IsMovingMonOnScreen) MovingMonSprite.sprite = GetPokemon(movingAddress).SpeciesData.Icon1;
                return;
            }
        }
        if (state is State.Active or State.Moving)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow)) ChangeSelection(Direction.W);
            else if (Input.GetKeyDown(KeyCode.RightArrow)) ChangeSelection(Direction.E);
            else if (Input.GetKeyDown(KeyCode.UpArrow)) ChangeSelection(Direction.N);
            else if (Input.GetKeyDown(KeyCode.DownArrow)) ChangeSelection(Direction.S);
            else if (Input.GetKeyDown(KeyCode.Return)) StartCoroutine(HandleReturn());
        }
    }
}

