using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;
    public float MoveSpeed;
    Vector2 Movement = new Vector2();
    Rigidbody2D RB;
    public float JumpMagnitude;
    
    // Start is called before the first frame update
   void Start()
    {
     

    }
   
    void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            RB.velocity = new Vector2(RB.velocity.x, JumpMagnitude);
        }*/
     
        if (Input.GetKey(KeyCode.D))
        {
            Movement.x = 1 * MoveSpeed;
            RB.velocity = Movement;
            Debug.Log("You pressed D");
            while(Input.GetKey(KeyCode.D))
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    RB.velocity = new Vector2(RB.velocity.x, JumpMagnitude);
                }
            }
        }

        else if (Input.GetKey(KeyCode.A))
        {
            Movement.x = -1 * MoveSpeed;
            RB.velocity = Movement;
            Debug.Log("You pressed A");
        }

        else
        {
            Movement = new Vector2(0, Movement.y);
        }

        /*
        if (Input.GetKey(KeyCode.W))
        {
            Movement.y = 1 * MoveSpeed;
            RB.velocity = Movement;
            Debug.Log("You pressed W");

        }

        else if (Input.GetKey(KeyCode.S))
        {
            Movement.y = -1 * MoveSpeed;
            RB.velocity = Movement;
            Debug.Log("You pressed S");
        }

        else
        {
            Movement = new Vector2(Movement.x, 0);
            RB.velocity = Movement;
        }
        */
    }

}