using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskTest : MonoBehaviour
{
    public MaskManager maskManager;
    public AudioSource audioSource;

    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftCommand))
        {
            Debug.Log("Starting StatUp test");
            //StartCoroutine(BattleAnim.StatUp(audioSource, maskManager));
            StartCoroutine(BattleAnim.ShowBurn(maskManager));
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //StartCoroutine(BattleAnim.StatDown(audioSource, maskManager));
            StartCoroutine(BattleAnim.ShowPoison(maskManager));
        }
    }
}
