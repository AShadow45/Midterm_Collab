using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCombat : MonoBehaviour
{
    // Start is called before the first frame update
    public Button attackButton;
    public GameObject bat;
    public GameObject batHB;
    public GameObject gun1;
    public GameObject gun1Barrel;
    public GameObject bullet1;
    


    public float AttTime = 0.2f;
    public VJHandler jsMovement;
    private Vector3 direction;

    [Header("Weapons")]
    public int weaponNum = 1;
    public float bulletSpeed = 200f;

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        direction = jsMovement.InputDirection;
        SetDir();
        ShowWeapon();
    }
    public void Attack()
    {
        if(weaponNum == 1)
        {
            StartCoroutine("batAttack");
        }
        if (weaponNum == 2)
        {
            GameObject bullet = Instantiate(bullet1, gun1Barrel.transform.position, gun1Barrel.transform.rotation);

            Rigidbody2D bulletrb = bullet.GetComponent<Rigidbody2D>();

            bulletrb.AddForce(gun1Barrel.transform.up * bulletSpeed);
        }


    }

    IEnumerator batAttack()
    {
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
}
