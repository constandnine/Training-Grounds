using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCustomise : MonoBehaviour
{

    public GameObject player;
    public CustomisedPlayer customisedPlayer;
    public AudioSource gloveSounds;

    public void ChangeColour(float colourFloat)
    {
        player.GetComponent<Renderer>().material.SetFloat("_ColourValue", colourFloat);
        //customisedPlayer.gloveMaterial = material;
    }

    public void ChangeGloveSound(AudioSource gloveSound)
    {
        gloveSounds = gloveSound;
    }
}
