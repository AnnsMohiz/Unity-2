using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void SpawnRandomAnimal()
     {
            //Randomly Generates Animal Index and Spawn
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);

            //random range is use for spawn randomly animals 
            //we use zero in bracket its index of an Array
            //using length assign to the animal Prefab.. lenth is of an array 
           int animalIndex = Random.Range(0, animalPrefabs.Length);   
           //here we spawn animals 
           Instantiate(animalPrefabs[animalIndex],spawnPos,animalPrefabs[animalIndex].transform.rotation);
     }
}
