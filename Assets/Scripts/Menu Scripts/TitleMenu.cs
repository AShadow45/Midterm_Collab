using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public void StartB()
    {
        SceneManager.LoadScene("4F");
    }

    public void Quit()
    {
        Application.Quit();   
    }
}
