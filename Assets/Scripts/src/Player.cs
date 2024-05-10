using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;
using Scene = SceneID;
using BagOutcome = BagController.BagOutcome;
using PartyScreenOutcome = PartyScreen.PartyScreenOutcome;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Player : LoadedChar
{
    public const int maxBoxes = 255;

    public static Player player;

    public bool[] TM = new bool[(int)TMID.Count];
    public bool[] storyFlags = new bool[(int)Flag.Count];
    public bool[] trainerFlags = new bool[(int)TrainerFlag.Count];
    public bool[] seenFlags = new bool[(int)SpeciesID.Count];
    public bool[] caughtFlags = new bool[(int)SpeciesID.Count];
    public List<Box> boxes;
    public int currentBox = 0;
    public int money = 0;
    public string playerName = "Brendan";

    public string saveID = "Test";

    public static readonly Vector3 choicePosition = new(-400, 60);

    public TODShading todShading;

    public Dictionary<ItemID, int> Bag = new();
    public List<(ItemID, int)> SerializeBag => Bag.Select(x => (x.Key, x.Value)).ToList();

    public Dictionary<MapData, bool[,]> neighborCollision;


    public List<TileTrigger> triggers;
    public List<TileTrigger> signposts;
    public List<WarpTrigger> warps;

    public BattleTerrain currentTerrain;
    //public MapID currentMap;
    public MapData lastMap = null;
    //public Vector2Int pos;
    //public Vector2Int moveTarget;
    public PlayerState state;
    //public bool active;
    public bool locked;
    //public Direction facing;

    public Dictionary<string, (MapData map, LoadedChar chara)> loadedChars;
    public LoadedChar opponent;

    public bool whichStep;

    public MapDirectory mapDirectory;

    //public CollisionID currentHeight;
    public MapManager mapManager;
    public PlayerMovement playerGraphics;
    public FieldAnnouncer announcer;

    public new GameObject camera;
    private GameObject blackScreen;
    private SpriteRenderer blackScreenRenderer;

    public Canvas canvas;

    public AudioSource audioSource;

    private FieldMenu menu;
    public MenuItem cachedMenuItem;
    public Vector2 menuOpenPos;
    public Vector2 menuClosedPos;

    private BagController bagController;
    public ItemID bagResult;
    public BagOutcome bagOutcome;

    private PartyScreen partyScreen;
    public int partyScreenResult;
    public PartyScreenOutcome partyScreenOutcome;

    public bool boxGiving;
    public Pokemon boxGiveTarget;

    public CachedScreenData cachedScreenData;

    private bool blackScreenOn;

    private bool menuOpen;

    public override IEnumerator WalkNorth() { yield return playerGraphics.WalkNorth(this, 0.3F); }
    public override IEnumerator WalkSouth() { yield return playerGraphics.WalkSouth(this, 0.3F); }
    public override IEnumerator WalkEast() { yield return playerGraphics.WalkEast(this, 0.3F); }
    public override IEnumerator WalkWest() { yield return playerGraphics.WalkWest(this, 0.3F); }
    public override IEnumerator BumpNorth() { yield return playerGraphics.BumpNorth(this, 0.3F); }
    public override IEnumerator BumpSouth() { yield return playerGraphics.BumpSouth(this, 0.3F); }
    public override IEnumerator BumpEast() { yield return playerGraphics.BumpEast(this, 0.3F); }
    public override IEnumerator BumpWest() { yield return playerGraphics.BumpWest(this, 0.3F); }
    public override IEnumerator FaceNorth() { yield return playerGraphics.FaceNorth(this, 0); }
    public override IEnumerator FaceSouth() { yield return playerGraphics.FaceSouth(this, 0); }
    public override IEnumerator FaceEast() { yield return playerGraphics.FaceEast(this, 0); }
    public override IEnumerator FaceWest() { yield return playerGraphics.FaceWest(this, 0); }
    public override IEnumerator RunNorth() => throw new NotImplementedException();
    public override IEnumerator RunSouth() => throw new NotImplementedException();
    public override IEnumerator RunEast() => throw new NotImplementedException();
    public override IEnumerator RunWest() => throw new NotImplementedException();

    public enum Screen
    {
        Map,
        Bag,
        Pokemon,
    }

    public class CachedScreenData
    {
        public Screen type;
    }

    public class BagCachedData : CachedScreenData
    {
        public BagController.Pocket pocket;
        public int position;
        public int selection;
        public BagCachedData()
        {
            type = Screen.Bag;
        }
    }

    public class PartyBoxCachedData : CachedScreenData
    {
        public int currentMon;
        public PartyBoxCachedData()
        {
            type = Screen.Pokemon;
        }
    }

    public IEnumerator DoChoiceMenu(DataStore<int> dataStore,
        List<(string, int)> choices, int cancelChoice)
        => ChoiceMenu.DoChoiceMenu(this, choices, cancelChoice, dataStore,
            announcer.transform, choicePosition, Vector2.zero);

    public static CachedScreenData MapCachedData = new() { type = Screen.Map };

    public float textSpeed = 25;

    public enum MenuItem
    {
        CloseMenu,
        Bag,
        Pokemon,
        Pokedex,
        Save,
        Settings
    }

    public void DeserializeBag(List<(ItemID, int)> listIn)
    {
        foreach ((ItemID item, int number) in listIn)
        {
            Bag.Add(item, number);
        }
    }

    public MapData StringToMap(string stringIn)
    {
        foreach (MapData data in mapDirectory.maps)
        {
            if (data.id == stringIn) return data;
        }
        return null;
    }

    [Serializable]
    public struct SaveFile
    {
        public bool[] TM;
        public bool[] storyFlags;
        public bool[] trainerFlags;
        public bool[] seenFlags;
        public bool[] caughtFlags;
        public string mapID;
        public int posX;
        public int posY;
        public CollisionID currentHeight;
        public List<(ItemID, int)> bag;
        public string name;
        public int currentBox;
        public int money;
        public Pokemon[] party;
        public List<Box> boxes;
    }

    public void LoadSave(SaveFile file)
    {
        TM = file.TM;
        if (TM.Length != (int)TMID.Count)
        {
            Array.Resize(ref TM, (int)TMID.Count);
        }
        storyFlags = file.storyFlags;
        if (storyFlags.Length != (int)Flag.Count)
        {
            Array.Resize(ref storyFlags, (int)Flag.Count);
        }
        trainerFlags = file.trainerFlags;
        if (trainerFlags.Length != (int)TrainerFlag.Count)
        {
            Array.Resize(ref trainerFlags, (int)TrainerFlag.Count);
        }
        seenFlags = file.seenFlags;
        if (seenFlags.Length != (int)SpeciesID.Count)
        {
            Array.Resize(ref seenFlags, (int)SpeciesID.Count);
        }
        caughtFlags = file.caughtFlags;
        if (caughtFlags.Length != (int)SpeciesID.Count)
        {
            Array.Resize(ref caughtFlags, (int)SpeciesID.Count);
        }
        currentMap = StringToMap(file.mapID);
        pos = new(file.posX, file.posY);
        DeserializeBag(file.bag);
        playerName = file.name;
        currentBox = file.currentBox;
        currentHeight = file.currentHeight;
        money = file.money;
        Party = file.party;
        if (Party.Length != 6)
        {
            Array.Resize(ref Party, 6);
        }
        boxes = file.boxes;
    }

    private string savePath => Application.persistentDataPath + "/" + saveID + ".dat";

    public void LoadSave(string saveID)
    {
        this.saveID = saveID;
        BinaryFormatter bf = new();
        FileStream file = File.OpenRead(savePath);
        SaveFile data = (SaveFile)bf.Deserialize(file);
        LoadSave(data);
    }

    public void SaveGame()
    {
        BinaryFormatter bf = new();
        FileStream file = File.Create(savePath);
        SaveFile data = new()
        {
            TM = TM,
            storyFlags = storyFlags,
            trainerFlags = trainerFlags,
            seenFlags = seenFlags,
            caughtFlags = caughtFlags,
            mapID = currentMap.id,
            posX = pos.x,
            posY = pos.y,
            name = playerName,
            currentBox = currentBox,
            currentHeight = currentHeight,
            money = money,
            party = Party,
            boxes = boxes
        };
        bf.Serialize(file, data);
        file.Close();
        Debug.Log("Game saved!");
    }

    public Pokemon[] Party = new Pokemon[6];
    public int monsInParty
    {
        get
        {
            int mons = 0;
            for (int i = 0; i < 6; i++)
            {
                if (Party[i].exists) mons++;
            }
            return mons;
        }
    }

    public IEnumerator GetItem(ItemID item, int amount)
    {
        switch (Item.ItemTable[(int)item].type)
        {
            case ItemType.TM:
                //yield return Field.Announce("Received" + Item.ItemTable[item].name");
                TM[Item.ItemTable[(int)item].ItemSubdata[0]] = true;
                break;
            case ItemType.KeyItem:
                //yield return Field.Announce("Received" + Item.ItemTable[item].name");
                storyFlags[Item.ItemTable[(int)item].ItemSubdata[0]] = true;
                break;
            default:
                //yield return Field.Announce("Received" + Item.ItemTable[item].name");
                AddItem(item, amount);
                break;
        }
        yield break;
    }

    public void AddItem(ItemID item, int amount = 1)
    {
        if (Bag.ContainsKey(item))
        {
            Bag[item] += amount;
        }
        else
        {
            Bag.Add(item, amount);
        }
    }

    public int NumberOf(ItemID item)
    {
        int number;
        if (Bag.TryGetValue(item, out number)) return number;
        else return 0;
    }

    public bool UseItem(ItemID item, int number = 1) //Returns true when the item is exhausted
    {
        int remaining = NumberOf(item);
        if (remaining is 0) return true;
        remaining -= number;
        if (remaining <= 0) { Bag.Remove(item); return true; }
        else { Bag[item] = remaining; return false; }
    }

    public void VerifyBag()
    {
        foreach (ItemID key in Bag.Keys)
            if (Bag[key] < 1) Bag.Remove(key);
    }

    public void DeactivateAll() { foreach ((MapData _, LoadedChar i) in loadedChars.Values) i.Deactivate(); }
    public void ActivateAll() { foreach ((MapData _, LoadedChar i) in loadedChars.Values) i.Activate(); }

    public void LockAll() { foreach ((MapData _, LoadedChar i) in loadedChars.Values) i.free = false; }
    public void UnlockAll() { foreach ((MapData _, LoadedChar i) in loadedChars.Values) i.free = true; }

    public void RemoveAllChars() { DeactivateAll(); loadedChars = new(); }

    public bool TryAddMon(Pokemon mon)
    {
        seenFlags[(int)mon.species] = true;
        caughtFlags[(int)mon.species] = true;
        SortParty();
        if (monsInParty >= 6)
        {
            return false;
        }
        else
        {
            Party[monsInParty] = mon;
            return true;
        }
    }

    public bool CatchMon(Pokemon mon)
    {
        if (TryAddMon(mon)) return true;
        else
        {
            int firstBox = currentBox;
            int currentBoxes = boxes.Count;
            while (currentBox < currentBoxes)
            {
                int boxSlot = boxes[currentBox].nextSlot;
                if (boxSlot == 255)
                {
                    currentBox++;
                    continue;
                }
                else
                {
                    boxes[currentBox].pokemon[boxSlot] = mon;
                    return true;
                }
            }
            currentBox = 0;
            while (currentBox < firstBox)
            {
                int boxSlot = boxes[currentBox].nextSlot;
                if (boxSlot == 255)
                {
                    currentBox++;
                    continue;
                }
                else
                {
                    boxes[currentBox].pokemon[boxSlot] = mon;
                    return true;
                }
            }
            if (currentBoxes < maxBoxes)
            {
                boxes.Add(new("Box " + (currentBoxes + 1)));
                currentBox = currentBoxes;
                boxes[currentBoxes].pokemon[0] = mon;
                return true;
            }
        }
        return false;
    }

    public void SortParty()
    {
        int currentPos = 0;
        for (int i = 0; i < 6; i++)
        {
            if (Party[i].exists) Party[currentPos++] = Party[i];
        }
        for (int i = currentPos; i < 6; i++)
        {
            Party[i] = Pokemon.EmptyMon;
        }
    }

    public void EmptyParty()
    {
        for (int i = 0; i < 6; i++)
        {
            Party[i] = Pokemon.EmptyMon;
        }
    }

    public void ResetData()
    {
        TM = new bool[(int)TMID.Count];
        storyFlags = new bool[(int)Flag.Count];
    }

    public void RenderMap()
    {
        Grid grid = new GameObject("Grid").AddComponent<Grid>();
        grid.cellSize = new Vector3(0.5F, 0.5F, 1.0F);
        Tilemap level1 = new GameObject("Tilemap1").AddComponent<Tilemap>();
        Tilemap level2 = new GameObject("Tilemap2").AddComponent<Tilemap>();
        Tilemap level3 = new GameObject("Tilemap3").AddComponent<Tilemap>();
        TilemapRenderer renderer1 = level1.gameObject.AddComponent<TilemapRenderer>();
        TilemapRenderer renderer2 = level2.gameObject.AddComponent<TilemapRenderer>();
        TilemapRenderer renderer3 = level3.gameObject.AddComponent<TilemapRenderer>();
        renderer1.mode = TilemapRenderer.Mode.Chunk;
        renderer2.mode = TilemapRenderer.Mode.Chunk;
        renderer3.mode = TilemapRenderer.Mode.Chunk;
        renderer1.sortingLayerID = 0;
        renderer2.sortingLayerID = 0;
        renderer3.sortingLayerID = 0;
        renderer1.sortingOrder = -4;
        renderer2.sortingOrder = -3;
        renderer3.sortingOrder = 3;
        level1.transform.SetParent(grid.gameObject.transform);
        level2.transform.SetParent(grid.gameObject.transform);
        level3.transform.SetParent(grid.gameObject.transform);
        mapManager.level1 = level1;
        mapManager.level2 = level2;
        mapManager.level3 = level3;
        SwitchMap();
    }

    public void SwitchMap()
    {
        mapManager.map = currentMap;
        todShading.shadingBehaviour = currentMap.shading;
        mapManager.ReadMap();
        currentMap.mapScripts.BeforeLoad(this);
        RefreshObjects();
        currentMap.mapScripts.OnLoad(this);
    }

    public void RefreshTriggers()
    {
        triggers = new();
        foreach (TileTrigger i in currentMap.triggers) triggers.Add(i);
    }

    public void RefreshSignposts()
    {
        signposts = new();
        foreach (TileTrigger i in currentMap.signposts) signposts.Add(i);
    }

    public void RefreshWarps()
    {
        warps = new();
        foreach (WarpTrigger i in currentMap.warps) warps.Add(i);
    }

    public void RefreshChars()
    {
        loadedChars ??= new();
        List<MapData> maps = new() { currentMap };
        foreach (Connection i in currentMap.connection)
        {
            Debug.Log("Adding " + i.map);
            maps.Add(i.map);
        }
        foreach ((MapData m, LoadedChar i) in loadedChars.Values)
        {
            bool keep = false;
            Debug.Log(currentMap);
            Debug.Log(i.currentMap);
            if (i.keepOnLoad)
            {
                if (i.currentMap != currentMap)
                    foreach (Connection j in currentMap.connection)
                    {
                        if (j.map == i.currentMap)
                        {
                            Vector2Int mapOffset = GetMapOffset(j);
                            i.pos += mapOffset;
                            if (i.moving) i.moveTarget += mapOffset;
                            i.AlignObject();
                        }
                    }
                i.currentMap = currentMap;
                continue;
            }
            foreach (MapData j in maps)
            {
                Debug.Log("Testing " + j);
                Debug.Log("MapID is " + m);
                if (m == j)
                {
                    Debug.Log("Matched");
                    if (i.currentMap != currentMap)
                        foreach (Connection k in currentMap.connection)
                        {
                            if (k.map == i.currentMap)
                            {
                                Debug.Log(i.pos);
                                Vector2Int offset = GetMapOffset(k);
                                Debug.Log(offset);
                                i.pos += offset;
                                if (i.moving) i.moveTarget += offset;
                                i.AlignObject();
                                Debug.Log(i.pos);
                            }
                        };
                    i.currentMap = currentMap;
                    keep = true;
                    break;
                }
            }
            if (keep) continue;
            StartCoroutine(i.Unload());
        }
        foreach (MapData i in maps)
        {
            foreach (MapChar charData in i.chars)
            {
                if (!charData.data.IsLoaded(this))
                {
                    LoadedChar chara = charData.data.Load(this, i, charData.pos);
                    if (i != currentMap)
                    {
                        foreach (Connection k in currentMap.connection)
                        {
                            if (k.map == i)
                            {
                                Vector2Int offset = GetMapOffset(k);
                                chara.pos += offset;
                                if (chara.moving) chara.moveTarget += offset;
                                chara.AlignObject();
                            }
                        };
                    }
                }
            }
        }
    }

    public void RefreshObjects()
    {
        RefreshTriggers();
        RefreshSignposts();
        RefreshWarps();
        RefreshChars();
    }

    public LoadedChar GetChar(string id)
    {
        return loadedChars[id].chara;
    }

    public void SwitchAndReposition(Vector2Int pos)
    {
        mapManager.map = currentMap;
        mapManager.ReadAndReposition(this, pos);
        currentMap.mapScripts.BeforeLoad(this);
        RefreshObjects();
        currentMap.mapScripts.OnLoad(this);
    }

    public MapData GetMapByID(string id)
    {
        if (currentMap.id == id) { return currentMap; }
        foreach (MapData map in mapDirectory.maps)
        {
            if (map.id == id) return map;
        }
        return null;
    }

    public void AlignPlayer() => playerGraphics.playerTransform.position = new Vector3(pos.x + 0.5F, pos.y + 0.5F, pos.y);

    public new void UpdateCollision() => currentHeight = CheckCollision(pos, false);

    public void CreatePlayerGraphics(HumanoidGraphics graphics) => playerGraphics = new(this, graphics);

    public CollisionID CheckCollision(Vector2Int pos, bool checkChars)
    {
        if (checkChars)
        {
            if (pos == this.pos || (state == PlayerState.Moving && pos == moveTarget)) return CollisionID.Impassable;
            if (loadedChars.Count > 0) foreach ((MapData _, LoadedChar loadedChar) in loadedChars.Values)
                    if (loadedChar.pos == pos || (loadedChar.moving && loadedChar.moveTarget == pos)) return CollisionID.Impassable;
        }
        if (pos.x >= 0 && pos.y >= 0 && pos.x < currentMap.width && pos.y < currentMap.height)
            return (CollisionID)mapManager.collision[pos.x, pos.y];
        else
        {
            return CollisionOnBorderingMaps(pos);
        }
    }

    private CollisionID CollisionOnBorderingMaps(Vector2Int pos)
    {
        (MapData map, Vector2Int pos) relativeTile = TileOutsideMap(pos);
        if (relativeTile.map == null) return CollisionID.Impassable;
        else
        {
            return (CollisionID)mapManager.borderingCollision[relativeTile.map]
                [relativeTile.pos.x, relativeTile.pos.y];
        }
    }

    private (MapData, Vector2Int) TileOutsideMap(Vector2Int pos)
    {
        foreach (Connection i in currentMap.connection)
        {
            Vector2Int checkPos = pos - GetMapOffset(i);
            if (checkPos.x >= 0 && checkPos.x < i.map.width
                && checkPos.y >= 0 && checkPos.y < i.map.height)
                return (i.map, checkPos);
        }
        return (null, Vector2Int.zero);
    }

    private IEnumerator CheckEvolutions()
    {
        Debug.Log("Checking evolutions");
        List<Pokemon> toEvo = new();
        bool doEvo = false;
        foreach (Pokemon mon in Party) if (mon.shouldEvolve)
            { toEvo.Add(mon); doEvo = true; }
        if (doEvo)
        {
            yield return FadeToBlack(0.2F);
            yield return Scene.Evolution.Load();
            EvolutionScene evolutionScene = FindAnyObjectByType<EvolutionScene>();
            foreach (Pokemon mon in toEvo)
            {
                yield return evolutionScene.PrepareScene(mon);
                if (mon.makeShedinja && NumberOf(ItemID.PokeBall) > 0)
                {
                    if (TryAddMon(Pokemon.WildPokemon(SpeciesID.Shedinja, 1)))
                        UseItem(ItemID.PokeBall);
                }
                yield return FadeFromBlack(0.2F);
                yield return evolutionScene.DoEvolutionScene();
                yield return FadeToBlack(0.2F);
            }
        }
    }

    private IEnumerator DoSingleEvolution(Pokemon mon, CachedScreenData cachedScreenData)
    {
        yield return FadeToBlack(0.2F);
        yield return Scene.Evolution.Load();
        EvolutionScene evolutionScene = FindAnyObjectByType<EvolutionScene>();
        yield return evolutionScene.PrepareScene(mon);
        if (mon.makeShedinja && NumberOf(ItemID.PokeBall) > 0)
        {
            if (TryAddMon(Pokemon.WildPokemon(SpeciesID.Shedinja, 1)))
                UseItem(ItemID.PokeBall);
        }
        yield return FadeFromBlack(0.2F);
        yield return evolutionScene.DoEvolutionScene();
        yield return FadeToBlack(0.2F);
    }

    public Vector2Int GetMapOffset(Connection connection)
    {
        return connection.direction switch
        {
            Direction.N => new Vector2Int(connection.offset, currentMap.height),
            Direction.S => new Vector2Int(connection.offset, 0 - connection.map.height),
            Direction.E => new Vector2Int(currentMap.width, connection.offset),
            Direction.W => new Vector2Int(0 - connection.map.width, connection.offset),
            _ => Vector2Int.zero
        };
    }

    public Vector2Int GetCoordinateWithOffset(Connection i, Vector2Int basePos)
        => GetMapOffset(i) + basePos;

    public bool CheckCollisionAllowed(Vector2Int pos, CollisionID currentCollision, bool checkChars = true)
    {
        CollisionID nextCollision = CheckCollision(pos, checkChars);
        if (nextCollision == CollisionID.Impassable) return false;
        if (currentCollision == CollisionID.Change) return true;
        if (nextCollision is CollisionID.Bridge or CollisionID.Change) return true;
        if (currentCollision == nextCollision) return true;
        else return false;
    }

    private void TryChangeMap(int x, int y)
    {
        if (x >= mapManager.map.width)
        {
            foreach (Connection i in mapManager.map.connection)
            {
                if (i.direction == Direction.E && y >= i.offset && y < i.map.height + i.offset)
                {
                    lastMap = currentMap;
                    currentMap = i.map;
                    SwitchAndReposition(new Vector2Int(-1, y - i.offset));
                    AlignPlayer();
                }
            }
        }
        else if (x < 0)
        {
            foreach (Connection i in mapManager.map.connection)
            {
                if (i.direction == Direction.W && y >= i.offset && y < i.map.height + i.offset)
                {
                    lastMap = currentMap;
                    currentMap = i.map;
                    SwitchAndReposition(new Vector2Int(i.map.width, y - i.offset));
                    AlignPlayer();
                }
            }
        }
        else if (y >= mapManager.map.height)
        {
            foreach (Connection i in mapManager.map.connection)
            {
                if (i.direction == Direction.N && x >= i.offset && x < i.map.width + i.offset)
                {
                    lastMap = currentMap;
                    currentMap = i.map;
                    SwitchAndReposition(new Vector2Int(x - i.offset, -1));
                    AlignPlayer();
                }
            }
        }
        else if (y < 0)
        {
            foreach (Connection i in mapManager.map.connection)
            {
                if (i.direction == Direction.S && x >= i.offset && x < i.map.width + i.offset)
                {
                    lastMap = currentMap;
                    currentMap = i.map;
                    SwitchAndReposition(new Vector2Int(x - i.offset, i.map.height));
                    AlignPlayer();
                }
            }
        }
    }

    private void FindGUI()
    {
        announcer = FindAnyObjectByType<FieldAnnouncer>();
        announcer.player = this;
        menu = FindAnyObjectByType<FieldMenu>();
        menu.player = this;
        canvas = menu.canvas;
    }

    private void AlignMenu()
    {
        if (menuOpen) menu.transform.localPosition = menuOpenPos;
    }

    public void CaptureCamera() => camera.transform.parent = playerGraphics.playerObject.transform;

    public void DonateCamera(LoadedChar chara) => camera.transform.parent = chara.gameObject.transform;

    public void FreeCamera() => camera.transform.parent = null;

    public void CenterCamera() => camera.transform.localPosition = new Vector3(0, 0, -100);

    public IEnumerator StartSingleTrainerBattle(LoadedChar opponentChar, TeamData opponentTeam)
    {
        Pokemon[] opponentParty = opponentTeam.GetParty();
        state = PlayerState.Locked;
        locked = true;
        active = false;
        DeactivateAll();
        mapManager.ClearMap();
        opponent = opponentChar;
        yield return FadeToBlack(0.2F);
        yield return Scene.Battle.Load();
        Battle battle = FindAnyObjectByType<Battle>();
        battle.player = this;
        SortParty();
        battle.opponentName = opponentTeam.trainerName;
        battle.playerPokemon = Party;
        battle.opponentPokemon = opponentParty;
        opponentParty.HealAll();
        battle.battleType = Battle.BattleType.Single;
        battle.wildBattle = false;
        battle.battleTerrain = currentTerrain;
        battle.prizeMoney = opponentTeam.prizeMoney;
        yield return FadeFromBlack(0.2F);
        battle.StartCoroutine(battle.StartBattle());
    }

    public IEnumerator StartSingleWildBattle(Pokemon wildMon)
    {
        Debug.Log("Start Single Wild Battle");
        state = PlayerState.Locked;
        locked = true;
        active = false;
        DeactivateAll();
        yield return FadeToBlack(0.2F);
        yield return Scene.Battle.Load();
        Battle battle = FindAnyObjectByType<Battle>();
        battle.player = this;
        SortParty();
        battle.playerPokemon = Party;
        battle.opponentPokemon = new Pokemon[6];
        battle.opponentPokemon[0] = wildMon;
        for (int i = 1; i < 6; i++)
        {
            battle.opponentPokemon[i] = Pokemon.EmptyMon;
        }
        battle.battleType = Battle.BattleType.Single;
        battle.battleTerrain = currentTerrain;
        battle.wildBattle = true;
        yield return FadeFromBlack(0.2F);
        battle.StartCoroutine(battle.StartBattle());
    }

    public IEnumerator BattleWon()
    {
        yield return FadeToBlack(0.2F);
        ResetTransformations();
        yield return CheckEvolutions();
        yield return Scene.Map.Load();
        Debug.Log("Map loaded");
        MapReturn();
        ActivateAll();
        yield return FadeFromBlack(0.2F);
        active = true;
        locked = false;
    }

    public IEnumerator WildBattleWon()
    {
        yield return BattleWon();
        state = PlayerState.Free;
    }

    public IEnumerator TrainerBattleWon()
    {
        yield return BattleWon();
        yield return opponent.charData.OnWin(this, opponent);
    }

    public IEnumerator FadeToBlack(float duration)
    {
        float baseTime = Time.time;
        float endTime = baseTime + duration;
        while (Time.time < endTime)
        {
            blackScreenRenderer.color = new(0, 0, 0, (Time.time - baseTime) / duration);
            yield return null;
        }
        blackScreenOn = true;
    }

    public IEnumerator FadeFromBlack(float duration)
    {
        float endTime = Time.time + duration;
        while (Time.time < endTime)
        {
            blackScreenRenderer.color = new(0, 0, 0, (endTime - Time.time) / duration);
            yield return null;
        }
        blackScreenRenderer.color = new(0, 0, 0, 0);
        blackScreenOn = false;
    }

    public string GaveToHold(int i) => "Gave " + Party[i].MonName + " the " +
                                    Party[i].item.Data().itemName + " to hold.";

    private IEnumerator DoPartyScreenWithPrompt()
    {
        yield return Scene.Party.Load();
        partyScreen = FindObjectOfType<PartyScreen>();
        StartCoroutine(FadeFromBlack(0.2f));
        yield return partyScreen.DoPartyScreen(true);
    }

    private IEnumerator DoWarp(WarpTrigger warp)
    {
        locked = true;
        state = PlayerState.Locked;
        TileBase targetTile = mapManager.level1.GetTile(new(2 * warp.pos.x, 2 * warp.pos.y));
        if (targetTile is IDoor)
        {
            yield return TriggeredTileAnim.DoDoorAnim(this, warp.pos, (IDoor)targetTile, 0.3f);
        }
        StartCoroutine(WalkInDirection());
        yield return FadeToBlack(0.3f);
        currentMap = warp.destination;
        pos = warp.destinationPos;
        SwitchMap();
        AlignPlayer();
        bool isDoor = false;
        TileBase newTile = mapManager.level1.GetTile(new(2 * pos.x, 2 * pos.y));
        if (newTile is IDoor) isDoor = true;
        if (isDoor)
        {
            StartCoroutine(TriggeredTileAnim.DoBackwardsDoorAnim(p, pos, (IDoor)newTile, 0.3f));
        }
        yield return FadeFromBlack(0.3f);
        if (isDoor)
        {
            yield return GoSouth();
        }
        locked = false;
        state = PlayerState.Free;
    }

    public IEnumerator DoMenu()
    {
        const float menuDistance = 6f;
        menuOpen = true;
        LockAll();
        menu.OpenMenu();
        audioSource.PlayOneShot(SFX.BagOpen);
        state = PlayerState.Locked;
        yield return AnimUtils.Slide(menu.transform, new Vector2(-menuDistance, 0f), 0.2f);
        menuOpenPos = menu.transform.localPosition;
        bool done = false;
        while (!done)
        {
            yield return menu.DoMenu();
            switch (cachedMenuItem)
            {
                case MenuItem.Bag:
                    DeactivateAll();
                    cachedScreenData = new BagCachedData();
                    yield return FadeToBlack(0.2f);
                    bool doneBag = false;
                    while (!doneBag)
                    {
                        yield return Scene.Bag.Load();
                        bagController = FindObjectOfType<BagController>();
                        StartCoroutine(FadeFromBlack(0.2f));
                        yield return bagController.DoBag(this, false, (BagCachedData)cachedScreenData);
                        switch (bagOutcome)
                        {
                            case BagOutcome.None:
                                yield return FadeToBlack(0.2f);
                                yield return Scene.Map.Load();
                                MapReturn();
                                menu.transform.localPosition = menuOpenPos;
                                menu.OpenMenu(MenuItem.Bag);
                                yield return FadeFromBlack(0.2f);
                                ActivateAll();
                                doneBag = true;
                                break;
                            case BagOutcome.Use:
                                yield return FadeToBlack(0.2f);
                                switch (bagResult.FieldEffect())
                                {
                                    default: //Going to party menu
                                        yield return DoPartyScreenWithPrompt();
                                        yield return FadeToBlack(0.2f);
                                        break;
                                    case FieldEffect.Evolution:
                                        yield return Scene.Party.Load();
                                        partyScreen = FindObjectOfType<PartyScreen>();
                                        StartCoroutine(FadeFromBlack(0.2f));
                                        yield return partyScreen.DoPartyScreen(true);
                                        if (partyScreenOutcome == PartyScreenOutcome.Evo)
                                        {
                                            Pokemon mon = Party[partyScreenResult];
                                            foreach (EvolutionData evo in mon.SpeciesData.evolution)
                                            {
                                                if (evo.Method is EvolutionMethod.EvolutionItem &&
                                                    evo.Data == (int)bagResult)
                                                {
                                                    mon.shouldEvolve = true;
                                                    mon.destinationSpecies = evo.Destination;
                                                    break;
                                                }
                                            }
                                            if (mon.shouldEvolve)
                                            {
                                                UseItem(bagResult);
                                                yield return DoSingleEvolution(mon, null);
                                            }
                                        }
                                        else
                                        {
                                            yield return FadeToBlack(0.2f);
                                        }
                                        break;
                                }
                                break;
                            case BagOutcome.Give:
                                yield return FadeToBlack(0.2f);
                                yield return DoPartyScreenWithPrompt();
                                yield return FadeToBlack(0.2f);
                                break;

                        }
                    }
                    break;
                case MenuItem.Pokemon:
                    DeactivateAll();
                    cachedScreenData = new PartyBoxCachedData();
                    yield return FadeToBlack(0.2f);
                    bool donepartyScreen = false;
                    bool skipLoad = false;
                    while (!donepartyScreen)
                    {
                        if (!skipLoad)
                        {
                            yield return Scene.Party.Load();
                            partyScreen = FindObjectOfType<PartyScreen>();
                            StartCoroutine(FadeFromBlack(0.2f));
                            yield return partyScreen.DoPartyScreen(false);
                        }
                        else skipLoad = false;
                        switch (partyScreenOutcome)
                        {
                            default:
                            case PartyScreenOutcome.None:
                                yield return FadeToBlack(0.2f);
                                yield return Scene.Map.Load();
                                MapReturn();
                                menu.transform.localPosition = menuOpenPos;
                                menu.OpenMenu(MenuItem.Pokemon);
                                yield return FadeFromBlack(0.2f);
                                ActivateAll();
                                donepartyScreen = true;
                                break;
                            case PartyScreenOutcome.GiveItem:
                                yield return FadeToBlack(0.2f);
                                yield return Scene.Bag.Load();
                                BagController bagController = FindObjectOfType<BagController>();
                                StartCoroutine(FadeFromBlack(0.2f));
                                yield return bagController.DoBag(this, true);
                                int cachedMon = ((PartyBoxCachedData)cachedScreenData).currentMon;
                                Party[cachedMon].item = bagResult;
                                Party[cachedMon].CheckTransformation();
                                if (!bagResult.IsZCrystal()) UseItem(bagResult);
                                yield return FadeToBlack(0.2f);
                                yield return Scene.Party.Load();
                                PartyScreen partyScreen = FindObjectOfType<PartyScreen>();
                                StartCoroutine(FadeFromBlack(0.2f));
                                if (bagResult != ItemID.None)
                                    yield return partyScreen.DoPartyScreen(false, cachedMon, true,
                                        GaveToHold(cachedMon));
                                else
                                    yield return partyScreen.DoPartyScreen(false, cachedMon);
                                skipLoad = true;
                                break;
                        }

                    }
                    break;
                case MenuItem.Pokedex:
                    DeactivateAll();
                    yield return FadeToBlack(0.2f);
                    yield return Scene.Pokedex.Load();
                    DexScreen dexScreen = FindAnyObjectByType<DexScreen>();
                    yield return FadeFromBlack(0.2f);
                    yield return dexScreen.DoDexScreen();
                    yield return FadeToBlack(0.2f);
                    yield return Scene.Map.Load();
                    MapReturn();
                    menu.transform.localPosition = menuOpenPos;
                    menu.OpenMenu(MenuItem.Pokedex);
                    yield return FadeFromBlack(0.2f);
                    ActivateAll();
                    break;
                case MenuItem.Save:
                    SaveGame();
                    state = PlayerState.Announce;
                    menu.active = false;
                    yield return announcer.AnnouncementUp();
                    yield return announcer.Announce("Game saved.");
                    yield return announcer.AnnouncementDown();
                    yield return null;
                    menu.active = true;
                    state = PlayerState.Locked;

#if UNITY_EDITOR
                    Debug.Log(Application.persistentDataPath);
#endif
                    break;
                case MenuItem.CloseMenu:
                default:
                    done = true;
                    break;
            }
        }
        yield return AnimUtils.Slide(menu.transform, new Vector2(menuDistance, 0f), 0.2f);
        menuOpen = false;
        state = PlayerState.Free;
        menu.ClearName();
        UnlockAll();
    }

    public IEnumerator DoBagPrompt()
    {
        yield return FadeToBlack(0.2f);
        DeactivateAll();
        yield return Scene.Bag.Load();
        BagController bagController = FindObjectOfType<BagController>();
        StartCoroutine(FadeFromBlack(0.2f));
        yield return bagController.DoBag(this, true);
        yield return FadeToBlack(0.2f);
        yield return Scene.Map.Load();
        MapReturn();
        ActivateAll();
        yield return FadeFromBlack(0.2f);
    }

    public bool CheckWarps(Direction dir)
    {
        foreach (WarpTrigger warp in warps)
        {
            Debug.Log(warp);
            switch (warp.triggerType)
            {
                case WarpTrigger.TriggerType.WalkOn:
                    if (pos + dir.Vector() == warp.pos)
                    {
                        StartCoroutine(DoWarp(warp));
                        return true;
                    }
                    break;
                case WarpTrigger.TriggerType.WalkNorthFrom:
                    if (pos == warp.pos && dir is Direction.N)
                    {
                        StartCoroutine(DoWarp(warp));
                        return true;
                    }
                    break;
                case WarpTrigger.TriggerType.WalkEastFrom:
                    if (pos == warp.pos && dir is Direction.E)
                    {
                        StartCoroutine(DoWarp(warp));
                        return true;
                    }
                    break;
                case WarpTrigger.TriggerType.WalkWestFrom:
                    if (pos == warp.pos && dir is Direction.W)
                    {
                        StartCoroutine(DoWarp(warp));
                        return true;
                    }
                    break;
                case WarpTrigger.TriggerType.WalkSouthFrom:
                    if (pos == warp.pos && dir is Direction.S)
                    {
                        StartCoroutine(DoWarp(warp));
                        return true;
                    }
                    break;
                default:
                    break;
            }
        }
        return false;
    }


    public void CheckGrassEncounter()
    {
        byte index = mapManager.wildData[pos.x, pos.y];
        if (index == 0) return;
        WildDataset dataset = currentMap.grassData[index - 1];
        if (random.NextDouble() * 100 < dataset.encounterPercent)
        {
            StartCoroutine(StartSingleWildBattle(dataset.GetWildMon()));
        }
    }

    public void TryGoSouth()
    {
        if (facing != Direction.S)
            StartCoroutine(playerGraphics.FaceSouth(this, 0.1F));
        else if (CheckWarps(Direction.S)) return;
        else if (CheckCollisionAllowed(GetFacingTile(), currentHeight))
        {
            TryChangeMap(pos.x, pos.y - 1);
            CheckTileBehavior(GetFacingTile());
            StartCoroutine(GoSouth());
        }
        else
        {
            StartCoroutine(playerGraphics.BumpSouth(this, 0.3F));
        }
    }

    public void TryGoNorth()
    {
        if (facing != Direction.N)
            StartCoroutine(playerGraphics.FaceNorth(this, 0.1F));
        else if (CheckWarps(Direction.N)) return;
        else if (CheckCollisionAllowed(GetFacingTile(), currentHeight))
        {
            TryChangeMap(pos.x, pos.y + 1);
            CheckTileBehavior(GetFacingTile());
            StartCoroutine(GoNorth());
        }
        else
        {
            StartCoroutine(playerGraphics.BumpNorth(this, 0.3F));
        }
    }

    public void TryGoWest()
    {
        if (facing != Direction.W)
            StartCoroutine(playerGraphics.FaceWest(this, 0.1F));
        else if (CheckWarps(Direction.W)) return;
        else if (CheckCollisionAllowed(GetFacingTile(), currentHeight))
        {
            TryChangeMap(pos.x - 1, pos.y);
            CheckTileBehavior(GetFacingTile());
            StartCoroutine(GoWest());
        }
        else
        {
            StartCoroutine(playerGraphics.BumpWest(this, 0.3F));
        }
    }

    public void TryGoEast()
    {
        if (facing != Direction.E)
            StartCoroutine(playerGraphics.FaceEast(this, 0.1F));
        else if (CheckWarps(Direction.E)) return;
        else if (CheckCollisionAllowed(GetFacingTile(), currentHeight))
        {
            TryChangeMap(pos.x + 1, pos.y);
            CheckTileBehavior(GetFacingTile());
            StartCoroutine(GoEast());
        }
        else
        {
            StartCoroutine(playerGraphics.BumpEast(this, 0.3F));
        }
    }
    public IEnumerator GoSouth()
    {
        state = PlayerState.Moving;
        yield return playerGraphics.WalkSouth(this, 0.3F);
        UpdateCollision();
        state = locked ? PlayerState.Locked : PlayerState.Free;
        if (!CheckForTriggers())
            CheckGrassEncounter();
    }

    public IEnumerator GoNorth()
    {
        state = PlayerState.Moving;
        yield return playerGraphics.WalkNorth(this, 0.3F);
        UpdateCollision();
        state = locked ? PlayerState.Locked : PlayerState.Free;
        if (!CheckForTriggers())
            CheckGrassEncounter();
    }

    public IEnumerator GoWest()
    {
        state = PlayerState.Moving;
        yield return playerGraphics.WalkWest(this, 0.3F);
        UpdateCollision();
        state = locked ? PlayerState.Locked : PlayerState.Free;
        if (!CheckForTriggers())
            CheckGrassEncounter();
    }

    public IEnumerator GoEast()
    {
        state = PlayerState.Moving;
        yield return playerGraphics.WalkEast(this, 0.3F);
        UpdateCollision();
        state = locked ? PlayerState.Locked : PlayerState.Free;
        if (!CheckForTriggers())
            CheckGrassEncounter();
    }

    public bool CheckForTriggers()
    {
        foreach (TileTrigger i in triggers)
        {
            if (i.pos == new Vector2Int(pos.x, pos.y))
            {
                StartCoroutine(i.script.OnTrigger(this));
                return true;
            }
        }
        return false;
    }

    public bool CheckForCharacters()
    {
        Vector2Int facingTile = GetFacingTile();
        foreach ((MapData _, LoadedChar i) in loadedChars.Values)
        {
            if (i.pos == facingTile && i.available)
            {
                StartCoroutine(i.charData.OnInteract(this, i));
                return true;
            }
        }
        return false;
    }

    public bool CheckForSignposts()
    {
        Vector2Int facingTile = GetFacingTile();
        foreach (TileTrigger i in signposts)
        {
            if (i.pos == facingTile)
            {
                audioSource.PlayOneShot(SFX.Message);
                StartCoroutine(i.script.OnTrigger(this));
                return true;
            }
        }
        return false;
    }

    public IEnumerator DoBox()
    {
        if (boxes.Count is 0) boxes = new()
        {
            new("Box 1"),
            new("Box 2"),
            new("Box 3"),
            new("Box 4"),
            new("Box 5"),
            new("Box 6"),
            new("Box 7"),
            new("Box 8")
        };
        Lock();
        yield return FadeToBlack(0.2F);
        DeactivateAll();
        boxGiving = false;
        bool done = false;
        while (!done)
        {
            yield return Scene.Box.Load();
            BoxScreen boxScreen = FindAnyObjectByType<BoxScreen>();
            boxScreen.p = this;
            yield return FadeFromBlack(0.2F);
            if (boxGiving)
                yield return boxScreen.GiveAndDoBoxScreen();
            else
                yield return boxScreen.DoBoxScreen();
            yield return FadeToBlack(0.2F);
            if (!boxGiving)
            {
                done = true;
            }
            else
            {
                yield return Scene.Bag.Load();
                BagController bagController = FindObjectOfType<BagController>();
                StartCoroutine(FadeFromBlack(0.2f));
                yield return bagController.DoBag(this, true);
                UseItem(bagResult);
                boxGiveTarget.item = bagResult;
                boxGiveTarget.CheckTransformation();
                yield return FadeToBlack(0.2F);
            }
        }
        yield return Scene.Map.Load();
        MapReturn();
        ActivateAll();
        yield return FadeFromBlack(0.2F);
        Unlock();
    }

    public void StartBox() => StartCoroutine(DoBox());

    public void CheckForInteractables()
    {
        if (!CheckForCharacters())
            CheckForSignposts();
    }

    public IEnumerator DoAnnouncements(List<string> text)
    {
        PlayerState previousState = state;
        state = PlayerState.Announce;
        yield return announcer.AnnouncementUp();
        bool chime = false;
        foreach (string i in text)
        {
            yield return announcer.Announce(i, chime);
            chime = true;
        }
        yield return announcer.AnnouncementDown();
        state = previousState;
    }

    private void ResetTransformations()
    {
        foreach (Pokemon mon in Party)
        {
            mon.transformed = false;
            if (mon.hp > mon.hpMax) mon.hp = mon.hpMax;
        }
    }

    public void Lock()
    {
        locked = true;
        state = PlayerState.Locked;
    }

    public void Unlock()
    {
        locked = false;
        state = PlayerState.Free;
    }

    private void MapReturn()
    {
        if (todShading == null) todShading = TODShading.Initialize(this);
        camera = Instantiate(Resources.Load<GameObject>("Prefabs/Map CameraGUI"));
        FindGUI();
        AlignMenu();
        mapManager = gameObject.AddComponent<MapManager>();
        RenderMap();
        CreatePlayerGraphics(CharGraphics.brendanWalk);
        AlignPlayer();
        CaptureCamera();
        CenterCamera();
        UpdateCollision();
    }

    public IEnumerator InitMapTest()
    {
        yield return Scene.Map.Load();
        MapReturn();
        boxes = new()
        {
            new("Box 1"),
            new("Box 2"),
            new("Box 3"),
            new("Box 4"),
            new("Box 5"),
            new("Box 6"),
            new("Box 7"),
            new("Box 8")
        };
        Pokemon bulbasaur = Pokemon.WildPokemon(SpeciesID.Bulbasaur, 15);
        bulbasaur.move1 = MoveID.Toxic;
        bulbasaur.pp1 = 30;
        bulbasaur.move2 = MoveID.Growl;
        bulbasaur.pp2 = 40;
        bulbasaur.move3 = MoveID.Tackle;
        bulbasaur.pp3 = 40;
        Pokemon golisopod = Pokemon.WildPokemon(SpeciesID.Golisopod, 5);
        golisopod.move1 = MoveID.HeadSmash;
        golisopod.pp1 = 30;
        golisopod.move2 = MoveID.BellyDrum;
        golisopod.pp2 = 30;
        Pokemon minior = Pokemon.WildPokemon(SpeciesID.MiniorRedMeteor, 30);
        minior.move1 = MoveID.ClangorousSoul;
        minior.pp1 = 30;
        minior.move2 = MoveID.BellyDrum;
        minior.pp2 = 30;
        TryAddMon(bulbasaur);
        TryAddMon(golisopod);
        TryAddMon(minior);
        TryAddMon(Pokemon.WildPokemon(SpeciesID.Pikachu, 5));
        TryAddMon(Pokemon.WildPokemon(SpeciesID.Dialga, 5));
        AddItem(ItemID.PokeBall, 5);
        AddItem(ItemID.GreatBall, 5);
        AddItem(ItemID.CheriBerry, 5);
        AddItem(ItemID.ThunderStone, 1);
        AddItem(ItemID.Potion, 3);
        AddItem(ItemID.AdamantCrystal, 1);
        AddItem(ItemID.AbilityCapsule, 2);
        AddItem(ItemID.SwiftFeather, 5);
        AddItem(ItemID.Carbos, 10);
        AddItem(ItemID.PPUp, 5);
        AddItem(ItemID.PPMax, 5);
        seenFlags[(int)SpeciesID.Raichu] = true;
        seenFlags[(int)SpeciesID.RaichuAlola] = true;
        seenFlags[(int)SpeciesID.VivillonArchipelago] = true;
        seenFlags[(int)SpeciesID.VivillonContinental] = true;
        seenFlags[(int)SpeciesID.VivillonElegant] = true;
        seenFlags[(int)SpeciesID.VivillonFancy] = true;
        seenFlags[(int)SpeciesID.VivillonGarden] = true;
        seenFlags[(int)SpeciesID.VivillonHighPlains] = true;
        seenFlags[(int)SpeciesID.VivillonIcySnow] = true;
        seenFlags[(int)SpeciesID.VivillonJungle] = true;
        seenFlags[(int)SpeciesID.VivillonMarine] = true;
        seenFlags[(int)SpeciesID.VivillonMeadow] = true;
        seenFlags[(int)SpeciesID.VivillonModern] = true;
        seenFlags[(int)SpeciesID.VivillonMonsoon] = true;
        seenFlags[(int)SpeciesID.VivillonOcean] = true;
        seenFlags[(int)SpeciesID.VivillonPokeBall] = true;
        seenFlags[(int)SpeciesID.VivillonPolar] = true;
        seenFlags[(int)SpeciesID.VivillonRiver] = true;
        seenFlags[(int)SpeciesID.VivillonSandstorm] = true;
        seenFlags[(int)SpeciesID.VivillonSavanna] = true;
        seenFlags[(int)SpeciesID.VivillonSun] = true;
        seenFlags[(int)SpeciesID.VivillonTundra] = true;
        active = true;
    }

    public void Start()
    {
        player = this;
        Time.timeScale = 1;
        p = this;
        random = new();
        if (blackScreen == null)
        {
            blackScreen = new("BlackScreen");
            blackScreen.transform.parent = transform;
            blackScreen.transform.localScale = new(1000, 1000, 1000);
            blackScreen.transform.position = new(0, 0, -9);
            blackScreenRenderer = blackScreen.AddComponent<SpriteRenderer>();
            blackScreenRenderer.sprite = Sprite.Create(Resources.Load<Texture2D>("Sprites/Box"), new Rect(0, 0, 4, 4), StaticValues.defPivot, 4);
            blackScreenRenderer.color = new(0, 0, 0, blackScreenOn ? 255 : 0);
            blackScreenRenderer.sortingOrder = 10;
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex((int)Scene.Main))
        {
            StartCoroutine(InitMapTest());
        }
    }

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public override void Update()
    {
        if (active)
        {
            switch (state)
            {
                case PlayerState.Free:
                    AlignPlayer();
                    foreach ((MapData _, LoadedChar chara) in loadedChars.Values)
                    {
                        if (chara.charData.SeeCheck(this))
                        {
                            if (chara.CheckForSight(chara)) return;
                        }
                    }
                    if (Input.GetKey(KeyCode.UpArrow)) TryGoNorth();
                    else if (Input.GetKey(KeyCode.DownArrow)) TryGoSouth();
                    else if (Input.GetKey(KeyCode.LeftArrow)) TryGoWest();
                    else if (Input.GetKey(KeyCode.RightArrow)) TryGoEast();
                    else if (Input.GetKeyDown(KeyCode.Return)) CheckForInteractables();
                    else if (Input.GetKeyDown(KeyCode.M)) StartCoroutine(DoMenu());
                    break;
                case PlayerState.Moving:
                    break;
                case PlayerState.Locked:
                    break;
                case PlayerState.Announce:
                    break;
                default:
                    break;
            }
        }
    }
}
