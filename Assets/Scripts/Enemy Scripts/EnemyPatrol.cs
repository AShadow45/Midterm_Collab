﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    //..............................................SPEED
    [Header("Speed Settings")]
    [Tooltip("Speed in the X-Axis")]
    public float xSpeed = 0.5f;
    [Tooltip("Speed in the Y-Axis")]
    public float ySpeed = 0.1f;
    //..............................................DIRECTION
    int xDirect = -1;
    int yDirect = -1;
    //..............................................POSITION
    float yStartPos;
    float yPos = 0;

    //Enemy Postion
    [Header("Enemy Position")]
    [Tooltip("Negative X Position")]
    public int xnegat;
    [Tooltip("Positive X Position")]
    public int xposit;
    [Tooltip("Negative Y Position")]
    public int ynegat;
    [Tooltip("Positive Y Position")]
    public int yposit;

    SpriteRenderer rend;

    void Start()
    {
        yStartPos = transform.position.y;
        rend = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (transform.position.x < xnegat)
        {
            xDirect = 1;
            rend.flipX = true;
        }

        if (transform.position.x > xposit)
        {
            xDirect = -1;
            rend.flipX = false;
        }

        if (transform.position.y < ynegat)
        {
            yDirect = 1;
        }

        if (transform.position.y > yposit)
        {
            yDirect = -1;
        }

        Vector2 newposition = transform.position;
        yPos += ySpeed;
        newposition.x += xSpeed * xDirect * Time.deltaTime;
       // newposition.y = Mathf.Sin(yPos) * .04f + yStartPos;
        transform.position = newposition;
    }
}
