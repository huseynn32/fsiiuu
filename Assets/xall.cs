using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class xall : MonoBehaviour
{
    public Text scorete;
    int score = 10;


    private void Start()
    {
        scorete.text = PlayerPrefs.GetInt("Score").ToString();
        score = PlayerPrefs.GetInt("Score");
    }

    public void hus()
    {
        score += 10;
        scorete.text = score.ToString();
        PlayerPrefs.SetInt("Score", score);
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
