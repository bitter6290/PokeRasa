using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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

    private AudioClip SelectMove;
    private AudioClip MoveCursor;


    [SerializeField] private Battle battle;

    [SerializeField] private int currentMon = 3;
    [SerializeField] private int currentMove = 1; //0 means Back

    public int currentPartyMon = 1; //0 means Back

    public bool megaEvolving;

    public MenuMode menuMode;

    private BattlePokemon mon;

    private static Color transparent = new(0, 0, 0, 0);

    private static Color moveColor = new(88.0F / 255.0F, 146.0F / 255.0F, 232.0F / 255.0F);
    private static Color struggleColor = new(160.0F / 255.0F, 200.0F / 255.0F, 245.0F / 255.0F);
    private static Color bagColor = new(80.0F / 255.0F, 179.0F / 255.0F, 95.0F / 255.0F);
    private static Color switchColor = new(196.0F / 255.0F, 168.0F / 255.0F, 8.0F / 255.0F);
    private static Color runColor = new(1, 64.0F / 255.0F, 64.0F / 255.0F);

    private static Color megaNoColor = new(220.0F / 255.0F, 239.0F / 255.0F, 1);
    private static Color megaYesColor = new(0, 137.0F / 255.0F, 1);

    private static Color partyOK = new(25.0F / 255.0F, 25.0F / 255.0F, 128.0F / 255.0F);
    private static Color partyFainted = new(128.0F / 255.0F, 25.0F / 255.0F, 25.0F / 255.0F);

    private static Color backColor = new(240F / 255F, 160F / 255F, 160F / 255F);
    private static Color partyColor = new(240F / 255F, 240F / 255F, 240F / 255F);

    private void _()
    {

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

    private IEnumerator MoveNoPP(int currentMon, int currentMove)
    {
        yield return battle.Announce(Move.MoveTable[(int)battle.PokemonOnField[currentMon].GetMove(currentMove - 1)].name + BattleText.NoPP);
        battle.state = BattleState.PlayerInput;
    }

    private IEnumerator MoveDisabled(int currentMon, int currentMove)
    {
        yield return battle.Announce(battle.MonNameWithPrefix(currentMon, true) + "'s "
            + Move.MoveTable[(int)battle.PokemonOnField[currentMon].GetMove(currentMove - 1)].name
            + " is disabled!");
        battle.state = BattleState.PlayerInput;
    }

    private IEnumerator MoveEncored(int currentMon)
    {
        yield return battle.Announce(battle.MonNameWithPrefix(currentMon, true)
            + " can only use "
            + Move.MoveTable[(int)battle.PokemonOnField[currentMon].encoredMove].name
            + "!");
        battle.state = BattleState.PlayerInput;
    }

    private IEnumerator MonTormented(int currentMon)
    {
        yield return battle.Announce(battle.MonNameWithPrefix(currentMon, true)
            + " can't use the same move again because of the torment!");
        battle.state = BattleState.PlayerInput;
    }

    private IEnumerator MonFainted(int currentMon)
    {
        yield return battle.Announce(battle.PlayerPokemon[currentMon].monName
            + " has no energy to battle!");
        battle.state = BattleState.PlayerInput;
    }

    private IEnumerator MonOnField(int currentMon)
    {
        yield return battle.Announce(battle.PlayerPokemon[currentMon].monName
            + " is already on the field!");
        battle.state = BattleState.PlayerInput;
    }

    private IEnumerator MonTrapped(int currentMon)
    {
        yield return battle.Announce(battle.PokemonOnField[currentMon].PokemonData.monName
            + " is trapped and cannot switch!");
        battle.state = BattleState.PlayerInput;
    }

    private string LeadingZero(string input)
    {
        return input.Length == 1 ? "0" + input : input;
    }

    private Color partyMonColor(int index)
    {
        return battle.PlayerPokemon[index].fainted ? partyFainted : partyOK;
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

        menuMode = MenuMode.Main;
        currentMon = 3;
        SelectMove = Resources.Load<AudioClip>("Sound/Battle SFX/Select Move");
        MoveCursor = Resources.Load<AudioClip>("Sound/Battle SFX/Move Cursor");
    }

    // Update is called once per frame
    public void Update()
    {
        switch (battle.state)
        {
            case BattleState.PlayerInput:
                announce.enabled = false;
                switch (menuMode)
                {
                    case MenuMode.Moves:
                        mon = battle.PokemonOnField[currentMon];
                        box1.color = TypeUtils.typeColor[(int)mon.GetMove(0).Data().type];
                        box2.color = mon.GetMove(1) == MoveID.None
                            ? transparent : TypeUtils.typeColor[(int)mon.GetMove(1).Data().type];
                        box3.color = mon.GetMove(2) == MoveID.None
                            ? transparent : TypeUtils.typeColor[(int)mon.GetMove(2).Data().type];
                        box4.color = mon.GetMove(3) == MoveID.None
                            ? transparent : TypeUtils.typeColor[(int)mon.GetMove(3).Data().type];
                        box5.color = backColor;

                        text1.text = mon.GetMove(0).Data().name;
                        text2.text = mon.GetMove(1).Data().name;
                        text3.text = mon.GetMove(2).Data().name;
                        text4.text = mon.GetMove(3).Data().name;

                        pp1.text = LeadingZero(mon.GetPP(0).ToString()) + " / " +
                            LeadingZero(mon.GetMaxPP(0).ToString());
                        pp2.text = LeadingZero(mon.GetPP(1).ToString()) + " / " +
                            LeadingZero(mon.GetMaxPP(1).ToString());
                        pp3.text = LeadingZero(mon.GetPP(2).ToString()) + " / " +
                            LeadingZero(mon.GetMaxPP(2).ToString());
                        pp4.text = LeadingZero(mon.GetPP(3).ToString()) + " / " +
                            LeadingZero(mon.GetMaxPP(3).ToString());

                        box1.enabled = !(mon.GetMove(0) == MoveID.None);
                        box2.enabled = !(mon.GetMove(1) == MoveID.None);
                        box3.enabled = !(mon.GetMove(2) == MoveID.None);
                        box4.enabled = !(mon.GetMove(3) == MoveID.None);
                        text1.enabled = !(mon.GetMove(0) == MoveID.None);
                        text2.enabled = !(mon.GetMove(1) == MoveID.None);
                        text3.enabled = !(mon.GetMove(2) == MoveID.None);
                        text4.enabled = !(mon.GetMove(3) == MoveID.None);
                        pp1.enabled = !(mon.GetMove(0) == MoveID.None);
                        pp2.enabled = !(mon.GetMove(1) == MoveID.None);
                        pp3.enabled = !(mon.GetMove(2) == MoveID.None);
                        pp4.enabled = !(mon.GetMove(3) == MoveID.None);

                        text5.enabled = true;
                        box5.enabled = true;
                        text5.text = "Back";

                        text7.enabled = false;
                        box6.enabled = false;
                        box7.enabled = false;

                        selector1.enabled = currentMove == 1;
                        selector2.enabled = currentMove == 2;
                        selector3.enabled = currentMove == 3;
                        selector4.enabled = currentMove == 4;
                        selector5.enabled = currentMove == 0;
                        selector6.enabled = false;
                        selector7.enabled = false;

                        partyText1.enabled = false;
                        partyText2.enabled = false;
                        partyText3.enabled = false;
                        partyText4.enabled = false;
                        partyText5.enabled = false;
                        partyText6.enabled = false;

                        partyMon1.enabled = false;
                        partyMon2.enabled = false;
                        partyMon3.enabled = false;
                        partyMon4.enabled = false;
                        partyMon5.enabled = false;
                        partyMon6.enabled = false;


                        if (battle.CanMegaEvolve(currentMon))
                        {
                            megaIndicator.SetActive(true);
                            if (Input.GetKeyDown(KeyCode.M))
                            {
                                megaEvolving = !megaEvolving;
                                battle.megaEvolveOnMove[currentMon] = megaEvolving;
                                battle.audioSource0.PlayOneShot(SelectMove);
                                battle.audioSource0.panStereo = 0;
                            }
                            megaIndicator.GetComponent<SpriteRenderer>().color = megaEvolving ? megaYesColor : megaNoColor;
                        }
                        else
                        {
                            megaIndicator.SetActive(false);
                        }

                        if (Input.GetKeyDown(KeyCode.RightArrow))
                        {
                            switch (currentMove)
                            {
                                case 1:
                                    currentMove = mon.GetMove(1) == MoveID.None ? 0 : 2;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                    break;
                                case 2:
                                    currentMove = 0;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                    break;
                                case 3:
                                    if (mon.GetMove(3) != MoveID.None)
                                    {
                                        currentMove = 4;
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
                            switch (currentMove)
                            {
                                case 0:
                                    currentMove = mon.GetMove(1) == MoveID.None ? 1 : 2;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                    break;
                                case 2:
                                    currentMove = 1;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                    break;
                                case 4:
                                    currentMove = 3;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
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
                                    if (mon.GetMove(2) != MoveID.None)
                                    {
                                        currentMove = 3;
                                        battle.audioSource0.PlayOneShot(MoveCursor);
                                        battle.audioSource0.panStereo = 0;
                                    }
                                    break;
                                case 2:
                                    if (mon.GetMove(3) != MoveID.None)
                                    {
                                        currentMove = 4;
                                        battle.audioSource0.PlayOneShot(MoveCursor);
                                        battle.audioSource0.panStereo = 0;
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
                                    currentMove = 1;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                    break;
                                case 4:
                                    currentMove = 2;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (Input.GetKeyDown(KeyCode.Return))
                        {
                            battle.audioSource0.PlayOneShot(SelectMove);
                            battle.audioSource0.panStereo = 0;
                            switch (currentMove)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                    switch (mon.CanUseMove(currentMove - 1))
                                    {
                                        case MoveSelectOutcome.LowPP:
                                            battle.state = BattleState.Announcement;
                                            StartCoroutine(MoveNoPP(currentMon, currentMove - 1));
                                            break;
                                        case MoveSelectOutcome.Encored:
                                            battle.state = BattleState.Announcement;
                                            StartCoroutine(MoveEncored(currentMon));
                                            break;
                                        case MoveSelectOutcome.Disabled:
                                            battle.state = BattleState.Announcement;
                                            StartCoroutine(MoveDisabled(currentMon, currentMove - 1));
                                            break;
                                        case MoveSelectOutcome.Tormented:
                                            battle.state = BattleState.Announcement;
                                            StartCoroutine(MonTormented(currentMon));
                                            break;
                                        case MoveSelectOutcome.Success:
                                            if (battle.TryAddMove(currentMon, currentMove))
                                            {
                                                mon.choseMove = true;
                                                switch (battle.battleType)
                                                {
                                                    case BattleType.Single:
                                                        battle.Targets[currentMon] = 0;
                                                        break;
                                                }
                                                if (GetNextPokemon())
                                                {
                                                    battle.state = BattleState.Announcement;
                                                    menuMode = MenuMode.Main;
                                                    currentMove = 1;
                                                    currentMon = 2;
                                                    GetNextPokemon();
                                                    battle.DoNextMove();
                                                }
                                                else
                                                {
                                                    menuMode = MenuMode.Main;
                                                    currentMove = 1;

                                                }
                                            }
                                            else
                                            {
                                                battle.state = BattleState.Announcement;
                                                StartCoroutine(MoveNoPP(currentMon, currentMove));
                                            }
                                            break;
                                    }
                                    break;
                                case 0:
                                    currentMove = 1;
                                    menuMode = MenuMode.Main;
                                    break;
                            }
                        }
                        break;
                    case MenuMode.Main:
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
                        box7.enabled = false;

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

                        partyText1.enabled = false;
                        partyText2.enabled = false;
                        partyText3.enabled = false;
                        partyText4.enabled = false;
                        partyText5.enabled = false;
                        partyText6.enabled = false;

                        partyMon1.enabled = false;
                        partyMon2.enabled = false;
                        partyMon3.enabled = false;
                        partyMon4.enabled = false;
                        partyMon5.enabled = false;
                        partyMon6.enabled = false;

                        megaIndicator.SetActive(false);

                        if (Input.GetKeyDown(KeyCode.RightArrow))
                        {
                            switch (currentMove)
                            {
                                case 1:
                                    currentMove = 2;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                    break;
                                case 3:
                                    currentMove = 4;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
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
                                    currentMove = 1;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                    break;
                                case 4:
                                    currentMove = 3;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
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
                                    currentMove = 3;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                    break;
                                case 2:
                                    currentMove = 4;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
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
                                    currentMove = 1;
                                    battle.audioSource0.PlayOneShot(MoveCursor);
                                    battle.audioSource0.panStereo = 0;
                                    break;
                                case 4:
                                    currentMove = 2;
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
                            battle.audioSource0.PlayOneShot(SelectMove);
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
                                            case BattleType.Single:
                                                battle.Targets[currentMon] = 0;
                                                break;
                                        }
                                        if (GetNextPokemon())
                                        {
                                            battle.state = BattleState.Announcement;
                                            menuMode = MenuMode.Main;
                                            currentMove = 1;
                                            currentMon = 2;
                                            GetNextPokemon();
                                            battle.DoNextMove();
                                        }
                                        else
                                        {
                                            menuMode = MenuMode.Main;
                                            currentMove = 1;
                                        }
                                    }
                                    else
                                    {
                                        menuMode = MenuMode.Moves;
                                    }
                                    break;
                                case 3:
                                    battle.switchDuringTurn = false;
                                    currentPartyMon = 1;
                                    menuMode = MenuMode.Party;
                                    break;
                                default:
                                    break;

                            }
                        }
                        break;
                    case MenuMode.Party:
                        announce.enabled = false;

                        box1.enabled = battle.PlayerPokemon[0].exists;
                        box2.enabled = battle.PlayerPokemon[2].exists;
                        box3.enabled = battle.PlayerPokemon[1].exists;
                        box4.enabled = battle.PlayerPokemon[3].exists;
                        box5.enabled = battle.PlayerPokemon[4].exists;
                        box6.enabled = battle.PlayerPokemon[5].exists;
                        box7.enabled = !battle.switchDuringTurn;

                        box1.color = partyMonColor(0);
                        box2.color = partyMonColor(2);
                        box3.color = partyMonColor(1);
                        box4.color = partyMonColor(3);
                        box5.color = partyMonColor(4);
                        box6.color = partyMonColor(5);
                        box7.color = backColor;

                        text1.enabled = false;
                        text2.enabled = false;
                        text3.enabled = false;
                        text4.enabled = false;
                        text5.enabled = false;
                        text7.enabled = !battle.switchDuringTurn;

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

                        partyText1.enabled = battle.PlayerPokemon[0].exists;
                        partyText2.enabled = battle.PlayerPokemon[2].exists;
                        partyText3.enabled = battle.PlayerPokemon[1].exists;
                        partyText4.enabled = battle.PlayerPokemon[3].exists;
                        partyText5.enabled = battle.PlayerPokemon[4].exists;
                        partyText6.enabled = battle.PlayerPokemon[5].exists;

                        partyText1.text = battle.PlayerPokemon[0].monName;
                        partyText2.text = battle.PlayerPokemon[2].monName;
                        partyText3.text = battle.PlayerPokemon[1].monName;
                        partyText4.text = battle.PlayerPokemon[3].monName;
                        partyText5.text = battle.PlayerPokemon[4].monName;
                        partyText6.text = battle.PlayerPokemon[5].monName;

                        partyMon1.enabled = battle.PlayerPokemon[0].exists;
                        partyMon2.enabled = battle.PlayerPokemon[2].exists;
                        partyMon3.enabled = battle.PlayerPokemon[1].exists;
                        partyMon4.enabled = battle.PlayerPokemon[3].exists;
                        partyMon5.enabled = battle.PlayerPokemon[4].exists;
                        partyMon6.enabled = battle.PlayerPokemon[5].exists;

                        partyMon1.sprite = battle.playerMonIcons[0];
                        partyMon2.sprite = battle.playerMonIcons[2];
                        partyMon3.sprite = battle.playerMonIcons[1];
                        partyMon4.sprite = battle.playerMonIcons[3];
                        partyMon5.sprite = battle.playerMonIcons[4];
                        partyMon6.sprite = battle.playerMonIcons[5];

                        megaIndicator.SetActive(false);

                        if (Input.GetKeyDown(KeyCode.RightArrow))
                        {
                            switch (currentPartyMon)
                            {
                                case 1:
                                    currentPartyMon = box2.enabled ? 3 :
                                        battle.switchDuringTurn ? 1 : 0;
                                    if (currentPartyMon != 1)
                                    {
                                        battle.audioSource0.PlayOneShot(MoveCursor);
                                        battle.audioSource0.panStereo = 0;
                                    }
                                    break;
                                case 2:
                                    currentPartyMon = box4.enabled ? 4 :
                                        battle.switchDuringTurn ? 2 : 0;
                                    if (currentPartyMon != 2)
                                    {
                                        battle.audioSource0.PlayOneShot(MoveCursor);
                                        battle.audioSource0.panStereo = 0;
                                    }
                                    break;
                                case 3:
                                    currentPartyMon = box5.enabled ? 5 :
                                        battle.switchDuringTurn ? 3 : 0;
                                    if (currentPartyMon != 3)
                                    {
                                        battle.audioSource0.PlayOneShot(MoveCursor);
                                        battle.audioSource0.panStereo = 0;
                                    }
                                    break;
                                case 4:
                                    currentPartyMon = box6.enabled ? 6 :
                                        battle.switchDuringTurn ? 4 : 0;
                                    if (currentPartyMon != 4)
                                    {
                                        battle.audioSource0.PlayOneShot(MoveCursor);
                                        battle.audioSource0.panStereo = 0;
                                    }
                                    break;
                                case 5:
                                    if (!battle.switchDuringTurn)
                                    {
                                        currentPartyMon = 0;
                                        battle.audioSource0.PlayOneShot(MoveCursor);
                                        battle.audioSource0.panStereo = 0;
                                    }
                                    break;
                                case 6:
                                    if (!battle.switchDuringTurn)
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
                            battle.audioSource0.PlayOneShot(SelectMove);
                            battle.audioSource0.panStereo = 0;
                            switch (currentPartyMon)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                    if (battle.PlayerPokemon[currentPartyMon - 1].fainted)
                                    {
                                        battle.state = BattleState.Announcement;
                                        StartCoroutine(MonFainted(currentPartyMon - 1));
                                    }
                                    else if (battle.PlayerPokemon[currentPartyMon - 1].onField)
                                    {
                                        battle.state = BattleState.Announcement;
                                        StartCoroutine(MonOnField(currentPartyMon - 1));
                                    }
                                    else if (battle.AbilityOnSide(Ability.ShadowTag, 0)
                                        || (battle.AbilityOnSide(Ability.ArenaTrap, 0)
                                        && battle.IsGrounded(currentMon))
                                        || battle.PokemonOnField[currentMon].trapped
                                        || battle.PokemonOnField[currentMon].getsContinuousDamage)
                                    {
                                        battle.state = BattleState.Announcement;
                                        StartCoroutine(MonTrapped(currentMon));
                                    }
                                    else
                                    {
                                        if (battle.switchDuringTurn)
                                        {
                                            battle.state = BattleState.Announcement;
                                            battle.switchingTarget = currentPartyMon - 1;
                                            battle.choseSwitchMon = true;
                                        }
                                        else
                                        {
                                            battle.PokemonOnField[currentMon].choseMove = true;
                                            battle.Moves[currentMon] = MoveID.Switch;
                                            battle.SwitchTargets[currentMon] = currentPartyMon - 1;
                                            if (GetNextPokemon())
                                            {
                                                battle.state = BattleState.Announcement;
                                                menuMode = MenuMode.Main;
                                                currentMove = 1;
                                                currentMon = 2;
                                                GetNextPokemon();
                                                battle.DoNextMove();
                                            }
                                            else
                                            {
                                                menuMode = MenuMode.Main;
                                                currentMove = 1;
                                            }
                                        }
                                    }
                                    break;
                                case 0:
                                    menuMode = MenuMode.Main;
                                    battle.audioSource0.volume = 0.6F;
                                    battle.audioSource0.PlayOneShot(SelectMove);
                                    battle.audioSource0.panStereo = 0;
                                    break;
                                default:
                                    break;

                            }
                        }
                        break;
                }
                break;
            case BattleState.Announcement:
                announce.enabled = true;
                box1.enabled = false;
                box2.enabled = false;
                box3.enabled = false;
                box4.enabled = false;
                box5.enabled = false;
                box6.enabled = false;
                box7.enabled = false;
                text1.enabled = false;
                text2.enabled = false;
                text3.enabled = false;
                text4.enabled = false;
                text5.enabled = false;
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
                partyText1.enabled = false;
                partyText2.enabled = false;
                partyText3.enabled = false;
                partyText4.enabled = false;
                partyText5.enabled = false;
                partyText6.enabled = false;
                partyMon1.enabled = false;
                partyMon2.enabled = false;
                partyMon3.enabled = false;
                partyMon4.enabled = false;
                partyMon5.enabled = false;
                partyMon6.enabled = false;
                megaIndicator.SetActive(false);
                break;
        }
    }
}
