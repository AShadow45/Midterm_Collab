using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final_boss_blocker : MonoBehaviour
{

    public GameObject crack;

    void Start()
    {
        crack.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            crack.SetActive(true);
            Handheld.Vibrate();
        }

    }
    
}
