using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homeScreen : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("Cutscene1");
    }

    public void reallystartGame()
    {
        SceneManager.LoadScene("basement1");
    }

    public void skip1()
    {
        SceneManager.LoadScene("Cutscene3");
    }

    public void skip2()
    {
        SceneManager.LoadScene("Cutscene4");
    }

    public void skip3()
    {
        SceneManager.LoadScene("Hall3Slecht");
    }
}
