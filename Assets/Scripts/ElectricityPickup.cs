using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricityPickup : MonoBehaviour
{
    public GameObject electricityUI;

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            //Time.timeScale = 1f;
            electricityUI.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
