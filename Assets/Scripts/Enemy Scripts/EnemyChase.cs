﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    Rigidbody2D rb;
    
    //....................................................CHASE
    [Header("Chase Settings")]
    public float speed;
    GameObject player;
    Collider2D playerInco;
    public LayerMask playerLayer;

    float distVal;
    Transform target;

    public bool isChasing;
    public float detectRad;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
    }
    
    void Update()
    {
        //.................................................CHASE
        distVal = Vector3.Distance(transform.position, target.position);

        if (!isChasing && distVal <= detectRad)
        {
            isChasing = true;
            Seek();
        }
        else if (isChasing && distVal <= detectRad)
        {
            Seek();
        }
        else if (isChasing && distVal > detectRad)
        {
            isChasing = false;
        }
    }

    public void Seek()
    {
        playerInco = Physics2D.OverlapCircle(transform.position, detectRad, playerLayer);
        if (playerInco)
        {
            rb.velocity = transform.up * speed;
            transform.up = playerInco.transform.position - transform.position;
        }
    }
}
