using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final_boss_blocker : MonoBehaviour
{

    public GameObject crack;

    AudioSource aud;

    void Start()
    {
        crack.SetActive(false);
        aud = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            crack.SetActive(true);
            aud.Play();
            Handheld.Vibrate();
        }

    }
    
}
