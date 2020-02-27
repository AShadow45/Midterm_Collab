using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBoss_Controls : MonoBehaviour
{
    Rigidbody2D rb;
    float speed;
   
    //.....................................................CHASE
    [Header("Chase Settings")]
    GameObject player;
    Collider2D playerInco;
    public LayerMask playerLayer;

    float distVal;
    Transform target;

    //.....................................................ATTACK
    [Header("Attack Settings")]
    public GameObject Webs;

    //.....................................................HEALTH
    [Header("Health Settings")]
    [Tooltip("Mini Boss Current Health")]
    public int mb_curHealth;
    [Tooltip("Mini Boss Maximum Health")]
    public int mb_maxHealth;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    
    void Update()
    {
        distVal = Vector3.Distance(transform.position, target.position);
    }

    //.....................................................CHASE
    void Seek() {
        playerInco = Physics2D.OverlapCircle(transform.position, 4, playerLayer);
        if (playerInco)
        {
            rb.velocity = transform.up * 2f;
            transform.up = playerInco.transform.position - transform.position;
        }
    }
}
