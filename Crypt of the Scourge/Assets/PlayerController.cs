using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int x;
    int Add(int hours, int pay)
    {
        int result;
        result = hours * pay;

        return result;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        x = Add(9, 5);
        Debug.Log(x);
  
    }

    // Update is called once per frame
    void Update()
    {

    }

}