﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
               Invoke("SpawnRandomBall", startDelay);

    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);


        //
       //instantiate random ball from array
int ballIndex = Random.Range(0, ballPrefabs.Length);
Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
            spawnInterval = Random.Range(0.5f, 3.0f);

            // Invoke again
    Invoke("SpawnRandomBall", spawnInterval);
    Debug.Log("spawnInterval: " + spawnInterval);
       }
        
    

}
