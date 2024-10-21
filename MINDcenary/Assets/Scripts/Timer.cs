using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{
    public float temporestante = 0;
    public bool timeisrunning = true;
    public TMP_Text timer;
    public GameObject gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeisrunning)
        {
            if(temporestante >= 0)
            {
                temporestante -= Time.deltaTime;
                DisplayTime(temporestante);
            }
        } 

        if(temporestante <= 0)
        {
            gameover.SetActive(true);
        } 
    }
    void DisplayTime (float timetoDisplay)
    {
        timetoDisplay -=1;
        float minutes = Mathf.FloorToInt (timetoDisplay / 60);
        float seconds = Mathf.FloorToInt (timetoDisplay % 60);
        timer.text = string.Format ("{0:00} : {1:00}", minutes, seconds);
    }
}
