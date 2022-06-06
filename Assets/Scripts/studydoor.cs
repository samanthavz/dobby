using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class studydoor : MonoBehaviour
{
    bool enter = false;
    bool bad = false;
    bool good = false;

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

    public void badside()
    {
        bad = true;
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void goodside()
    {
        good = true;
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void Update()
    {
        if (enter)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(good)
                {
                   SceneManager.LoadScene("Cutscene5Good"); 
                }

                if(bad)
                {
                   SceneManager.LoadScene("Cutscene5Bad"); 
                }
                
            }
        }
    }
}
