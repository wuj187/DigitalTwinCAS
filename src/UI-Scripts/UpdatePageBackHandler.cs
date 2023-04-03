using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Author: Digital Twin Forest Team
 * Purpose: A button handler for back button in the update data page
 */

public class UpdatePageBackHandler : MonoBehaviour
{
    public Dropdown plotSelection;
    public Dropdown treeSelection;

    public void backButtonHandler()
    {
        plotSelection.value = 0;
        treeSelection.value = 0;
    }
}
