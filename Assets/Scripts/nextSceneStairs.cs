using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextSceneStairs : MonoBehaviour
{

    //change scene once at stairs

    public Animator anim;

    public string sceneName;

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
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
