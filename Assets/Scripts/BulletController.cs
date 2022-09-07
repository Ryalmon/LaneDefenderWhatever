using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public Rigidbody2D bulletRB;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletRB.velocity = transform.right * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            // Gets the collision of the enemy component
            collision.GetComponent<EnemyController>().EnemyTakeDamage(1);

            // Destroys game object
            Destroy(gameObject);
        }
        else if (collision.CompareTag("OOB"))
        {
            Destroy(gameObject);
        }
    }

}
