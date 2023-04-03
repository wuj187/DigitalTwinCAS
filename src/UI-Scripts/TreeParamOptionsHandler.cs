using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Author: Digital Twin Forest Team
 * Purpose: A button handler to show/hide tree parameters types
 */

public class TreeParamOptionsHandler : MonoBehaviour
{
    public ValueIndicator indicator;
    public Canvas updatecanvas;
    public FileReader FR;

    public void handleTreeParamOptions(string datatype)
    {
        indicator.TreeParamType = datatype;
        updatecanvas.gameObject.SetActive(true);
        FR.readTreeParam();
    }
}
