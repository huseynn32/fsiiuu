using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;








public class reklam3 : MonoBehaviour,IUnityAdsListener
{

    private string gameID = "4113841";
    private string reklam = "reklam";




    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameID, true);
    }
    public void reklm()
    {
        if (Advertisement.IsReady(reklam))
        {
            Advertisement.Show(reklam);

        }
        else
        {
            Debug.Log("yuklenmedi");
        }
       
    }
    public void OnUnityAdsDidError(string message)
    {
        Debug.LogError("gosterilmedi11" + message);
    }

    public void OnUnityAdsDidFinish(string placementID, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished || showResult==ShowResult.Skipped)
        {
        }
        else if (showResult == ShowResult.Skipped)
        {

        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("ienbh");
        }
    }
 
    public void OnUnityAdsDidStart(string placementId)
    {
            SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }

    public void OnUnityAdsReady(string placementId)
    {
    }
}
