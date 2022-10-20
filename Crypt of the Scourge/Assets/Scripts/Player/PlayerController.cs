using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to Control player input
public class PlayerController : MonoBehaviour
{
    //Defined fields and variables
    private Rigidbody2D RB2D;
    public float MoveSpeed;
    public float JumpForce;
    private bool IsJumping;
    private bool FaceRight;
    private float MoveHorizontal;
    private float MoveVertical;

    // Start is called before the first frame update
    // We want our character to have a starting state. Call game object and define if character is jumping or moving
    void Start()
    {
        RB2D=gameObject.GetComponent<Rigidbody2D>();
        IsJumping = false;
        FaceRight = true;
    }

    // Update is called once per frame
    // Check every frame for movement input
    void Update()
    {
        MoveHorizontal = Input.GetAxisRaw("Horizontal");
        MoveVertical = Input.GetAxisRaw("Vertical");

    }

    //Since we are dealing with physics its better to put any manipulation of input in FixedUpdate
    void FixedUpdate()
    {
        if (MoveHorizontal != 0)    //If statement to check to see if Horizontal input is -1 or 1
        {
            RB2D.AddForce(new Vector2 (MoveHorizontal * MoveSpeed, 0f), ForceMode2D.Impulse);
        }

        if ( MoveHorizontal > 0 && !FaceRight)  //If statements to control if character is facing the right direction.
        {
            flip();
        }
        if (MoveHorizontal < 0 && FaceRight)
        {
            flip();
        }

        if (!IsJumping && MoveVertical > 0.1f)  //If statement to control jumping
        {
            RB2D.AddForce(new Vector2(0f, MoveVertical * JumpForce), ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)    //Methods for ground check box if ground check fails do not allow a jump. Alter at a later date for double jump.
    {
        if (collision.gameObject.tag == "Ground")  //Utilize tags to determine what is considered to be ground
        {
            IsJumping = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsJumping = true;
        }
    }

    //Flip method for character. We want to alter the transform.
    void flip()                          
    {
        Vector2 CurrentDirection = gameObject.transform.localScale;
        CurrentDirection.x *= -1;
        gameObject.transform.localScale = CurrentDirection;
        FaceRight = !FaceRight;              //If character is facing one direction force it into the other directon.
    }
}
