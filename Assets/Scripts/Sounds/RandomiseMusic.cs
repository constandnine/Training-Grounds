using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomiseMusic : MonoBehaviour
{
    [Header("Audio clips")]

    [SerializeField] private AudioClip[] musicClips;

    private AudioSource musicSource;


    private int clipIndex;


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
        clipIndex = Random.Range(0, musicClips.Length);


        musicSource.clip = musicClips[clipIndex];
        

        musicSource.Play();
    }
}
