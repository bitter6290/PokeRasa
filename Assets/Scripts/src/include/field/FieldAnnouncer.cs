﻿using System.Collections;
using TMPro;
using UnityEngine;
public class FieldAnnouncer : MonoBehaviour
{
    public Player player;
    public RectTransform announcementBox;
    public TextMeshProUGUI announcementText;
    public Vector3 announcerUpPosition;
    public Vector3 announcerDownPosition;
    private float boxHeight;
    public AudioSource audioSource;
    public bool up = false;

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

    public void Flush() => announcementText.text = string.Empty;

    public IEnumerator AnnouncementUp()
    {
        if (up) yield break;
        up = true;
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
        up = false;
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

    public IEnumerator Announce(string announcement, bool doChime = false, bool persist = false)
    {
        float targetTime;
        if (doChime) audioSource.PlayOneShot(SFX.Message);
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
        if (!persist)
        {
            while (!Input.GetKeyDown(KeyCode.Return))
            {
                yield return null;
            }
            announcementText.text = string.Empty;
        }
        else yield return new WaitForSeconds(0.1f);
    }

    public void Start() => audioSource = gameObject.AddComponent<AudioSource>();
}