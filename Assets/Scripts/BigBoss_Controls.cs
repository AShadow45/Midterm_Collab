using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoss_Controls : MonoBehaviour
{
    Rigidbody2D rb;
    float speed;

    //.........................................ATTACK
    [Header("Attack Settings")]


    //.........................................HEALTH
    [Header("Health Settings")]
    [Tooltip("Big Boss Current Health")]
    public int bb_curHealth;
    [Tooltip("Big Boss Maximum Health")]
    public int bb_maxHealth;

    //.........................................SPAWNING ENEMIES
    [Header("Spawn Settings")]
    public GameObject Minions;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        
    }

    void SpawnMinions() {

    }
}
