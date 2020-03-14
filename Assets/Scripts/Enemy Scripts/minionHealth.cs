using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minionHealth : MonoBehaviour
{
    [Header("Health Settings")]
    public int ENEM_curHealth;
    public int ENEM_maxHealth;

    public GameObject player;
    public GameObject bloodFX;

    AudioSource aud;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        aud = GetComponent<AudioSource>();
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
        Debug.Log(col.name);

        if (col.gameObject.tag == "batHB")
        {
            aud.Play();
            ENEM_curHealth -= player.GetComponent<PlayerCombat>().batDamage;
            GameObject newBlood = Instantiate(bloodFX, col.transform.position, col.transform.rotation);

        }
        else if (col.gameObject.tag == "Bullet")
        {
            aud.Play();
            ENEM_curHealth -= player.GetComponent<PlayerCombat>().gunDamage;

            GameObject newBlood = Instantiate(bloodFX, col.transform.position, col.transform.rotation);

            Destroy(col.gameObject);
        }
    }
}
