using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Plot14DataDisplay : MonoBehaviour
{
    public Plot14Data dataObj;

    public Text EnvDataDisplay;
    public Text OverallTreeParaDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnvDataDisplay.text = "Humility: " + dataObj.getHumility().ToString() + " %\n\n" +
                              "Temperature: " + dataObj.getTemp().ToString() + " C\n\n" +
                              "CO2 Concentration: " + dataObj.getCO2().ToString() + " uL/L\n\n" +
                              "O2 Concentration: " + dataObj.getO2().ToString() + " mL/L\n\n" +
                              "Soil PH: " + dataObj.getSoilPH().ToString();

        OverallTreeParaDisplay.text = "Avg Tree Height: " + dataObj.getAvgHeight().ToString() + " m\n\n" +
                                      "Avg Tree Perimeter: " + dataObj.getAvgPrimeter().ToString() + " cm\n\n" +
                                      "Tree Density: " + dataObj.getTreeDensity().ToString() + " /100*m*m\n\n" +
                                      "Avg Tree Age: " + dataObj.getTreeAge().ToString() + " years\n\n" +
                                      "LAI: " + dataObj.getLAI().ToString();
    }
}

