using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCustomise : MonoBehaviour
{
    public int playerCount;
    public GameObject player;
    //public CustomisedPlayer customisedPlayer;
    public AudioSource gloveSounds;


    private void Start()
    {
        if(playerCount == 1)
        {
            player = GameObject.FindGameObjectWithTag("P1");
        }
        else if(playerCount == 2)
        {
            player = GameObject.FindGameObjectWithTag("P2");
        }
    }

    public void ChangeColour(float colourFloat)
    {
        player.GetComponent<Renderer>().material.SetFloat("_ColourValue",colourFloat);
        //customisedPlayer.gloveMaterial = material;
    }

    public void ChangeColourBrightness(float brightnessFloat)
    {
        player.GetComponent<Renderer>().material.SetFloat("_Brightness", brightnessFloat);
    }

    public void ChangeGloveSound(AudioSource gloveSound)
    {
        gloveSounds = gloveSound;
    }
}
