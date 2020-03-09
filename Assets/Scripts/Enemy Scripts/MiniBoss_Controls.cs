﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniBoss_Controls : MonoBehaviour
{
    Rigidbody2D rb;
  
    //.....................................................ATTACK
    [Header("Attack Settings")]
    public GameObject Webs;
    public Transform SpawnPoint;
    public int webMax = 5;
    public int speed = 100;

    //.....................................................HEALTH
    [Header("Health Settings")]
    [Tooltip("Mini Boss Current Health")]
    public int mb_curHealth;
    [Tooltip("Mini Boss Maximum Health")]
    public int mb_maxHealth = 10; 

    //.....................................................STAIRWAY 
    [Header("Spider Web")]
    public GameObject spiderWeb;
    public Collider2D webCollider;
    public AudioSource aud;

    [Header("Gun")]
    public GameObject gun;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mb_curHealth = mb_maxHealth;

        gun.SetActive(false);
        

        SpawnPoint = GameObject.FindGameObjectWithTag("MiniBoss").transform;
        InvokeRepeating("Damage", 0, .1f);

    
    void Update()
    {
        if (mb_curHealth <= 0)
        {
            StartCoroutine(FadeTo(0.0f, 1.5f));
            webCollider.enabled = false;
            StartCoroutine(Die());

            gun.SetActive(true);
        

        }
        //Damage();
    }

    //......................................................ATTACK

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "batHB")
        {
            mb_curHealth -= 1;
        }
    }

    void Damage() {
        for (int i = 0; i < webMax; i++) {
           // Instantiate(Webs, SpawnPoint.position, transform.rotation);
            GameObject newBullet = Instantiate(Webs, transform.position, Quaternion.identity) as GameObject;
            newBullet.GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
        }
        
    }

    //spider web fade
    IEnumerator FadeTo(float aValue, float aTime)
    {
        float alpha = spiderWeb.GetComponent<Renderer>().material.color.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
            spiderWeb.GetComponent<Renderer>().material.color = newColor;
            aud.Play();
            yield return null;
        }
    }

    //destroy spider boss
    IEnumerator Die()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(1.55f);
        Destroy(this.gameObject);
    }
}
