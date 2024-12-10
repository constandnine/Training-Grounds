using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourCustomise : MonoBehaviour
{

    public GameObject player;

    public void ChangeColour(Material material)
    {
        player.GetComponent<Renderer>().material = material;
        
    }
}
