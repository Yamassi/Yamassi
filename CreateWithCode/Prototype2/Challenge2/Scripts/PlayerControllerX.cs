using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float startDelay = 2f;
    public GameObject dogPrefab;
    void Start()
    {
        InvokeRepeating("SpawnDog", startDelay, Random.Range(3f, 5f));
    }
    // Update is called once per frame
    void Update()
    {

    }

    void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
