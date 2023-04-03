using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Author: Digital Twin Forest Team
 * Purpose: A dropdown menu handler for plot selection
 */

public class PlotSelectionHandler : MonoBehaviour
{
    public Dropdown plotSelect;
    public ValueIndicator indicator;
    public FileReader FR;

    public void PlotDropDownHandler()
    {
        indicator.plotNumber = plotSelect.value;
        if (indicator.isEnvData)
        {
            FR.readEnvData();
        }
        if (indicator.isTreeParam)
        {
            FR.readTreeParam();
        }
    }
}
