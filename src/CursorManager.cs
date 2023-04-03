using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: Digital Twin Forest Team
 * Purpose: Allow users to center the mouse when clicking 'C'
 */

public class CursorManager : MonoBehaviour
{
    public bool control;

    // Update is called once per frame
    void Update()
    {
        if (control)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            control = false;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            control = true;
            
        }   
    }
}
