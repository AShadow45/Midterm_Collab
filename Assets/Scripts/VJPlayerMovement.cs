using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VJPlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public VJHandler jsMovement;

    private Vector3 direction;
    private float xMin, xMax, yMin, yMax;

    public GameObject bat;

    void Update()
    {

        direction = jsMovement.InputDirection; //InputDirection can be used as per the need of your project

        if (direction.magnitude != 0)
        {

            transform.position += direction * moveSpeed * Time.deltaTime;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), Mathf.Clamp(transform.position.y, yMin, yMax), 0f);//to restric movement of player
        }

        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch thisTouch = Input.GetTouch(i);


            if (thisTouch.phase == TouchPhase.Ended)
          {

                bat.SetActive(true);
            }
        }
    }

    void Start()
    {

        //Initialization of boundaries
        xMax = Screen.width - 0; // I used 50 because the size of player is 100*100
        xMin = -5;
        yMax = Screen.height - 0;
        yMin = -5;

        bat.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit sth");
    }
}
