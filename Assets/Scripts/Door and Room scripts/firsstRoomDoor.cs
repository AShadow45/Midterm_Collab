using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firsstRoomDoor : MonoBehaviour
{
    AudioSource aud;
    
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            aud.Play();
        }
    }
}
