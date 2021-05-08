using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takip : MonoBehaviour
{
    Camera kamera;
    Vector2 baslangic;

    GameObject[] ku;
    yonet yoneti;


    private void OnMouseDrag()
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }


    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        baslangic = transform.position;

        ku = GameObject.FindGameObjectsWithTag("kutu");

        yoneti = GameObject.Find("yonet").GetComponent<yonet>();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject kutu in ku)
            {
                if (kutu.name == gameObject.name)
                {
                    float mesafe = Vector3.Distance(kutu.transform.position, transform.position);


                    if (mesafe <= 1)
                    {
                        transform.position = kutu.transform.position;
                        yoneti.sayi();
                        this.enabled = false;


                    }
                    else
                    {
                        transform.position = baslangic;
                    }
                }
            }
        }
    }
}
