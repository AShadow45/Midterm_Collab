using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class broken_stairs : MonoBehaviour
{
    public Text hintText;

    void Start()
    {
        hintText.text = "";
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(stairText());
        }
    }
    IEnumerator stairText()
    {
        hintText.text = "The stairway is damaged.\nIt's too dangerous to use it.";
        yield return new WaitForSeconds(4.5f);
        hintText.text = "";
    }
}
