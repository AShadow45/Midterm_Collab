using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [Header("Health Settings")]
    public int currentHealth;
    public int maxHealth = 10;
    float EndDelay = .1f;

    void Start()
    {
        currentHealth = maxHealth;
    }
    
    void Update()
    {
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth <= 0)
        {
           
            Die();
            SceneManager.LoadScene("Title");
        }

    }

    public void Damage(int dmg) {
        currentHealth -= dmg;
      
    }

    void Die() {
        Destroy(gameObject, EndDelay + .1f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "EChaser")
        {
            currentHealth -= 2;
        }
    }
}
