using UnityEngine;
using System.Collections;

public class Announcer : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI announcer;

    public IEnumerator Announce(string announcement, bool erase = true)
    {
        float targetTime;
        for (int i = 1; i <= announcement.Length; i++)
        {
            announcer.text = announcement[..i];
            targetTime = Time.time + 0.04F;
            while (Time.time < targetTime)
            {
                if (Input.GetKey(KeyCode.Return))
                    i = Mathf.Min(i + 1, announcement.Length - 1);
                yield return null;
            }
        }
        if (erase)
        {
            targetTime = Time.time + 3.0F;
            while (Time.time < targetTime)
            {
                if (Input.GetKeyDown(KeyCode.Return))
                    break;
                yield return null;
            }
            announcer.text = "";
        }
    }

    public IEnumerator AnnounceAndDisappear(string announcement)
    {
        gameObject.SetActive(true);
        yield return Announce(announcement);
        gameObject.SetActive(false);
    }
}

