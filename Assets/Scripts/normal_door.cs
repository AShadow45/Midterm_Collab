using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normal_door : MonoBehaviour
{

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player is here");
        }
    }
}
