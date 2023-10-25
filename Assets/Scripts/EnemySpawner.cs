using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnRadiusX = 10f;
    [SerializeField] private float spawnRadiusZ = 10f;
    [SerializeField] private float spawnY = 0f;

    [SerializeField] private GameObject enemyPrefab;


    void Start()
    {
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {

        float randomX = Random.Range(-spawnRadiusX, spawnRadiusX);
        float randomZ = Random.Range(-spawnRadiusZ, spawnRadiusZ);
        Vector3 spawnPos = (Vector3)transform.position + new Vector3(randomX, spawnY, randomZ);

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

    }

}
