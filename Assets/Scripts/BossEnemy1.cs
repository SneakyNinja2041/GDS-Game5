using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossEnemy1 : MonoBehaviour
{

    public Transform target;
    public Rigidbody rb;

    public int currentHealth;
    public int maxHealth = 50;

    public Slider bossHealthBar;

    public GameObject battleCube;

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

            bossDrop.isFireDrop = true;
            battleCube.SetActive(false);
        }

        if (cam.isBossFight == true)
        {
            bossHealthBar.value = currentHealth;
        }

        transform.LookAt(target);
    }

}
