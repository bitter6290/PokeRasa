using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class BagController : MonoBehaviour
{

    public enum Pocket
    {
        Item,
        Medicine,
        PokeBall,
        TM,
        Berry,
        Mail,
        BattleItem,
        KeyItem
    }

    private string[] PocketNames = new[]
    {
        "Items",
        "Medicine",
        "Poké Balls",
        "TMs",
        "Berries",
        "Mail",
        "Battle Items",
        "Key Items"
    };

    public enum BagOutcome
    {
        None,
        Use,
        Give
    }

    private const int CloseMenu = 128;
    private const int GiveItem = 256;
    private const int UseItem = 512;
    private const int TrashItem = 1024;

    private struct MenuChoice
    {
        public int choiceID;
        public string name;
        public MenuChoice(int ChoiceID, string Name) { choiceID = ChoiceID; name = Name; }
    }

    private static MenuChoice[] menuChoices = new MenuChoice[]
    {
        new(CloseMenu, "Close"),
        new(GiveItem, "Give"),
        new(UseItem, "Use"),
        new(TrashItem, "Trash")
    };

    public RawImage itemSprite;
    public TextMeshProUGUI itemDesc;

    private Pocket currentPocket;
    public TextMeshProUGUI pocketName;

    public ItemDisplay[] itemDisplays = new ItemDisplay[8];
    public Player p;

    [SerializeField]
    private ItemID[] items;
    [SerializeField]
    private int cachedItemCount;
    [SerializeField]
    private int currentPosition;
    [SerializeField]
    private int currentSelection;

    private bool active;

    private bool prompt;

    private bool done;

    private ItemID currentItemID => items[currentPosition + currentSelection];

    private void GetItems(Pocket pocket)
    {
        List<ItemID> items = new();
        cachedItemCount = 1;
        foreach (ItemID item in p.Bag.Keys)
        {
            if (GetPocket(item) == pocket) { items.Add(item); cachedItemCount++; }
        }
        items.Add(ItemID.CloseBag);
        this.items = items.ToArray();
    }

    private void UpdateDisplay()
    {
        for (int i = 0; i < 8; i++)
        {
            int j = currentPosition + i;
            if (j >= cachedItemCount)
            {
                itemDisplays[i].Nullify();
                continue;
            }
            itemDisplays[i].selected = i == currentSelection;
            itemDisplays[i].UpdateDisplay(items[j]);
        }
        if (currentItemID is not ItemID.CloseBag)
        {
            itemSprite.enabled = true;
            itemSprite.texture = currentItemID.Data().ItemSprite;
        }
        else itemSprite.enabled = false;
        itemDesc.text = string.Empty; //Todo: item descriptions
    }

    private void UpdatePocket()
    {
        GetItems(currentPocket);
        currentSelection = 0;
        pocketName.text = PocketNames[(int)currentPocket];
        UpdateDisplay();
    }

    public IEnumerator DoBag(Player player, bool prompt)
    {
        p = player;
        foreach (ItemDisplay i in itemDisplays) i.p = p;
        this.prompt = prompt;
        currentPocket = Pocket.Item;
        currentPosition = 0;
        currentSelection = 0;
        UpdatePocket();
        active = true;
        while (!done)
        {
            yield return null;
        }
        active = false;
    }

    public IEnumerator DoBag(Player player, bool prompt, Player.BagCachedData callback)
    {
        p = player;
        callback ??= new() { pocket = Pocket.Item, position = 0, selection = 0 };
        foreach (ItemDisplay i in itemDisplays) i.p = p;
        this.prompt = prompt;
        currentPocket = callback.pocket;
        currentPosition = callback.position;
        currentSelection = callback.selection;
        UpdatePocket();
        active = true;
        while (!done)
        {
            yield return null;
        }
        active = false;
    }

    private Pocket GetPocket(ItemID item)
    {
        switch (item.Data().type)
        {
            case ItemType.HeldItem:
            case ItemType.FieldItem:
            case ItemType.Plate:
            case ItemType.HeldFieldItem:
            case ItemType.AbstractItem:
            case ItemType.HoldToTransform:
            case ItemType.MegaStone:
            default:
                return Pocket.Item;
            case ItemType.BattleItem:
                return Pocket.BattleItem;
            case ItemType.Medicine:
                return Pocket.Medicine;
            case ItemType.PokeBall:
                return Pocket.PokeBall;
            case ItemType.Berry:
                return Pocket.Berry;
            case ItemType.TM:
                return Pocket.TM;
            case ItemType.KeyItem:
            case ItemType.ZCrystalGeneric:
            case ItemType.ZCrystalSpecific:
            case ItemType.ZCrystalMoveSpecific:
            case ItemType.ZCrystalMultipleSpecies:
                return Pocket.KeyItem;
        }
    }

    private bool GetsChoice(ItemID item, int choice)
    {
        switch (choice)
        {
            case CloseMenu: return true;
            case UseItem:
                return item.FieldEffect() is not FieldEffect.None;
            case GiveItem:
                return item.Data().type is not ItemType.KeyItem;
            case TrashItem:
                return false; //Todo
            default:
                throw new System.Exception("Passed bad choice argument to BagController.GetsChoice");
        }
    }

    private IEnumerator DoChoiceMenu()
    {
        active = false;
        DataStore<int> result = new();
        List<(string, int)> choices = new();
        foreach (MenuChoice choice in menuChoices)
        {
            if (GetsChoice(currentItemID, choice.choiceID))
            {
                choices.Add((choice.name, choice.choiceID));
            }
        }
        bool goingDown = currentSelection < 4;
        yield return ChoiceMenu.DoChoiceMenu(p, choices, 0,
            result, itemDisplays[currentSelection].transform, new(-80, goingDown ? 15 : -15), new(1, goingDown ? 1 : 0));
        switch (result.Data)
        {
            case CloseMenu:
            default:
                active = true;
                break;
            case GiveItem:
                CacheAndReturn(BagOutcome.Give);
                break;
            case UseItem:
                CacheAndReturn(BagOutcome.Use);
                break;
        }
    }

    private void CloseDoNothing()
    {
        p.audioSource.PlayOneShot(SFX.Select);
        done = true;
        p.bagResult = ItemID.None;
        p.bagOutcome = BagOutcome.None;
    }

    private void CacheAndReturn(BagOutcome outcome)
    {
        p.bagResult = currentItemID;
        p.bagOutcome = outcome;
        p.cachedScreenData = new Player.BagCachedData()
        {
            pocket = currentPocket,
            position = currentPosition,
            selection = currentSelection
        };
        done = true;
    }

    private void Update()
    {
        if (!active) return;
        if (Input.GetKeyDown(KeyCode.Backspace)) CloseDoNothing();
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            if (currentItemID is ItemID.CloseBag) CloseDoNothing();
            else if (prompt) { done = true; p.bagResult = currentItemID; }
            else StartCoroutine(DoChoiceMenu());
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currentItemID is ItemID.CloseBag) return;
            if (currentSelection < 8)
            {
                currentSelection++;
                p.audioSource.PlayOneShot(SFX.MoveCursor);
                UpdateDisplay();
            }
            else
            {
                currentPosition++;
                p.audioSource.PlayOneShot(SFX.MoveCursor);
                UpdateDisplay();
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (currentSelection + currentPosition is 0) return;
            if (currentSelection > 0)
            {
                currentSelection--;
                p.audioSource.PlayOneShot(SFX.MoveCursor);
                UpdateDisplay();
            }
            else
            {
                currentPosition--;
                p.audioSource.PlayOneShot(SFX.MoveCursor);
                UpdateDisplay();
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && !(currentPocket is Pocket.Item))
        {
            currentPocket--;
            p.audioSource.PlayOneShot(SFX.MoveCursor);
            UpdatePocket();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && !(currentPocket is Pocket.KeyItem))
        {
            currentPocket++;
            p.audioSource.PlayOneShot(SFX.MoveCursor);
            UpdatePocket();
        }
    }
}

