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
    public int bb_maxHealth = 30;
    [Tooltip("Minion Current Health")]
    public int bb_Minion_curHealth;
    [Tooltip("Minion Maximum Health")]
    public int bb_Minion_maxHealth = 3;

    public GameObject player;
    public GameObject bloodFX;

    //.........................................SPAWNING ENEMIES
    [Header("Spawn Settings")]
    public GameObject Minions;
    [Tooltip("Current Number of Minions on Screen")]
    public int curNUM_Minions;
    [Tooltip("Max Number of Minions on Screen")]
    public int maxNUM_Minions = 10;
    float spawnRate_Minions; // Delay between minions spawning

    public AudioSource aud;
    public AudioClip hitSound;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        rb = GetComponent<Rigidbody2D>();
        bb_curHealth = bb_maxHealth;
        bb_Minion_curHealth = bb_Minion_maxHealth;
        curNUM_Minions = maxNUM_Minions;
        InvokeRepeating("SpawnMinions", 0, spawnRate_Minions);

    }
    
    void Update()
    {

        if (curNUM_Minions < maxNUM_Minions)
        {
           SpawnMinions();
        }
       

        MinionDeath();

        if (bb_curHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void SpawnMinions() {
        
        for (int i = 0; i < maxNUM_Minions; i++)
        {
            float spawnYLocal = Random.Range(-14, 2);
            var minionSpawn = Instantiate(Minions, new Vector2(77, spawnYLocal), Quaternion.identity);
        }
    }

    void MinionDeath()
    {
        if (bb_Minion_curHealth <= 0)
        {
            Destroy(Minions.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.name);

        if (col.gameObject.tag == "batHB")
        {
            aud.PlayOneShot(hitSound);
            bb_curHealth -= player.GetComponent<PlayerCombat>().batDamage;
            GameObject newBlood = Instantiate(bloodFX, col.transform.position, col.transform.rotation);

        }
        else if (col.gameObject.tag == "Bullet")
        {
            bb_curHealth -= player.GetComponent<PlayerCombat>().gunDamage;
            aud.PlayOneShot(hitSound);
            GameObject newBlood = Instantiate(bloodFX, col.transform.position, col.transform.rotation);

            Destroy(col.gameObject);
        }
    }
}
