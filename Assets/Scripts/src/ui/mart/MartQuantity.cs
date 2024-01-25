using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;

public class MartQuantity : MonoBehaviour
{
    private static readonly Vector3 position = new(-375, 0);

    [SerializeField]
    private TextMeshProUGUI quantityText;
    [SerializeField]
    private TextMeshProUGUI priceText;

    [SerializeField]
    private Sprite arrowDefault;
    [SerializeField]
    private Sprite arrowSelect;

    [SerializeField]
    private Image upArrow;
    [SerializeField]
    private Image downArrow;

    private bool upArrowHit;
    private float upArrowTime;
    private bool downArrowHit;
    private float downArrowTime;

    public int quantity = 1;

    private ItemID item;

    private Player p;

    private bool done;
    public bool Done => done;

    private bool initialized = false;

    private bool inDialogue = false;

    private void UpdateText()
    {
        quantityText.text = quantity.ToString();
        priceText.text = "$" + quantity * item.Data().price;
    }

    private IEnumerator TryToBuy()
    {
        inDialogue = true;
        yield return p.announcer.Announce(item.Data().itemName
            + ", and you want " + quantity + ".\nThat will be $"
            + quantity * item.Data().price + ". OK?");
        DataStore<int> menuResult = new();
        yield return p.DoChoiceMenu(menuResult, ScriptUtils.binaryChoice, 0);
        if (menuResult.Data is 1)
        {
            p.money -= quantity * item.Data().price;
            p.AddItem(item, quantity);
            yield return p.announcer.Announce("Here you are!\nThank you!");
            yield return p.announcer.Announce("You put away the " + item.Data().itemName
                + (quantity > 1 ? "s" : string.Empty) + " in your Bag.");
        }
        yield return p.announcer.AnnouncementDown();
        done = true;
        yield break; //Todo
    }

    public static IEnumerator DoQuantityScreen(Player p, ItemID item)
    {
        yield return p.announcer.AnnouncementUp();
        yield return p.announcer.Announce(item.Data().itemName + "? Certainly.\nHow many would you like?", persist: true);
        GameObject quantityObject = Instantiate(Resources.Load<GameObject>("Prefabs/Mart/Quantity"));
        MartQuantity quantityScreen = quantityObject.GetComponent<MartQuantity>();
        quantityScreen.Initialize(p, item);
        quantityObject.transform.SetParent(p.canvas.transform);
        quantityObject.transform.localPosition = position;
        quantityObject.transform.localScale = Vector3.one;
        while (!quantityScreen.Done) yield return null;
        Destroy(quantityObject);
        yield break; //Todo
    }

    public void Initialize(Player p, ItemID item)
    {
        if (initialized) return;
        initialized = true;
        this.p = p;
        this.item = item;
        UpdateText();
    }

    private void Update()
    {
        if (inDialogue) return;
        if (upArrowHit & Time.time > upArrowTime) { upArrow.sprite = arrowDefault; upArrowHit = false; }
        if (downArrowHit & Time.time > downArrowTime) { downArrow.sprite = arrowDefault; downArrowHit = false; }
        if (Input.GetKeyDown(KeyCode.Delete) || Input.GetKeyDown(KeyCode.Escape))
        {
            done = true;
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(TryToBuy());
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if ((quantity + 1) * item.Data().price <= p.money && quantity < 99)
            {
                p.audioSource.PlayOneShot(SFX.MoveCursor);
                quantity++;
                UpdateText();
                upArrow.sprite = arrowSelect;
                upArrowHit = true;
                upArrowTime = Time.time + 0.15F;
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (quantity > 1)
            {
                p.audioSource.PlayOneShot(SFX.MoveCursor);
                quantity--;
                UpdateText();
                downArrow.sprite = arrowSelect;
                downArrowHit = true;
                downArrowTime = Time.time + 0.15F;
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            int toIncrement = (p.money / item.Data().price) - quantity;
            if (!Input.GetKey(KeyCode.RightShift) && !Input.GetKey(KeyCode.LeftShift) && toIncrement > 10) toIncrement = 10;
            if (quantity + toIncrement > 99) toIncrement = 99 - quantity;
            if (toIncrement > 0)
            {
                p.audioSource.PlayOneShot(SFX.MoveCursor);
                quantity += toIncrement;
                UpdateText();
                upArrow.sprite = arrowSelect;
                upArrowHit = true;
                upArrowTime = Time.time + 0.4F;
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            int newQuantity = 1;
            if (!Input.GetKey(KeyCode.RightShift) && !Input.GetKey(KeyCode.LeftShift) && quantity > 11)
            {
                newQuantity = quantity - 10;
            }
            if (quantity > 1)
            {
                p.audioSource.PlayOneShot(SFX.MoveCursor);
                quantity = newQuantity;
                UpdateText();
                downArrow.sprite = arrowSelect;
                downArrowHit = true;
                downArrowTime = Time.time + 0.4F;
            }
        }
        return;
    }
}