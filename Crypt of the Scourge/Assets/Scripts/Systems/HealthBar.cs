using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Script to control the HP bar UI
public class HealthBar : MonoBehaviour
{
    Slider HealthSlider;       //Define the Health Slider as a field
    void Start()
    {
        HealthSlider = GetComponent<Slider>();  //Grab the component for the health slider
    }
    public void SetMaxHealth(int MaxHealth)  //Create Methods for maximum health and health and allow HealthSlider component to accept those values. 
    {
        HealthSlider.maxValue = MaxHealth;
        HealthSlider.value = MaxHealth;
    }
    
    public void SetHealth(int Health)  //We separate Health from MaxHealth in case inputs get messed up.
    {
        HealthSlider.value = Health;
    }
}
