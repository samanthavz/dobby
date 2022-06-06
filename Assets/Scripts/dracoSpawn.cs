using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using PixelCrushers.DialogueSystem;

public class dracoSpawn : MonoBehaviour
{
    public float timeRemaining = 3;
    public bool timerIsRunning = false;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject krant;


    public void timerStart()
    {
        Debug.Log("link made");
        gameObject.SetActive(true);
        // Starts the timer automatically
        timerIsRunning = true;
        door1.SetActive(false);
        door2.SetActive(false);
        door3.SetActive(false);
        krant.SetActive(false);
    }

    void startConvo()
    {
        gameObject.GetComponent<DialogueSystemTrigger>().OnUse();
    }

    public void loadScene()
    {
        SceneManager.LoadScene("Kitchen1");
    }

    public void Update()
    {
        if (timerIsRunning)
        {
            Debug.Log("timer starting");
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }

            if (timeRemaining < 2)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
            }

            if (timeRemaining <= 0)
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                startConvo();
            }
        }
    }
}
