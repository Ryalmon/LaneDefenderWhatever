/*****************************************************************************
// File Name :         FireballB.cs
// Author :            Ashton Mutnansky and Ryan Salmon
// Creation Date :     April 28, 2022
//
// Brief Description : This script ontrols the behavior of the fireball assets
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

/*public class FireballB : MonoBehaviour
{
    // Serialized field of float speed
    [SerializeField]
    private float speed = 6f;

    /// <summary>
    /// Update function that gets transform of where you are aiming
    /// </summary>
    void Update()
    {
        // Transform of shot being aimed
        transform.Translate(transform.up * speed * Time.deltaTime, Space.World);
    }

    /// <summary>
    /// if fireball collides with something
    /// compare the tag with "Enemy", "Boss Enemy", or "Spawner"
    /// if either do set amount of damage
    /// then the fireball destroys itself
    /// if it hits a wall it just destroys itself
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If statement that gets the enenmy tag and on collision the fireball
        // will do set amount of damage
        if (collision.CompareTag("Enemy"))
        {
            // Gets the collision of the enemy component
            collision.GetComponent<EnemyHealth1>().EnemyTakeDamage(50);

            // Destroys game object
            Destroy(gameObject);
        }
        /*if (collision.CompareTag("Boss Enemy"))
        {
            collision.GetComponent<EnemyHealth1>().EnemyTakeDamage(25);
            Destroy(gameObject);
        }*/

        // If statement that gets the enenmy tag and on collision the fireball
        // will do set amount of damage
        /*
        if (collision.CompareTag("Spawner"))
        {
            // Gets the collision of the enemy component
            collision.GetComponent<EnemyHealth1>().EnemyTakeDamage(50);

            // Destroys game object
            Destroy(gameObject);
        }

        // Destroys fireball when collision with tag
        if (collision.CompareTag("Walls"))
        {
            // Destroys game object
            Destroy(gameObject);
        }

        // Destroys fireball when collision with tag
        if (collision.CompareTag("Player1"))
        {
            // Destroys game object
            Destroy(gameObject);
        }

        // Destroys fireball when collision with tag
        if (collision.CompareTag("Player2"))
        {
            // Destroys game object
            Destroy(gameObject);
        }
    }
}
        */