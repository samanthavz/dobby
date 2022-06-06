using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class enddoor : MonoBehaviour
{
    bool enter = false;
    public GameObject bad;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            enter = true;
        }
    }

    void OnTriggerExit2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            enter = false;
        }
    }

    public void startConvGood()
    {
        gameObject.GetComponent<DialogueSystemTrigger>().OnUse(); 
    }

    public void startConvBad()
    {
        bad.GetComponent<DialogueSystemTrigger>().OnUse(); 
    }

    public void Update()
    {
        if (enter)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(Scoring.totalscore > 49)
                {
                    startConvGood();
                }
                else if (Scoring.totalscore < 49)
                {
                    startConvBad();
                }
                
            }
        }
    }
}
