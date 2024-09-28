using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] Camera fpsCamera;
    [SerializeField] float ZoomOutFOV = 60f;
    [SerializeField] float ZoomInFOV = 26f;
    [SerializeField] float ZoomOutSencitivity = 2f;
    [SerializeField] float ZoomInSencitivity = 0.5f;
    bool zoomedInToggle = false;

    private void OnDisable()
    {
        ZoomOut();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                ZoomIn();
            }
            else if (zoomedInToggle == true)
            {
                ZoomOut();
            }
        }
    }

    private void ZoomOut()
    {
        zoomedInToggle = false;
        fpsCamera.fieldOfView = ZoomOutFOV;
        fpsController.mouseLook.XSensitivity = fpsController.mouseLook.YSensitivity = ZoomOutSencitivity;
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        fpsCamera.fieldOfView = ZoomInFOV;
        fpsController.mouseLook.XSensitivity = fpsController.mouseLook.YSensitivity = ZoomInSencitivity;
    }
}
