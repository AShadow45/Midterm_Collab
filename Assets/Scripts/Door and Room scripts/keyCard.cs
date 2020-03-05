using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyCard : MonoBehaviour
{
    public bool haveKeyCard;

    Renderer rend;

    public Text hintText;

    void Start()
    {
        haveKeyCard = false;
        rend = GetComponent<Renderer>();
        hintText.text = "";
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            haveKeyCard = true;
            rend.enabled = false;
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
