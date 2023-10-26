using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHitbox : MonoBehaviour
{
    public GameObject thisGO;

    public int currentHealth;
    public int maxHealth = 50;

    public GameObject battleCube;


    [SerializeField] GameObject cameraGO;
    CameraController cam;

    [SerializeField] GameObject bossDropper;
    BossDrop bossDrop;

    void Start()
    {
        currentHealth = maxHealth;

        bossDrop = bossDropper.GetComponent<BossDrop>();
        cam = cameraGO.GetComponent<CameraController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Element"))
        {
            Debug.Log("Boss Hit!");
            currentHealth--;  
        }

    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            bossDrop.bossKilled++;
            thisGO.SetActive(false);
        }

    }
}
