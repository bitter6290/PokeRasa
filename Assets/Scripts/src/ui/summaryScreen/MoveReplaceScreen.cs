using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using static MenuManager;

public class MoveReplaceScreen : MonoBehaviour
{
    private static MoveReplaceScreen currentScreen;

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

    public TextMeshProUGUI newMoveName;
    public TextMeshProUGUI newMovePP;
    public RawImage newMoveBox;
    public RawImage newMoveOutline;


    public Canvas canvas;

    public Sprite physical;
    public Sprite special;
    public Sprite status;

    private Sprite monIcon0;
    private Sprite monIcon1;

    public int selectedMove;

    public Player player;
    public AudioSource audioSource;

    private Pokemon mon;
    private MoveID move;
    private DataStore<int> dataStore;

    private bool done;

    private MoveData CurrentData => selectedMove is 4 ?
        move.Data() : mon.MoveIDs[selectedMove].Data();

    public static IEnumerator DoMoveReplaceScreen(Player player, Pokemon mon, DataStore<int> dataStore,
        MoveID move)
    {
        yield return player.FadeToBlack(0.3F);
        GameObject screen = Instantiate(Resources.Load<GameObject>("Prefabs/Summary Screen/Move Replace Screen"));
        yield return null;
        currentScreen.player = player;
        currentScreen.move = move;
        currentScreen.dataStore = dataStore;
        currentScreen.mon = mon;
        currentScreen.RefreshAll();
        yield return new WaitForSeconds(0.5F);
        yield return player.FadeFromBlack(0.3F);
        while (!currentScreen.done) yield return null;
        yield return player.FadeToBlack(0.3F);
        Destroy(screen.gameObject);
        yield return new WaitForSeconds(0.5F);
        yield return player.FadeFromBlack(0.3F);
    }

    public void RefreshAll()
    {

        moveScreenName.text = mon.MonName;
        monIcon0 = mon.SpeciesData.graphics.icon1;
        monIcon1 = mon.SpeciesData.graphics.icon2;

        move1Box.color = mon.MoveIDs[0].Data().type.Color();
        move2Box.color = mon.MoveIDs[1].Data().type.Color();
        move3Box.color = mon.MoveIDs[2].Data().type.Color();
        move4Box.color = mon.MoveIDs[3].Data().type.Color();
        newMoveBox.color = move.Data().type.Color();
        move1Name.text = mon.MoveIDs[0].Data().name;
        move2Name.text = mon.MoveIDs[1].Data().name;
        move3Name.text = mon.MoveIDs[2].Data().name;
        move4Name.text = mon.MoveIDs[3].Data().name;
        newMoveName.text = move.Data().name;
        move1PP.text = LeadingZero(mon.pp1.ToString()) + " / " + LeadingZero(mon.maxPp1.ToString());
        move2PP.text = LeadingZero(mon.pp2.ToString()) + " / " + LeadingZero(mon.maxPp2.ToString());
        move3PP.text = LeadingZero(mon.pp3.ToString()) + " / " + LeadingZero(mon.maxPp3.ToString());
        move4PP.text = LeadingZero(mon.pp4.ToString()) + " / " + LeadingZero(mon.maxPp4.ToString());
        newMovePP.text = LeadingZero(move.Data().pp.ToString()) + " / " + LeadingZero(move.Data().pp.ToString());
        move1Name.color = move1PP.color = mon.MoveIDs[0].Data().type.TextColor();
        move2Name.color = move2PP.color = mon.MoveIDs[1].Data().type.TextColor();
        move3Name.color = move3PP.color = mon.MoveIDs[2].Data().type.TextColor();
        move4Name.color = move4PP.color = mon.MoveIDs[3].Data().type.TextColor();
        newMoveName.color = newMovePP.color = move.Data().type.TextColor();

        selectedMove = 4;
        RefreshMove(false);
    }

    public void Start()
    {
        currentScreen = this;
        canvas.worldCamera = FindAnyObjectByType<Camera>();
        audioSource = gameObject.AddComponent<AudioSource>();
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
        newMoveOutline.enabled = selectedMove == 4;
        if (playSound)
        {
            audioSource.PlayOneShot(SFX.MoveCursor);
        }
    }

    public void Update()
    {
        monImage.sprite = Time.time % 0.36F > 0.18F ? monIcon0 : monIcon1;
        if (Input.GetKeyDown(KeyCode.DownArrow) && selectedMove < 4)
        {
            selectedMove++; RefreshMove();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && selectedMove > 0)
        {
            selectedMove--; RefreshMove();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            dataStore.Data = selectedMove;
            player.audioSource.PlayOneShot(SFX.Select);
            done = true;
        }
        else if (Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.Delete))
        {
            dataStore.Data = 4;
            player.audioSource.PlayOneShot(SFX.Select);
            done = true;
        }
    }
}