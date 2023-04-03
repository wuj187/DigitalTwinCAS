using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Author: Digital Twin Forest Team
 * Purpose: A button handler to show/hide environmental data
 */

public class EnvDataDispButtonHandler : MonoBehaviour
{
    private bool isActive = false;
    public Image EnvDisp;           // act like the panel to display the environment data

    public void EnvDataDispHandle()
    {
        if (!isActive)
        {
            EnvDisp.gameObject.SetActive(true);
            isActive = !isActive;
        }
        else
        {
            EnvDisp.gameObject.SetActive(false);
            isActive = !isActive;
        }
    }
}
