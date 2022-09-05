/*****************************************************************************
// File Name :         CharacterMovement.cs
// Author :            Ryan Salmon
// Creation Date :     April 13, 2022
//
// Brief Description : controls player 1 movement in the game 
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator PlayerAnim;
    public float PlayerSpeed;
    private Vector2 PlayerInput;

    /// <summary>
    /// on awake
    /// reference the player rigidbody
    /// </summary>
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        //PlayerAnim = GetComponent<Animator>();
    }

    /// <summary>
    /// on update
    /// call the muve function
    /// </summary>
    private void Update()
    {
        Move();
        //Animate();
    }

    /// <summary>
    /// if the move function is called
    /// references the horizontal and vertical axis
    /// adds velocity in said directions overtime
    /// works with the input system
    /// </summary>
    private void Move()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");

        if (Horizontal == 0 && Vertical == 0)
        {
            rb.velocity = new Vector2(0, 0);
            return;
        }

        PlayerInput = new Vector2(Horizontal, Vertical);
        rb.velocity = PlayerInput * PlayerSpeed * Time.fixedDeltaTime;
    }
}
