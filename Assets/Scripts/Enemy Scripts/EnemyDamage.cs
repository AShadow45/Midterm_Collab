using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public EnemyHealth enemyHealth;
    public int damage;

    public AudioSource aud;
    public AudioClip dmgSound;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerHealth.currentHealth -= damage;
            aud.PlayOneShot(dmgSound);
        }
    }
}
