using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    //..............................................SPEED
    float xSpeed = 0.5f;
    float ySpeed = 0.1f;
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

    void Start()
    {
        yStartPos = transform.position.y;
    }
    
    void Update()
    {
        if (transform.position.x < xnegat)
        {
            xDirect = 1;
        }

        if (transform.position.x > xposit)
        {
            xDirect = -1;
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
