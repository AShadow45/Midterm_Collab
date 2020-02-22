using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject player;
    float speed;

    Collider2D playerInco;
    public LayerMask playerLayer;

    //....................................................CHASE
    float distVal;
    Transform target;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    
    void Update()
    {
        //.................................................CHASE
        distVal = Vector3.Distance(transform.position, target.position);
        if (distVal < 10f)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }


    }
}
