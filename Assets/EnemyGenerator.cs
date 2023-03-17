using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;

    float spawnTimer = 0;

    [SerializeField]
    float timeBetweenEnemySpawns = 1f;





    
    void Update()
    {
        spawnTimer+= Time.deltaTime;

        if (spawnTimer > timeBetweenEnemySpawns){
            Instantiate(enemyPrefab);
            spawnTimer = 0;
        }


    
    }
}
