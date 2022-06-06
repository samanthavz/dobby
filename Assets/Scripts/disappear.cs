using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    public GameObject lucius;
    public GameObject narcissa;
    public GameObject draco;

    public void disappearing()
    {
        lucius.SetActive(false);
        narcissa.SetActive(false);
    }

    public void disappearingDraco()
    {
        draco.SetActive(false);
    }
}
