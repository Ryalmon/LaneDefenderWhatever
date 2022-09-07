using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private int spawnPick;
    //reference to the 5 spawners
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    public GameObject Spawn4;
    public GameObject Spawn5;

    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;

    private int enemyPick;

    public bool canSpawn;
    private float timer;
    public float timeBetweenSpawning;


    // Start is called before the first frame update
    void Start()
    {
        spawnPick = Random.Range(1, 5);
        enemyPick = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if(canSpawn == true)
        {
            if(spawnPick == 1)
            {

            }
        }

    }

    private void WaveSpawn()
    {
        if (!canSpawn)
        {
            // Timer set to Time.deltaTime to get fire rate
            timer += Time.deltaTime;

            // If statement that controls the spawn rate
            if (timer > timeBetweenSpawning)
            {
                // CanShoot is set equal to true
                canSpawn = true;

                // Timer set to 0
                timer = 0;
            }
        }
    }
}
