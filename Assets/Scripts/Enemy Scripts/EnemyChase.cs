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

    public PlayerHealth damage;

    //....................................................CHASE
    float distVal;
    Transform target;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    
    void Update()
    {
        if(target.position.x < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (target.position.x > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        //.................................................CHASE
        distVal = Vector3.Distance(transform.position, target.position);
        if (distVal < 10f)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        playerInco = Physics2D.OverlapCircle(transform.position, 11f, playerLayer);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            damage.currentHealth -= 1;
        }
    }
}
