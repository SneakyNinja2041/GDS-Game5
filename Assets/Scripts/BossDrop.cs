using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDrop : MonoBehaviour
{
    public GameObject lightningDropPrefab;
    public GameObject fireDropPrefab;
    public GameObject waterDropPrefab;

    public bool isLightningDrop;
    public bool isFireDrop;
    public bool isWaterDrop;

    public int bossesKilled;

    private void Start()
    {
        isLightningDrop = false;
        isFireDrop = false;
        isWaterDrop = false;

        bossesKilled = 0;
    }

    private void Update()
    {
        if (bossesKilled == 1)
        {
            // whatever the first drop is spawns
        }
        if (bossesKilled == 2)
        {
            // whateber the second drop is
        }
        if (bossesKilled == 3)
        {
            // whatever the third boss fight drops
        }

    }




}
