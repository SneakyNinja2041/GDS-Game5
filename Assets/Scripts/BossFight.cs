using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFight : MonoBehaviour
{
    [SerializeField] GameObject cameraGO;
    CameraController cam;

    

     void Start()
    {
        cam = cameraGO.GetComponent<CameraController>();
    }

    void Update()
    {
        

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cam.isBossFight = true;
            
        }


    }
}
