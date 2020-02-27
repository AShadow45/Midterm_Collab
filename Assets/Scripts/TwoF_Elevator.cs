using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TwoF_Elevator : MonoBehaviour
{
    public GameObject generator;
    public string sceneName;
    Collider2D elevatorCol;

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
        
                SceneManager.LoadScene(sceneName);
            
        }
    }
}
