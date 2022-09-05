/*****************************************************************************
// File Name :         ProjectileShoot.cs
// Author :            Ashton Mutnansky
// Creation Date :     April 12, 2022
//
// Brief Description : This is a script that will get the projectile to shoot 
                       when input is clicked.
*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

public class ProjectileShoot : MonoBehaviour
{
    // Private variable sets Camera to mainCamera
    private Camera mainCamera;
    
    // Private variable of Vector3 is set as mousePos
    private Vector3 mousePos;
    
    // Public variable of GameObject is set as projectile
    public GameObject projectile;
    
    // Public variable of Transform is set to projectileTransform
    public Transform projectileTransform;
    
    // Public bool variable is set to canShoot
    public bool canShoot;
    
    // Private float is set to timer
    private float timer;

    // Public float is set to timeBetweenFiring
    public float timeBetweenFiring;
    
    /// <summary>
    /// Start function that sets mainCamera to a find tag function and sets 
    /// it to its get component
    /// </summary>
    void Start()
    {
        // Main camera is set = to GameObject to reference getting it through
        // GetComponent
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    /// <summary>
    /// Update function that updates all the inputs that will get the 
    /// projectile to fire when button pressed and instantiate the 
    /// fireball.
    /// </summary>
    void Update()
    {
        // MousePos is set = to mainCamera world point to get mousePosition
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        // Vector3 is set as a rotation to get mouse transform position
        Vector3 rotation = mousePos - transform.position;

        // Float variable is set as a rotate and will get the rotation
        // of the mouse.
        float rotateZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        // Sets transform.rotation to a Quaternion
        transform.rotation = Quaternion.Euler(0, 0, rotateZ);

        // If statement that gets when canShoot is true or false
        if (!canShoot)
        {
            // Timer set to Time.deltaTime to get fire rate
            timer += Time.deltaTime;
            
            // If statement that controls the fireball fire rate
            if(timer > timeBetweenFiring)
            {
                // CanShoot is set equal to true
                canShoot = true;
                
                // Timer set to 0
                timer = 0;
            }
        }

        // If statement that helps to instantiate the fireball sprite
        if (Input.GetMouseButton(0) && canShoot)
        {
            // CanShoot is set to false
            canShoot = false;
            
            // Instantiates the projectile in Unity
            Instantiate(projectile, projectileTransform.position, Quaternion.identity);
        }
    }
}
