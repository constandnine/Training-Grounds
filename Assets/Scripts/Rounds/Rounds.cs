using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Rounds : MonoBehaviour
{
    [Header("Playercontroller")]

    [SerializeField] private PlayerController[] playerControllers;


    [Header("Time")]

    [SerializeField] private float timeToRestart;

    private Timer timerScript;

    private float startTime;


    [Header("Round's")]

    [SerializeField] private int round;
    [SerializeField] private int mximalRoundsAmount;

    [SerializeField] private float roundInterFall;


    [Header("Player Corner")]

    [SerializeField] private Transform redCorner;
    [SerializeField] private Transform bleuCorner;

    [SerializeField] private Transform redCornerPlayer;
    [SerializeField] private Transform bleuCornerPlayer;


    [Header("Fade Out")]

    [SerializeField] private float fadeSpeed;

    bool startFadeOut;

    private Color fadeColor;


    [Header("UI")]

    [SerializeField] private GameObject drawScreen;

    [SerializeField] private Image fadeImage;


    [Header("Sound")]

    private AudioSource bellSound;


    private void Start()
    {
        timerScript = GetComponent<Timer>();

        startTime = timerScript.timeInSeconds;


        fadeColor = fadeImage.color;
    }


    public void EndofRound()
    {      
        foreach (var playerController in playerControllers)
        {
            if (playerController != null)
            {
                playerController.enabled = false;
            }


            break;
        }


        if (round > mximalRoundsAmount)
        {
            drawScreen.SetActive(true);


            StartCoroutine(ReloadScene());
        }

        else
        {
            if (fadeColor.a != 1 && startFadeOut == false)
            {
                FadeIn();
            }


            else if (fadeColor.a >= 0.99 && startFadeOut == false)
            {
                redCornerPlayer.position = redCorner.position;
                bleuCornerPlayer.position = bleuCorner.position;


                startFadeOut = true;
            }

            else if (fadeColor.a != 0 && startFadeOut == true)
            {
                FadeOut();
            }

            else if (fadeColor.a == 0)
            {
                startFadeOut = false;

                timerScript.timeInSeconds = startTime;


                StartCoroutine(StartNextRound());
            }
        }
    }


    private void FadeIn()
    {
        fadeColor.a += fadeSpeed * Time.deltaTime;


        fadeColor.a = Mathf.Clamp01(fadeColor.a);


        fadeImage.color = fadeColor;
    }

    private void FadeOut()
    {
        fadeColor.a -= fadeSpeed * Time.deltaTime;


        fadeColor.a = Mathf.Clamp01(fadeColor.a);


        fadeImage.color = fadeColor;
    }


    private IEnumerator StartNextRound()
    {
        yield return new WaitForSeconds(roundInterFall);


        bellSound.Play();


        timerScript.timeInSeconds = startTime;
        round++;


        startFadeOut = false;


        foreach (var playerController in playerControllers)
        {
            if (playerController != null)
            {
                playerController.enabled = true;
            }


            break;
        }
    }


    private IEnumerator ReloadScene()
    {
        yield return new WaitForSeconds(timeToRestart);
    }
}
