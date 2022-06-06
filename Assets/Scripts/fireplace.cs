using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireplace : MonoBehaviour
{
    bool enter = false;
    bool check = true;

    bool fireoff = false;
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

    public void plsdontcrash()
    {
        Animator.SetBool("lightsOn", true);
    }
    public void Update()
    {
        Animator.SetBool("lightsOn", true);

        if (enter && check)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!fireoff)
                {
                    Animator.SetBool("FireOn", true);
                    Debug.Log("fire on"); 
                    fireoff = true;
                }
                else if (fireoff)
                {
                    Animator.SetBool("FireOn", false);
                    Debug.Log("fire off"); 
                    fireoff = false;
                }
                
            }
        }
    }
}
