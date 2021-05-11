using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject blockPrefab;

    float TimeToFaster = 5f;
    float fasterSpawnTime = 10f;
    public float timeBetweenWaves = 2f ;
    private float TimeToSpawn = 2f;

    private void Update()
    {
       
        if (Time.time > TimeToSpawn)
        {
            SpawnBlocks();
            TimeToSpawn = timeBetweenWaves + Time.time;
        }
        if (Time.time > TimeToFaster)
        {
            timeBetweenWaves -= 0.05f;
            TimeToFaster = Time.time + fasterSpawnTime;
            
        }


    }



    void SpawnBlocks()
    {
        int random = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (random != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
