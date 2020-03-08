using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextSceneStairs : MonoBehaviour
{

    //change scene once at stairs

    public Animator anim;

    public string sceneName;

    public AudioSource aud;
    float startVolume = 1;

    bool startFade = false;

    void Start()
    {
        aud.volume = startVolume;
    }

 
    void Update()
    {
        if (startFade)
        {
            aud.volume -= startVolume * Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger("fadeOut");
            StartCoroutine(changeScene());

            if (aud.isPlaying == true)
            {
                startFade = true;
            }
        }
    }

    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}
