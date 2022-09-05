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

    private int enemyPick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnPick = Random.Range(1, 5);
        enemyPick = Random.Range(1, 5);

        Debug.Log("Spawn " + spawnPick + " Enemy " + enemyPick);

    }
}
