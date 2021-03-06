﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCombat : MonoBehaviour
{
    [Header("Objects")]
    public Button attackButton;
    public GameObject bat;
    public GameObject batHB;
    public GameObject gun1;
    public GameObject gun1Barrel;
    public GameObject bullet1;

    public GameObject smokeFX1;

    public Rigidbody2D rb;

    public VJHandler jsMovement;
    private Vector3 direction;

    [Header("Weapons")]
    public float AttTime = 1f;
    public int weaponNum = 1;
    public float gun1Recoil = 200f;
    public float bulletSpeed = 200f;
    
    [Header("Damage")]
    public int gunDamage = 1;
    public int batDamage = 3;
    public float knockback = 300f;

    [Header("Dash")]
    
    public float dashSpeed;
    public float dashCoolDownTime;
    private bool dashAgain;

    [Header("Button")]
    public GameObject attckButton;

    AudioSource aud;
    public AudioClip batSound;
    public AudioClip gunSound;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashAgain = true;

        jsMovement = GameObject.FindWithTag("JoyStick").GetComponent<VJHandler>();

        attckButton.SetActive(false);

        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        direction = jsMovement.InputDirection;
        SetDir();
        ShowWeapon();

        if (weaponNum == 1 || weaponNum ==2)
        {
            attckButton.SetActive(true);
        }

    }
    public void Attack()
    {
        if(weaponNum == 1)
        {
            StartCoroutine("batAttack");
        }
        if (weaponNum == 2)
        {
            aud.PlayOneShot(gunSound);
            GameObject bullet = Instantiate(bullet1, gun1Barrel.transform.position, gun1Barrel.transform.rotation);
            GameObject newsmokeFX1 = Instantiate(smokeFX1, gun1Barrel.transform.position, gun1Barrel.transform.rotation);

            Rigidbody2D bulletrb = bullet.GetComponent<Rigidbody2D>();
            //Bullet add force
            bulletrb.AddForce(gun1Barrel.transform.up * bulletSpeed);

            Destroy(bullet, 1.2f);
            Destroy(newsmokeFX1, 1f);
            //recoil
            rb.AddForce(-gun1Barrel.transform.up * gun1Recoil);
            
        }


    }
    public void Dash()
    {
        if (dashAgain == true)
        {
            rb.AddForce(gun1Barrel.transform.up * dashSpeed);
            StartCoroutine("DashCoolDown");
        }
    }

    IEnumerator DashCoolDown()
    {
        dashAgain = false;
        yield return new WaitForSeconds(dashCoolDownTime);
        dashAgain = true;
    }
    IEnumerator batAttack()
    {
        aud.PlayOneShot(batSound);
        batHB.SetActive(true);
        yield return new WaitForSeconds(AttTime);
        batHB.SetActive(false);
    }
    void SetDir()
    {


        //Set weapon Direction
        if (direction.x != 0 && direction.y != 0)
        {
            bat.transform.eulerAngles = new Vector3(0, 0,Mathf.RoundToInt(( Mathf.Atan2(-direction.x, direction.y) * 180 / Mathf.PI)) /45) *45;
            gun1.transform.eulerAngles = new Vector3(0, 0, (Mathf.Atan2(-direction.x, direction.y) * 180 / Mathf.PI));
        }

    }
    void ShowWeapon() 
    {
        //bat
        if (weaponNum == 1)
        {
            bat.SetActive(true);
        }
        else if (weaponNum != 1)
        {
            bat.SetActive(false);
        }
        //gun
        if (weaponNum == 2)
        {
            gun1.SetActive(true);
        }
        else if (weaponNum != 2)
        {
            gun1.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bat"))
        {
            weaponNum = 1;
            other.gameObject.SetActive(false);
        }

        else if (other.CompareTag("Gun"))
        {
            weaponNum = 2;
            other.gameObject.SetActive(false);
        }
    }
}
