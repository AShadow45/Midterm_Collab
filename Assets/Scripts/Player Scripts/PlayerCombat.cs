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
    public float AttTime = 0.2f;
    public VJHandler jsMovement;
    private Vector3 direction;

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        direction = jsMovement.InputDirection;
        SetDir();
    }
    public void Attack()
    {
        StartCoroutine("Attacking");
    }

    IEnumerator Attacking()
    {
        batHB.SetActive(true);
        yield return new WaitForSeconds(AttTime);
        batHB.SetActive(false);
    }
    void SetDir()
    {


        //Set Bat Direction
        if (direction.x != 0 && direction.y != 0)
        {
            bat.transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2(-direction.x, direction.y) * 180 / Mathf.PI);
        }

    }
}
