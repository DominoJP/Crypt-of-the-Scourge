using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script to control Health, Bones, and abilities
public class PlayerBehaviour : MonoBehaviour
{
    HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
       Damage from enemies or traps would go in here current implementations do no work
    }
    */

    private void PlayerTakeDamage (int dmg)                                  //Method for taking damage and altering HP Bar UI
    {
        GameManager.gameManager.PlayerHealth.Damage(dmg);
        healthBar.SetHealth(GameManager.gameManager.PlayerHealth.Health);
    }
}
