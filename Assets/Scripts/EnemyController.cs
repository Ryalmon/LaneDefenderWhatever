using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //starting health value
    public int enemyHealth = 1;
    //current enemy health
    public int currentEnemyHealth;

    public float enemySpeed = 10f;
    private Rigidbody2D enemyRB;


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
        }
    }
}
