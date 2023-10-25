using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool isBossFight;
    [SerializeField] GameObject bossUI;

    // camera to follow the player around the rooms

    // lock the camera when walking into a room? maybe if that works

    // lock the camera when fighting bosses

    private void Start()
    {
        isBossFight = false;

    }

    private void Update()
    {
        if (isBossFight == true)
        {
            bossUI.SetActive(true);
        }
        else
        {
            bossUI.SetActive(false);
        }

    }

}
