using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rounds : MonoBehaviour
{
    [Header("Script References")]

    [SerializeField] private Timer timer;


    [Header("Round Counnter")]

    [SerializeField] private int rounds;


    [Header("UI")]

    [SerializeField] private GameObject drawScreen;


    private void EndofRound()
    {
        if (timer.timeInSeconds == 0f)
        {
            rounds ++;


            // return player to start position


            // reset timer


            // start next round
        }
    }
}
