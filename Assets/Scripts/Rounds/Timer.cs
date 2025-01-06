using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [Header("Time")]

    [SerializeField] private float _timeInSeconds;
    public float timeInSeconds { get { return _timeInSeconds; } set { _timeInSeconds = value; } }


    [Header("UI")]

    [SerializeField] private TextMeshProUGUI  timerText;


    private void Update()
    {
        Countdown();
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

    }
}
