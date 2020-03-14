using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VJPlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public VJHandler jsMovement;

    public Rigidbody2D rb;

    private Vector3 direction;
    private float xMin, xMax, yMin, yMax;

    public GameObject bat;

    private Animator anim;
    SpriteRenderer rend;
    private bool isWalkingSide = false;

    void Update()
    {

        direction = jsMovement.InputDirection; //InputDirection can be used as per the need of your project

        if (direction.magnitude != 0)
        {
            rb.AddForce(direction *moveSpeed);
           // transform.position += direction * moveSpeed * Time.deltaTime;
            //transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), Mathf.Clamp(transform.position.y, yMin, yMax), 0f);//to restric movement of player
        }

        playerAnimation();

        Debug.Log(direction.y);

    }

    void Start()
    {
        jsMovement = GameObject.FindWithTag("JoyStick").GetComponent<VJHandler>();
        rb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();

        //Initialization of boundaries
       // xMax = Screen.width - 0; // I used 50 because the size of player is 100*100
       // xMin = -500;
       // yMax = Screen.height - 0;
        //yMin = -500;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit" + collision.gameObject.name);
    }

    void playerAnimation()
    {
        if (direction.x < 0f)
        {
            anim.SetBool(AnimationHash.walkSide, true);
            rend.flipX = true;
            //transform.rotation = Quaternion.Euler(0, 180, 0);
            //isWalkingSide = true;
        }
       else if (direction.x > 0f)
        {
            anim.SetBool(AnimationHash.walkSide, true);
            rend.flipX = false;
            //transform.rotation = Quaternion.Euler(0, 0, 0);
            //isWalkingSide = true;
        }
        else
        {
            anim.SetBool(AnimationHash.walkSide, false);
            //isWalkingSide = false;
        }
        /*
        if (direction.y > 0 && !isWalkingSide)
        {
            anim.SetBool(AnimationHash.walkBack, true);

        } else if (direction.y < 0 && !isWalkingSide)
        {
            anim.SetBool(AnimationHash.walkFront, true);
        } else
        {
            anim.SetBool(AnimationHash.walkFront, false);
            anim.SetBool(AnimationHash.walkBack, false);
        }
        */
    }
}
