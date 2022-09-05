/*****************************************************************************
// File Name :         MeleeController.cs
// Author :            Ryan Salmon and Ashton Mutnansky
// Creation Date :     April 27, 2022
//
// Brief Description : Script that gets the collision of the enemies to come in
                       contact of player that will activate the sprite of the 
                       sword and slash the enemies to do damage.
                       Knockback commented out because it wouldn't work properly.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class MeleeController : MonoBehaviour

{
    
    // Gets hitBox transform of game object
    public GameObject hitBox;

    /// <summary>
    /// Function that gets the collision of the enemies and calls from 
    /// the damage script to hurt the enemies when slashed
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If statement that gets tag of Enemy to be collided with
        // the player's sword and will take damage after activating the
        // sprite renderer of the sword.
        if (collision.CompareTag("Enemy"))
        {            
            hitBox.GetComponent<SpriteRenderer>().enabled = true;
            collision.GetComponent<EnemyHealth1>().EnemyTakeDamage(20);
            // collision.GetComponent<EnemyAIController>().Knockback();
            StartCoroutine(HitDelay());
        }

        // If statement that gets tag of Boss Enemy to be collided with
        // the player's sword and will take damage after activating the
        // sprite renderer of the sword.
        if (collision.CompareTag("Boss Enemy"))
        {
            hitBox.GetComponent<SpriteRenderer>().enabled = true;
            collision.GetComponent<BossHealth>().EnemyTakeDamage(20);
            StartCoroutine(HitDelay());
            
        }

        // If statement that gets tag of Spawner to be collided with
        // the player's sword and will take damage after activating the
        // sprite renderer of the sword.
        if (collision.CompareTag("Spawner"))
        {
            hitBox.GetComponent<SpriteRenderer>().enabled = true;
            collision.GetComponent<EnemyHealth1>().EnemyTakeDamage(15);
            StartCoroutine(HitDelay());

        }


    }

    /// <summary>
    /// Coroutine that gets the hitdelay of the sword slash so player
    /// melee can be balanced
    /// </summary>
    /// <returns></returns>
    IEnumerator HitDelay()
    {
        yield return new WaitForSeconds(.1f);
        hitBox.GetComponent<SpriteRenderer>().enabled = false;

    }
}
    */