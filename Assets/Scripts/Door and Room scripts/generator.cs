using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generator : MonoBehaviour
{
    public bool generatorOn;

    public Text hintText;

    AudioSource aud;

    void Start()
    {
        generatorOn = false;
        hintText.text = "";
        aud = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            generatorOn = true;
            StartCoroutine(elevatorText());
            aud.Play();
        
        }
    }

    IEnumerator elevatorText()
    {
        hintText.text = "The generator is on.\nThe elevator should work now.";
        yield return new WaitForSeconds(4.5f);
        hintText.text = "";
    }
}
