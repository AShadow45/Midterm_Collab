using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medkit : MonoBehaviour
{
    AudioSource aud;
    SpriteRenderer rend;
    Collider2D col;

    GameObject player;
    PlayerHealth playerHealth;
    int plusH;

    void Start()
    {
        aud = GetComponent<AudioSource>();
        rend = GetComponent<SpriteRenderer>();
        col = GetComponent<BoxCollider2D>();

        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();

        plusH = 2;
    }
    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.currentHealth += plusH;
            aud.Play();
            rend.enabled = false;
            col.enabled = false;
        }
    }
}
