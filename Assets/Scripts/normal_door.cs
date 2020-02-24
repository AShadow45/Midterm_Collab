using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normal_door : MonoBehaviour
{

    private SpriteRenderer rend;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        
    }

    /*
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player is here");

            this.gameObject.SetActive(false);
        }
    }
    */

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rend.enabled = !rend.enabled;
        }
    }
}
