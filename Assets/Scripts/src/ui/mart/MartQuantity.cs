using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;

public class MartQuantity : MonoBehaviour
{
    private const float arrowAnimTime = 0.15F;
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
    private bool selling = false;

    private void UpdateText()
    {
        quantityText.text = quantity.ToString();
        int buyPrice = quantity * item.Data().price;
        priceText.text = "$" + (selling ? buyPrice * 4 / 5 : buyPrice);
    }

    private IEnumerator TryToBuy()
    {
        inDialogue = true;
        int buyPrice = quantity * item.Data().price;
        yield return p.announcer.Announce(selling
            ? ("I can pay $" + buyPrice * 4 / 5 + ".\nWould that be OK?")
            : (item.Data().itemName + ", and you want " + quantity
                + ".\nThat will be $" + buyPrice + ". OK?"));
        DataStore<int> menuResult = new();
        yield return p.DoChoiceMenu(menuResult, ScriptUtils.binaryChoice, 0);
        if (menuResult.Data is 1)
        {
            if (selling)
            {
                p.money += buyPrice * 4 / 5;
                p.UseItem(item, quantity);
                yield return p.announcer.Announce("Turned over the " + item.Data().itemName
                    + " and received $" + buyPrice * 4 / 5 + ".");
            }
            else
            {
                p.money -= quantity * item.Data().price;
                p.AddItem(item, quantity);
                yield return p.announcer.Announce("Here you are!\nThank you!");
                yield return p.announcer.Announce("You put away the " + item.Data().itemName
                    + (quantity > 1 ? "s" : string.Empty) + " in your Bag.");
            }
        }
        yield return p.announcer.AnnouncementDown();
        done = true;
        yield break; //Todo
    }

    public static IEnumerator DoQuantityScreen(Player p, ItemID item, bool selling)
    {
        yield return p.announcer.AnnouncementUp();
        yield return p.announcer.Announce(item.Data().itemName
            + (selling
                ? "?\nHow many would you like to sell?"
                : "? Certainly.\nHow many would you like?"),
            persist: true);
        GameObject quantityObject = Instantiate(Resources.Load<GameObject>("Prefabs/Mart/Quantity"));
        MartQuantity quantityScreen = quantityObject.GetComponent<MartQuantity>();
        quantityScreen.Initialize(p, item, selling);
        quantityObject.transform.SetParent(p.canvas.transform);
        quantityObject.transform.localPosition = position;
        quantityObject.transform.localScale = Vector3.one;
        while (!quantityScreen.Done) yield return null;
        Destroy(quantityObject);
        yield break; //Todo
    }

    public void Initialize(Player p, ItemID item, bool selling)
    {
        if (initialized) return;
        initialized = true;
        this.p = p;
        this.item = item;
        this.selling = selling;
        UpdateText();
    }

    private void Update()
    {
        if (inDialogue) return;
        if (upArrowHit & Time.time > upArrowTime) { upArrow.sprite = arrowDefault; upArrowHit = false; }
        if (downArrowHit & Time.time > downArrowTime) { downArrow.sprite = arrowDefault; downArrowHit = false; }
        if (Input.GetKeyDown(KeyCode.Delete) || Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log(done);
            done = true;
            Debug.Log(done);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(TryToBuy());
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if ((selling ? (quantity < p.NumberOf(item)) :
                (quantity + 1) * item.Data().price <= p.money) && quantity < 99)
            {
                p.audioSource.PlayOneShot(SFX.MoveCursor);
                quantity++;
                UpdateText();
                upArrow.sprite = arrowSelect;
                upArrowHit = true;
                upArrowTime = Time.time + arrowAnimTime;
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
                downArrowTime = Time.time + arrowAnimTime;
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            int toIncrement = (selling ? p.NumberOf(item) : p.money / item.Data().price) - quantity;
            if (!Input.GetKey(KeyCode.RightShift) && !Input.GetKey(KeyCode.LeftShift) && toIncrement > 10) toIncrement = 10;
            if (quantity + toIncrement > 99) toIncrement = 99 - quantity;
            if (toIncrement > 0)
            {
                p.audioSource.PlayOneShot(SFX.MoveCursor);
                quantity += toIncrement;
                UpdateText();
                upArrow.sprite = arrowSelect;
                upArrowHit = true;
                upArrowTime = Time.time + arrowAnimTime;
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
                downArrowTime = Time.time + arrowAnimTime;
            }
        }
        return;
    }
}