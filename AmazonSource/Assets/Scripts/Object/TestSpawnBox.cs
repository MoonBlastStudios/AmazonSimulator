using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TestSpawnBox : MonoBehaviour
{
    public GameObject box;              //The object/prefab that will spawn.

    //FOR TESTING PURPOSES - I know that we'll be using Screen Positions instead of this.    
    private GameObject[] spawnPoints;   //An array for the Spawn Points. We'll be able to add and remove as many as needed.
    private int randomPosition;         //Each Spawn Point as a integer. This helps when randomly selecting one of the Spawn Points.
    private GameObject spawnPosition;   //The position of the randomly selected Spawn Point.

    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawn");       //This finds all the objects tagged as "Spawn"; usually the Spawn Points.
        InvokeRepeating("SpawnBox", 0.0f, 0.7f);                        //Every 0.7 "seconds", the function "Spawn Box" will trigger.
    }

    void SpawnBox()
    {
        randomPosition = Random.Range(0, spawnPoints.Length);           //This randomly selects one of the Spawn Points and stores its position.
        spawnPosition = spawnPoints[randomPosition];                    //This takes the randomly chosen Spawn Point and find it's transform.
        Instantiate(box, spawnPosition.transform);                      //This spawns a box at transform of the aforementioned Spawn Point.
    }
}
