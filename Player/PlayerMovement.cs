using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    public float runSpeed = 40f;

    private SpriteRenderer SpRend;

    float horizontalMove = 0f;
    bool jump = false;

    void Awake()
    {
        SpRend = GetComponent<SpriteRenderer>();

    }
    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        //print(horizontalMove);
        if (horizontalMove > 0)
        {
            SpRend.flipX = false;
        }

        else if (horizontalMove < 0)
        {
            SpRend.flipX = true;
        }
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;

        }
    }


    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;

    }
}