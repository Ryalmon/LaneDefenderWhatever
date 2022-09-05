/*****************************************************************************
// File Name :         HealthBar.cs
// Author :            Ryan Salmon
// Creation Date :     April 13, 2022
//
// Brief Description : This script is meant to be used to control the health
                       bar in the game by being referenced in the player health
                       script
                       Brackeys tutorial was referenced for this
*****************************************************************************/
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;

    /// <summary>
    /// the set max health function will be referenced by the player health script
    /// sets return value to health so when referenced the slider can match the player health
    /// set health works for the current health and set max health works for the max health amount
    /// </summary>
    /// <param name="health"></param>
    public void SetMaxHealth(int health)
    {
        healthSlider.maxValue = health;
        healthSlider.value = health;
    }

    /// <summary>
    /// moves the health bar in relation to the health
    /// </summary>
    /// <param name="health"></param>
    public void SetHealth(int health)
    {
        healthSlider.value = health;
    }
}
