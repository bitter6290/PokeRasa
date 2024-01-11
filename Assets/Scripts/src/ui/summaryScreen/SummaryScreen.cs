using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using static MenuManager;
using static StatusSprite;

public class SummaryScreen : MonoBehaviour
{
    public enum ScreenState
    {
        MonScreen,
        MoveScreen,
    }

    public Transform container;

    //Move screen

    public TextMeshProUGUI moveName;
    public TextMeshProUGUI moveType;
    public RawImage moveTypeBox;
    public Image moveSplitType;
    public TextMeshProUGUI movePower;
    public TextMeshProUGUI moveAccuracy;
    public TextMeshProUGUI moveDescription;

    public Image monImage;
    public TextMeshProUGUI moveScreenName;

    public TextMeshProUGUI move1Name;
    public TextMeshProUGUI move1PP;
    public RawImage move1Box;
    public RawImage move1Outline;
    public TextMeshProUGUI move2Name;
    public TextMeshProUGUI move2PP;
    public RawImage move2Box;
    public RawImage move2Outline;
    public TextMeshProUGUI move3Name;
    public TextMeshProUGUI move3PP;
    public RawImage move3Box;
    public RawImage move3Outline;
    public TextMeshProUGUI move4Name;
    public TextMeshProUGUI move4PP;
    public RawImage move4Box;
    public RawImage move4Outline;

    private int totalMoves;

    public Canvas canvas;

    public Sprite physical;
    public Sprite special;
    public Sprite status;

    private Sprite monIcon0;
    private Sprite monIcon1;

    public int selectedMove;

    private bool allowSwitching;

    //Mon screen

    public Image monBox;
    public TextMeshProUGUI monScreenName;
    public TextMeshProUGUI speciesText;
    public TextMeshProUGUI type1;
    public RawImage type1Box;
    public TextMeshProUGUI type2;
    public RawImage type2Box;
    public TextMeshProUGUI levelText;
    public RectTransform xpSlider;
    public TextMeshProUGUI xpToNext;
    public Image monStatus;
    public TextMeshProUGUI hpCurrent;
    public TextMeshProUGUI hpMax;
    public RawImage hpSlider;
    public Color lowHealth;
    public Color mediumHealth;
    public Color highHealth;

    public TextMeshProUGUI attack;
    public TextMeshProUGUI defense;
    public TextMeshProUGUI spAtk;
    public TextMeshProUGUI spDef;
    public TextMeshProUGUI speed;

    public TextMeshProUGUI abilityName;
    public TextMeshProUGUI abilityDesc;

    public TextMeshProUGUI attackLabel;
    public TextMeshProUGUI defenseLabel;
    public TextMeshProUGUI spAtkLabel;
    public TextMeshProUGUI spDefLabel;
    public TextMeshProUGUI speedLabel;
    public Color goodNature;
    public Color badNature;

    public TextMeshProUGUI itemName;
    public Image itemSprite;


    public int index;
    private Pokemon PlayerMon => player.Party[index];
    public Battle battle;
    public BoxScreen boxScreen;
    public Player player;
    public AudioSource audioSource;

    private Pokemon mon;

    public AudioClip selectionSound;

    private MoveData CurrentData => mon.MoveIDs[selectedMove].Data();

    private ScreenState state = ScreenState.MoveScreen;
    private bool moving = false;

    private const int screenWidth = 1250;

    public static IEnumerator CloseScreen(SummaryScreen screen)
    {
        Battle battle = screen.battle;
        BoxScreen boxScreen = screen.boxScreen;
        Player player = screen.player;
        yield return player.FadeToBlack(0.3F);
        Destroy(screen.gameObject);
        yield return new WaitForSeconds(0.5F);
        if (battle != null) battle.menuOpen = false;
        if (boxScreen != null) boxScreen.Activate();
        yield return player.FadeFromBlack(0.3F);
    }

    public static IEnumerator Create(Player player, int mon, Battle battle = null)
    {
        yield return player.FadeToBlack(0.3F);
        GameObject screen = Instantiate(Resources.Load<GameObject>("Prefabs/Summary Screen/Move Info Screen"));
        SummaryScreen screenScript = screen.GetComponent<SummaryScreen>();
        screenScript.player = player;
        screenScript.battle = battle;
        screenScript.boxScreen = null;
        screenScript.index = mon;
        screenScript.allowSwitching = true;
        screenScript.mon = screenScript.PlayerMon;
        if (battle != null) battle.menuOpen = true;
        yield return new WaitForSeconds(0.5F);
        yield return player.FadeFromBlack(0.3F);
    }

    public static IEnumerator Create(Player player, Pokemon mon, BoxScreen boxScreen)
    {
        yield return player.FadeToBlack(0.3F);
        GameObject screen = Instantiate(Resources.Load<GameObject>("Prefabs/Summary Screen/Move Info Screen"));
        SummaryScreen screenScript = screen.GetComponent<SummaryScreen>();
        screenScript.player = player;
        screenScript.battle = null;
        screenScript.boxScreen = boxScreen;
        screenScript.index = 0;
        screenScript.allowSwitching = false;
        screenScript.mon = mon;
        yield return new WaitForSeconds(0.5F);
        yield return player.FadeFromBlack(0.3F);
    }

    public void RefreshAll()
    {

        monBox.sprite = mon.SpeciesData.FrontSprite1;

        monScreenName.text = mon.MonName;
        speciesText.text = mon.SpeciesData.pokedexData.number.ToString().LeadingZero2() + " / " + mon.SpeciesData.speciesName;

        type1Box.color = mon.SpeciesData.type1.Color();
        type1.text = mon.SpeciesData.type1.Name();
        type1.color = mon.SpeciesData.type1.TextColor();

        if (mon.SpeciesData.type1 != mon.SpeciesData.type2)
        {
            type2Box.enabled = true;
            type2.enabled = true;
            type2Box.color = mon.SpeciesData.type2.Color();
            type2.text = mon.SpeciesData.type2.Name();
            type2.color = mon.SpeciesData.type2.TextColor();
        }
        else
        {
            type2Box.enabled = false;
            type2.enabled = false;
        }


        levelText.text = "Lv. " + mon.level;
        xpSlider.localScale = new(mon.LevelProgress, 1, 1);
        xpToNext.text = mon.NextLevelXP - mon.xp + " to next";

        hpCurrent.text = mon.hp.ToString();
        hpMax.text = mon.hpMax.ToString();
        hpSlider.transform.localScale = new((float)mon.hp / mon.hpMax, 1, 1);
        hpSlider.color = (((mon.hp * 4) - 1) / mon.hpMax) switch
        {
            0 => HealthBarColors.Red,
            1 => HealthBarColors.Amber,
            _ => HealthBarColors.Green
        };

        monStatus.enabled = mon.status != Status.None;
        monStatus.sprite = mon.status.ToSprite();

        abilityName.text = mon.GetAbility.Name();
        abilityDesc.text = mon.GetAbility.Description();

        if (mon.CurrentItem is not ItemID.None)
        {
            itemSprite.enabled = true;
            itemName.text = mon.CurrentItem.Data().itemName;
            itemSprite.sprite = mon.CurrentItem.Sprite();
        }
        else
        {
            itemSprite.enabled = false;
            itemName.text = "No Item";
        }


        moveScreenName.text = mon.MonName;
        monIcon0 = Sprite.Create(Resources.Load<Texture2D>("Sprites/Pokemon/" + mon.SpeciesData.graphicsLocation + "/icon"),
            new(0, 32, 32, 32), new(0.5F, 0.5F));
        monIcon1 = Sprite.Create(Resources.Load<Texture2D>("Sprites/Pokemon/" + mon.SpeciesData.graphicsLocation + "/icon"),
            new(0, 0, 32, 32), new(0.5F, 0.5F));

        move1Box.color = mon.MoveIDs[0].Data().type.Color();
        move2Box.color = mon.MoveIDs[1].Data().type.Color();
        move3Box.color = mon.MoveIDs[2].Data().type.Color();
        move4Box.color = mon.MoveIDs[3].Data().type.Color();
        move1Name.text = mon.MoveIDs[0].Data().name;
        move2Name.text = mon.MoveIDs[1].Data().name;
        move3Name.text = mon.MoveIDs[2].Data().name;
        move4Name.text = mon.MoveIDs[3].Data().name;
        move1PP.text = LeadingZero(mon.pp1.ToString()) + " / " + LeadingZero(mon.maxPp1.ToString());
        move2PP.text = LeadingZero(mon.pp2.ToString()) + " / " + LeadingZero(mon.maxPp2.ToString());
        move3PP.text = LeadingZero(mon.pp3.ToString()) + " / " + LeadingZero(mon.maxPp3.ToString());
        move4PP.text = LeadingZero(mon.pp4.ToString()) + " / " + LeadingZero(mon.maxPp4.ToString());
        move1Name.color = mon.MoveIDs[0].Data().type.TextColor();
        move1PP.color = mon.MoveIDs[0].Data().type.TextColor();
        move2Name.color = mon.MoveIDs[1].Data().type.TextColor();
        move2PP.color = mon.MoveIDs[1].Data().type.TextColor();
        move3Name.color = mon.MoveIDs[2].Data().type.TextColor();
        move3PP.color = mon.MoveIDs[2].Data().type.TextColor();
        move4Name.color = mon.MoveIDs[3].Data().type.TextColor();
        move4PP.color = mon.MoveIDs[3].Data().type.TextColor();

        attack.text = mon.attack.ToString();
        defense.text = mon.defense.ToString();
        spAtk.text = mon.spAtk.ToString();
        spDef.text = mon.spDef.ToString();
        speed.text = mon.speed.ToString();


        attackLabel.color = NatureUtils.NatureEffect(mon.Nature, Stat.Attack) switch
        {
            > 1 => goodNature,
            < 1 => badNature,
            _ => Color.black
        };

        defenseLabel.color = NatureUtils.NatureEffect(mon.Nature, Stat.Defense) switch
        {
            > 1 => goodNature,
            < 1 => badNature,
            _ => Color.black
        };

        spAtkLabel.color = NatureUtils.NatureEffect(mon.Nature, Stat.SpAtk) switch
        {
            > 1 => goodNature,
            < 1 => badNature,
            _ => Color.black
        };

        spDefLabel.color = NatureUtils.NatureEffect(mon.Nature, Stat.SpDef) switch
        {
            > 1 => goodNature,
            < 1 => badNature,
            _ => Color.black
        };

        speedLabel.color = NatureUtils.NatureEffect(mon.Nature, Stat.Speed) switch
        {
            > 1 => goodNature,
            < 1 => badNature,
            _ => Color.black
        };

        totalMoves = mon.Moves;
        move2Box.enabled = totalMoves > 1;
        move2Name.enabled = totalMoves > 1;
        move2PP.enabled = totalMoves > 1;
        move3Box.enabled = totalMoves > 2;
        move3Name.enabled = totalMoves > 2;
        move3PP.enabled = totalMoves > 2;
        move4Box.enabled = totalMoves > 3;
        move4Name.enabled = totalMoves > 3;
        move4PP.enabled = totalMoves > 3;
        selectedMove = 0;
        RefreshMove(false);
    }

    public void Start()
    {
        canvas.worldCamera = FindAnyObjectByType<Camera>();
        audioSource = gameObject.AddComponent<AudioSource>();
        RefreshAll();
    }

    private void RefreshMove(bool playSound = true)
    {
        MoveData cachedData = CurrentData;
        moveName.text = cachedData.name.ToString();
        movePower.text = cachedData.power < 2 ? "--" : cachedData.power.ToString();
        moveAccuracy.text = cachedData.accuracy == 101 ? "--" : cachedData.accuracy.ToString();
        moveSplitType.sprite = cachedData.power switch
        {
            0 => status,
            _ => cachedData.physical ? physical : special
        };
        moveType.text = cachedData.type.Name();
        moveTypeBox.color = cachedData.type.Color();
        moveDescription.text = cachedData.moveDesc;
        move1Outline.enabled = selectedMove == 0;
        move2Outline.enabled = selectedMove == 1;
        move3Outline.enabled = selectedMove == 2;
        move4Outline.enabled = selectedMove == 3;
        if (playSound) audioSource.PlayOneShot(selectionSound);
    }

    public IEnumerator MoveToMon() //x from 0 to -1250
    {
        moving = true;
        float startTime = Time.time;
        audioSource.PlayOneShot(selectionSound);
        while (Time.time < startTime + 0.3F)
        {
            container.localPosition = new(screenWidth * (Time.time - startTime) / 0.3F, 0);
            yield return null;
        }
        container.localPosition = new(screenWidth, 0, 0);
        state = ScreenState.MonScreen;
        moving = false;
    }

    public IEnumerator MonToMove() //x from -1250 to 0
    {
        moving = true;
        float startTime = Time.time;
        audioSource.PlayOneShot(selectionSound);
        while (Time.time < startTime + 0.3F)
        {
            container.localPosition = new(screenWidth - screenWidth * (Time.time - startTime) / 0.3F, 0);
            yield return null;
        }
        container.localPosition = new(0, 0, 0);
        state = ScreenState.MoveScreen;
        moving = false;
    }

    public void Update()
    {
        if (moving) return;
        switch (state)
        {
            case ScreenState.MoveScreen:
                monImage.sprite = Time.time % 0.36F > 0.18F ? monIcon0 : monIcon1;
                if (Input.GetKeyDown(KeyCode.DownArrow)) switch (selectedMove)
                    {
                        case 0 when totalMoves > 1:
                            selectedMove = 1; RefreshMove(); break;
                        case 1 when totalMoves > 2:
                            selectedMove = 2; RefreshMove(); break;
                        case 2 when totalMoves > 3:
                            selectedMove = 3; RefreshMove(); break;
                        default: break;
                    }
                else if (Input.GetKeyDown(KeyCode.UpArrow)) switch (selectedMove)
                    {
                        case 1:
                            selectedMove = 0; RefreshMove(); break;
                        case 2:
                            selectedMove = 1; RefreshMove(); break;
                        case 3:
                            selectedMove = 2; RefreshMove(); break;
                        default: break;
                    }
                else if (Input.GetKeyDown(KeyCode.LeftArrow)) StartCoroutine(MoveToMon());
                else if (Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.Delete)) player.StartCoroutine(CloseScreen(this));
                break;
            case ScreenState.MonScreen:
                if (Input.GetKeyDown(KeyCode.RightArrow)) StartCoroutine(MonToMove());
                else if (Input.GetKeyDown(KeyCode.UpArrow) && index > 0 && allowSwitching)
                {
                    index--;
                    mon = PlayerMon;
                    audioSource.PlayOneShot(selectionSound);
                    RefreshAll();
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow) && index < 5 && player.Party[index + 1].exists && allowSwitching)
                {
                    index++;
                    mon = PlayerMon;
                    audioSource.PlayOneShot(selectionSound);
                    RefreshAll();
                }
                else if (Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.Delete)) player.StartCoroutine(CloseScreen(this));
                break;
        }
    }
}