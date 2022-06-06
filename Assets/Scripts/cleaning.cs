using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleaning : MonoBehaviour
{
    bool dracomad = false;
    bool enter = false;
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
    public void dracoMad()
    {
        dracomad = true;

        if (dracomad)
        {
            Animator.SetBool("Mess", true);
            dracomad = false;
        }
    }

    public void endConvo()
    {
        gameObject.SetActive(true);

    }

    void Update()
    {
        if (enter)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Animator.SetBool("Mess", false);
                    gameObject.SetActive(false);
                }
            }
    }
}
