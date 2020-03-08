using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TwoF_Elevator : MonoBehaviour
{
    public GameObject generator;
    public string sceneName;
    Collider2D elevatorCol;

    public Animator anim;
    public Text hintText;
    AudioSource aud;
    public AudioClip wrong;
    public AudioClip goUp;

    void Start()
    {
        elevatorCol = GetComponent<BoxCollider2D>();
        hintText.text = "";
    }

   void Update()
    {
        if (generator.GetComponent<generator>().generatorOn == true)
        {
            elevatorCol.isTrigger = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            aud.PlayOneShot(goUp);
            anim.SetTrigger("fadeOut");
            StartCoroutine(changeScene());
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            aud.PlayOneShot(wrong);
            StartCoroutine(lockText());
        }
    }

    IEnumerator lockText()
    {
        hintText.text = "The elevator isn't working.\nThere's no power running on this floor.";
        yield return new WaitForSeconds(4.5f);
        hintText.text = "";
    }

    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}
