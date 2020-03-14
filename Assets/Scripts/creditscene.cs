using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(creditRoll());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator creditRoll()
    {
        yield return new WaitForSeconds(31f);

        SceneManager.LoadScene("Title");
    }
}
