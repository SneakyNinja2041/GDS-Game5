using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class HealthPickup : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;

    public Transform enemy;
    public HealthBar healthBar; 
    //PlayerHealth playerHealth;

    [SerializeField] private GameObject player;

    void Start()
    {
        //playerHealth = player.GetComponent<PlayerHealth>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealht(maxHealth);
        Time.timeScale = 1f;
    }

    //void GainHealth(int damage)
    //{
    //    currentHealth += damage;
    //
    //    healthBar.SetHealth(currentHealth);
    //}

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            //playerHealth.currentHealth--;
            Destroy(this.gameObject);
            currentHealth++;
        }
    }

}
