using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDrop : MonoBehaviour
{
    public GameObject lightningDropPrefab;
    public GameObject fireDropPrefab;
    public GameObject waterDropPrefab;

    public int bossKilled;

    private void Start()
    {
        bossKilled = 0;
    }

    private void Update()
    {
        if (bossKilled == 2)
        {
            lightningDropPrefab.SetActive(true);
        }
        if (bossKilled == 3)
        {
            waterDropPrefab.SetActive(true);
        }
        if (bossKilled == 1)
        {
            fireDropPrefab.SetActive(true);
        }

    }




}
