using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem
{
    //Variables set as fields
    private int UnitHealth;
    private int UnitMaxHealth;


    public int Health         //Property for health in game
    {
        get
        {
            return UnitHealth;
        }
        set
        {
            UnitHealth = value;
        }
    }
    public int MaxHealth            //Proper for maximum potential  health in game Note: lack of parenthesis means it is a property not a method. 
    {
        get
        {
            return UnitMaxHealth;
        }
        set
        {
            UnitMaxHealth = value;
        }
    }

    public HealthSystem(int health, int maxHealth) //Constructor for health system objects, pass new health variables through the constructor.
    {
        UnitHealth=health;         //Fields to be set equal to new variables within the constructor.
        UnitMaxHealth=maxHealth;
    }

    public void Damage (int Dmg)  //Damage method
    {
        if(UnitHealth > 0)
        {
            UnitHealth -= Dmg;
        }
    }
}
