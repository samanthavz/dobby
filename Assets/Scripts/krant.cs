using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class krant : MonoBehaviour
{
    bool enter = false;
    bool check = false;
    public Animator animator;
    public AudioSource audio;
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
                audio.Play();
                Debug.Log("pressed e");
                animator.SetBool("up", true);
                check = true;
            }
        } else if (check)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    animator.SetBool("up", false);
                    check = false;
                } 
            }
    }
}
