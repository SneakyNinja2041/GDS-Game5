using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHiboxes : MonoBehaviour
{

    [SerializeField] private GameObject healthDrop;

    [SerializeField] private GameObject player;
    //PlayerHealth playerH;

    public Transform enemy;

    public GameObject thisGO;

    private int randomTemp;

    public Slider enemyHealth;
    public int currentHealth;
    public int maxHealth = 3;

    void Start()
    {
        currentHealth = maxHealth;

        enemyHealth.maxValue = maxHealth;
        enemyHealth.value = currentHealth;

        //playerH = player.GetComponent<PlayerHealth>();
    }

    public void EnemyTakeDamage()
    {
        currentHealth--; // or minus however much the spell is supposed to do
        enemyHealth.value = currentHealth;

        if (currentHealth <= 0)
        {
            // animation or sound
            Debug.Log("ENEMY KILLED!");



            randomTemp = Random.Range(1, 10);
            if (randomTemp <= 5)
            {
                Instantiate(healthDrop, enemy.position, Quaternion.identity);
            }


            thisGO.SetActive(false);
        }
    }


    void OnTriggerEnter(Collider other) // activates once when the collider touches
    {
        if (other.CompareTag("Element"))
        {
            EnemyTakeDamage();
        }

        if (other.CompareTag("Player"))
        {
            Debug.Log("hit player");
            //playerH.currentHealth--;
        }

    }

}
