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


    private void Start()
    {
        isLightningDrop = false;
        isFireDrop = false;
        isWaterDrop = false;
    }

    private void Update()
    {
        if (isLightningDrop == true)
        {
            lightningDropPrefab.SetActive(true);
        }
        if (isWaterDrop == true)
        {
            waterDropPrefab.SetActive(true);
        }
        if (isFireDrop == true)
        {
            fireDropPrefab.SetActive(true);
        }

    }




}
