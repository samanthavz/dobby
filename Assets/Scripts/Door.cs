using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using PixelCrushers.DialogueSystem;

public class Door : MonoBehaviour
{
    bool enter = false;
    bool check = false;
    bool warning = false;

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            enter = true;
        }
    }

    public void startConvo()
    {
        gameObject.GetComponent<DialogueSystemTrigger>().OnUse(); 
    }

    public void warningcheck()
    {
        warning = true;
    }

    void OnTriggerExit2D (Collider2D other)
    {
        if (other.tag == "Player")
        {
            enter = false;
        }
    }

    public void convoEnd ()
    {
        check = true;
    }

    public void Update()
    {
        if (enter && check && !warning)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                startConvo();
            }
        }
    }
}
