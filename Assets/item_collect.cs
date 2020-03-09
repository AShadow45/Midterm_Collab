using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_collect : MonoBehaviour
{
    public AudioSource aud;
    //public AudioClip pickUpSound;

    void Start()
    {
        //aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
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
