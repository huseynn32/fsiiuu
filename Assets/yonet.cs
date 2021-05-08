using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class yonet : MonoBehaviour
{
    // Start is called before the first frame update
    int yerl = 0;
    int top = 1;
    int sceneIndex, levelPassed;
    public GameObject panel2;



    void Start()
    {

        Debug.Log(PlayerPrefs.GetInt("LevelPassed"));
        sceneIndex = PlayerPrefs.GetInt("LevelPassed");
        
    }


    public void sayi()
    {
        yerl++;
        if (yerl == top)
        {
            PlayerPrefs.SetInt("LevelPassed", 3);
            levelPassed = levelPassed + PlayerPrefs.GetInt("LevelPassed");
            panel2.SetActive(true);
            SceneManager.LoadScene(levelPassed);
            Time.timeScale = 0;

        }
    }


    void Update()
    {

    }
}
