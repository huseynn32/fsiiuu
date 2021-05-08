using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class banner : MonoBehaviour
{

    string gameID = "4113841";



    void Start()
    {
        StartCoroutine(reklamtimer());
    }




    IEnumerator reklamtimer()
    {
        yield return new WaitForSeconds(1);
        reklamtimer();
    }


    void reklamevent()
    {
    }


    public void OnUnityAdsReady(string ID)
    {
            Debug.Log("hfube");

    }

    public void OnUnityAdsDidError(string message)
    {

    }


    public void OnUnityAdsDidStart(string ID)
    {
    }

   
}
