using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using System;
using static SFX;

public class DexScreen : MonoBehaviour
{
    private const int listItems = 5;
    private const int selectedItem = 2;
    private const int screenWidth = 800;

    private RectTransform Transform => gameObject.transform as RectTransform;

    private enum State
    {
        List,
        MainData,
        Stats,
        Forms,

        Busy,
    }
    private State state = State.Busy;
    [SerializeField]
    private Image monSprite;
    [SerializeField]
    private TextMeshProUGUI seenText;
    [SerializeField]
    private TextMeshProUGUI caughtText;
    [SerializeField]
    private DexListItem[] dexList = new DexListItem[listItems];

    private int maxDexNum;
    private int position;

    [NonSerialized]
    public bool done;

    private SpeciesID currentSpecies;

    private AudioSource audioSource;

    [Serializable]
    public struct DataDisplay
    {
        [Serializable]
        public struct StatBar
        {
            public TextMeshProUGUI statNumber;
            public RawImage statBar;

            public void Set(int stat)
            {
                ((RectTransform)statBar.transform).sizeDelta = new(stat switch
                {
                    0 => 60,
                    <= 10 => stat * 0.5F + 15, //15 - 20
                    <= 100 => stat * 0.8F + 12, //20 - 92
                    <= 150 => stat * 0.5F + 42, //92 - 117
                    <= 250 => stat * 0.33F + 67.5F, //117 - 150
                    > 250 => 150, //150
                }, 36);
                statBar.color = stat switch
                {
                    0 => new(120F/255F, 120F/255F, 120F/255F),
                    <= 50 => new((3 * stat + 105) / 255F, 30 / 255F, 30 / 255F),
                    < 80 => new(1, (7 * stat - 305) / 255F, 30 / 255F),
                    < 125 => new((-5 * stat + 655) / 255F, 1, 30 / 255F),
                    < 200 => new(30 / 255F, 1, (3 * stat - 345) / 255F),
                    >= 200 => new(30 / 255F, (-2 * stat + 655) / 255F, 1)
                };
                statNumber.color = (stat < 65 || stat > 240) & stat != 0 ? Color.white : Color.black;
                statNumber.text = stat is 0 ? "???" : stat.ToString();
            }
        }
        public TextMeshProUGUI speciesName;
        public TextMeshProUGUI speciesCategory;
        public TextMeshProUGUI height;
        public TextMeshProUGUI weight;
        public TextMeshProUGUI desc;

        public TextMeshProUGUI ability1;
        public TextMeshProUGUI ability2;
        public TextMeshProUGUI ability3;

        public Image sprite;
        public Image icon;

        public TextMeshProUGUI number;
        public TextMeshProUGUI statScreenName;
        public RawImage type1Box;
        public TextMeshProUGUI type1Text;
        public RawImage type2Box;
        public TextMeshProUGUI type2Text;

        public StatBar HP;
        public StatBar Attack;
        public StatBar Defense;
        public StatBar SpAtk;
        public StatBar SpDef;
        public StatBar Speed;

        public void Adopt(SpeciesID species)
        {
            SpeciesData data = species.Data();
            speciesName.text = "No. " + ((int)data.pokedexData.forms[0]).LeadingZero4() + " " + species.Data().speciesName;
            speciesCategory.text = data.pokedexData.category + " Pokémon";

            sprite.sprite = data.graphics.frontSprite1;
            icon.sprite = data.graphics.icon1;

            number.text = "No. " + ((int)data.pokedexData.forms[0]).LeadingZero4();
            statScreenName.text = data.speciesName;

            type1Box.color = data.type1.Color();
            type1Text.color = data.type1.TextColor();
            type1Text.text = data.type1.Name();
            if (data.type1 == data.type2)
            {
                type2Box.enabled = false;
                type2Text.enabled = false;
            }
            else
            {
                type2Box.enabled = true;
                type2Box.color = data.type2.Color();
                type2Text.enabled = true;
                type2Text.color = data.type2.TextColor();
                type2Text.text = data.type2.Name();
            }
            if (Player.player.caughtFlags[(int)species])
            {
                height.text = data.pokedexData.height / 100F + " m";
                weight.text = data.pokedexData.weight / 1000F + " kg";

                HP.Set(data.baseHP);
                Attack.Set(data.baseAttack);
                Defense.Set(data.baseDefense);
                SpAtk.Set(data.baseSpAtk);
                SpDef.Set(data.baseSpDef);
                Speed.Set(data.baseSpeed);
                ability1.text = data.abilities[0].Name();
                if (data.abilities[1] == data.abilities[0])
                {
                    ability2.enabled = false;
                }
                else
                {
                    ability2.enabled = true;
                    ability2.text = data.abilities[1].Name();
                }
                if (data.abilities[2] == data.abilities[0])
                {
                    ability3.enabled = false;
                }
                else
                {
                    ability3.enabled = true;
                    ability3.text = data.abilities[2].Name();
                }
                desc.text = data.pokedexData.entry;
            }
            else
            {
                height.text = "???";
                weight.text = "???";
                HP.Set(0);
                Attack.Set(0);
                Defense.Set(0);
                SpAtk.Set(0);
                SpDef.Set(0);
                Speed.Set(0);
                ability1.text = "???";
                ability2.enabled = false;
                ability3.enabled = false;
                desc.text = "";
            }
        }
    }


    [SerializeField]
    private DataDisplay dataDisplay;

    [Serializable]
    public struct FormScreen
    {
        public Image[] Borders;
        public Image[] Sprites;

        [NonSerialized]
        public List<SpeciesID> forms;
        [NonSerialized]
        public int totalForms;

        [NonSerialized]
        public int maxShown;

        [NonSerialized]
        public int position;
        [NonSerialized]
        public int selection;

        public void Initialize(SpeciesID species)
        {
            forms = new();
            foreach (SpeciesID form in species.Data().pokedexData.forms)
            {
                if (Player.player.seenFlags[(int)form]) forms.Add(form);
            }
            totalForms = forms.Count;
            position = 0;
            selection = 0;
            Debug.Log("Forms: " + totalForms);
            UpdateSprites();
        }

        public void UpdateSprites()
        {
            maxShown = Mathf.Min(10, totalForms - (position + 1));
            for (int i = 0; i < 11; i++)
            {
                if (i > maxShown)
                {
                    Sprites[i].enabled = false;
                }
                else
                {
                    Sprites[i].enabled = true;
                    Sprites[i].sprite = forms[position + i].Data().graphics.icon1;
                }
            }
            if (selection is not 11) selection = maxShown is 7 ? 11 : Mathf.Min(selection, maxShown);
            UpdateBorders();
        }

        public void UpdateBorders()
        {
            for (int i = 0; i < 12; i++)
            {
                Borders[i].color = i == selection ? Color.red : Color.black;
                if (i is 11) break;
                if (Sprites[i].enabled) Sprites[i].sprite = forms[position + i].Data().graphics.icon1;
            }
        }
    }

    [SerializeField]
    private FormScreen formScreen;

    private float StateToXPos(State state) => state switch
    {
        State.List => 0,
        State.MainData => -800,
        State.Stats => -1600,
        State.Forms => 800,
        _ => 0
    };

    private IEnumerator GotoMonData(SpeciesID species)
    {
        Player p = Player.player;
        state = State.Busy;
        yield return p.FadeToBlack(0.2F);
        Transform.localPosition = new(StateToXPos(State.MainData), 0);
        dataDisplay.Adopt(species);
        yield return p.FadeFromBlack(0.2F);
        state = State.MainData;
    }

    private IEnumerator GotoForms(SpeciesID species)
    {
        Player p = Player.player;
        state = State.Busy;
        yield return p.FadeToBlack(0.2F);
        Transform.localPosition = new(StateToXPos(State.Forms), 0);
        formScreen.Initialize(species);
        yield return p.FadeFromBlack(0.2F);
        state = State.Forms;
    }

    private IEnumerator ReturnToList()
    {
        Player p = Player.player;
        state = State.Busy;
        yield return p.FadeToBlack(0.2F);
        Transform.localPosition = new(0, 0, 0);
        UpdateListDisplays();
        yield return p.FadeFromBlack(0.2F);
        state = State.List;
    }

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        int seen = 0;
        int caught = 0;
        for (SpeciesID i = 0; i < SpeciesID.FormsStart; i++)
        {
            if (i.Data().pokedexData.ShowEntry(Player.player))
            {
                seen++;
                maxDexNum = (int)i;
                if (i.Data().pokedexData.ShowCaught(Player.player))
                {
                    caught++;
                }
            }
        }
        seenText.text = "Seen: " + seen.LeadingZero4();
        caughtText.text = "Caught: " + caught.LeadingZero4();
        position = 1;
        UpdateListDisplays();
        Transform.localPosition = new(0, 0, 0);
        state = State.Busy;
    }

    private IEnumerator SlideRight(State newState)
    {
        state = State.Busy;
        Vector3 basePos = Transform.localPosition;
        float baseTime = Time.time;
        while (Time.time < baseTime + 0.5F)
        {
            Transform.localPosition = new(basePos.x + (Time.time - baseTime) * screenWidth * 2, basePos.y, basePos.z);
            yield return null;
        }
        Transform.localPosition = new(StateToXPos(newState), basePos.y, basePos.z);
        state = newState;
    }

    private IEnumerator SlideLeft(State newState)
    {
        state = State.Busy;
        Vector3 basePos = Transform.localPosition;
        float baseTime = Time.time;
        while (Time.time < baseTime + 0.5F)
        {
            Transform.localPosition = new(basePos.x - (Time.time - baseTime) * screenWidth * 2, basePos.y, basePos.z);
            yield return null;
        }
        Transform.localPosition = new(StateToXPos(newState), basePos.y, basePos.z);
        state = newState;
    }

    private void UpdateListDisplays()
    {
        for (int i = 0; i < listItems; i++)
        {
            int speciesNum = position + i - selectedItem;
            if (speciesNum < 1 || speciesNum > maxDexNum)
                dexList[i].Disable();
            else
                dexList[i].Adopt(Player.player, (SpeciesID)speciesNum);
        }
        monSprite.sprite = ((SpeciesID)position).Data().
            pokedexData.GetFirstSpecies(Player.player).Data().graphics.frontSprite1;
        currentSpecies = (SpeciesID)position;
    }

    public IEnumerator DoDexScreen()
    {
        state = State.List;
        while (!done) yield return false;
    }

    private void Update()
    {
        bool ShiftDown() => Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        switch (state)
        {
            case State.List:
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    Player.player.audioSource.PlayOneShot(Select);
                    done = true;
                    return;
                }
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (position > 1)
                    {
                        position = Mathf.Max(1, position -
                            (ShiftDown() ? 10 : 1));
                        UpdateListDisplays();
                        audioSource.PlayOneShot(MoveCursor);
                    }
                    return;
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (position < maxDexNum)
                    {
                        position = Mathf.Min(maxDexNum, position +
                            (ShiftDown() ? 10 : 1));
                        UpdateListDisplays();
                        audioSource.PlayOneShot(MoveCursor);
                    }
                    return;
                }
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    currentSpecies = (SpeciesID)position;
                    StartCoroutine(GotoMonData(currentSpecies));
                }
                break;
            case State.MainData:
                if (Input.GetKeyDown(KeyCode.C))
                {
                    audioSource.PlayOneShot(currentSpecies.Data().Cry);
                }
                else if (Input.GetKeyDown(KeyCode.F))
                {
                    audioSource.PlayOneShot(Select);
                    StartCoroutine(GotoForms(currentSpecies));
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    audioSource.PlayOneShot(MoveCursor);
                    StartCoroutine(SlideLeft(State.Stats));
                }
                else if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    audioSource.PlayOneShot(Select);
                    StartCoroutine(ReturnToList());
                }
                break;
            case State.Stats:
                if (Input.GetKeyDown(KeyCode.C))
                {
                    audioSource.PlayOneShot(currentSpecies.Data().Cry);
                }
                else if (Input.GetKeyDown(KeyCode.F))
                {
                    audioSource.PlayOneShot(Select);
                    StartCoroutine(GotoForms(currentSpecies));
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    audioSource.PlayOneShot(MoveCursor);
                    StartCoroutine(SlideRight(State.MainData));
                }
                else if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    audioSource.PlayOneShot(Select);
                    StartCoroutine(ReturnToList());
                }
                break;
            case State.Forms:
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    StartCoroutine(GotoMonData(formScreen.selection is 11 ? currentSpecies : formScreen.forms[formScreen.position + formScreen.selection]));
                }
                else if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    StartCoroutine(GotoMonData(currentSpecies));
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    if (formScreen.selection % 4 is 3) return;
                    else if (formScreen.selection >= formScreen.maxShown)
                    {
                        if (formScreen.selection > 7)
                        {
                            audioSource.PlayOneShot(MoveCursor);
                            formScreen.selection = 11;
                            formScreen.UpdateBorders();
                        }
                        else return;
                    }
                    else
                    {
                        audioSource.PlayOneShot(MoveCursor);
                        formScreen.selection++;
                        formScreen.UpdateBorders();
                    }
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    if (formScreen.selection % 4 is 0) return;
                    else if (formScreen.selection is 11)
                    {
                        if (formScreen.maxShown > 7)
                        {
                            audioSource.PlayOneShot(MoveCursor);
                            formScreen.selection = formScreen.maxShown;
                            formScreen.UpdateBorders();
                        }
                        else return;
                    }
                    else
                    {
                        audioSource.PlayOneShot(MoveCursor);
                        formScreen.selection--;
                        formScreen.UpdateBorders();
                    }
                }
                else if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (formScreen.selection < 4)
                    {
                        if (formScreen.position is 0) return;
                        else
                        {
                            audioSource.PlayOneShot(MoveCursor);
                            formScreen.position -= 4;
                            formScreen.UpdateSprites();
                        }
                    }
                    else if (formScreen.selection is 11)
                    {
                        audioSource.PlayOneShot(MoveCursor);
                        formScreen.selection = Mathf.Min(7, formScreen.maxShown);
                        formScreen.UpdateBorders();
                    }
                    else
                    {
                        audioSource.PlayOneShot(MoveCursor);
                        formScreen.selection -= 4;
                        formScreen.UpdateBorders();
                    }
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    Debug.Log(formScreen.position);
                    Debug.Log(formScreen.maxShown);
                    if (formScreen.selection > 7)
                    {
                        if (formScreen.totalForms > formScreen.position + 11)
                        {
                            audioSource.PlayOneShot(MoveCursor);
                            formScreen.position += 4;
                            formScreen.UpdateSprites();
                        }
                    }
                    else
                    {
                        switch((formScreen.selection / 4, formScreen.maxShown / 4))
                        {
                            case (0, 0):
                            case (1, 1):
                                audioSource.PlayOneShot(MoveCursor);
                                formScreen.selection = 11;
                                formScreen.UpdateBorders();
                                break;
                            case (0, 1):
                                audioSource.PlayOneShot(MoveCursor);
                                formScreen.selection = Mathf.Min(formScreen.selection + 4, formScreen.maxShown);
                                formScreen.UpdateBorders();
                                break;
                            case (1, 2):
                                audioSource.PlayOneShot(MoveCursor);
                                formScreen.selection = formScreen.selection + 4 > formScreen.maxShown ? 11 : formScreen.selection + 4;
                                formScreen.UpdateBorders();
                                break;
                            case (0, 2):
                                audioSource.PlayOneShot(MoveCursor);
                                formScreen.selection = formScreen.selection + 4;
                                formScreen.UpdateBorders();
                                break;
                        }
                    }
                }
                if (formScreen.selection is not 11)
                {
                    formScreen.Sprites[formScreen.selection].sprite =
                        Time.time % 0.3F > 0.15F ? formScreen.forms[formScreen.selection + formScreen.position].Data().graphics.icon1 :
                            formScreen.forms[formScreen.selection + formScreen.position].Data().graphics.icon2;
                }
                break;
            default: break;
        }
    }
}

