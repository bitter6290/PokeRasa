using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Player : MonoBehaviour
{


    public bool[] TM = new bool[96];
    public bool[] HM = new bool[8];
    public bool[] keyItem = new bool[8];

    public Dictionary<ItemID, int> Bag;

    public bool[] storyFlags = new bool[100];

    public BattleTerrain currentTerrain;


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
        yield return null;
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

    public void StartBattle(Pokemon[] opponentParty, BattleType battleType)
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
        Battle battle = GameObject.Find("BattleController").GetComponent<Battle>();
        battle.player = this;
        battle.PlayerPokemon = Party;
        battle.OpponentPokemon = useOpponentParty;
        battle.battleType = battleType;
        battle.battleTerrain = currentTerrain;
        battle.StartCoroutine(battle.StartBattle());
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
    }
}
