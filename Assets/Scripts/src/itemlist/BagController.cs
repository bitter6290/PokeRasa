using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class BagController : MonoBehaviour
{

    private enum Pocket
    {
        Item,
        Medicine,
        PokeBall,
        TM,
        Berry,
        Mail,
        BattleItem,
        MegaStone,
        ZCrystal,
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
        "Mega Stones",
        "Z-Crystals",
        "Key Items"
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

    private bool close;

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
        while (!close)
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
            case ItemType.MegaStone:
                return Pocket.MegaStone;
            case ItemType.KeyItem:
                return Pocket.KeyItem;
            case ItemType.ZCrystalGeneric:
            case ItemType.ZCrystalSpecific:
            case ItemType.ZCrystalMoveSpecific:
            case ItemType.ZCrystalMultipleSpecies:
                return Pocket.ZCrystal;
        }
    }

    private IEnumerator DoChoiceMenu()
    {
        active = false;
        DataStore<int> result = new();
        bool goingDown = currentSelection < 4;
        yield return ChoiceMenu.DoChoiceMenu(p, new() { ("Close", 0), ("Test", 1) }, 0,
            result, itemDisplays[currentSelection].transform, new(-80, goingDown ? 15 : -15), new(1, goingDown ? 1 : 0));
        switch (result.Data)
        {
            default:
                active = true;
                break;
        }
    }

    private void Update()
    {
        if (!active) return;
        if (Input.GetKeyDown(KeyCode.Backspace)) { close = true; p.bagResult = ItemID.None; }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            if (currentItemID is ItemID.CloseBag) { close = true; p.bagResult = ItemID.None; }
            else if (prompt) { close = true; p.bagResult = currentItemID; }
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

