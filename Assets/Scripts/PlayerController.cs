using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRigidbody;
    private float movementSpeed = 10f;
    private float verticalMove;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        

        //If press W or UP arrow go up
        
        //IF press S or DOWN arrow go Down
        
        //If Press SPACE Shoot Bullet
        //reference bullet Spawner
        //start coroutine to delay time before next shot

    }

    
}
