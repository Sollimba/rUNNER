using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectAtDistance : MonoBehaviour
{
    [SerializeField] public GameObject objectToSpawn;
    public float distanceToDisappear = 20f;
    public float distanceToSpawn = 20f;
    public float spawnYPosition = -5f;
    private float lastSpawnPosition;
    private GameObject spawnedObject;

    void Start()
    {
        lastSpawnPosition = transform.position.x;
    }

    void Update()
    {
        float distanceTraveled = Mathf.Abs(transform.position.x - lastSpawnPosition);

        if (distanceTraveled >= distanceToSpawn)
        {
            SpawnObject();
            lastSpawnPosition = transform.position.x;
        }
    }

    void SpawnObject()
    {
        Vector3 spawnPosition = new Vector3(transform.position.x + distanceToSpawn, spawnYPosition, transform.position.z);

        spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}
