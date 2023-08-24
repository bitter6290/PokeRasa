using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{

    public AudioSource source;

    private AudioClip WildStart;
    private AudioClip WildContinue;

    // Start is called before the first frame update
    void Start()
    {
        WildStart = Resources.Load<AudioClip>("Sound/Music/B2 Wild Intro");
        WildContinue = Resources.Load<AudioClip>("Sound/Music/B2 Wild Repeated");
        source.PlayOneShot(WildStart);
    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
        {
            source.PlayOneShot(WildContinue);
        }
    }
}
