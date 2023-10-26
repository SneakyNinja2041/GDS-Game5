using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    public Transform spawner;

    void Start()
    {
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawner.position, spawner.rotation);

    }

}
