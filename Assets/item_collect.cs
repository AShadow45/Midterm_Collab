﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_collect : MonoBehaviour
{
    AudioSource aud;
    void Start()
    {
        aud = GetComponent<AudioSource>();
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
