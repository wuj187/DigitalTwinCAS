using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: Digital Twin Forest Team
 * Purpose: How to change perspective by using the mouse
 */

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 150f;
    public Transform playerBody;

    public PauseManager PM;
    private float xRotation = 0f;

    // Update is called once per frame
    void Update()
    {
        // if the system is paused, perspective change will disconnect with the mouse
        if (PM.isPaused) { return; }

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // use the mouse the look up and look down
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        // use the mouse the look left and look right
        playerBody.Rotate(Vector3.up * mouseX);  
    }
}
