using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{

    [Range(0f, 600f)]
    [SerializeField]
    private float JumpForce = 500f;
    // the range lets the slider only go a certian amount
    [Range(0f, 600f)]
    [SerializeField]
    private float movementSmooth = .06f;
    // adds movement smooth and creates a boolean for it
    [SerializeField]
    private bool airControl;
    // adds air control that can be toggled
    public AudioSource bubbles;


    [SerializeField]
    private Rigidbody2D r2d2;
    private bool facingRight;
    //is the player facing right?
    private Vector2 startVelocity = Vector2.zero;
    // adds a start of the velocity, this helps with movement smoothing

        void start()
    {
        bubbles = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Awake()
    {

        r2d2 = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
 

    public void Move(float move, bool jump)
    {

        if (airControl)
        {

            Vector2 maxVelocity = new Vector2(move * 10f, r2d2.velocity.y);

            r2d2.velocity = Vector2.SmoothDamp(r2d2.velocity, maxVelocity, ref startVelocity, movementSmooth);
        }


        if (jump)
        {
            r2d2.AddForce(new Vector2(0, JumpForce));
            bubbles.Play();
        }

    }
}
