using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using static Player;

public class MoveSelectScreen : MonoBehaviour
{
    private static MoveSelectScreen currentScreen;

    public TextMeshProUGUI moveName;
    public TextMeshProUGUI moveType;
    public RawImage moveTypeBox;
    public Image moveSplitType;
    public TextMeshProUGUI movePower;
    public TextMeshProUGUI moveAccuracy;
    public TextMeshProUGUI moveDescription;

    public Image monImage;
    public TextMeshProUGUI moveScreenName;

    public MoveBox[] moveBoxes = new MoveBox[4];

    public Canvas canvas;

    public Sprite physical;
    public Sprite special;
    public Sprite status;

    private Sprite monIcon0;
    private Sprite monIcon1;

    public int selectedMove;

    public AudioSource audioSource;

    private Pokemon mon;
    private DataStore<int> dataStore;

    private int cachedMoves;

    private bool done;

    private MoveData CurrentData => mon.MoveIDs[selectedMove].Data();

    public static IEnumerator DoMoveSelectScreen(Pokemon mon, DataStore<int> dataStore, bool gmax = false)
    {
        yield return player.FadeToBlack(0.3F);
        GameObject screen = Instantiate(Resources.Load<GameObject>("Prefabs/Summary Screen/Move Select Screen"));
        yield return null;
        currentScreen.dataStore = dataStore;
        currentScreen.mon = mon;
        currentScreen.cachedMoves = mon.Moves;
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
        for (int i = 0; i < 4; i++)
        {
            moveBoxes[i].Adopt(mon, i);
        }
        selectedMove = 0;
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
        for (int i = 0; i < 4; i++)
        {
            moveBoxes[i].SetSelected(selectedMove == i);
        }
        if (playSound)
        {
            audioSource.PlayOneShot(SFX.MoveCursor);
        }
    }

    public void Update()
    {
        monImage.sprite = Time.time % 0.36F > 0.18F ? monIcon0 : monIcon1;
        if (Input.GetKeyDown(KeyCode.DownArrow) && selectedMove < cachedMoves - 1)
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
            player.audioSource.PlayOneShot(SFX.Select);
            done = true;
        }
    }
}