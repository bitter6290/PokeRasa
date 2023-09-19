using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;
using Scene = SceneID;

[Serializable]
public class Player : MonoBehaviour
{


    public bool[] TM = new bool[96];
    public bool[] HM = new bool[8];
    public bool[] keyItem = new bool[8];

    System.Random random;

    public Dictionary<ItemID, int> Bag;
    public Dictionary<MapID, bool[,]> neighborCollision;

    public List<TileTrigger> triggers;
    public List<TileTrigger> signposts;

    public bool[] storyFlags = new bool[100];

    public BattleTerrain currentTerrain;
    public MapID currentMap;
    public int xPos;
    public int yPos;
    public PlayerState state;
    public bool active;
    public bool locked;
    public Direction facing;

    public bool whichStep;

    public CollisionID currentHeight;
    public MapManager mapManager;
    public PlayerGraphics playerGraphics;
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
        RefreshObjects();
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

    public void RefreshObjects()
    {
        RefreshTriggers();
        RefreshSignposts();
    }

    public void SwitchAndReposition(int xPosition, int yPosition)
    {
        mapManager.mapID = currentMap;
        mapManager.ReadAndReposition(this, xPosition, yPosition);
        RefreshObjects();
    }

    public void AlignPlayer() => playerGraphics.playerTransform.position = new Vector3(xPos + 0.5F, yPos + 0.5F);

    public void UpdateCollision() => currentHeight = CheckCollision(xPos, yPos);

    public void CreatePlayerGraphics(HumanoidGraphicsID id) => playerGraphics = new(this, id);

    private CollisionID CheckCollision(int x, int y)
    {
        if (x >= 0 && y >= 0 && x < currentMap.Data().width && y < currentMap.Data().height)
            return (CollisionID)mapManager.collision[x, y];
        else
        {
            return CollisionOnBorderingMaps(new Vector2Int(x, y));
        }
    }

    private CollisionID CollisionOnBorderingMaps(Vector2Int pos)
    {
        (MapID, Vector2Int)? relativeTile = TileOutsideMap(pos);
        if (relativeTile == null) return CollisionID.Impassable;
        else
        {
            (MapID map, Vector2Int pos) trueRelativeTile = ((MapID, Vector2Int))relativeTile;
            Debug.Log(trueRelativeTile);
            Debug.Log(mapManager.borderingCollision[trueRelativeTile.map].GetLength(0));
            Debug.Log(mapManager.borderingCollision[trueRelativeTile.map].GetLength(1));
            return (CollisionID)mapManager.borderingCollision[trueRelativeTile.map][trueRelativeTile.pos.x, trueRelativeTile.pos.y];
        }
    }

    private (MapID, Vector2Int)? TileOutsideMap(Vector2Int pos)
    {
        foreach (Connection i in currentMap.Data().connection)
        {
            Vector2Int checkPos = pos - GetMapOffset(i);
            Debug.Log(checkPos);
            if (checkPos.x >= 0 && checkPos.x < i.map.Data().width
                && checkPos.y >= 0 && checkPos.y < i.map.Data().height)
                return (i.map, checkPos);
        }
        return null;
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

    private bool CheckCollisionAllowed(Direction direction)
    {
        CollisionID nextCollision = direction switch
        {
            Direction.N => CheckCollision(xPos, yPos + 1),
            Direction.W => CheckCollision(xPos - 1, yPos),
            Direction.E => CheckCollision(xPos + 1, yPos),
            Direction.S => CheckCollision(xPos, yPos - 1),
            _ => CollisionID.Impassable
        };
        if (nextCollision == CollisionID.Impassable) return false;
        if (currentHeight == CollisionID.Change) return true;
        if (nextCollision is CollisionID.Bridge or CollisionID.Change) return true;
        if (currentHeight == nextCollision) return true;
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
                    currentMap = i.map;
                    SwitchAndReposition(-1, y - i.offset);
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
                    currentMap = i.map;
                    SwitchAndReposition(i.map.Data().width, y - i.offset);
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
                    currentMap = i.map;
                    SwitchAndReposition(x - i.offset, -1);
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
                    currentMap = i.map;
                    SwitchAndReposition(x - i.offset, i.map.Data().height);
                    AlignPlayer();
                }
            }
        }
    }

    private void FindCamera() => camera = GameObject.Find("Main Camera");
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

    public IEnumerator StartSingleTrainerBattle(Pokemon[] opponentParty, BattleType battleType)
    {
        Pokemon[] useOpponentParty = new Pokemon[6];
        for (int i = 0; i < opponentParty.Length; i++)
        {
            useOpponentParty[i] = opponentParty[i];
        }
        for (int i = opponentParty.Length; i < 6; i++)
        {
            useOpponentParty[i] = Pokemon.MakeEmptyMon;
        }
        state = PlayerState.Locked;
        active = false;
        mapManager.ClearMap();
        yield return Scene.Battle.Load();
        Battle battle = FindAnyObjectByType<Battle>();
        battle.player = this;
        SortParty();
        battle.PlayerPokemon = Party;
        battle.OpponentPokemon = useOpponentParty;
        battle.battleType = battleType;
        battle.battleTerrain = currentTerrain;
        battle.StartCoroutine(battle.StartBattle());
    }

    public IEnumerator StartSingleWildBattle(Pokemon wildMon)
    {
        Debug.Log("Start Single Wild Battle");
        yield return null;
        state = PlayerState.Locked;
        active = false;
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
        active = true;
    }

    public IEnumerator WildBattleWon()
    {
        yield return BattleWon();
        state = PlayerState.Free;
    }

    public void CheckGrassEncounter()
    {
        byte index = mapManager.wildData[xPos, yPos];
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
        else if (CheckCollisionAllowed(Direction.S))
        {
            TryChangeMap(xPos, yPos - 1);
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
        else if (CheckCollisionAllowed(Direction.N))
        {
            TryChangeMap(xPos, yPos + 1);
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
        else if (CheckCollisionAllowed(Direction.W))
        {
            TryChangeMap(xPos - 1, yPos);
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
        else if (CheckCollisionAllowed(Direction.E))
        {
            TryChangeMap(xPos + 1, yPos);
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
            if (i.pos == new Vector2Int(xPos,yPos))
            {
                StartCoroutine(i.script(this));
                return true;
            }
        }
        return false;
    }

    public bool CheckForSignposts()
    {
        Vector2Int facingTile = GetFacingTile();
        foreach(TileTrigger i in signposts)
        {
            if(i.pos == facingTile)
            {
                StartCoroutine(i.script(this));
                return true;
            }
        }
        return false;
    }

    public void CheckForInteractables()
    {
        //if(!CheckForCharacters)
        CheckForSignposts();
    }

    public Vector2Int GetFacingTile()
    {
        return facing switch
        {
            Direction.N => new Vector2Int(xPos, yPos + 1),
            Direction.S => new Vector2Int(xPos, yPos - 1),
            Direction.E => new Vector2Int(xPos + 1, yPos),
            Direction.W => new Vector2Int(xPos - 1, yPos),
            _ => new Vector2Int(xPos, yPos)
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
        if(active)
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
