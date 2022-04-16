using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;


    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 31.0f;

    private float startDelay = 2f;
    private float spawnInterval = 1;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(3f, 5f));
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        int RandomBall = Random.Range(1, ballPrefabs.Length);
        Debug.Log(spawnPosY);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[RandomBall], spawnPos, ballPrefabs[RandomBall].transform.rotation);
    }

}
