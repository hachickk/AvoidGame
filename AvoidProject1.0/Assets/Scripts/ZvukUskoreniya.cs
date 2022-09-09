using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZvukUskoreniya : MonoBehaviour
{

    public GameObject uskorenieSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "mashina")
        {
            Instantiate(uskorenieSound, transform.position, Quaternion.identity);
        }
    }
}
