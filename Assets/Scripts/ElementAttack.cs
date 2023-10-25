using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementAttack : MonoBehaviour
{
    public GameObject earthPrefab;
    public GameObject firePrefab;
    //public GameObject waterPrefab;
    public GameObject electricityPrefab;
    public Transform elementSpawnPoint;
    public float countdownInterval;
    private float countdownTimer;

    //public AudioClip shootSound;
    //private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        UpdateShooting();

    }

    private void UpdateShooting()
    {
        countdownTimer -= Time.deltaTime;

        if (countdownTimer <= 0 && Input.GetKey(KeyCode.Alpha1))
        {
            countdownTimer = countdownInterval;
            ShootEarth();

        }

        if (countdownTimer <= 0 && Input.GetKey(KeyCode.Alpha2))
        {
            countdownTimer = countdownInterval;
            ShootFire();

        }

        if (countdownTimer <= 0 && Input.GetKey(KeyCode.Alpha3))
        {
            countdownTimer = countdownInterval;
            ShootElectricity();

        }
    }

    private void ShootEarth()
    {
        Instantiate(earthPrefab, elementSpawnPoint.position, elementSpawnPoint.rotation);
        //instantiate means to spawn, quaternion means rotation
    }

    private void ShootFire()
    {
        Instantiate(firePrefab, elementSpawnPoint.position, elementSpawnPoint.rotation);
        //instantiate means to spawn, quaternion means rotation
    }

    private void ShootElectricity()
    {
        Instantiate(electricityPrefab, elementSpawnPoint.position, elementSpawnPoint.rotation);
        //instantiate means to spawn, quaternion means rotation
    }
}
