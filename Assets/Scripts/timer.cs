using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class timer : MonoBehaviour
{
    public float timeRemaining = 40;
    public bool timerIsRunning = false;

    public void timerStart()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void startConvo()
    {
        gameObject.GetComponent<DialogueSystemTrigger>().OnUse();
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                startConvo();
            }
        }
    }
}
