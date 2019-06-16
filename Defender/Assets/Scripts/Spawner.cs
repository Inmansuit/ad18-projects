using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;

    public GameObject hexagonPrefab;

    private float nextSpawn = 0f;

   

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextSpawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextSpawn = Time.time + 1f / spawnRate;
        }
    }
}
