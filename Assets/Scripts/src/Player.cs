using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;
using Scene = SceneID;

public class Player : MonoBehaviour
{


    public bool[] TM = new bool[96];
    public bool[] HM = new bool[8];
    public bool[] keyItem = new bool[8];
    public bool[] storyFlags = new bool[(int)Flag.Count];
    public bool[] trainerFlags = new bool[(int)TrainerFlag.Count];
    public List<Box> boxes = new();

    public System.Random random;

    public Dictionary<ItemID, int> Bag;
    public Dictionary<MapID, bool[,]> neighborCollision;

    public List<TileTrigger> triggers;
    public List<TileTrigger> signposts;

    public BattleTerrain currentTerrain;
    public MapID currentMap;
    public MapID lastMap = 0;
    public Vector2Int pos;
    public Vector2Int moveTarget;
    public PlayerState state;
    public bool active;
    public bool locked;
    public Direction facing;

    public Dictionary<int, LoadedChar> loadedChars;
    public LoadedChar opponent;

    public bool whichStep;

    public CollisionID currentHeight;
    public MapManager mapManager;
    public PlayerMovement playerGraphics;
    public GUIManager announcer;

    public HumanoidGraphicsID graphicsID;

    public new GameObject camera;

    public float textSpeed = 25;

    public Pokemon[] Party = new Pokemon[6];
    private int monsInParty
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
                keyItem[Item.ItemTable[(int)item].ItemSubdata[0]] = true;
                break;
            default:
                if (Bag.ContainsKey(item))
                {
                    Bag[item] += amount;
                }
                else
                {
                    Bag.Add(item, amount);
                }
                break;
        }
        yield break;
    }

    public void DeactivateAll() { foreach (LoadedChar i in loadedChars.Values) i.Deactivate(); }
    public void ActivateAll() { foreach (LoadedChar i in loadedChars.Values) i.Activate(); }

    public void RemoveAllChars() => loadedChars = new();

    public bool TryAddMon(Pokemon mon)
    {
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

    private void SortParty()
    {
        int currentPos = 0;
        for (int i = 0; i < 6; i++)
        {
            if (Party[i].exists)
            {
                Party[currentPos] = Party[i];
                currentPos++;
            }
        }
        for (int i = currentPos; i < 6; i++)
        {
            Party[i] = Pokemon.MakeEmptyMon;
        }
    }

    public void EmptyParty()
    {
        for (int i = 0; i < 6; i++)
        {
            Party[i] = Pokemon.MakeEmptyMon;
        }
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
        mapManager.mapID = currentMap;
        mapManager.ReadMap();
        currentMap.Data().BeforeLoad(this);
        RefreshObjects();
        currentMap.Data().OnLoad(this);
    }

    public void RefreshTriggers()
    {
        triggers = new();
        foreach (TileTrigger i in currentMap.Data().triggers) triggers.Add(i);
    }

    public void RefreshSignposts()
    {
        signposts = new();
        foreach (TileTrigger i in currentMap.Data().signposts) signposts.Add(i);
    }

    public void RefreshChars()
    {
        loadedChars ??= new();
        List<MapID> maps = new() { currentMap };
        foreach (Connection i in currentMap.Data().connection)
        {
            Debug.Log("Adding " + i.map);
            maps.Add(i.map);
        }
        foreach (LoadedChar i in loadedChars.Values)
        {
            bool keep = false;
            Debug.Log(currentMap);
            Debug.Log(i.currentMap);
            if (i.keepOnLoad)
            {
                if (i.currentMap != currentMap)
                    foreach (Connection j in currentMap.Data().connection)
                    {
                        if (j.map == i.currentMap) i.pos += GetMapOffset(j);
                    };
                i.currentMap = currentMap;
                continue;
            }
            foreach (MapID j in maps)
            {
                Debug.Log("Testing " + j);
                Debug.Log("MapID is " + i.charData.mapID);
                if (i.charData.mapID == j)
                {
                    Debug.Log("Matched");
                    if (i.currentMap != currentMap)
                        foreach (Connection k in currentMap.Data().connection)
                        {
                            if (k.map == i.currentMap)
                            {
                                Debug.Log(i.pos);
                                Debug.Log(GetMapOffset(k));
                                i.pos += GetMapOffset(k);
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
        foreach (MapID i in maps)
        {
            foreach (CharData j in i.Data().chars)
            {
                if (!j.IsLoaded(this))
                {
                    j.Load(this);
                    if (i != currentMap)
                    {
                        foreach (Connection k in currentMap.Data().connection)
                        {
                            if (k.map == i) j.pos += GetMapOffset(k);
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
        RefreshChars();
    }

    public LoadedChar GetChar(int index, MapID map = 0)
    {
        if (map == 0) map = currentMap;
        return loadedChars[map.ObjID(index)];
    }

    public void SwitchAndReposition(Vector2Int pos)
    {
        mapManager.mapID = currentMap;
        mapManager.ReadAndReposition(this, pos);
        currentMap.Data().BeforeLoad(this);
        RefreshObjects();
        currentMap.Data().OnLoad(this);
    }

    public void AlignPlayer() => playerGraphics.playerTransform.position = new Vector3(pos.x + 0.5F, pos.y + 0.5F, pos.y);

    public void UpdateCollision() => currentHeight = CheckCollision(pos, false);

    public void CreatePlayerGraphics(HumanoidGraphicsID id) => playerGraphics = new(this, id);

    public CollisionID CheckCollision(Vector2Int pos, bool checkChars)
    {
        if (checkChars)
        {
            if (pos == this.pos || (state == PlayerState.Moving && pos == moveTarget)) return CollisionID.Impassable;
            if (loadedChars.Count > 0) foreach (LoadedChar loadedChar in loadedChars.Values)
                    if (loadedChar.pos == pos || (loadedChar.moving && loadedChar.moveTarget == pos)) return CollisionID.Impassable;
        }
        if (pos.x >= 0 && pos.y >= 0 && pos.x < currentMap.Data().width && pos.y < currentMap.Data().height)
            return (CollisionID)mapManager.collision[pos.x, pos.y];
        else
        {
            return CollisionOnBorderingMaps(pos);
        }
    }

    private CollisionID CollisionOnBorderingMaps(Vector2Int pos)
    {
        (MapID? map, Vector2Int pos) relativeTile = TileOutsideMap(pos);
        if (relativeTile.map == null) return CollisionID.Impassable;
        else
        {
            return (CollisionID)mapManager.borderingCollision[(MapID)relativeTile.map]
                [relativeTile.pos.x, relativeTile.pos.y];
        }
    }

    private (MapID?, Vector2Int) TileOutsideMap(Vector2Int pos)
    {
        foreach (Connection i in currentMap.Data().connection)
        {
            Vector2Int checkPos = pos - GetMapOffset(i);
            if (checkPos.x >= 0 && checkPos.x < i.map.Data().width
                && checkPos.y >= 0 && checkPos.y < i.map.Data().height)
                return (i.map, checkPos);
        }
        return (null, Vector2Int.zero);
    }

    public Vector2Int GetMapOffset(Connection connection)
    {
        return connection.direction switch
        {
            Direction.N => new Vector2Int(connection.offset, currentMap.Data().height),
            Direction.S => new Vector2Int(connection.offset, 0 - connection.map.Data().height),
            Direction.E => new Vector2Int(currentMap.Data().width, connection.offset),
            Direction.W => new Vector2Int(0 - connection.map.Data().width, connection.offset),
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
        if (x >= mapManager.mapData.width)
        {
            foreach (Connection i in mapManager.mapData.connection)
            {
                if (i.direction == Direction.E && y >= i.offset && y < i.map.Data().height + i.offset)
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
            foreach (Connection i in mapManager.mapData.connection)
            {
                if (i.direction == Direction.W && y >= i.offset && y < i.map.Data().height + i.offset)
                {
                    lastMap = currentMap;
                    currentMap = i.map;
                    SwitchAndReposition(new Vector2Int(i.map.Data().width, y - i.offset));
                    AlignPlayer();
                }
            }
        }
        else if (y >= mapManager.mapData.height)
        {
            foreach (Connection i in mapManager.mapData.connection)
            {
                if (i.direction == Direction.N && x >= i.offset && x < i.map.Data().width + i.offset)
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
            foreach (Connection i in mapManager.mapData.connection)
            {
                if (i.direction == Direction.S && x >= i.offset && x < i.map.Data().width + i.offset)
                {
                    lastMap = currentMap;
                    currentMap = i.map;
                    SwitchAndReposition(new Vector2Int(x - i.offset, i.map.Data().height));
                    AlignPlayer();
                }
            }
        }
    }

    private void FindAnnouncer()
    {
        announcer = FindAnyObjectByType<GUIManager>();
        announcer.player = this;
    }

    private void CaptureCamera()
    {
        camera.transform.parent = playerGraphics.playerObject.transform;
        camera.transform.localPosition = new Vector3(0, 0, -100);
    }

    public IEnumerator StartSingleTrainerBattle(LoadedChar opponentChar, TeamData opponentTeam)
    {
        Pokemon[] opponentParty = opponentTeam.GetParty();
        state = PlayerState.Locked;
        active = false;
        DeactivateAll();
        mapManager.ClearMap();
        opponent = opponentChar;
        yield return Scene.Battle.Load();
        Battle battle = FindAnyObjectByType<Battle>();
        battle.player = this;
        SortParty();
        battle.OpponentName = opponentTeam.trainerName;
        battle.PlayerPokemon = Party;
        battle.OpponentPokemon = opponentParty;
        battle.battleType = BattleType.Single;
        battle.wildBattle = false;
        battle.battleTerrain = currentTerrain;
        battle.StartCoroutine(battle.StartBattle());
    }

    public IEnumerator StartSingleWildBattle(Pokemon wildMon)
    {
        Debug.Log("Start Single Wild Battle");
        yield return null;
        state = PlayerState.Locked;
        active = false;
        DeactivateAll();
        mapManager.ClearMap();
        yield return null;
        yield return Scene.Battle.Load();
        Battle battle = FindAnyObjectByType<Battle>();
        battle.player = this;
        SortParty();
        battle.PlayerPokemon = Party;
        battle.OpponentPokemon = new Pokemon[6];
        battle.OpponentPokemon[0] = wildMon;
        for (int i = 1; i < 6; i++)
        {
            battle.OpponentPokemon[i] = Pokemon.MakeEmptyMon;
        }
        battle.battleType = BattleType.Single;
        battle.battleTerrain = currentTerrain;
        battle.wildBattle = true;
        battle.StartCoroutine(battle.StartBattle());
    }

    public IEnumerator BattleWon()
    {
        yield return Scene.Map.Load();
        Debug.Log("Map loaded");
        camera = Instantiate(Resources.Load<GameObject>("Prefabs/Map CameraGUI"));
        FindAnnouncer();
        mapManager = gameObject.AddComponent<MapManager>();
        RenderMap();
        CreatePlayerGraphics(HumanoidGraphicsID.brendanWalk);
        AlignPlayer();
        CaptureCamera();
        UpdateCollision();
        ActivateAll();
        active = true;
    }

    public IEnumerator WildBattleWon()
    {
        yield return BattleWon();
        state = PlayerState.Free;
    }

    public IEnumerator TrainerBattleWon()
    {
        yield return BattleWon();
        opponent.charData.OnWin(this, opponent);
    }

    public void CheckGrassEncounter()
    {
        byte index = mapManager.wildData[pos.x, pos.y];
        if (index == 0) return;
        WildDataset dataset = currentMap.Data().grassData[index - 1];
        if (random.NextDouble() * 100 < dataset.encounterPercent)
        {
            StartCoroutine(StartSingleWildBattle(dataset.GetWildMon()));
        }
    }

    public void TryGoSouth()
    {
        if (facing != Direction.S)
            StartCoroutine(playerGraphics.FaceSouth(this, 0.1F));
        else if (CheckCollisionAllowed(GetFacingTile(), currentHeight))
        {
            TryChangeMap(pos.x, pos.y - 1);
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
        else if (CheckCollisionAllowed(GetFacingTile(), currentHeight))
        {
            TryChangeMap(pos.x, pos.y + 1);
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
        else if (CheckCollisionAllowed(GetFacingTile(), currentHeight))
        {
            TryChangeMap(pos.x - 1, pos.y);
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
        else if (CheckCollisionAllowed(GetFacingTile(), currentHeight))
        {
            TryChangeMap(pos.x + 1, pos.y);
            StartCoroutine(GoEast());
        }
        else
        {
            StartCoroutine(playerGraphics.BumpEast(this, 0.3F));
        }
    }
    public IEnumerator GoSouth()
    {
        yield return playerGraphics.WalkSouth(this, 0.3F);
        UpdateCollision();
        if (!CheckForTriggers())
            CheckGrassEncounter();
    }

    public IEnumerator GoNorth()
    {
        yield return playerGraphics.WalkNorth(this, 0.3F);
        UpdateCollision();
        if (!CheckForTriggers())
            CheckGrassEncounter();
    }

    public IEnumerator GoWest()
    {
        yield return playerGraphics.WalkWest(this, 0.3F);
        UpdateCollision();
        if (!CheckForTriggers())
            CheckGrassEncounter();
    }

    public IEnumerator GoEast()
    {
        yield return playerGraphics.WalkEast(this, 0.3F);
        UpdateCollision();
        if (!CheckForTriggers())
            CheckGrassEncounter();
    }

    public bool CheckForTriggers()
    {
        foreach (TileTrigger i in triggers)
        {
            if (i.pos == new Vector2Int(pos.x, pos.y))
            {
                i.script(this);
                return true;
            }
        }
        return false;
    }

    public bool CheckForCharacters()
    {
        Vector2Int facingTile = GetFacingTile();
        foreach (LoadedChar i in loadedChars.Values)
        {
            if (i.pos == facingTile && i.available)
            {
                i.charData.OnInteract(this, i);
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
                i.script(this);
                return true;
            }
        }
        return false;
    }

    public void CheckForInteractables()
    {
        if (!CheckForCharacters())
            CheckForSignposts();
    }

    public Vector2Int GetFacingTile()
    {
        return facing switch
        {
            Direction.N => new Vector2Int(pos.x, pos.y + 1),
            Direction.S => new Vector2Int(pos.x, pos.y - 1),
            Direction.E => new Vector2Int(pos.x + 1, pos.y),
            Direction.W => new Vector2Int(pos.x - 1, pos.y),
            _ => new Vector2Int(pos.x, pos.y)
        };
    }

    public IEnumerator DoAnnouncements(List<string> text)
    {
        state = PlayerState.Announce;
        yield return announcer.AnnouncementUp();
        foreach (string i in text)
        {
            yield return announcer.Announce(i);
        }
        yield return announcer.AnnouncementDown();
        state = locked ? PlayerState.Locked : PlayerState.Free;
    }

    public IEnumerator InitMapTest()
    {
        yield return Scene.Map.Load();
        camera = Instantiate(Resources.Load<GameObject>("Prefabs/Map CameraGUI"));
        FindAnnouncer();
        mapManager = gameObject.AddComponent<MapManager>();
        currentMap = MapID.Test;
        RenderMap();
        CreatePlayerGraphics(HumanoidGraphicsID.brendanWalk);
        AlignPlayer();
        CaptureCamera();
        UpdateCollision();
        Party[0] = Pokemon.WildPokemon(SpeciesID.Venusaur, 4);
        Party[0].item = ItemID.Venusaurite;
        active = true;
    }
    // Start is called before the first frame update
    public void Start()
    {
        random = new();
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex((int)Scene.Main))
        {
            StartCoroutine(InitMapTest());
        }
    }

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    public void Update()
    {
        if (active)
        {
            switch (state)
            {
                case PlayerState.Free:
                    AlignPlayer();
                    if (Input.GetKey(KeyCode.UpArrow)) TryGoNorth();
                    else if (Input.GetKey(KeyCode.DownArrow)) TryGoSouth();
                    else if (Input.GetKey(KeyCode.LeftArrow)) TryGoWest();
                    else if (Input.GetKey(KeyCode.RightArrow)) TryGoEast();
                    else if (Input.GetKeyDown(KeyCode.Return)) CheckForInteractables();
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
