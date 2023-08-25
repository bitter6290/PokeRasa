using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    BitArray TM = new BitArray(96);
    BitArray HM = new BitArray(8);
    BitArray keyItem = new BitArray(0);


    private IEnumerator OnItemGet(ushort item)
    {
        switch (Item.ItemTable[item].type)
        {
            case ItemType.TM:
                //yield return Field.Announce("Received" + Item.ItemTable[item].name");
                TM[Item.ItemTable[item].itemData.tmID] = true;
                break;
            default:
                break;
        }
        yield return null;
    }
    Pokemon[] Team = new Pokemon[6];
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
