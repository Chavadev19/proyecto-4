using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Timer : MonoBehaviour
{
    bool stopWatchActive = false;
    [SerializeField] float currentTime;
    public TextMeshProUGUI currentTimerText;
    public TimeSpan time;

    void Start()
    {
        
        stopWatchActive = true;
    }

    void Update()
    {
        if (stopWatchActive)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
                stopWatchActive = false;
                
                OnTimerEnd();
            }

            time = TimeSpan.FromSeconds(currentTime);
            currentTimerText.text = time.ToString(@"mm\:ss\:fff");
           
        }
    }

    public void StartStopWatch()
    {
        stopWatchActive = true;
    }

    public void StopWatch()
    {
        stopWatchActive = false;
    }

    void OnTimerEnd()
    {
        Debug.Log("Timer has ended!");
    }
}
