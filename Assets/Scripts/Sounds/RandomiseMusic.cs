using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomiseMusic : MonoBehaviour
{
    [Header("Audio clips")]

    [SerializeField] private AudioClip[] musicClips;

    private AudioSource musicSource;


    private int clipIndex;
    private bool restard;


    private void Awake()
    {
        musicSource = GetComponent<AudioSource>();


        if (musicClips.Length > 0)
        {
            PlayNextSong();
        }
    }


    private void PlayNextSong()
    {
        musicSource.clip = musicClips[clipIndex];

        musicSource.Play();
        

        clipIndex ++;

        if (clipIndex >= musicClips.Length)
        {
            restard= true;
        }
    }


    private void RestardPlaylist()
    {
        clipIndex = 0;


        PlayNextSong();
    }
}
