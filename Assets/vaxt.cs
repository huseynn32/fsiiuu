using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class vaxt : MonoBehaviour
{
    public float zaman, verilenzaman;
    public Transform ilk;
    public Text timer;
    public GameObject panel1;
    public Text sss;


    void Start()
    {
        zaman = verilenzaman;
    }

    // Update is called once per frame
    void Update()
    {
        zaman -= Time.deltaTime;
        timer.text = zaman.ToString("f2");

        if (zaman <= 0)
        {
            panel1.SetActive(true);
            zaman = verilenzaman;
            Time.timeScale = 0f;

        }

    }
}
