using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    [SerializeField] private int rounds;
    [SerializeField] private int mximalRoundsAmount;

    [SerializeField] private float roundInterFall;


    [Header("Player Corner")]

    [SerializeField] private Transform redCorner;
    [SerializeField] private Transform blueCorner;

    [SerializeField] private Transform redCornerPlayer;
    [SerializeField] private Transform blueCornerPlayer;


    [Header("Fade Out")]

    [SerializeField] private float fadeSpeed;

    public bool startFadeOut;

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


        if (rounds > mximalRoundsAmount)
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
                blueCornerPlayer.position = blueCorner.position;


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

                rounds++;

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


        rounds += 1;


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


        Scene currentScene = SceneManager.GetActiveScene();
        
        SceneManager.LoadScene(currentScene.name);
    }
}
