using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class brief : MonoBehaviour
{
    bool enter = false;
    bool check = false;
    bool talk = false;
    public Animator animator;

    public Animator animator2;
    public AudioSource audio;

    public void burnletter()
    {
        animator2.SetBool("burn", true);
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
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

    public void Update()
    {
        if (enter && !check)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("pressed e");
                animator.SetBool("up", true);
                check = true;
                audio.Play();
            }
        } else if (check)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    animator.SetBool("up", false);
                    check = false;

                    if (!talk)
                    {
                        gameObject.GetComponent<DialogueSystemTrigger>().OnUse();
                        talk = true;
                    }
                } 
            }
    }
}
