using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{


    public float spawnRate = 1f;

    public GameObject ScorePrefab;

    private float nextScore = 0f;

    void Update()
        {
            if (Time.time >= nextScore)
            {
                Instantiate(ScorePrefab, Vector3.zero, Quaternion.identity);
                nextScore = Time.time + 1f / spawnRate;
            }
        }
    
}
