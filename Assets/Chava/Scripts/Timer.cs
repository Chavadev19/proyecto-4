using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class Timer : MonoBehaviour
{
    bool watchActive = false;
    [SerializeField] float currentTime;
    [SerializeField] private TextMeshProUGUI currentTimerText;
    [SerializeField] private TimeSpan time;
    [SerializeField] private GameManager _gameManager;

    void Start()
    {
        _gameManager = FindFirstObjectByType<GameManager>();
        watchActive = true;
    }

    void Update()
    {
        if (watchActive)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
                watchActive = false;
                
                OnTimerEnd();
            }

            time = TimeSpan.FromSeconds(currentTime);
            currentTimerText.text = time.ToString(@"mm\:ss\:fff");
           
        }
    }


    void OnTimerEnd()
    {
        _gameManager.Defeat();
    }
}
