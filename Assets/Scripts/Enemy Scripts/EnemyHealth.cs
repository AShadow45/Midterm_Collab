using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [Header("Health Settings")]
    public int ENEM_curHealth;
    public int ENEM_maxHealth;

    void Start()
    {
        ENEM_curHealth = ENEM_maxHealth;
    }
    
    void Update()
    {
        if (ENEM_curHealth > ENEM_maxHealth)
        {
            ENEM_curHealth = ENEM_maxHealth;
        }

        if (ENEM_curHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "batHB")
        {
            ENEM_curHealth -= 1;
        }
    }
}
