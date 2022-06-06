using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class cooking : MonoBehaviour
{
    bool enter = false;
    bool start = true;

    public Animator animator;

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

    public void steamytime()
    {
        animator.SetBool("steam", true);
    }

    public void nosteamytime()
    {
        animator.SetBool("steam", false);
    }

      public void startConv()
    {
        gameObject.GetComponent<DialogueSystemTrigger>().OnUse(); 
    }

    public void Update()
    {
        if (enter && start)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                startConv();
                start = false;
            }
        }
    }
}
