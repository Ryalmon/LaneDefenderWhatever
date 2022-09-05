/*****************************************************************************
// File Name :         Fireball.cs
// Author :            Ashton Mutnansky
// Creation Date :     April 11, 2022
//
// Brief Description : This is a script that controls the fireballs behavior
//                     in Unity.
*****************************************************************************/

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    // Private Vector3 is to mousePos
    private Vector3 mousePos;
    
    // Private Camera is set to mainCam
    private Camera mainCam;
    
    // Private Rigidbody2D is set as rb
    private Rigidbody2D rb;
    
    // Public float is set to force
    public float force;
    
    /// <summary>
    /// Start function that will get the fireballs location wherever the
    /// transform is located.
    /// </summary>
    void Start()
    {
        // MainCam is set to GameObject to find with tag and GetComponent
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        
        // Rb is set to a GetComponent
        rb = GetComponent<Rigidbody2D>();
        
        // MousePos is set to mainCam world point
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        
        // Vector3 direction of mousePos will be picked up by transform Pos
        Vector3 direction = mousePos - transform.position;
        
        // Vector3 rotation is set to mousePos transform
        Vector3 rotation = transform.position - mousePos;
        
        // rb.velocity is set to new Vector2 to get direction on x and y axis
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        
        // Float variable is set to rotation values through Mathf x and y
        // values
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        
        // Transform rotation is set to Quaternion
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<EnemyHealth1>().EnemyTakeDamage(10);
            Destroy(gameObject);
        }
        if (collision.CompareTag("Boss Enemy"))
        {
            collision.GetComponent<EnemyHealth1>().EnemyTakeDamage(5);
            Destroy(gameObject);
        }

        if (collision.CompareTag("Walls")) 
        {
            Destroy(gameObject);
        }
    }
}
*/