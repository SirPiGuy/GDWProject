using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //SpaceTanks Script
    public GameObject[] enemyPrefabs; //Array that holds each enemy available to spawn
    private float spawnRangeX = 12f;
    private float spawnRangePosZ = 9f;
    private float spawnRangeNegZ = -7f;
    private float aboveGround = 0.35f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval); //Repeatedly call the function, starting at 2 seconds and repeating every 3s after that
    }

    void SpawnRandomEnemy()
    {
        //Randomly generate an enemy index and position, then spawn the prefab at that location
        //TODO Get each prefab to spawn in properly rotated
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        int spawnPosition = Random.Range(0, 3);
        if(spawnPosition == 0)
        {
            //Spawn enemy facing down, at top of screen
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), aboveGround, spawnRangePosZ);
            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
        }
        if (spawnPosition == 1)
        {
            //Spawn enemy facing left, at right of screen
            Vector3 spawnPos = new Vector3(spawnRangeX, aboveGround, Random.Range(spawnRangeNegZ, spawnRangePosZ));
            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
        }
        if (spawnPosition == 2)
        {
            //Spawn enemy facing up, at bottom of screen
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), aboveGround, spawnRangeNegZ);
            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
        }
        if (spawnPosition == 3)
        {
            //Spawn enemy facing right, at left of screen
            Vector3 spawnPos = new Vector3(-spawnRangeX, aboveGround, Random.Range(spawnRangeNegZ, spawnRangePosZ));
            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
        }

    }
}
