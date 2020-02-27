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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rend.enabled = !rend.enabled;
        }
    }
}
