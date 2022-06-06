using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class DracoDiagon : MonoBehaviour
{
    public Animator animator;
    public GameObject barker;
    bool enter = false;
    bool moved = false;

    public void move()
    {
        animator.SetBool("move", true);
        moved = true;
        barker.GetComponent<BoxCollider2D>().enabled = true;
    }

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
        if (enter && moved)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                startConv();
            }
        }
    }
    
}
