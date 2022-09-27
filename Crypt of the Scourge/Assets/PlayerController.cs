using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject Player;
    public float MoveSpeed;
    Vector2 Movement = new Vector2();
    Rigidbody2D RB;
    
    
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

        if (Input.GetKeyDown(KeyCode.D))
        {
            Movement.x = 1 * MoveSpeed;
            RB.velocity = Movement;
            Debug.Log("Did we get here?");
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            Movement.x = -1 * MoveSpeed;
            RB.velocity = Movement;
            Debug.Log("Did we get ?");



        }
        else
        {
            Movement = new Vector2(0, Movement.y);
            RB.velocity = Movement;

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Movement.y = 1 * MoveSpeed;
            RB.velocity = Movement;
            Debug.Log("Did we  here?");

        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            Movement.y = -1 * MoveSpeed;
            RB.velocity = Movement;  
        }

        else
        {
            Movement = new Vector2(Movement.x, 0);
            RB.velocity = Movement;
        }
    }

}