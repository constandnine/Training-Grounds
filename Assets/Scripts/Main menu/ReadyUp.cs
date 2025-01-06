using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ReadyUp : MonoBehaviour
{
    private bool p1Ready, p2Ready;
    public ParticleSystem p1, p2;

    public GameObject[] MainMenuUI, inGameUI;
    public GameObject otherCams;
    public Camera mainCamera;

    // Update is called once per frame
    void Update()
    {
        if (p1Ready && p2Ready)
        {
            // start countdown
            Invoke("StartGame", 3);

            // go to fight scene
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
    }

    public void UnreadyBothPlayers()
    {
        p1Ready = false;
        p2Ready = false;
        p1.startColor = Color.red;
        p2.startColor = Color.red;
    }
}
