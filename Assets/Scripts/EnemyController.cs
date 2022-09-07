using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //starting health value
    public int enemyHealth = 10;
    //current enemy health
    public int currentEnemyHealth;

    public float enemySpeed = 10f;
    private Rigidbody2D enemyRB;

    public AudioClip hitSound;
    public AudioClip failSound;
    public AudioClip deadSound;


    void Start()
    {
        currentEnemyHealth = enemyHealth;
        enemyRB = GetComponent<Rigidbody2D>();
        enemyRB.velocity = transform.right * -enemySpeed;
    }

    public void EnemyTakeDamage(int damage)
    {
        currentEnemyHealth -= damage;

        if (currentEnemyHealth <= 0)
        {
            Destroy(gameObject);
            Vector3 camPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(deadSound, camPos);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Vector3 camPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(hitSound, camPos);
        }

        else if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 camPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(failSound, camPos);
            Destroy(gameObject);
        }

    }
    

}
