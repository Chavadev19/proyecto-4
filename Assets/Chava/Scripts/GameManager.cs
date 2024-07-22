using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool clickOnce = false;
    [SerializeField] private GameObject pause;

    private void Update()
    {
        SetPause();
    }


    public void Play()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void Exit()
    {
        Debug.Log("Cerrando juego...");
        Application.Quit();
    }

    private void SetPause()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!clickOnce)
            {
                pause.SetActive(true);
                Time.timeScale = 0f;
                clickOnce = true;
            }
            else
            {
                pause.SetActive(false);
                Time.timeScale = 1f;
                clickOnce = false;
            }
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
