using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Overall_Forest_Data_Display : MonoBehaviour
{
    public Overall_Forest_Data OFData;

    //Environmental data display
    public Text HumilityDisplay;
    public Text TempDisplay;
    public Text CO2Display;
    public Text O2Display;
    public Text SoildPHDisplay;

    // tree data display
    public Text AvgHeightDisplay;
    public Text AvgPrimemterDisplay;
    public Text TreeDensityDisplay;
    public Text AvgAgeDisplay;
    public Text LAIPHDisplay;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HumilityDisplay.text = "Humility: " + OFData.getHumility().ToString() + " %";
        TempDisplay.text = "Temperature: " + OFData.getTemp().ToString() + " C";
        CO2Display.text = "CO2 Concentration: " + OFData.getCO2().ToString() + " uL/L";
        O2Display.text = "O2 Concentration: " + OFData.getO2().ToString() + " mL/L";
        SoildPHDisplay.text = "Soil PH: " + OFData.getSoilPH().ToString();
        AvgHeightDisplay.text = "Avg Tree Height: " + OFData.getAvgHeight().ToString() + " m";
        AvgPrimemterDisplay.text = "Avg Tree Perimeter: " + OFData.getAvgPrimeter().ToString() + " cm";
        TreeDensityDisplay.text = "Tree Density: " + OFData.getTreeDensity().ToString() + " /100*m*m";
        AvgAgeDisplay.text = "Avg Tree Age: " + OFData.getTreeAge().ToString() + " years";
        LAIPHDisplay.text = "LAI: " + OFData.getLAI().ToString();
    }
}
