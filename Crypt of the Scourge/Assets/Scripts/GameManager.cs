using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager       //Set gameManager property, notation is a little screwy.
    {
        get;
        private set;
    }

    public HealthSystem PlayerHealth = new HealthSystem(50, 50);
    // Changed Start to Awake so that GameManager is the first instantiated script.
    void Awake()
    {
        if (gameManager != null && gameManager != this) //We need to check to see if there is only one GameManager as this is the overall controller for the game. 
        {
            Destroy(this);                 //If another GameManager does somehow form, destroy it. 
        }

        else
        {
            gameManager = this;
        }

    }

}
