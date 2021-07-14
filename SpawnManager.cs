using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    
    private float spawnRangeX = 10;
    private float spawnRangeZ = 25;

    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    private void SpawnRandomAnimal()
    {
            int arrayIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnLocation = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), transform.position.y, spawnRangeZ);
            Instantiate(animalPrefabs[arrayIndex], spawnLocation, animalPrefabs[arrayIndex].transform.rotation);
    }
}
