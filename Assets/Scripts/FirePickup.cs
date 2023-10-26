using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePickup : MonoBehaviour
{
    public GameObject fireUI;

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            //Time.timeScale = 1f;
            fireUI.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
