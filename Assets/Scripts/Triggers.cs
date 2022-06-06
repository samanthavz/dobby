using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Triggers : MonoBehaviour
{
    public float loadtime = 4;
    public bool trigger = false;

    public string leveltoload;
    public void test() {
        Debug.Log("convo ended");
    }


    public void loadLevel()
    {
        trigger = true;
    }

    void Update()
    {
        if (trigger)
        {
            if (loadtime > 0)
            {
                loadtime -= Time.deltaTime;
            }
            else
            {
                loadtime = 0;
                SceneManager.LoadScene(leveltoload);
            }
        }
    }
}
