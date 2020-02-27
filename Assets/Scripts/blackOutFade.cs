using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackOutFade : MonoBehaviour
{
    
    public Renderer blackSpriteRend;
    /*
    Color col;

    void Start()
    {
        col = blackSpriteRend.material.color;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (col.a > 0) {
                col.a -= 0.1f * Time.deltaTime;
                blackSpriteRend.material.color = col;
             }
        }
    }
    */
    
        public float minimum = 0.0f;
        public float maximum = 1f;
        public float duration = 3.0f;
        private float startTime;
        public SpriteRenderer sprite;
        void Start()
        {
            startTime = Time.time;
        }
        void Update()
        {
            float t = (Time.time - startTime) / duration;
            sprite.color = new Color(0f, 0f, 0f, Mathf.SmoothStep(maximum, minimum, t));
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {

            }
        }
  
}
