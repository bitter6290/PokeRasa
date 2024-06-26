using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static SFX;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private Image box1;
    [SerializeField] private Image box2;
    [SerializeField] private Image box3;
    [SerializeField] private Image box4;
    [SerializeField] private Image box5;
    [SerializeField] private Image box6;
    [SerializeField] private Image box7;


    [SerializeField] private TextMeshProUGUI text1;
    [SerializeField] private TextMeshProUGUI text2;
    [SerializeField] private TextMeshProUGUI text3;
    [SerializeField] private TextMeshProUGUI text4;
    [SerializeField] private TextMeshProUGUI text5;
    [SerializeField] private TextMeshProUGUI text7;

    [SerializeField] private TextMeshProUGUI pp1;
    [SerializeField] private TextMeshProUGUI pp2;
    [SerializeField] private TextMeshProUGUI pp3;
    [SerializeField] private TextMeshProUGUI pp4;


    [SerializeField] private SpriteRenderer selector1;
    [SerializeField] private SpriteRenderer selector2;
    [SerializeField] private SpriteRenderer selector3;
    [SerializeField] private SpriteRenderer selector4;
    [SerializeField] private SpriteRenderer selector5;
    [SerializeField] private SpriteRenderer selector6;
    [SerializeField] private SpriteRenderer selector7;


    [SerializeField] private SpriteRenderer partyMon1;
    [SerializeField] private SpriteRenderer partyMon2;
    [SerializeField] private SpriteRenderer partyMon3;
    [SerializeField] private SpriteRenderer partyMon4;
    [SerializeField] private SpriteRenderer partyMon5;
    [SerializeField] private SpriteRenderer partyMon6;

    [SerializeField] private TextMeshProUGUI partyText1;
    [SerializeField] private TextMeshProUGUI partyText2;
    [SerializeField] private TextMeshProUGUI partyText3;
    [SerializeField] private TextMeshProUGUI partyText4;
    [SerializeField] private TextMeshProUGUI partyText5;
    [SerializeField] private TextMeshProUGUI partyText6;

    [SerializeField] private TextMeshProUGUI announce;

    [SerializeField] private GameObject megaIndicator;
    [SerializeField] private TextMeshProUGUI megaKey;
    [SerializeField] private SpriteRenderer megaSymbol;

    [SerializeField] private GameObject summaryIndicator;

    [SerializeField] private Sprite megaSprite;
    [SerializeField] private Sprite zSprite;
    [SerializeField] private Sprite dynaSprite;


    [SerializeField] private Battle battle;

    [SerializeField] private int currentMon = 3;
    [SerializeField] private int currentMove = 1; //0 means Back

    public enum PartyScreenReason
    {
        ChoosingSwitch,
        SwitchingMove,
        UsingItem,
        RevivalBlessing,
    }

    public PartyScreenReason partyScreenReason;

    private ItemID cachedItem;
    private ItemSubset cachedSubset;
    private int cachedItemPosition;

    private Image Box(int i) => i switch
    {
        1 => box1,
        2 => box2,
        3 => box3,
        4 => box4,
        5 => box5,
        6 => box6,
        7 => box7,
        _ => throw new System.Exception("Passed bad argument to MenuManager.Box")
    };

    private Image PartyBox(int i) => i switch
    {
        1 => box1,
        2 => box3,
        3 => box2,
        4 => box4,
        5 => box5,
        6 => box6,
        7 => box7,
        _ => throw new System.Exception("Passed bad argument to MenuManager.PartyBox")
    };

    private TextMeshProUGUI Text(int i) => i switch
    {
        1 => text1,
        2 => text2,
        3 => text3,
        4 => text4,
        5 => text5,
        _ => throw new System.Exception("Passed bad argument to MenuManager.Text")
    };

    private TextMeshProUGUI PP(int i) => i switch
    {
        1 => pp1,
        2 => pp2,
        3 => pp3,
        4 => pp4,
        _ => throw new System.Exception("Passed bad argunemt to MenuManager.PP")
    };

    private TextMeshProUGUI PartyText(int i) => i switch
    {
        1 => partyText1,
        2 => partyText3,
        3 => partyText2,
        4 => partyText4,
        5 => partyText5,
        6 => partyText6,
        _ => throw new System.Exception("Passed bad argument to MenuManager.PartyText")
    };

    private SpriteRenderer PartyIcon(int i) => i switch
    {
        1 => partyMon1,
        2 => partyMon3,
        3 => partyMon2,
        4 => partyMon4,
        5 => partyMon5,
        6 => partyMon6,
        _ => throw new System.Exception("Passed bad argument to MenuManager.PartyIcon")
    };

    private TextMeshProUGUI ItemText(int i) => i switch
    {
        1 => partyText1,
        2 => partyText2,
        3 => partyText3,
        4 => partyText4,
        _ => throw new System.Exception("Passed bad argument to MenuManager.ItemText")
    };

    private SpriteRenderer ItemIcon(int i) => i switch
    {
        1 => partyMon1,
        2 => partyMon2,
        3 => partyMon3,
        4 => partyMon4,
        _ => throw new System.Exception("Passed bad argument to MenuManager.ItemIcon")
    };
    public enum MenuMode
    {
        Main,
        Moves,
        Party,
        ItemCategories,
        Items,
    }

    private enum ItemSubset
    {
        PokeBalls,
        Medicine,
        Berries,
        BattleItems,
    }

    public int currentPartyMon = 1; //0 means Back

    private bool canMegaEvolve;
    private bool canUseZMove;
    private bool canDynamax;
    private bool canTera;
    public bool megaEvolving;
    public bool usingZMove;
    public bool dynamaxing;
    public bool terastalizing;

    public MenuMode menuMode;

    private Battle.BattlePokemon mon;

    private ItemID[] cachedItems;
    private int cachedItemCount;
    private int currentItemPosition;

    private static Color transparent = new(0, 0, 0, 0);

    private static Color moveColor = new(88.0F / 255.0F, 146.0F / 255.0F, 232.0F / 255.0F);
    private static Color struggleColor = new(160.0F / 255.0F, 200.0F / 255.0F, 245.0F / 255.0F);
    private static Color bagColor = new(80.0F / 255.0F, 179.0F / 255.0F, 95.0F / 255.0F);
    private static Color switchColor = new(196.0F / 255.0F, 168.0F / 255.0F, 8.0F / 255.0F);
    private static Color runColor = new(1, 64.0F / 255.0F, 64.0F / 255.0F);

    private static Color megaNoColor = new(220.0F / 255.0F, 239.0F / 255.0F, 1);
    private static Color megaYesColor = new(0, 137.0F / 255.0F, 1);

    private static Color zNoColor = new(220.0F / 255.0F, 1, 239.0F / 255.0F);
    private static Color zYesColor = new(0, 1, 137.0F / 255.0F);

    private static Color dynaNoColor = new(1, 213.0F / 255.0F, 199.0F / 255.0F);
    private static Color dynaYesColor = new(1, 94.0F / 255.0F, 41.0F / 255.0F);

    private static Color teraYesColor = new(224.0F / 255.0F, 176.0F / 255.0F, 1);
    private static Color teraNoColor = new(248.0F / 255.0F, 232.0F / 255.0F, 1);

    private static Color partyOK = new(25.0F / 255.0F, 25.0F / 255.0F, 128.0F / 255.0F);
    private static Color partyFainted = new(128.0F / 255.0F, 25.0F / 255.0F, 25.0F / 255.0F);

    private static Color backColor = new(240F / 255F, 160F / 255F, 160F / 255F);
    private static Color partyColor = new(240F / 255F, 240F / 255F, 240F / 255F);

    private ItemID[] GetItemsBySubset(ItemSubset subset)
    {
        List<ItemID> itemIDs = new();
        foreach (ItemID i in battle.player.Bag.Keys)
        {
            if (i.Data().type == subset switch
            {
                ItemSubset.PokeBalls => ItemType.PokeBall,
                ItemSubset.Medicine => ItemType.Medicine,
                ItemSubset.Berries => ItemType.Berry,
                ItemSubset.BattleItems => ItemType.BattleItem,
                _ => null
            }) itemIDs.Add(i);
        }
        return itemIDs.ToArray();
    }

    private void TrySelect(int selectedMove)
    {
        switch (mon.CanUseMove(selectedMove - 1))
        {
            case MoveSelectOutcome.LowPP:
                _ = StartCoroutine(AnnounceAndReturn(
                    battle.PokemonOnField[currentMon].GetMove(selectedMove - 1).Data().name
                    + BattleText.NoPP));
                break;
            case MoveSelectOutcome.Encored:
                StartCoroutine(AnnounceAndReturn(
                    battle.MonNameWithPrefix(currentMon, true)
                    + " can only use "
                    + battle.PokemonOnField[currentMon].encoredMove.Data().name
                    + "!"));
                break;
            case MoveSelectOutcome.Disabled:
                StartCoroutine(AnnounceAndReturn(
                    battle.MonNameWithPrefix(currentMon, true) + "'s "
                    + battle.PokemonOnField[currentMon].disabledMove.Data().name
                    + " is disabled!"));
                break;
            case MoveSelectOutcome.Tormented:
                StartCoroutine(AnnounceAndReturn(
                    battle.MonNameWithPrefix(currentMon, true)
                    + " can't use the same move again because of the torment!"));
                break;
            case MoveSelectOutcome.Imprisoned:
                StartCoroutine(AnnounceAndReturn(
                    battle.MonNameWithPrefix(currentMon, true) + "'s "
                    + battle.PokemonOnField[currentMon].GetMove(selectedMove - 1).Data().name
                    + " is imprisoned!"));
                break;
            case MoveSelectOutcome.Gravity:
                StartCoroutine(AnnounceAndReturn(
                    battle.MonNameWithPrefix(currentMon, true) + " can't use "
                    + battle.PokemonOnField[currentMon].GetMove(selectedMove - 1).Data().name
                    + " under the intense gravity!"));
                break;
            case MoveSelectOutcome.HealBlock:
                StartCoroutine(AnnounceAndReturn(
                    battle.MonNameWithPrefix(currentMon, true) + " can't use "
                    + battle.PokemonOnField[currentMon].GetMove(selectedMove - 1).Data().name
                    + " during the heal block!"));
                break;
            case MoveSelectOutcome.Choiced:
                StartCoroutine(AnnounceAndReturn(
                    battle.MonNameWithPrefix(currentMon, true) + " can only use " +
                    battle.PokemonOnField[currentMon].lastMoveUsed.Data().name + "!"));
                break;
            case MoveSelectOutcome.Vested:
                StartCoroutine(AnnounceAndReturn(
                    battle.MonNameWithPrefix(currentMon, true) + " can't use "
                    + battle.PokemonOnField[currentMon].GetMove(selectedMove - 1).Data().name
                    + " because of its Assault Vest!"));
                break;
            case MoveSelectOutcome.Success:
                if (battle.TryAddMove(currentMon, selectedMove))
                {
                    mon.choseMove = true;
                    switch (battle.battleType)
                    {
                        case Battle.BattleType.Single:
                            battle.Targets[currentMon] = 0;
                            break;
                    }
                    if (GetNextPokemon())
                    {
                        menuMode = MenuMode.Main;
                        GoToAnnounce();
                        currentMove = 1;
                        currentMon = 2;
                        GetNextPokemon();
                        battle.DoNextMove();
                    }
                    else
                    {
                        megaEvolving = false;
                        MainMenu();
                        currentMove = 1;
                    }
                }
                else
                {
                    GoToAnnounce();
                    battle.state = BattleState.Announcement;
                    StartCoroutine(AnnounceAndReturn(
                    battle.PokemonOnField[currentMon].GetMove(selectedMove - 1).Data().name
                    + BattleText.NoPP));
                }
                break;
        }
    }

    public bool GetNextPokemon()
    {
        megaEvolving = false;
        for (int i = 0; i < 6; i++)
        {
            if (battle.PokemonOnField[i].exists && battle.PokemonOnField[i].player
                && !battle.PokemonOnField[i].choseMove)
            {
                currentMon = i;
                return false;
            }
        }
        return true;
    }

    public void SetForTest()
    {
        battle.menuManager.currentMove = 1;
        battle.menuManager.currentMon = 2;
    }

    public void CleanForTurnStart()
    {
        MainMenu();
        currentMove = 1;
        currentMon = 2;
        _ = GetNextPokemon();
    }

    private void DisableParty()
    {
        box7.enabled = false;
        for (int i = 1; i <= 6; i++)
        {
            PartyText(i).enabled = false;
            PartyIcon(i).enabled = false;
        }
    }

    private void RefreshMoves()
    {
        for (int i = 0; i < 4; i++)
        {
            if (mon.GetMoveRaw(i) == MoveID.None)
            {
                PP(i + 1).enabled = false;
                Box(i + 1).enabled = false;
                Text(i + 1).enabled = false;
            }
            else
            {
                Type type = battle.GetEffectiveType(mon.GetMove(i), currentMon);
                Box(i + 1).enabled = true;
                Text(i + 1).enabled = true;
                PP(i + 1).enabled = true;
                Box(i + 1).color = (dynamaxing & mon.GetMove(i).Data().power == 0)
                    ? Type.Normal.Color()
                    : (mon.GetMove(i) == MoveID.None
                        ? transparent
                        : type.Color());
                Text(i + 1).text = dynamaxing ? mon.GetMove(i).MaxMove(mon.pokemon).Data().name : mon.GetMove(i).Data().name;
                Text(i + 1).color = (dynamaxing & mon.GetMove(i).Data().power == 0) ? Color.black : type.TextColor();
                PP(i + 1).text = LeadingZero(mon.GetPP(i).ToString()) + " / " +
                    LeadingZero(mon.GetMaxPP(i).ToString());
                PP(i + 1).color = (dynamaxing & mon.GetMove(i).Data().power == 0) ? Color.black : type.TextColor();
            }
        }
    }
    private void MovesMenu()
    {
        menuMode = MenuMode.Moves;
        mon = battle.PokemonOnField[currentMon];

        currentMove = mon.lastMoveSlot;
        if (currentMove is 0 or 63) currentMove = 1;

        box5.color = backColor;
        text5.enabled = true;
        box5.enabled = true;
        text5.text = "Back";

        RefreshMoves();


        text7.enabled = false;
        box6.enabled = false;

        selector1.enabled = currentMove == 1;
        selector2.enabled = currentMove == 2;
        selector3.enabled = currentMove == 3;
        selector4.enabled = currentMove == 4;
        selector5.enabled = currentMove == 0;
        selector6.enabled = false;
        selector7.enabled = false;

        DisableParty();

        RefreshMegaAndZ();
    }

    public void MainMenu()
    {
        usingZMove = false;
        megaEvolving = false;
        dynamaxing = false;
        battle.megaEvolveOnMove[currentMon] = false;
        battle.usingZMove[currentMon] = false;
        battle.dynamaxing[currentMon] = false;
        bool canUseAnyMove = battle.PokemonOnField[currentMon].CanUseAnyMove;

        box1.color = canUseAnyMove ? moveColor : struggleColor;
        box2.color = bagColor;
        box3.color = switchColor;
        box4.color = runColor;

        box1.enabled = true;
        box2.enabled = true;
        box3.enabled = true;
        box4.enabled = true;
        box5.enabled = false;
        box6.enabled = false;

        text1.text = canUseAnyMove ? "Moves" : "Struggle";
        text2.text = "Bag";
        text3.text = "Switch";
        text4.text = "Run";

        text1.enabled = true;
        text2.enabled = true;
        text3.enabled = true;
        text4.enabled = true;
        text5.enabled = false;
        text7.enabled = false;

        pp1.enabled = false;
        pp2.enabled = false;
        pp3.enabled = false;
        pp4.enabled = false;

        selector1.enabled = currentMove == 1;
        selector2.enabled = currentMove == 2;
        selector3.enabled = currentMove == 3;
        selector4.enabled = currentMove == 4;
        selector5.enabled = currentMove == 0;
        selector6.enabled = false;
        selector7.enabled = false;

        DisableParty();

        megaIndicator.SetActive(false);
        summaryIndicator.SetActive(false);
        menuMode = MenuMode.Main;
    }

    public void PartyMenu(PartyScreenReason reason)
    {
        partyScreenReason = reason;
        announce.enabled = false;
        battle.choseSwitchMon = false;

        for (int i = 1; i <= 5; i++)
        {
            Text(i).enabled = false;
        }

        box7.enabled = reason is not PartyScreenReason.SwitchingMove or PartyScreenReason.RevivalBlessing;
        text7.enabled = box7.enabled;
        box7.color = backColor;
        text7.text = "Back";

        selector1.enabled = currentPartyMon == 1;
        selector2.enabled = currentPartyMon == 3;
        selector3.enabled = currentPartyMon == 2;
        selector4.enabled = currentPartyMon == 4;
        selector5.enabled = currentPartyMon == 5;
        selector6.enabled = currentPartyMon == 6;
        selector7.enabled = currentPartyMon == 0;

        pp1.enabled = false;
        pp2.enabled = false;
        pp3.enabled = false;
        pp4.enabled = false;

        for (int i = 0; i < 6; i++)
        {
            PartyBox(i + 1).enabled = battle.playerPokemon[i].exists;
            PartyBox(i + 1).color = partyMonColor(i);
            PartyText(i + 1).enabled = battle.playerPokemon[i].exists;
            PartyText(i + 1).text = battle.playerPokemon[i].MonName;
            PartyIcon(i + 1).enabled = battle.playerPokemon[i].exists;
            PartyIcon(i + 1).sprite = (currentPartyMon == (i + 1)
                && Time.time % 0.36 > 0.18) ?
            battle.PlayerIcon2(i) : battle.PlayerIcon1(i);
        }

        megaIndicator.SetActive(false);
        summaryIndicator.SetActive(true);
        menuMode = MenuMode.Party;
    }

    public void RefreshMegaAndZ()
    {
        if (battle.CanMegaEvolve(currentMon))
        {
            canMegaEvolve = true;
            canUseZMove = false;
            usingZMove = false;
            canDynamax = false;
            dynamaxing = false;
            canTera = false;
            terastalizing = false;
            megaKey.text = "M";
            megaSymbol.sprite = megaSprite;
            megaIndicator.GetComponent<SpriteRenderer>().color =
                megaEvolving ? megaYesColor : megaNoColor;
            megaIndicator.SetActive(true);
        }
        else
        {
            canMegaEvolve = false;
            megaEvolving = false;
            if (currentMove > 0 && battle.CanUseZMove(currentMon, currentMove - 1))
            {
                canDynamax = false;
                dynamaxing = false;
                canTera = false;
                terastalizing = false;
                canUseZMove = true;
                megaKey.text = "Z";
                megaSymbol.sprite = zSprite;
                megaIndicator.GetComponent<SpriteRenderer>().color =
                    usingZMove ? zYesColor : zNoColor;
                megaIndicator.SetActive(true);
            }
            else
            {
                usingZMove = false;
                canUseZMove = false;
                if (battle.CanDynamax(currentMon))
                {
                    canTera = false;
                    terastalizing = false;
                    canDynamax = true;
                    megaKey.text = "X";
                    megaSymbol.sprite = dynaSprite;
                    megaIndicator.GetComponent<SpriteRenderer>().color =
                        dynamaxing ? dynaYesColor : dynaNoColor;
                    megaIndicator.SetActive(true);
                }
                else
                {
                    dynamaxing = false;
                    canDynamax = false;
                    if (battle.CanTerastalize(currentMon))
                    {
                        canTera = true;
                        megaKey.text = "T";
                        Texture2D texture = mon.pokemon.TeraSymbol;
                        megaSymbol.sprite = Sprite.Create(texture, new(0, 0, texture.width, texture.height), StaticValues.defPivot, texture.width * 1.8F);
                        megaIndicator.GetComponent<SpriteRenderer>().color =
                            terastalizing ? teraYesColor : teraNoColor;
                        megaIndicator.SetActive(true);
                    }
                    else
                    {
                        terastalizing = false;
                        canTera = false;
                        megaIndicator.SetActive(false);
                    }
                }
            }
        }
    }

    private void DisableBoxes()
    {
        for (int i = 1; i <= 5; i++)
        {
            Box(i).enabled = false;
            Text(i).enabled = false;
        }
        box6.enabled = false;
    }

    public void GoToAnnounce()
    {
        battle.state = BattleState.Announcement;
        announce.enabled = true;
        DisableBoxes();
        box7.enabled = false;
        text7.enabled = false;
        selector1.enabled = false;
        selector2.enabled = false;
        selector3.enabled = false;
        selector4.enabled = false;
        selector5.enabled = false;
        selector6.enabled = false;
        selector7.enabled = false;
        pp1.enabled = false;
        pp2.enabled = false;
        pp3.enabled = false;
        pp4.enabled = false;
        DisableParty();
        megaIndicator.SetActive(false);
        summaryIndicator.SetActive(false);
    }

    public void ItemCategoryMenu()
    {
        menuMode = MenuMode.ItemCategories;
        announce.enabled = false;
        box1.enabled = true;
        box2.enabled = true;
        box3.enabled = true;
        box4.enabled = true;
        box5.enabled = true;
        box6.enabled = false;
        box7.enabled = false;

        text1.enabled = true;
        text2.enabled = true;
        text3.enabled = true;
        text4.enabled = true;
        text5.enabled = true;

        selector1.enabled = true;
        selector2.enabled = false;
        selector3.enabled = false;
        selector4.enabled = false;
        selector5.enabled = false;
        selector6.enabled = false;
        selector7.enabled = false;

        pp1.enabled = false;
        pp2.enabled = false;
        pp3.enabled = false;
        pp4.enabled = false;
        DisableParty();

        box1.color = moveColor;
        text1.text = "Medicine";
        box2.color = runColor;
        text2.text = "Poké Balls";
        box3.color = bagColor;
        text3.text = "Berries";
        box4.color = switchColor;
        text4.text = "Battle Items";
        box5.color = backColor;
        text5.text = "Back";

        currentMove = 0;
    }

    private void ItemSubmenu(ItemSubset subset, int initialPosition = 0)
    {
        menuMode = MenuMode.Items;
        cachedItems = GetItemsBySubset(subset);
        cachedItemCount = cachedItems.Length;
        cachedSubset = subset;
        DisableBoxes();
        box5.enabled = true;
        box5.color = backColor;
        text5.enabled = true;
        text5.text = "Back";
        text5.color = Color.black;

        for (int i = 1; i <= 4; i++)
        {
            Box(i).color = partyColor;
        }

        selector1.enabled = false;
        selector2.enabled = false;
        selector3.enabled = false;
        selector4.enabled = false;
        selector5.enabled = false;
        selector6.enabled = false;
        selector7.enabled = false;
        pp1.enabled = false;
        pp2.enabled = false;
        pp3.enabled = false;
        pp4.enabled = false;
        DisableParty();
        megaIndicator.SetActive(false);
        summaryIndicator.SetActive(false);
        currentItemPosition = initialPosition;
        currentMove = 0;
        UpdateItemSubmenu();
    }

    private void UpdateItemSubmenu()
    {
        for (int i = 0; i < 4; i++)
        {
            if (currentItemPosition + i < cachedItemCount)
            {
                Box(i + 1).enabled = true;
                ItemIcon(i + 1).enabled = true;
                ItemText(i + 1).enabled = true;
                ItemText(i + 1).color = Color.black;
                ItemIcon(i + 1).sprite = Sprite.Create(
                    cachedItems[currentItemPosition + i].Data().ItemSprite, new(0, 0, 24, 24), StaticValues.defPivot);
                ItemText(i + 1).text = cachedItems[currentItemPosition + i].Data().itemName;
            }
            else
            {
                Box(i + 1).enabled = false;
                ItemIcon(i + 1).enabled = false;
                ItemText(i + 1).enabled = false;
            }
        }
    }

    private void ChangeSelection(int destination)
    {
        currentMove = destination;
        battle.audioSource0.PlayOneShot(MoveCursor);
        battle.audioSource0.panStereo = 0;
    }

    private IEnumerator AnnounceAndReturn(string announcement)
    {
        GoToAnnounce();
        yield return battle.Announce(announcement);
        battle.state = BattleState.PlayerInput;
        switch (menuMode)
        {
            case MenuMode.Main: MainMenu(); break;
            case MenuMode.Moves: MovesMenu(); break;
            case MenuMode.Party: PartyMenu(PartyScreenReason.ChoosingSwitch); break;
        }
    }

    public static string LeadingZero(string input) => input.Length == 1 ? "0" + input : input;

    private Color partyMonColor(int index)
    {
        return battle.playerPokemon[index].fainted ? partyFainted : partyOK;
    }

    // Start is called before the first frame update
    public void Start()
    {
        partyText1.color = partyColor;
        partyText2.color = partyColor;
        partyText3.color = partyColor;
        partyText4.color = partyColor;
        partyText5.color = partyColor;
        partyText6.color = partyColor;

        GoToAnnounce();
        currentMon = 3;
    }

    // Update is called once per frame
    public void Update()
    {
        if (battle.menuOpen) return;
        if (battle.state == BattleState.PlayerInput)
        {
            announce.enabled = false;
            switch (menuMode)
            {
                case MenuMode.Moves:
                    mon = battle.PokemonOnField[currentMon];

                    selector1.enabled = currentMove == 1;
                    selector2.enabled = currentMove == 2;
                    selector3.enabled = currentMove == 3;
                    selector4.enabled = currentMove == 4;
                    selector5.enabled = currentMove == 0;


                    if (canMegaEvolve)
                    {
                        if (Input.GetKeyDown(KeyCode.M))
                        {
                            megaEvolving = !megaEvolving;
                            battle.megaEvolveOnMove[currentMon] = megaEvolving;
                            battle.audioSource0.PlayOneShot(Select);
                            battle.audioSource0.panStereo = 0;
                            megaIndicator.GetComponent<SpriteRenderer>().color =
                                megaEvolving ? megaYesColor : megaNoColor;
                        }
                    }
                    else if (canUseZMove)
                    {
                        if (Input.GetKeyDown(KeyCode.Z))
                        {
                            usingZMove = !usingZMove;
                            battle.usingZMove[currentMon] = usingZMove;
                            battle.audioSource0.PlayOneShot(Select);
                            battle.audioSource0.panStereo = 0;
                            megaIndicator.GetComponent<SpriteRenderer>().color =
                                usingZMove ? zYesColor : zNoColor;
                        }
                    }
                    else if (canDynamax)
                    {
                        if (Input.GetKeyDown(KeyCode.X))
                        {
                            dynamaxing = !dynamaxing;
                            battle.dynamaxing[currentMon] = dynamaxing;
                            battle.audioSource0.PlayOneShot(Select);
                            battle.audioSource0.panStereo = 0;
                            megaIndicator.GetComponent<SpriteRenderer>().color =
                                dynamaxing ? dynaYesColor : dynaNoColor;
                            RefreshMoves();
                        }
                    }
                    else if (canTera)
                    {
                        if (Input.GetKeyDown(KeyCode.T))
                        {
                            terastalizing = !terastalizing;
                            battle.terastalizing[currentMon] = terastalizing;
                            battle.audioSource0.PlayOneShot(Select);
                            battle.audioSource0.panStereo = 0;
                            megaIndicator.GetComponent<SpriteRenderer>().color =
                                terastalizing ? teraYesColor : teraNoColor;
                        }
                    }

                    summaryIndicator.SetActive(false);

                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        switch (currentMove)
                        {
                            case 1:
                                ChangeSelection(mon.GetMoveRaw(1) == MoveID.None ? 0 : 2);
                                RefreshMegaAndZ();
                                break;
                            case 2:
                                ChangeSelection(0);
                                RefreshMegaAndZ();
                                break;
                            case 3:
                                if (mon.GetMoveRaw(3) != MoveID.None)
                                {
                                    ChangeSelection(4);
                                    RefreshMegaAndZ();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        switch (currentMove)
                        {
                            case 0:
                                ChangeSelection(mon.GetMoveRaw(1) == MoveID.None ? 1 : 2);
                                RefreshMegaAndZ();
                                break;
                            case 2:
                                ChangeSelection(1);
                                RefreshMegaAndZ();
                                break;
                            case 4:
                                ChangeSelection(3);
                                RefreshMegaAndZ();
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        switch (currentMove)
                        {
                            case 1:
                                if (mon.GetMoveRaw(2) != MoveID.None)
                                {
                                    ChangeSelection(3);
                                    RefreshMegaAndZ();
                                }
                                break;
                            case 2:
                                if (mon.GetMoveRaw(3) != MoveID.None)
                                {
                                    ChangeSelection(4);
                                    RefreshMegaAndZ();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        switch (currentMove)
                        {
                            case 3:
                                ChangeSelection(1);
                                RefreshMegaAndZ();
                                break;
                            case 4:
                                ChangeSelection(2);
                                RefreshMegaAndZ();
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        battle.audioSource0.PlayOneShot(Select);
                        battle.audioSource0.panStereo = 0;
                        switch (currentMove)
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                                TrySelect(currentMove);
                                break;
                            case 0:
                                currentMove = 1;
                                MainMenu();
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case MenuMode.Main:
                    bool canUseAnyMove = battle.PokemonOnField[currentMon].CanUseAnyMove;

                    selector1.enabled = currentMove == 1;
                    selector2.enabled = currentMove == 2;
                    selector3.enabled = currentMove == 3;
                    selector4.enabled = currentMove == 4;
                    selector5.enabled = currentMove == 0;

                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        switch (currentMove)
                        {
                            case 1:
                                ChangeSelection(2);
                                break;
                            case 3:
                                ChangeSelection(4);
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        switch (currentMove)
                        {
                            case 2:
                                ChangeSelection(1);
                                break;
                            case 4:
                                ChangeSelection(3);
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        switch (currentMove)
                        {
                            case 1:
                                ChangeSelection(3);
                                break;
                            case 2:
                                ChangeSelection(4);
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        switch (currentMove)
                        {
                            case 3:
                                ChangeSelection(1);
                                break;
                            case 4:
                                ChangeSelection(2);
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        battle.audioSource0.volume = 0.6F;
                        battle.audioSource0.PlayOneShot(Select);
                        battle.audioSource0.panStereo = 0;
                        switch (currentMove)
                        {
                            case 1:
                                if (!canUseAnyMove)
                                {
                                    battle.Moves[currentMon] = MoveID.Struggle;
                                    battle.PokemonOnField[currentMon].dontCheckPP = true;
                                    battle.PokemonOnField[currentMon].choseMove = true;
                                    switch (battle.battleType)
                                    {
                                        case Battle.BattleType.Single:
                                            battle.Targets[currentMon] = 0;
                                            break;
                                    }
                                    if (GetNextPokemon())
                                    {
                                        menuMode = MenuMode.Main;
                                        GoToAnnounce();
                                        currentMove = 1;
                                        currentMon = 2;
                                        GetNextPokemon();
                                        battle.DoNextMove();
                                    }
                                    else
                                    {
                                        MainMenu();
                                        currentMove = 1;
                                    }
                                }
                                else
                                {
                                    MovesMenu();
                                }
                                break;
                            case 2:
                                currentMove = 1;
                                ItemCategoryMenu();
                                break;
                            case 3:
                                currentPartyMon = 1;
                                PartyMenu(PartyScreenReason.ChoosingSwitch);
                                break;
                            case 4:
                                if (battle.wildBattle)
                                {
                                    battle.StartCoroutine(battle.TryToRun());
                                }
                                else
                                {
                                    GoToAnnounce();
                                    StartCoroutine(AnnounceAndReturn(
                                        "No! There's no running from a trainer battle!"));
                                }
                                break;
                            default:
                                break;

                        }
                    }
                    break;
                case MenuMode.Party:
                    announce.enabled = false;


                    selector1.enabled = currentPartyMon == 1;
                    selector2.enabled = currentPartyMon == 3;
                    selector3.enabled = currentPartyMon == 2;
                    selector4.enabled = currentPartyMon == 4;
                    selector5.enabled = currentPartyMon == 5;
                    selector6.enabled = currentPartyMon == 6;
                    selector7.enabled = currentPartyMon == 0;

                    bool useSprite2 = Time.time % 0.36 > 0.18;

                    partyMon1.sprite = currentPartyMon == 1 && useSprite2 ?
                        battle.PlayerIcon2(0) : battle.PlayerIcon1(0);
                    partyMon2.sprite = currentPartyMon == 3 && useSprite2 ?
                        battle.PlayerIcon2(2) : battle.PlayerIcon1(2);
                    partyMon3.sprite = currentPartyMon == 2 && useSprite2 ?
                        battle.PlayerIcon2(1) : battle.PlayerIcon1(1);
                    partyMon4.sprite = currentPartyMon == 4 && useSprite2 ?
                        battle.PlayerIcon2(3) : battle.PlayerIcon1(3);
                    partyMon5.sprite = currentPartyMon == 5 && useSprite2 ?
                        battle.PlayerIcon2(4) : battle.PlayerIcon1(4);
                    partyMon6.sprite = currentPartyMon == 6 && useSprite2 ?
                        battle.PlayerIcon2(5) : battle.PlayerIcon1(5);

                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        switch (currentPartyMon)
                        {
                            case 1:
                                currentPartyMon = box2.enabled ? 3 :
                                    partyScreenReason is PartyScreenReason.SwitchingMove or PartyScreenReason.RevivalBlessing ? 1 : 0;
                                if (currentPartyMon != 1)
                                {
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                }
                                break;
                            case 2:
                                currentPartyMon = box4.enabled ? 4 :
                                    partyScreenReason is PartyScreenReason.SwitchingMove or PartyScreenReason.RevivalBlessing ? 2 : 0;
                                if (currentPartyMon != 2)
                                {
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                }
                                break;
                            case 3:
                                currentPartyMon = box5.enabled ? 5 :
                                    partyScreenReason is PartyScreenReason.SwitchingMove or PartyScreenReason.RevivalBlessing ? 3 : 0;
                                if (currentPartyMon != 3)
                                {
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                }
                                break;
                            case 4:
                                currentPartyMon = box6.enabled ? 6 :
                                    partyScreenReason is PartyScreenReason.SwitchingMove or PartyScreenReason.RevivalBlessing ? 4 : 0;
                                if (currentPartyMon != 4)
                                {
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                }
                                break;
                            case 5:
                                if (partyScreenReason is not PartyScreenReason.SwitchingMove or PartyScreenReason.RevivalBlessing)
                                {
                                    currentPartyMon = 0;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                }
                                break;
                            case 6:
                                if (partyScreenReason is not PartyScreenReason.SwitchingMove or PartyScreenReason.RevivalBlessing)
                                {
                                    currentPartyMon = 0;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        switch (currentPartyMon)
                        {
                            case 3:
                                currentPartyMon = 1;
                                battle.audioSource0.PlayOneShot(MoveCursor);
                                battle.audioSource0.panStereo = 0;
                                break;
                            case 4:
                                currentPartyMon = 2;
                                battle.audioSource0.PlayOneShot(MoveCursor);
                                battle.audioSource0.panStereo = 0;
                                break;
                            case 5:
                                currentPartyMon = 3;
                                battle.audioSource0.PlayOneShot(MoveCursor);
                                battle.audioSource0.panStereo = 0;
                                break;
                            case 6:
                                currentPartyMon = 4;
                                battle.audioSource0.PlayOneShot(MoveCursor);
                                battle.audioSource0.panStereo = 0;
                                break;
                            case 0:
                                currentPartyMon =
                                    box5.enabled ? 5 :
                                    box2.enabled ? 3 : 1;
                                battle.audioSource0.PlayOneShot(MoveCursor);
                                battle.audioSource0.panStereo = 0;
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        switch (currentPartyMon)
                        {
                            case 1:
                                if (box3.enabled)
                                {
                                    currentPartyMon = 2;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                }
                                break;
                            case 3:
                                currentPartyMon = box4.enabled ? 4 : 2;
                                battle.audioSource0.PlayOneShot(MoveCursor);
                                battle.audioSource0.panStereo = 0;
                                break;
                            case 5:
                                currentPartyMon = box6.enabled ? 6 : 4;
                                battle.audioSource0.PlayOneShot(MoveCursor);
                                battle.audioSource0.panStereo = 0;
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        switch (currentPartyMon)
                        {
                            case 2:
                                currentPartyMon = 1;
                                battle.audioSource0.PlayOneShot(MoveCursor);
                                battle.audioSource0.panStereo = 0;
                                break;
                            case 4:
                                currentPartyMon = 3;
                                battle.audioSource0.PlayOneShot(MoveCursor);
                                battle.audioSource0.panStereo = 0;
                                break;
                            case 6:
                                currentPartyMon = 5;
                                battle.audioSource0.PlayOneShot(MoveCursor);
                                battle.audioSource0.panStereo = 0;
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        battle.audioSource0.volume = 0.6F;
                        battle.audioSource0.PlayOneShot(Select);
                        battle.audioSource0.panStereo = 0;
                        if (partyScreenReason != PartyScreenReason.UsingItem)
                        {
                            switch (currentPartyMon)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                    if (partyScreenReason is PartyScreenReason.RevivalBlessing)
                                    {
                                        if (battle.playerPokemon[currentPartyMon - 1].fainted)
                                        {
                                            GoToAnnounce();
                                            battle.switchingTarget = currentPartyMon - 1;
                                            battle.choseSwitchMon = true;
                                        }
                                        else
                                        {
                                            StartCoroutine(AnnounceAndReturn($"{battle.playerPokemon[currentPartyMon - 1].MonName} hasn't fainted!"));
                                        }
                                    }
                                    else if (battle.playerPokemon[currentPartyMon - 1].fainted)
                                    {
                                        StartCoroutine(AnnounceAndReturn(
                                            battle.playerPokemon[currentPartyMon - 1].MonName
                                            + " has no energy to battle!"));
                                    }
                                    else if (battle.playerPokemon[currentPartyMon - 1].onField)
                                    {
                                        StartCoroutine(AnnounceAndReturn(
                                            battle.playerPokemon[currentPartyMon - 1].MonName
                                            + " is already on the field!"));
                                    }
                                    else if (partyScreenReason is PartyScreenReason.SwitchingMove)
                                    {
                                        GoToAnnounce();
                                        battle.switchingTarget = currentPartyMon - 1;
                                        battle.choseSwitchMon = true;
                                    }
                                    else if (battle.IsTrapped(currentMon))
                                    {
                                        StartCoroutine(AnnounceAndReturn(
                                            battle.PokemonOnField[currentMon].pokemon.MonName
                                            + " is trapped and cannot switch!"));
                                    }
                                    else
                                    {
                                        battle.PokemonOnField[currentMon].choseMove = true;
                                        battle.Moves[currentMon] = MoveID.Switch;
                                        battle.SwitchTargets[currentMon] = currentPartyMon - 1;
                                        if (GetNextPokemon())
                                        {
                                            menuMode = MenuMode.Main;
                                            GoToAnnounce();
                                            currentMove = 1;
                                            currentMon = 2;
                                            GetNextPokemon();
                                            battle.DoNextMove();
                                        }
                                        else
                                        {
                                            MainMenu();
                                            currentMove = 1;
                                        }
                                    }
                                    break;
                                case 0:
                                    MainMenu();
                                    battle.audioSource0.volume = 0.6F;
                                    battle.audioSource0.PlayOneShot(Select);
                                    battle.audioSource0.panStereo = 0;
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (currentPartyMon)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                    battle.audioSource0.volume = 0.6F;
                                    battle.audioSource0.PlayOneShot(Select);
                                    battle.audioSource0.panStereo = 0;
                                    battle.PokemonOnField[currentMon].choseMove = true;
                                    battle.Moves[currentMon] = MoveID.UseItem;
                                    battle.itemToUse[currentMon] = cachedItem;
                                    battle.itemTarget[currentMon] = currentPartyMon - 1;
                                    if (GetNextPokemon())
                                    {
                                        menuMode = MenuMode.Main;
                                        GoToAnnounce();
                                        currentMove = 1;
                                        currentMon = 2;
                                        GetNextPokemon();
                                        battle.DoNextMove();
                                    }
                                    else
                                    {
                                        MainMenu();
                                        currentMove = 1;
                                    }
                                    break;
                                case 0:
                                    ItemSubmenu(cachedSubset, cachedItemPosition);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.S))
                    {
                        Debug.Log("S");
                        if (currentMon is > 0 and <= 6)
                        {
                            battle.audioSource0.PlayOneShot(Resources.Load<AudioClip>("Sound/Battle SFX/Select Move"));
                            battle.StartCoroutine(SummaryScreen.Create(battle.player, currentPartyMon - 1, battle));
                        }
                    }
                    break;
                case MenuMode.ItemCategories:
                    selector1.enabled = currentMove == 1;
                    selector2.enabled = currentMove == 2;
                    selector3.enabled = currentMove == 3;
                    selector4.enabled = currentMove == 4;
                    selector5.enabled = currentMove == 0;
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        switch (currentMove)
                        {
                            case 1:
                                ChangeSelection(2);
                                break;
                            case 3:
                                ChangeSelection(4);
                                break;
                            case 2:
                            case 4:
                                ChangeSelection(0);
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        switch (currentMove)
                        {
                            case 0:
                                ChangeSelection(2);
                                break;
                            case 2:
                                ChangeSelection(1);
                                break;
                            case 4:
                                ChangeSelection(3);
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        switch (currentMove)
                        {
                            case 1:
                                ChangeSelection(3);
                                break;
                            case 2:
                                ChangeSelection(4);
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        switch (currentMove)
                        {
                            case 3:
                                ChangeSelection(1);
                                break;
                            case 4:
                                ChangeSelection(2);
                                break;
                            default:
                                break;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        switch (currentMove)
                        {
                            case 0:
                                currentMove = 3;
                                battle.audioSource0.PlayOneShot(Select);
                                MainMenu();
                                break;
                            case 1:
                                ItemSubmenu(ItemSubset.Medicine);
                                battle.audioSource0.PlayOneShot(Select);
                                break;
                            case 2:
                                ItemSubmenu(ItemSubset.PokeBalls);
                                battle.audioSource0.PlayOneShot(Select);
                                break;
                            case 3:
                                ItemSubmenu(ItemSubset.Berries);
                                battle.audioSource0.PlayOneShot(Select);
                                break;
                            case 4:
                                ItemSubmenu(ItemSubset.BattleItems);
                                battle.audioSource0.PlayOneShot(Select);
                                break;
                        }
                    }
                    break;
                case MenuMode.Items:
                    selector1.enabled = currentMove == 1;
                    selector2.enabled = currentMove == 2;
                    selector3.enabled = currentMove == 3;
                    selector4.enabled = currentMove == 4;
                    selector5.enabled = currentMove == 0;

                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        if (currentMove > 2)
                        {
                            battle.audioSource0.PlayOneShot(MoveCursor);
                            currentMove -= 2;
                        }
                        else if (currentItemPosition > 1)
                        {
                            battle.audioSource0.PlayOneShot(MoveCursor);
                            currentItemPosition -= 2;
                            UpdateItemSubmenu();
                        }
                    }
                    else if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        if (currentMove < 3)
                        {
                            if (currentMove is 1 or 2 && currentItemPosition + currentMove + 2 < cachedItemCount)
                            {
                                battle.audioSource0.PlayOneShot(MoveCursor);
                                currentMove += 2;
                            }
                        }
                        else if (currentItemPosition + 4 < cachedItemCount)
                        {
                            battle.audioSource0.PlayOneShot(MoveCursor);
                            currentItemPosition += 2;
                            UpdateItemSubmenu();
                        }
                    }
                    else if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        switch (currentMove)
                        {
                            case 0:
                                if (box2.enabled) ChangeSelection(2);
                                else if (box1.enabled) ChangeSelection(1);
                                break;
                            case 2:
                                ChangeSelection(1);
                                break;
                            case 4:
                                ChangeSelection(3);
                                break;
                            default: break;
                        }
                    }
                    else if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        switch (currentMove)
                        {
                            case 1:
                                if (box2.enabled) ChangeSelection(2);
                                else ChangeSelection(0);
                                break;
                            case 2:
                                ChangeSelection(0);
                                break;
                            case 3:
                                if (box4.enabled) ChangeSelection(4);
                                else ChangeSelection(0);
                                break;
                            case 4:
                                ChangeSelection(0);
                                break;
                        }
                    }
                    else if (Input.GetKeyDown(KeyCode.Return))
                    {
                        switch (currentMove)
                        {
                            case 0:
                                battle.audioSource0.PlayOneShot(Select);
                                ItemCategoryMenu();
                                break;
                            default:
                                cachedItem = cachedItems[currentItemPosition + currentMove - 1];
                                cachedItemPosition = currentItemPosition;
                                switch (cachedItem.Data().type)
                                {
                                    case ItemType.PokeBall:
                                        battle.Moves[currentMon] = MoveID.UseItem;
                                        battle.itemToUse[currentMon] = cachedItem;
                                        battle.PokemonOnField[currentMon].choseMove = true;
                                        if (GetNextPokemon())
                                        {
                                            menuMode = MenuMode.Main;
                                            GoToAnnounce();
                                            currentMove = 1;
                                            currentMon = 2;
                                            GetNextPokemon();
                                            battle.DoNextMove();
                                        }
                                        else
                                        {
                                            megaEvolving = false;
                                            MainMenu();
                                            currentMove = 1;
                                        }
                                        return;
                                    case ItemType.Medicine:
                                    case ItemType.BattleItem:
                                    case ItemType.Berry:
                                        PartyMenu(PartyScreenReason.UsingItem);
                                        return;
                                }
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
