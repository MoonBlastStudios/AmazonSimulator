using System;
using System.Collections;
using System.Collections.Generic;
using Tools;
using UnityEngine;
using Random = UnityEngine.Random;

public class TestSpawnBox : MonoBehaviour
{
    [Header("Data")] 
    [SerializeField] private Range m_randomRotationOffset;

    [Header("Components")] 
    [SerializeField] private Transform m_boxParent;
    [SerializeField] private CustomTimer m_timer = null;
    [SerializeField] private Transform m_spawnPointsParent = null;
    
    [Header("Prefabs")]
    public GameObject box;              //The object/prefab that will spawn.

    //FOR TESTING PURPOSES - I know that we'll be using Screen Positions instead of this.    
    private List<GameObject> spawnPoints;   //An array for the Spawn Points. We'll be able to add and remove as many as needed.
    private int randomPosition;         //Each Spawn Point as a integer. This helps when randomly selecting one of the Spawn Points.
    private GameObject spawnPosition;   //The position of the randomly selected Spawn Point.

    void Start()
    {
        //-----------------------------------ORIGINAL-----------------------------------
        //spawnPoints = GameObject.FindGameObjectsWithTag("Spawn");       //This finds all the objects tagged as "Spawn"; usually the Spawn Points.
        InvokeRepeating("SpawnBox", 0.0f, 0.7f);                        //Every 0.7 "seconds", the function "Spawn Box" will trigger.
        //------------------------------------------------------------------------------

        spawnPoints = GameObjectTools.GetAllChildren(m_spawnPointsParent);
        Debug.Log(spawnPoints.Count);
    }

    private void Update()
    {
        if (m_timer.Tick(Time.deltaTime))
        {
            SpawnBox();
        }
    }

    void SpawnBox()
    {
        randomPosition = Random.Range(0, spawnPoints.Count - 1);           //This randomly selects one of the Spawn Points and stores its position.
        spawnPosition = spawnPoints[randomPosition];                    //This takes the randomly chosen Spawn Point and find it's transform.
        Instantiate(box, spawnPosition.transform.position, Quaternion.Euler(0,0,m_randomRotationOffset.GetRandom()), m_boxParent); //This spawns a box at transform of the aforementioned Spawn Point.
    }
}
