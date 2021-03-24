using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float _lastSpawnTime; //last Timestamp when an enemy was spawned
    float _nextSpawnDelay; //somewhere between 2 and 5 seconds
    //int maxEnemies; //how many enemies are permitted at MAX (won't spawn if at or above this value)
    public GameObject EnemyPrefab;

    private void Update()
    {
        if (ShouldSpawn() == true)
        {
            SpawnEnemy();
        }
    }

    bool ShouldSpawn()
    {
        float currentTime = Time.time;
        float targetSpawnTime = _lastSpawnTime + _nextSpawnDelay;

        if (currentTime > targetSpawnTime)
            return true;
        else 
            return false;
    }

    void SpawnEnemy()
    {
        //instantiate an enemy
        Vector3 spawnPosition = transform.position + (Vector3.right * Random.Range(-2f, 2f));
                               //transform.position + new Vector3( Random.Range(-2f,2f), 0f, 0f );
        Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);
        
        //update my values
        _lastSpawnTime = Time.time;
        _nextSpawnDelay = Random.Range(1f, 3f);

    }
}
