using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoss_Controls : MonoBehaviour
{
    Rigidbody2D rb;
    float speed;

    //.........................................ATTACK
   // [Header("Attack Settings")]


    //.........................................HEALTH
    [Header("Health Settings")]
    [Tooltip("Big Boss Current Health")]
    public int bb_curHealth;
    [Tooltip("Big Boss Maximum Health")]
    public int bb_maxHealth;
    [Tooltip("Minion Maximum Health")]
    public int bb_Minion_maxHealth = 3;

    //.........................................SPAWNING ENEMIES
    [Header("Spawn Settings")]
    public GameObject Minions;
    [Tooltip("Max Number of Minions on Screen")]
    public int maxNUM_Minions = 5;
    float spawnRate_Minions; // Delay between minions spawning

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
