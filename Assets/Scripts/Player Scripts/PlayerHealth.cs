﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [Header("Health Settings")]
    public int currentHealth;
    public int maxHealth;
    float EndDelay = .1f;

    [Header("UI")]
    public Sprite healthUI;

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

        if(currentHealth <= 0)
        {
            Die();
        }

       // healthUI.fillAmount = currentHealth / maxHealth;
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
