using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekXuy1 : MonoBehaviour
{
    public GameObject stenka2;
    public GameObject stenka3;
    public GameObject xuy3;
    public GameObject xuy4;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "mashina")
        {
          stenka2.SetActive(false);
          stenka3.SetActive(false);

          xuy3.SetActive(true);
          xuy4.SetActive(true);
        } 
    }

}
