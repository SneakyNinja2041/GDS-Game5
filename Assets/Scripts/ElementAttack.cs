using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementAttack : MonoBehaviour
{
    public GameObject earthPrefab;
    public GameObject firePrefab;
    public GameObject waterPrefab;
    public GameObject electricityPrefab;
    public Transform elementSpawnPoint;

    public float earthCountdownInterval;
    private float earthCountdownTimer;

    public float fireCountdownInterval;
    private float fireCountdownTimer;

    public float electricityCountdownInterval;
    private float electricityCountdownTimer;

    public float waterCountdownInterval;
    private float waterCountdownTimer;

    public GameObject fireUI;
    public GameObject electricityUI;
    public GameObject waterUI;
    public GameObject earthUI;

    void Start()
    {
        

    }

    void Update()
    {
        UpdateShooting();

    }

    private void UpdateShooting()
    {
        earthCountdownTimer -= Time.deltaTime;
        fireCountdownTimer -= Time.deltaTime;
        waterCountdownTimer -= Time.deltaTime;
        electricityCountdownTimer -= Time.deltaTime;

        if (earthUI.activeSelf)
        {
            if (earthCountdownTimer <= 0 && Input.GetKey(KeyCode.Alpha1))
            {
                earthCountdownTimer = earthCountdownInterval;
                ShootEarth();

            }
        }

        if (fireUI.activeSelf)
        {
            if (fireCountdownTimer <= 0 && Input.GetKey(KeyCode.Alpha2))
            {
                fireCountdownTimer = fireCountdownInterval;
                ShootFire();
                Debug.Log("Fire key pressed");
            }
        }

        if (electricityUI.activeSelf)
        {
            if (electricityCountdownTimer <= 0 && Input.GetKey(KeyCode.Alpha3))
            {
                electricityCountdownTimer = electricityCountdownInterval;
                ShootElectricity();

            }
        }
        
        if (waterUI.activeSelf)
        {
            if (waterCountdownTimer <= 0 && Input.GetKey(KeyCode.Alpha4))
            {
                waterCountdownTimer = waterCountdownInterval;
                ShootWater();

            }
        }
        
    }

    private void ShootEarth()
    {
        Instantiate(earthPrefab, elementSpawnPoint.position, elementSpawnPoint.rotation);
    }

    private void ShootFire()
    {
        Instantiate(firePrefab, elementSpawnPoint.position, elementSpawnPoint.rotation);
    }

    private void ShootElectricity()
    {
        Instantiate(electricityPrefab, elementSpawnPoint.position, elementSpawnPoint.rotation);
    }

    private void ShootWater()
    {
        Instantiate(waterPrefab, elementSpawnPoint.position, elementSpawnPoint.rotation);
    }
}
