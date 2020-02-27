using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyCard : MonoBehaviour
{
    public bool haveKeyCard;

    Renderer rend;

    void Start()
    {
        haveKeyCard = false;
        rend = GetComponent<Renderer>();
    }

  
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            haveKeyCard = true;
            rend.enabled = false;
        }
    }
}
