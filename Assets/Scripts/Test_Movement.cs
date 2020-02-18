using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Movement : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        // KEYBOARD CONTROLS

        float xSpeed = Input.GetAxis("Horizontal") * speed;
        float ySpeed = Input.GetAxis("Vertical") * speed;
        rb.velocity = new Vector2(xSpeed, ySpeed);

    }
}
