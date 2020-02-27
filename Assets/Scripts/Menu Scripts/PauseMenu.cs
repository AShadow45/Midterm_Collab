using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused;
    public GameObject PauseMenuCanvas;

    void Update()
    {
        if (isPaused)
        {
            isPaused = true;
            PauseMenuCanvas.SetActive(true);
        } 
    }

    public void Resume()
    {
        isPaused = false;
        PauseMenuCanvas.SetActive(false);
    }

    public void Options()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }
}
