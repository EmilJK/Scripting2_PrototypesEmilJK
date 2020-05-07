using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject objToSpawn;
    public float spawnTime;
    public float spawnTimeRandom;

    private float spawnTimer;

    private void Start()
    {
        ResetSpawnerTimer();
    }

    private void Update()
    {
        spawnTimer -= Time.deltaTime;

        if(spawnTimer <= 0f)
        {
            Instantiate(objToSpawn, transform.position, Quaternion.identity);
            ResetSpawnerTimer();
        }
    }


    void ResetSpawnerTimer()
    {
        spawnTimer = (spawnTime + Random.Range(0, spawnTimeRandom * 100f) / 100f);
    }
}
