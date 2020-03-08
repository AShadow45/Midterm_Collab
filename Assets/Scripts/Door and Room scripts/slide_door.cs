using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide_door : MonoBehaviour
{

    public Animator anim;

    AudioSource aud;

    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("open");
            aud.Play();
        }
    }
}
