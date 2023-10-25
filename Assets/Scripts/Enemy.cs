using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    // enemy movement


    [SerializeField] private GameObject healthDrop;

    private int randomTemp;
    
    public Slider enemyHealth;
    public int currentHealth;
    public int maxHealth = 3;

    // enemy attack



    // if the enemies change, need to reference the different prefabs

    void Start()
    {
        currentHealth = maxHealth;

        enemyHealth.maxValue = maxHealth;
        enemyHealth.value = currentHealth;
    }






    public void EnemyTakeDamage()
    {
        // enemy loses health based on how much dmg the spell does
        enemyHealth.value = currentHealth;

        if (currentHealth <= 0)
        {
            // animation or sound
            Debug.Log("ENEMY KILLED!");

            
            
            randomTemp = Random.Range(1, 10);
            if (randomTemp <= 5)
            {
                // spawn the health
            }
            

            Destroy(this.gameObject);
        }


    }

}
