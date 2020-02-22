using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PButton : MonoBehaviour
{
    public GameObject PauseMenu;
    public bool openMenu;

    void Start()
    {
        openMenu = false;
    }
    
    void Update()
    {
        if (openMenu)
        {
            PauseMenu.SetActive(true);
        } else
        {
            PauseMenu.SetActive(false);
            openMenu = false;
        }
    }

    public void Pause() {
        openMenu = true;
    }
}
