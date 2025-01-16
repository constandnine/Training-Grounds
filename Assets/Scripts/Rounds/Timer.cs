using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [Header("Rounds")]

    private Rounds roundScript;
    private bool endOfRound;


    [Header("Time")]

    [SerializeField] private float _timeInSeconds;
    public float timeInSeconds { get { return _timeInSeconds; } set { _timeInSeconds = value; } }


    [Header("UI")]

    [SerializeField] private TextMeshProUGUI  timerText;


    private void Start()
    {
        roundScript = GetComponent<Rounds>();


        endOfRound = false;
    }


    private void Update()
    {
        Countdown();
        

        if (timeInSeconds < 1)
        {
            endOfRound = true;
            TimeOut();
        }
    }


    private void Countdown()
    {
        if (timeInSeconds >= 1)
        {
            timeInSeconds -= Time.deltaTime;
        }


        int minutes = Mathf.FloorToInt(timeInSeconds / 60);
        int seconds = Mathf.FloorToInt(timeInSeconds % 60);


        timerText.text = $"{minutes:D2}:{seconds:D2}";
    }


    private void TimeOut()
    {
        if (endOfRound == true)
        {
            roundScript.EndofRound();


            //roundScript.round++;


            endOfRound = false;
        }
    }
}
