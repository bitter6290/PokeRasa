using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class MartMenu : MonoBehaviour
{
    private const int optionsOnScreen = 6;
    private static readonly Vector2 relativePosition = new(-45, -55);

    [SerializeField]
    private MartOption[] options = new MartOption[optionsOnScreen];
    [SerializeField]
    private RectTransform selector;
    [SerializeField]
    private TextMeshProUGUI moneyDisplay;

    private ItemID[] items;
    private int cachedCount;

    private int currentSelection;
    private int currentPosition;
    private int CurrentIndex => currentPosition + currentSelection;

    private ItemID CurrentItem => items[CurrentIndex];

    private bool done;
    public bool Done => done;

    private bool initialized = false;

    private bool busy;

    private Player p;

    public static IEnumerator DoMartMenu(Player p, ItemID[] items)
    {
        GameObject martObject = Instantiate(Resources.Load<GameObject>("Prefabs/Mart/Menu"));
        martObject.transform.SetParent(p.canvas.transform);
        martObject.transform.localPosition = relativePosition;
        martObject.transform.localScale = Vector3.one;
        MartMenu menu = martObject.GetComponent<MartMenu>();
        menu.Init(p, items);
        while (!menu.Done) yield return null;
        Destroy(menu.gameObject);
        yield break; //Todo
    }

    public IEnumerator GotoQuantity()
    {
        busy = true;
        yield return MartQuantity.DoQuantityScreen(p, CurrentItem);
        busy = false;
    }

    public IEnumerator NotEnoughMoney()
    {
        busy = true;
        yield return p.announcer.AnnouncementUp();
        yield return p.announcer.Announce("I'm sorry, but you don't have enough money to buy that at the moment.");
        yield return p.announcer.AnnouncementDown();
        busy = false;
    }

    private void ShiftSelector()
    {
        selector.SetParent(options[currentSelection].transform, false);
    }

    private void UpdateOptions()
    {
        for (int i = 0; i < optionsOnScreen && i < (cachedCount - currentPosition); i++)
        {
            options[i].Adopt(items[currentPosition + i]);
        }
    }

    public void Init(Player p, ItemID[] items)
    {
        if (initialized) return;
        initialized = true;
        this.p = p;
        this.items = new ItemID[items.Length + 1];
        items.CopyTo(this.items, 0);
        this.items[items.Length] = ItemID.CloseBag;
        cachedCount = this.items.Length;
        if (cachedCount < optionsOnScreen)
            for (int i = cachedCount; i < optionsOnScreen; i++)
                options[i].gameObject.SetActive(false);
        currentPosition = 0;
        currentSelection = 0;
        UpdateOptions();
        ShiftSelector();
    }

    public void Update()
    {
        moneyDisplay.text = "$" + p.money;
        if (busy) return;
        if (Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.Delete) || Input.GetKeyDown(KeyCode.Escape))
        {
            p.audioSource.PlayOneShot(SFX.Select);
            done = true;
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            if (CurrentItem is ItemID.CloseBag)
            {
                p.audioSource.PlayOneShot(SFX.Select);
                done = true;
            }
            else if (CurrentItem.Data().price <= p.money)
            {
                p.audioSource.PlayOneShot(SFX.Select);
                StartCoroutine(GotoQuantity());
            }
            else
            {
                StartCoroutine(NotEnoughMoney());
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (currentSelection > 0)
            {
                currentSelection--;
                ShiftSelector();
                p.audioSource.PlayOneShot(SFX.MoveCursor);
            }
            else if (currentPosition > 0)
            {
                currentPosition--;
                UpdateOptions();
                p.audioSource.PlayOneShot(SFX.MoveCursor);
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currentSelection + 1 < optionsOnScreen)
            {
                if (currentSelection + 1 < cachedCount)
                {
                    currentSelection++;
                    ShiftSelector();
                    p.audioSource.PlayOneShot(SFX.MoveCursor);
                }
            }
            else if (currentPosition + optionsOnScreen + 1 < cachedCount)
            {
                currentPosition++;
                UpdateOptions();
                p.audioSource.PlayOneShot(SFX.MoveCursor);
            }
        }
        return;
    }
}
