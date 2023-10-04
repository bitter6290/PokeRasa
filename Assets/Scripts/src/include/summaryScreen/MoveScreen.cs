using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using static MenuManager;

public class MoveScreen : MonoBehaviour
{
    public TextMeshProUGUI moveName;
    public TextMeshProUGUI moveType;
    public RawImage moveTypeBox;
    public Image moveSplitType;
    public TextMeshProUGUI movePower;
    public TextMeshProUGUI moveAccuracy;
    public TextMeshProUGUI moveDescription;

    public Image monImage;
    public TextMeshProUGUI monName;

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

    public Pokemon mon;
    public Battle battle;
    public Player player;
    public AudioSource audioSource;

    public AudioClip selectionSound;

    private MoveData currentData => mon.MoveIDs[selectedMove].Data();

    public static IEnumerator CloseScreen(MoveScreen screen)
    {
        Battle battle = null;
        if (screen.battle) battle = screen.battle;
        Player player = screen.player;
        yield return player.FadeToBlack(0.1F);
        Destroy(screen.gameObject);
        yield return new WaitForSeconds(0.5F);
        yield return player.FadeFromBlack(0.3F);
        if(battle) battle.menuOpen = false;
    }

    public static IEnumerator Create(Player player, Pokemon mon, Battle battle = null)
    {
        yield return player.FadeToBlack(0.3F);
        GameObject screen = Instantiate(Resources.Load<GameObject>("Prefabs/Summary Screen/Move Info Screen"));
        MoveScreen screenScript = screen.GetComponent<MoveScreen>();
        screenScript.player = player;
        screenScript.battle = battle;
        screenScript.mon = mon;
        if (battle) battle.menuOpen = true;
        yield return new WaitForSeconds(0.5F);
        yield return player.FadeFromBlack(0.3F);
    }

    public void Start()
    {
        canvas.worldCamera = FindAnyObjectByType<Camera>();

        monName.text = mon.monName;
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
        audioSource = gameObject.AddComponent<AudioSource>();
        selectedMove = 0;
        Refresh(false);
    }

    private void Refresh(bool playSound = true)
    {
        MoveData cachedData = currentData;
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

    public void Update()
    {
        monImage.sprite = Time.time % 0.36F > 0.18F ? monIcon0 : monIcon1;
        if (Input.GetKeyDown(KeyCode.DownArrow)) switch (selectedMove)
            {
                case 0 when totalMoves > 1:
                    selectedMove = 1; Refresh(); break;
                case 1 when totalMoves > 2:
                    selectedMove = 2; Refresh(); break;
                case 2 when totalMoves > 3:
                    selectedMove = 3; Refresh(); break;
                default: break;
            }
        else if (Input.GetKeyDown(KeyCode.UpArrow)) switch (selectedMove)
            {
                case 1:
                    selectedMove = 0; Refresh(); break;
                case 2:
                    selectedMove = 1; Refresh(); break;
                case 3:
                    selectedMove = 2; Refresh(); break;
                default: break;
            }
        else if (Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.Delete)) player.StartCoroutine(CloseScreen(this));

        
    }
}