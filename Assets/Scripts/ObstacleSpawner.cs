using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    public GameObject obstaclePrefab;

    public Transform[] spawnPoints;

    [SerializeField]
    private float startTimeBtwSpawns;
    private float decreaseTime = 0.025f;
    private float minTime = 0.23f;
    private float timeBtwSpawns;

    private void Update()
    {
        int randPos = Random.Range(0, spawnPoints.Length);

        if(timeBtwSpawns <= 0)
        {
            Instantiate(obstaclePrefab, spawnPoints[randPos].position, Quaternion.identity);
            if(startTimeBtwSpawns > minTime)
            {
                startTimeBtwSpawns -= decreaseTime;
            }
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
