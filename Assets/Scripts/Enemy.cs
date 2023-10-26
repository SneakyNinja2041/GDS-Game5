using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    // enemy movement
    public Transform target;
    public float speed = 2f;
    public Rigidbody rb;


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

    void Update()
    {

    }

    public void FollowPlayer()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        rb.MovePosition(pos);
        transform.LookAt(target);
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
                Instantiate(healthDrop);
            }
            

            Destroy(this.gameObject);
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
            //do dmg to the player
        }

    }
    


}
