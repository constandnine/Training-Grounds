using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ReadyUp : MonoBehaviour
{
    private bool p1Ready, p2Ready;
    public bool gameOver;
    public bool gameStart;
    public ParticleSystem p1, p2;

    public GameObject otherCams;
    public Camera mainCamera;

    [Header("Ui Screens")]

    [SerializeField] private GameObject fadeImage;

    [SerializeField] private GameObject timerText;
    [SerializeField] private GameObject objectivePanel;

    public GameObject[] MainMenuUI, inGameUI;

    // Update is called once per frame
    private void Start()
    {
       foreach(GameObject menuUI in MainMenuUI)
       {
            menuUI.SetActive(true);
       }

    }
    void Update()
    {
        if (p1Ready && p2Ready)
        {
            // start countdown
            Invoke("StartGame", 2);

            // go to fight scene
        }
        if (gameOver)
        {
            foreach (GameObject menuUI in MainMenuUI)
            {
                menuUI.SetActive(true);
            }
            foreach (GameObject gameUI in inGameUI)
            {
                gameUI.SetActive(false);
            }
            mainCamera.enabled = false;
            otherCams.SetActive(true);
        }
    }
    
    public void p1OnClick()
    {
        if (p1Ready)
        {
            p1Ready = false;
            p1.startColor = Color.red;
        }
        else
        {
            p1Ready = true;
            p1.startColor = Color.green;
        }
    }

    public void p2OnClick()
    {
        if (p2Ready)
        {
            p2Ready = false;
            p2.startColor = Color.red;
        }
        else
        {
            p2Ready = true;
            p2.startColor = Color.green;
        }
    }

    public void StartGame()
    {
        foreach(GameObject menuUI in MainMenuUI)
        {
            menuUI.SetActive(false);
        }
        foreach(GameObject gameUI in inGameUI)
        {
            gameUI.SetActive(true);
        }
        mainCamera.enabled = true;
        otherCams.SetActive(false);
        UnreadyBothPlayers();


        fadeImage.SetActive(true);
        timerText.SetActive(true);

        objectivePanel.SetActive(true);


        gameStart = true;
    }

    public void BackToMainMenu()
    {

    }

    public void UnreadyBothPlayers()
    {
        p1Ready = false;
        p2Ready = false;
        p1.startColor = Color.red;
        p2.startColor = Color.red;
    }
}
