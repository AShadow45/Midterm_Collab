﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyCard_Door : MonoBehaviour
{
    public GameObject keyCard;
    Collider2D thisDoorCollider;
    private SpriteRenderer rend;
    public Text hintText;

    void Start()
    {
        thisDoorCollider = GetComponent<BoxCollider2D>();
        rend = GetComponent<SpriteRenderer>();
        hintText.text = "";
    }

   
    void Update()
    {
        if (keyCard.GetComponent<keyCard>().haveKeyCard == true)
        {
            thisDoorCollider.isTrigger = true;
       
        }

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rend.enabled = !rend.enabled;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(lockText());
        }
    }

    IEnumerator lockText()
    {
        hintText.text = "The door is locked.";
        yield return new WaitForSeconds(4.5f);
        hintText.text = "";
    }
}
