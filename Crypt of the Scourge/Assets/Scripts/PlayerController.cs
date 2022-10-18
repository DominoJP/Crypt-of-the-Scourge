using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D RB2D;
    public float MoveSpeed;
    public float JumpForce;
    private bool IsJumping;
    private bool FaceRight;
    private float MoveHorizontal;
    private float MoveVertical;
    // Start is called before the first frame update
    void Start()
    {
        RB2D=gameObject.GetComponent<Rigidbody2D>();
        IsJumping = false;
        FaceRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal = Input.GetAxisRaw("Horizontal");
        MoveVertical = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        if (MoveHorizontal != 0)
        {
            RB2D.AddForce(new Vector2 (MoveHorizontal * MoveSpeed, 0f), ForceMode2D.Impulse);
        }

        if ( MoveHorizontal > 0 && !FaceRight)
        {
            flip();
        }
        if (MoveHorizontal < 0 && FaceRight)
        {
            flip();
        }

        if (!IsJumping && MoveVertical > 0.1f)
        {
            RB2D.AddForce(new Vector2(0f, MoveVertical * JumpForce), ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
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

    void flip()
    {
        Vector3 CurrentDirection = gameObject.transform.localScale;
        CurrentDirection.x *= -1;
        gameObject.transform.localScale = CurrentDirection;
        FaceRight = !FaceRight;
    }
}
