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

    public AudioClip dieSound;
    public AudioSource aud;
    public Animator anim;

    SpriteRenderer rend;
    Collider2D col;

    void Start()
    {
        currentHealth = maxHealth;
        rend = gameObject.GetComponent<SpriteRenderer>();
        col = gameObject.GetComponent<BoxCollider2D>();
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
            StartCoroutine(BackToTitle());
        }

    }

    public void Damage(int dmg) {
        currentHealth -= dmg;
      
    }

    void Die() {
        rend.enabled = false;
        col.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "EChaser")
        {
            currentHealth -= 2;
        }
    }

    IEnumerator BackToTitle()
    {
        aud.PlayOneShot(dieSound);
        anim.SetTrigger("fadeOut");
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene("Title");
    }
}
