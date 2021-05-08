using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endscren : MonoBehaviour
{




    public GameObject endcren;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "playertag")
        {
            endcren.gameObject.SetActive(true);
        }
    }
}
