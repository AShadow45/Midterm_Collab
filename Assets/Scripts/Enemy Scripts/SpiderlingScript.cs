using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderlingScript : MonoBehaviour
{
    [Header("Script")]
    public EnemyChase enemyChase;

    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

   
    void Update()
    {
        if (enemyChase.isChasing) {
            anim.SetTrigger("isDetected");
        }
    }
}
