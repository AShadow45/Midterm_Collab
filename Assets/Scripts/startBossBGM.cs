using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBossBGM : MonoBehaviour
{
    AudioSource aud;


    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            aud.Play();
        }
    }
}
