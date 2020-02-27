using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBoss_Controls : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
   
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
        
    }
    
    void Update()
    {
        
        
    }
    
    //......................................................ATTACK
    void Damage() {
        
    }
}
