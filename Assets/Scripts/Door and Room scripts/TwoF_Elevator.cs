using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TwoF_Elevator : MonoBehaviour
{
    public GameObject generator;
    public string sceneName;
    Collider2D elevatorCol;

    public Animator anim;

    void Start()
    {
        elevatorCol = GetComponent<BoxCollider2D>();
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

            anim.SetTrigger("fadeOut");
            StartCoroutine(changeScene());
        }
    }


    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}
