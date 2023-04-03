using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Author: Digital Twin Forest Team
 * Purpose: A button handler to switch between environmental data and pie chart
 */

public class pieChartButtonHandler : MonoBehaviour
{
    public Text EnvDataDisp;
    public GameObject graph;
    public Image legend;

    private bool isActive = false;

    public void ChangeView()
    {
        if (!isActive)
        {
            graph.gameObject.SetActive(true);
            legend.gameObject.SetActive(true);
            EnvDataDisp.gameObject.SetActive(false);
            isActive = !isActive;
        }
        else
        {
            graph.gameObject.SetActive(false);
            legend.gameObject.SetActive(false);
            EnvDataDisp.gameObject.SetActive(true);
            isActive = !isActive;
        }
    }
}