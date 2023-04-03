using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Author: Digital Twin Forest Team
 * Purpose: A button handler for update data button
 */

public class UpdateButtonHandler : MonoBehaviour
{
    public Canvas EnvDataOptions;
    public Canvas TreeParamOptions;
    public Dropdown treeSelection;
    public ValueIndicator indicator;
    public FileReader FR;

    public void UpdateEnvDataButtonHandle()
    {
        treeSelection.value = 0;
        TreeParamOptions.gameObject.SetActive(false);
        EnvDataOptions.gameObject.SetActive(true);

        // IF EnvDataButton Just selected, clear the original text
        if (!indicator.isEnvData)
        {
            FR.clearText();
        }
        indicator.isEnvData = true;
        indicator.isTreeParam = false;
    }

    public void UpdateTreeParamHande()
    {
        if (!indicator.isTreeParam)
        {
            FR.clearText();
            EnvDataOptions.gameObject.SetActive(false);
            TreeParamOptions.gameObject.SetActive(true);
            if (treeSelection.value == 0)
            {
                TreeParamOptions.gameObject.SetActive(false);
            }
            indicator.isTreeParam = true;
            indicator.isEnvData = false;
            if (treeSelection.value == 1)
            {
                indicator.TreeType = "RedPine";
            }
            else if (treeSelection.value == 2)
            {
                indicator.TreeType = "Oak";
            }
            else if (treeSelection.value == 3)
            {
                indicator.TreeType = "Beech";
            }
            else if (treeSelection.value == 4)
            {
                indicator.TreeType = "Birch";
            }
            else if (treeSelection.value == 5)
            {
                indicator.TreeType = "RedMaple";
            }
            else if (treeSelection.value == 6)
            {
                indicator.TreeType = "WhitePine";
            }
            else if (treeSelection.value == 7)
            {
                indicator.TreeType = "RedOak";
            }
            return;
        }

        EnvDataOptions.gameObject.SetActive(false);
        TreeParamOptions.gameObject.SetActive(true);
        if(treeSelection.value == 0)
        {
            TreeParamOptions.gameObject.SetActive(false);
        }
        indicator.isTreeParam = true;
        indicator.isEnvData = false;

        if(treeSelection.value == 1)
        {
            indicator.TreeType = "RedPine";
        }
        else if (treeSelection.value == 2)
        {
            indicator.TreeType = "Oak";
        }
        else if (treeSelection.value == 3)
        {
            indicator.TreeType = "Beech";
        }
        else if(treeSelection.value == 4)
        {
            indicator.TreeType = "Birch";
        }
        else if (treeSelection.value == 5)
        {
            indicator.TreeType = "RedMaple";
        }
        else if (treeSelection.value == 6)
        {
            indicator.TreeType = "WhitePine";
        }
        else if (treeSelection.value == 7)
        {
            indicator.TreeType = "RedOak";
        }
        FR.readTreeParam();
    }
}
