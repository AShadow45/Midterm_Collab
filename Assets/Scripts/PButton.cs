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
    
    void Update() {
        if (openMenu)
        {
            
        }
    }

    public void Pause() {
        openMenu = true;
        PauseMenu.SetActive(true);
    }
}
