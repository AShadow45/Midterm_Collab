using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [Header("Health UI")]
    public Sprite[] heartSprites;
    public Image HeartUI;
    public PlayerHealth playerHealth;

    void Start()
    {
        
    }
    
    void Update()
    {
        HeartUI.sprite = heartSprites[playerHealth.currentHealth];  
    }
}
