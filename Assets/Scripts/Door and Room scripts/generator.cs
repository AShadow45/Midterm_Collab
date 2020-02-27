using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    public bool generatorOn;
  

    void Start()
    {
        generatorOn = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            generatorOn = true;
        
        }
    }
}
