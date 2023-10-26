using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPickup : MonoBehaviour
{
    public GameObject waterUI;

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            //Time.timeScale = 1f;
            waterUI.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
