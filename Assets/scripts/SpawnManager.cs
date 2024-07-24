using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float  spawnRangeX = 10.0f ;
    private float spawnPosZ  = 20.0f;
    public float startdelay = 1.0f;
    public float startinterval = 1.0f; 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startdelay , startinterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomAnimal() {
        int AnimalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[AnimalIndex], spawnpos, (animalPrefabs[AnimalIndex].transform.rotation));

    }
}
