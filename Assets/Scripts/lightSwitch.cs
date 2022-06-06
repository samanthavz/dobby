using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class lightSwitch : MonoBehaviour
{
    bool enter = false;
    bool check = true;
    public GameObject light;
    public GameObject door;
    public GameObject diaTrigger;
    public GameObject fireplace;
    public Animator Animator;
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

    void startConvo()
    {
        diaTrigger.GetComponent<DialogueSystemTrigger>().OnUse();
    }

    public void Update()
    {
        if (enter && check)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Animator.SetBool("lightsOn", true);
                Debug.Log("lights on");
                light.SetActive(true);
                door.SetActive(true); 
                gameObject.SetActive(false);
                fireplace.SetActive(true); 
                startConvo();
                check = false;
                
            }
        }
    }
}
