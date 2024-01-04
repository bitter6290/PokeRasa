using System.Collections;
using TMPro;
using UnityEngine;
public class GUIManager : MonoBehaviour
{
    public Player player;
    public RectTransform announcementBox;
    public TextMeshProUGUI announcementText;
    public Vector3 announcerUpPosition;
    public Vector3 announcerDownPosition;
    public float boxHeight;

    public void Awake()
    {
        announcerUpPosition = announcementBox.localPosition;
        boxHeight = announcementBox.rect.height;
        announcerDownPosition = new Vector3(announcerUpPosition.x,
            announcerUpPosition.y - boxHeight, announcerUpPosition.z);
        announcementBox.position = announcerDownPosition;
        announcementText.text = string.Empty;
        DontDestroyOnLoad(this);
    }

    public IEnumerator AnnouncementUp()
    {
        float baseTime = Time.time;
        float endTime = baseTime + 0.1F;
        announcementText.text = string.Empty;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) * 10.0F;
            announcementBox.localPosition = new Vector3(announcerUpPosition.x,
                announcerDownPosition.y + boxHeight * progress, announcerUpPosition.z);
            yield return null;
        }
        announcementBox.localPosition = announcerUpPosition;
    }

    public IEnumerator AnnouncementDown()
    {
        float baseTime = Time.time;
        float endTime = baseTime + 0.1F;
        announcementText.text = string.Empty;
        while (Time.time < endTime)
        {
            float progress = (Time.time - baseTime) * 10.0F;
            announcementBox.localPosition = new Vector3(announcerUpPosition.x,
                announcerUpPosition.y - boxHeight * progress, announcerUpPosition.z);
            yield return null;
        }
        announcementBox.localPosition = announcerDownPosition;
    }

    public IEnumerator Announce(string announcement, bool intoPrompt = false)
    {
        float targetTime;
        announcementText.text = string.Empty;
        for (int i = 1; i <= announcement.Length; i++)
        {
            announcementText.text = announcement[..i];
            targetTime = Time.time + 1.0F / player.textSpeed;
            while (Time.time < targetTime)
            {
                if (Input.GetKeyDown(KeyCode.Return))
                { i = announcement.Length - 1; }
                yield return null;
            }
        }
        if (!intoPrompt)
        {
            while (!Input.GetKeyDown(KeyCode.Return))
            {
                yield return null;
            }
            announcementText.text = string.Empty;
        }
        else yield return new WaitForSeconds(0.1f);
    }
}