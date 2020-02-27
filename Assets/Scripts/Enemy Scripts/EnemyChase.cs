﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject player;
    float speed;

    Collider2D playerInco;
    public LayerMask playerLayer;

    public PlayerHealth damage;

    //....................................................CHASE
    float distVal;
    Transform target;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("Seek", 0, .1f);
    }
    
    void Update()
    {
        //.................................................CHASE
        distVal = Vector3.Distance(transform.position, target.position);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            damage.currentHealth -= 1;
        }
    }

    void Seek()
    {
        playerInco = Physics2D.OverlapCircle(transform.position, 6, playerLayer);
        if (playerInco)
        {
            rb.velocity = transform.up * 5f;
            transform.up = playerInco.transform.position - transform.position;
        }
    }
}
