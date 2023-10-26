using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] GameObject enemyGO;
    Enemy enemy;

    void Start()
    {
        enemy = enemyGO.GetComponent<Enemy>();
    }

    void OnTriggerStay(Collider player) //active while in the collider
    {
        if (player.tag == "Player")
        {
            enemy.FollowPlayer();
        }

    }


}
