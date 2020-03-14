using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastSceneStairFade : MonoBehaviour
{
    private Renderer blackSpriteRend;

    public GameObject boss;
    BigBoss_Controls bossH;

    void Start()
    {
       
        blackSpriteRend = GetComponent<Renderer>();
        bossH = boss.GetComponent<BigBoss_Controls>();
    }

    void Update()
    {
        if (bossH.bb_curHealth <= 0)
        {

            StartCoroutine(FadeTo(0.0f, 2f));
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
