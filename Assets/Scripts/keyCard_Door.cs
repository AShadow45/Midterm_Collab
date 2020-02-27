using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyCard_Door : MonoBehaviour
{
    public GameObject keyCard;
    Collider2D thisDoorCollider;
    private SpriteRenderer rend;

    void Start()
    {
        thisDoorCollider = GetComponent<BoxCollider2D>();
        rend = GetComponent<SpriteRenderer>();
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
}
