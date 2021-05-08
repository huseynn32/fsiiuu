using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject panel;





    void Start()
    {
    }

    public void openpanel(string neg)
    {

        if (neg == "pause")
        {
            panel.SetActive(true);
        Time.timeScale = 0;


        }
        else if (neg=="devam")
        {
            panel.SetActive(false);
            Time.timeScale = 1;

        }

        else if (neg == "puzzle")
        {
            panel.SetActive(false);
            Time.timeScale = 0;

        }

    }
}
