﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [Header("Health Settings")]
    public int ENEM_curHealth;
    public int ENEM_maxHealth;

    public GameObject player;
    public GameObject bloodFX;

    AudioSource aud;
    public AudioClip hitSound;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        aud = player.GetComponent<AudioSource>();
        ENEM_curHealth = ENEM_maxHealth;
    }
    
    void Update()
    {
        if (ENEM_curHealth > ENEM_maxHealth)
        {
            ENEM_curHealth = ENEM_maxHealth;
        }

        if (ENEM_curHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.name);

        if (col.gameObject.tag == "batHB")
        {
            aud.PlayOneShot(hitSound);
            ENEM_curHealth -= player.GetComponent<PlayerCombat>().batDamage;
            GameObject newBlood = Instantiate(bloodFX, col.transform.position, col.transform.rotation);

        }
        else if (col.gameObject.tag == "Bullet")
        {
            aud.PlayOneShot(hitSound);
            ENEM_curHealth -= player.GetComponent<PlayerCombat>().gunDamage;

            GameObject newBlood = Instantiate(bloodFX, col.transform.position, col.transform.rotation);

            Destroy(col.gameObject);
        }
    }
}
