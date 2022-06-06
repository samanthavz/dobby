using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class doorInteraction : MonoBehaviour
{
    bool enter = false;

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

      public void startConv()
    {
        gameObject.GetComponent<DialogueSystemTrigger>().OnUse(); 
    }

    public void Update()
    {
        if (enter)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                startConv();
            }
        }
    }
}
