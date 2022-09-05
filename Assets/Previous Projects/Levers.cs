/*****************************************************************************
// File Name :         Levers.cs
// Author :            Ryan Salmon
// Creation Date :     April 27, 2022
//
// Brief Description : This is a script that controls Levers in the game
                       Used to open doors atached to them
                       Start with the leverOn sprite inactive
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levers : MonoBehaviour
{
    //the door being destroyed
    public GameObject leverDoor;
    //the sprite of the lever being off
    public GameObject leverOff;
    //the sprite of the lever being on
    public GameObject leverOn;
    //Reactivates this game object
    public GameObject ambush;


    /// <summary>
    /// if the player triggers this object
    /// destroy the attached gameObject
    /// turn the leverOff object off
    /// turn the leverOn object on
    /// Activate the preset Game Object with attached enemies
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(leverDoor);
        leverOff.SetActive(false);
        leverOn.SetActive(true);
        ambush.SetActive(true);
    }
}
