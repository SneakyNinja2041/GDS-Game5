using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public CharacterController controller;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (x != 0 || z != 0)
        {
            // Calculate the rotation angle based on input
            float targetRotationAngle = Mathf.Atan2(x, z) * Mathf.Rad2Deg;
            targetRotationAngle += Camera.main.transform.eulerAngles.y; // Adjust for camera rotation

            // Preserve the original X and Z rotations
            Vector3 currentRotation = transform.eulerAngles;
            transform.rotation = Quaternion.Euler(currentRotation.x, targetRotationAngle, currentRotation.z);
        }
    }
}
