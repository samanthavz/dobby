using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class triggerConvo : MonoBehaviour
{
    bool enter = false;
    bool trigger = true;

    public GameObject barker;

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
        trigger = false;
        barker.GetComponent<BoxCollider2D>().enabled = false; 
    }

    public void Update()
    {
        if (enter && trigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                startConv();
            }
        }
    }
}
