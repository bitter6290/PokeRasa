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

    [SerializeField] private TextMeshProUGUI text1;
    [SerializeField] private TextMeshProUGUI text2;
    [SerializeField] private TextMeshProUGUI text3;
    [SerializeField] private TextMeshProUGUI text4;
    [SerializeField] private TextMeshProUGUI text5;

    [SerializeField] private TextMeshProUGUI pp1;
    [SerializeField] private TextMeshProUGUI pp2;
    [SerializeField] private TextMeshProUGUI pp3;
    [SerializeField] private TextMeshProUGUI pp4;


    [SerializeField] private SpriteRenderer selector1;
    [SerializeField] private SpriteRenderer selector2;
    [SerializeField] private SpriteRenderer selector3;
    [SerializeField] private SpriteRenderer selector4;
    [SerializeField] private SpriteRenderer selector5;

    [SerializeField] private TextMeshProUGUI announce;

    [SerializeField] private GameObject megaIndicator;

    private AudioClip SelectMove;
    private AudioClip MoveCursor;


    [SerializeField] private Battle battle;

    [SerializeField] private int currentMon = 3;
    [SerializeField] private int currentMove = 1; //0 means Back

    private bool megaEvolving;

    private int menuMode;

    private static Color moveColor = new(88.0F / 255.0F, 146.0F / 255.0F, 232.0F / 255.0F);
    private static Color struggleColor = new(160.0F / 255.0F, 200.0F / 255.0F, 245.0F / 255.0F);
    private static Color bagColor = new(80.0F / 255.0F, 179.0F / 255.0F, 95.0F / 255.0F);
    private static Color switchColor = new(196.0F / 255.0F, 168.0F / 255.0F, 8.0F / 255.0F);
    private static Color runColor = new(1, 64.0F / 255.0F, 64.0F / 255.0F);

    private static Color megaNoColor = new(220.0F / 255.0F, 239.0F / 255.0F, 1);
    private static Color megaYesColor = new(0, 137.0F / 255.0F, 1);

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
        yield return Battle.Announce(Move.MoveTable[battle.PokemonOnField[currentMon].GetMove(currentMove)].name + BattleText.NoPP, battle);
        battle.state = BattleState.PlayerInput;
    }

    private string LeadingZero(string input)
    {
        return input.Length == 1 ? "0" + input : input;
    }

    // Start is called before the first frame update
    void Start()
    {
        box5.color = new Color(240F / 255F, 160F / 255F, 160F / 255F);
        menuMode = MenuMode.Main;
        currentMon = 3;
        SelectMove = Resources.Load<AudioClip>("Sound/Battle SFX/Select Move");
        MoveCursor = Resources.Load<AudioClip>("Sound/Battle SFX/Move Cursor");
    }

    // Update is called once per frame
    void Update()
    {
        switch (battle.state) {
            case BattleState.PlayerInput:
                announce.enabled = false;
                switch (menuMode)
                {
                    case MenuMode.Moves:
                        box1.color = Type.typeColor[Move.MoveTable[battle.PokemonOnField[currentMon].PokemonData.move1].type];
                        box2.color = Type.typeColor[Move.MoveTable[battle.PokemonOnField[currentMon].PokemonData.move2].type];
                        box3.color = Type.typeColor[Move.MoveTable[battle.PokemonOnField[currentMon].PokemonData.move3].type];
                        box4.color = Type.typeColor[Move.MoveTable[battle.PokemonOnField[currentMon].PokemonData.move4].type];

                        text1.text = Move.MoveTable[battle.PokemonOnField[currentMon].PokemonData.move1].name;
                        text2.text = Move.MoveTable[battle.PokemonOnField[currentMon].PokemonData.move2].name;
                        text3.text = Move.MoveTable[battle.PokemonOnField[currentMon].PokemonData.move3].name;
                        text4.text = Move.MoveTable[battle.PokemonOnField[currentMon].PokemonData.move4].name;

                        pp1.text = LeadingZero(battle.PokemonOnField[currentMon].PokemonData.pp1.ToString()) + " / " +
                            LeadingZero(battle.PokemonOnField[currentMon].PokemonData.maxPp1.ToString());
                        pp2.text = LeadingZero(battle.PokemonOnField[currentMon].PokemonData.pp2.ToString()) + " / " +
                            LeadingZero(battle.PokemonOnField[currentMon].PokemonData.maxPp2.ToString());
                        pp3.text = LeadingZero(battle.PokemonOnField[currentMon].PokemonData.pp3.ToString()) + " / " +
                            LeadingZero(battle.PokemonOnField[currentMon].PokemonData.maxPp3.ToString());
                        pp4.text = LeadingZero(battle.PokemonOnField[currentMon].PokemonData.pp4.ToString()) + " / " +
                            LeadingZero(battle.PokemonOnField[currentMon].PokemonData.maxPp4.ToString());

                        box1.enabled = !(battle.PokemonOnField[currentMon].PokemonData.move1 == MoveID.None);
                        box2.enabled = !(battle.PokemonOnField[currentMon].PokemonData.move2 == MoveID.None);
                        box3.enabled = !(battle.PokemonOnField[currentMon].PokemonData.move3 == MoveID.None);
                        box4.enabled = !(battle.PokemonOnField[currentMon].PokemonData.move4 == MoveID.None);
                        text1.enabled = !(battle.PokemonOnField[currentMon].PokemonData.move1 == MoveID.None);
                        text2.enabled = !(battle.PokemonOnField[currentMon].PokemonData.move2 == MoveID.None);
                        text3.enabled = !(battle.PokemonOnField[currentMon].PokemonData.move3 == MoveID.None);
                        text4.enabled = !(battle.PokemonOnField[currentMon].PokemonData.move4 == MoveID.None);
                        pp1.enabled = !(battle.PokemonOnField[currentMon].PokemonData.move1 == MoveID.None);
                        pp2.enabled = !(battle.PokemonOnField[currentMon].PokemonData.move2 == MoveID.None);
                        pp3.enabled = !(battle.PokemonOnField[currentMon].PokemonData.move3 == MoveID.None);
                        pp4.enabled = !(battle.PokemonOnField[currentMon].PokemonData.move4 == MoveID.None);

                        text5.enabled = true;
                        box5.enabled = true;
                        text5.text = "Back";

                        selector1.enabled = currentMove == 1;
                        selector2.enabled = currentMove == 2;
                        selector3.enabled = currentMove == 3;
                        selector4.enabled = currentMove == 4;
                        selector5.enabled = currentMove == 0;


                        if (battle.CanMegaEvolve(currentMon))
                        {
                            megaIndicator.SetActive(true);
                            if (Input.GetKeyDown(KeyCode.M))
                            {
                                megaEvolving = !megaEvolving;
                                battle.audioSource.PlayOneShot(SelectMove);
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
                                    currentMove = battle.PokemonOnField[currentMon].PokemonData.move2 == MoveID.None ? 0 : 2;
                                    battle.audioSource.PlayOneShot(MoveCursor);
                                    break;
                                case 2:
                                    currentMove = 0;
                                    battle.audioSource.PlayOneShot(MoveCursor);
                                    break;
                                case 3:
                                    if (battle.PokemonOnField[currentMon].PokemonData.move4 != MoveID.None)
                                    {
                                        currentMove = 4;
                                        battle.audioSource.PlayOneShot(MoveCursor);
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
                                    currentMove = battle.PokemonOnField[currentMon].PokemonData.move2 == MoveID.None ? 1 : 2;
                                    battle.audioSource.PlayOneShot(MoveCursor);
                                    break;
                                case 2:
                                    currentMove = 1;
                                    battle.audioSource.PlayOneShot(MoveCursor);
                                    break;
                                case 4:
                                    currentMove = 3;
                                    battle.audioSource.PlayOneShot(MoveCursor);
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
                                    if (battle.PokemonOnField[currentMon].PokemonData.move3 != MoveID.None)
                                    {
                                        currentMove = 3;
                                        battle.audioSource.PlayOneShot(MoveCursor);
                                    }
                                    break;
                                case 2:
                                    if (battle.PokemonOnField[currentMon].PokemonData.move4 != MoveID.None)
                                    {
                                        currentMove = 4;
                                        battle.audioSource.PlayOneShot(MoveCursor);
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
                                    battle.audioSource.PlayOneShot(MoveCursor);
                                    break;
                                case 4:
                                    currentMove = 2;
                                    battle.audioSource.PlayOneShot(MoveCursor);
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (Input.GetKeyDown(KeyCode.Return))
                        {
                            battle.audioSource.PlayOneShot(SelectMove);
                            switch (currentMove)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                    if (battle.TryAddMove(currentMon, currentMove))
                                    {
                                        battle.PokemonOnField[currentMon].choseMove = true;
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
                                case 0:
                                    currentMove = 1;
                                    menuMode = MenuMode.Main;
                                    break;
                            }
                        }
                        break;
                    case MenuMode.Main:
                        box1.color = battle.PokemonOnField[currentMon].PokemonData.pp1
                            + battle.PokemonOnField[currentMon].PokemonData.pp2
                            + battle.PokemonOnField[currentMon].PokemonData.pp3
                            + battle.PokemonOnField[currentMon].PokemonData.pp4 == 0 ? struggleColor : moveColor;
                        box2.color = bagColor;
                        box3.color = switchColor;
                        box4.color = runColor;

                        box1.enabled = true;
                        box2.enabled = true;
                        box3.enabled = true;
                        box4.enabled = true;
                        box5.enabled = false;

                        text1.text = battle.PokemonOnField[currentMon].PokemonData.pp1
                            + battle.PokemonOnField[currentMon].PokemonData.pp2
                            + battle.PokemonOnField[currentMon].PokemonData.pp3
                            + battle.PokemonOnField[currentMon].PokemonData.pp4 == 0 ? "Struggle" : "Moves";
                        text2.text = "Bag";
                        text3.text = "Switch";
                        text4.text = "Run";

                        text1.enabled = true;
                        text2.enabled = true;
                        text3.enabled = true;
                        text4.enabled = true;
                        text5.enabled = false;

                        pp1.enabled = false;
                        pp2.enabled = false;
                        pp3.enabled = false;
                        pp4.enabled = false;

                        selector1.enabled = currentMove == 1;
                        selector2.enabled = currentMove == 2;
                        selector3.enabled = currentMove == 3;
                        selector4.enabled = currentMove == 4;
                        selector5.enabled = currentMove == 0;

                        megaIndicator.SetActive(false);

                        if (Input.GetKeyDown(KeyCode.RightArrow))
                        {
                            switch (currentMove)
                            {
                                case 1:
                                    currentMove = 2;
                                    battle.audioSource.PlayOneShot(MoveCursor);
                                    break;
                                case 3:
                                    currentMove = 4;
                                    battle.audioSource.PlayOneShot(MoveCursor);
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
                                    battle.audioSource.PlayOneShot(MoveCursor);
                                    break;
                                case 4:
                                    currentMove = 3;
                                    battle.audioSource.PlayOneShot(MoveCursor);
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
                                    battle.audioSource.PlayOneShot(MoveCursor);
                                    break;
                                case 2:
                                    currentMove = 4;
                                    battle.audioSource.PlayOneShot(MoveCursor);
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
                                    battle.audioSource.PlayOneShot(MoveCursor);
                                    break;
                                case 4:
                                    currentMove = 2;
                                    battle.audioSource.PlayOneShot(MoveCursor);
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (Input.GetKeyDown(KeyCode.Return))
                        {
                            battle.audioSource.volume = 0.6F;
                            battle.audioSource.PlayOneShot(SelectMove);
                            switch (currentMove)
                            {
                                case 1:
                                    menuMode = MenuMode.Moves;
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
                text1.enabled = false;
                text2.enabled = false;
                text3.enabled = false;
                text4.enabled = false;
                text5.enabled = false;
                selector1.enabled = false;
                selector2.enabled = false;
                selector3.enabled = false;
                selector4.enabled = false;
                selector5.enabled = false;
                pp1.enabled = false;
                pp2.enabled = false;
                pp3.enabled = false;
                pp4.enabled = false;
                megaIndicator.SetActive(false);
                break;
        }
    }
}
