using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XuyBlya : MonoBehaviour
{
    public GameObject stenka;
    public GameObject stenka1;

    public GameObject xuy1;
    public GameObject xuy2;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "mashina")
        {
        stenka.SetActive(false);
        stenka1.SetActive(false);

        xuy1.SetActive(true);
        xuy2.SetActive(true);

        }
    }

}
