using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;
    public float MoveSpeed;
    Vector2 Movement = new Vector2();
    Rigidbody2D RB2D;
    public float JumpMagnitude;
    
    // Start is called before the first frame update
   void Start()
    {
     

    }
   
    void Awake()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        
       
    }
    void movement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //RB2D.velocity = new Vector2(RB2D.velocity.x, JumpMagnitude);
            RB2D.AddForce(transform.up * JumpMagnitude, ForceMode2D.Impulse);
            Debug.Log("Avery SUCKS");

        }

        else if (Input.GetKey(KeyCode.D))
        {
            Movement.x = 1 * MoveSpeed;
            RB2D.velocity = Movement;
            Debug.Log("You pressed D");

        }

        else if (Input.GetKey(KeyCode.A))
        {
            Movement.x = -1 * MoveSpeed;
            RB2D.velocity = Movement;
            Debug.Log("You pressed A");
        }
    }

}