using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyCard : MonoBehaviour
{
    public bool haveKeyCard;

    Renderer rend;

    public Text hintText;

    AudioSource aud;

    void Start()
    {
        haveKeyCard = false;
        rend = GetComponent<Renderer>();
        hintText.text = "";
        aud = GetComponent<AudioSource>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            haveKeyCard = true;
            rend.enabled = false;
            aud.Play();
            StartCoroutine(cardText());
        }
    }

    IEnumerator cardText()
    {
        hintText.text = "Obtained a keycard.\nIt could be useful.";
        yield return new WaitForSeconds(4.5f);
        hintText.text = "";
    }
}
