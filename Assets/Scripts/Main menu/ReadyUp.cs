using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyUp : MonoBehaviour
{
    private bool p1Ready, p2Ready;
    public ParticleSystem p1, p2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (p1Ready && p2Ready)
        {
            // start countdown
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
}
