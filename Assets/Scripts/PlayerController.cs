using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator PlayerAnim;
    public float PlayerSpeed;
    private Vector2 PlayerInput;
    public SpriteRenderer barrelExplosion;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public AudioClip shootSound;
    public AudioClip deathSound;

    public bool canFire = true;
    public float timeBetweenBullets;


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

        if (Input.GetButton("Jump") && (canFire == true))
        {
            Shoot();
        }

        if (canFire == false)
        {
            DelayTimer();
            canFire = true;
        }
    }

    private void Move()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");

        if (Vertical == 0)
        {
            rb.velocity = new Vector2(0, 0);
            return;
        }

        PlayerInput = new Vector2(Horizontal, Vertical);
        rb.velocity = PlayerInput * PlayerSpeed * Time.fixedDeltaTime;
    }


    private void Shoot()
    {
        canFire = false;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Vector3 camPos = Camera.main.transform.position;
        AudioSource.PlayClipAtPoint(shootSound, camPos);
        
    

    }

    IEnumerator DelayTimer()
    {
        
        yield return new WaitForSeconds(10f);
        
    }
}
