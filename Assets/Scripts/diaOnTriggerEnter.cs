using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class diaOnTriggerEnter : MonoBehaviour
{
    bool enter = false;
    bool trigger = true;

    public GameObject triggerobject;
    public GameObject draco;

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
        draco.GetComponent<DialogueSystemTrigger>().OnUse(); 
        trigger = false;
        triggerobject.GetComponent<BoxCollider2D>().enabled = false; 
    }

    public void Update()
    {
        if (enter && trigger)
        {
                startConv();
        }
    }
}
