using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackOutFade : MonoBehaviour
{
    public GameObject blackOut;
    private Renderer blackSpriteRend;

    void Start()
    {
        blackOut.SetActive(true);
        blackSpriteRend = blackOut.GetComponent<Renderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FadeTo(0.0f, 1.5f));
        }

    }
        IEnumerator FadeTo(float aValue, float aTime)
    {
        float alpha = blackSpriteRend.material.color.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
           blackSpriteRend.material.color = newColor;
            yield return null;
        }
    }

}
