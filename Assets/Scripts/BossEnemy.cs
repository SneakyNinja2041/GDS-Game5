using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossEnemy : MonoBehaviour
{

    public int currentHealth;
    public int maxHealth = 50;

    public Slider bossHealthBar;

    [SerializeField] GameObject bossDropper;
    BossDrop bossDrop;

    [SerializeField] GameObject cameraGO;
    CameraController cam;


    void Start()
    {
        currentHealth = maxHealth;

        bossHealthBar.maxValue = maxHealth;
        bossHealthBar.value = currentHealth;

        bossDrop = bossDropper.GetComponent<BossDrop>();
        cam = cameraGO.GetComponent<CameraController>();
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            // death audio/animation and stuff
            // spawn the bossDropPrefab

            bossDrop.bossesKilled++;
        }

        if (cam.isBossFight == true)
        {

            currentHealth = maxHealth;
            bossHealthBar.value = currentHealth;
        }


    }

}
