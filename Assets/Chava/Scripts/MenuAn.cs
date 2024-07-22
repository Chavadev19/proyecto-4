using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAn : MonoBehaviour
{
    [SerializeField] private GameObject title;
    [SerializeField] private GameObject[] button;



    private void Start()
    {
        Time.timeScale = 1;


        LeanTween.moveY(title, 1000, 1).setEase(LeanTweenType.easeInExpo).setDelay(.5f);

        LeanTween.moveX(button[0], 960, 1).setEase(LeanTweenType.easeInExpo).setDelay(1);

        LeanTween.moveX(button[1], 960, 1).setEase(LeanTweenType.easeInExpo).setDelay(1);

    }
}
