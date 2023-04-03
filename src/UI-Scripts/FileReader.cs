using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

/*
 * Author: Digital Twin Forest Team
 * Purpose: Read JSON files for displaying current value
 */

public class FileReader : MonoBehaviour
{
    public ValueIndicator indicator;
    private JsonModel JsonModelObj;
    public Text currentValueDisp;

    public void readEnvData()
    {
        int plotNumber = indicator.plotNumber;

        string filePath;

        // no file to read
        if(plotNumber == 0)
        {
            currentValueDisp.text = "Please select a plot";
            return;
        }

        if (plotNumber == 15)
        {
            filePath = "./dataCenter/overalldata.json";
        }
        else
        {
            filePath = "./dataCenter/plot" + plotNumber.ToString() + "data.json";
        }

        string plotJsonData = File.ReadAllText(filePath);

        JsonModelObj = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonModel>(plotJsonData);

        if (indicator.EnvDataType.Equals("Humility"))
        {
            currentValueDisp.text =  "Current Humidity: " + JsonModelObj.envData.Humility + " %";
        }
        else if (indicator.EnvDataType.Equals("Temp"))
        {
            currentValueDisp.text = "Current Temperature: " + JsonModelObj.envData.Temp + " °C";
        }
        else if (indicator.EnvDataType.Equals("SCContent"))
        {
            currentValueDisp.text = "Current Soil C Contents: " + JsonModelObj.envData.SCContent + " % Dry";
        }
        else if (indicator.EnvDataType.Equals("SNContent"))
        {
            currentValueDisp.text = "Current Soil N Contents: " + JsonModelObj.envData.SNContent + " % Dry";
        }
        else
        {
            currentValueDisp.text = "Current LAI: " + JsonModelObj.envData.LAI;
        }
    }


    public void readTreeParam()
    {
        int plotNumber = indicator.plotNumber;

        string filePath;

        // no file to read
        if(plotNumber == 0)
        {
            currentValueDisp.text = "Please select a plot";
            return;
        }

        if (plotNumber == 15)
        {
            filePath = "./dataCenter/overalldata.json";
        }
        else
        {
            filePath = "./dataCenter/plot" + plotNumber.ToString() + "data.json";
        }

        string plotJsonData = File.ReadAllText(filePath);

        JsonModelObj = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonModel>(plotJsonData);

        if (indicator.TreeType.Equals("RedPine"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                currentValueDisp.text = "Current Density: " + JsonModelObj.redPine.Density + " trees/m^2";
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " + JsonModelObj.redPine.DBH + " cm";
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.redPine.Height + " m";
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.redPine.Age + " years";
            }
            return;
        }

        if (indicator.TreeType.Equals("Oak"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                currentValueDisp.text = "Current Density: " + JsonModelObj.oak.Density + " trees/m^2";
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " +  JsonModelObj.oak.DBH + " cm";
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.oak.Height + " m";
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.oak.Age + " years";
            }
            return;
        }

        if (indicator.TreeType.Equals("Beech"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                currentValueDisp.text = "Current Density: " + JsonModelObj.beech.Density + " trees/m^2";
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " + JsonModelObj.beech.DBH + " cm";
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.beech.Height + " m";
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.beech.Age + " years";
            }
            return;
        }

        if (indicator.TreeType.Equals("Birch"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                currentValueDisp.text = "Current Density: " + JsonModelObj.birch.Density + " trees/m^2";
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " + JsonModelObj.birch.DBH + " cm";
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.birch.Height + " m";
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.birch.Age + " years";
            }
            return;
        }

        if (indicator.TreeType.Equals("RedMaple"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                currentValueDisp.text = "Current Density: " + JsonModelObj.redMaple.Density + " trees/m^2";
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " + JsonModelObj.redMaple.DBH + " cm";
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.redMaple.Height + " m";
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.redMaple.Age + " years";
            }
            return;
        }

        if (indicator.TreeType.Equals("WhitePine"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                currentValueDisp.text = "Current Density: " + JsonModelObj.whitePine.Density + " trees/m^2";
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " + JsonModelObj.whitePine.DBH + " cm";
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.whitePine.Height + " m";
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.whitePine.Age + " years";
            }
            return;
        }

        if (indicator.TreeType.Equals("RedOak"))
        {
            if (indicator.TreeParamType.Equals("Density"))
            {
                currentValueDisp.text = "Current Density: " + JsonModelObj.redOak.Density + " trees/m^2";
            }
            if (indicator.TreeParamType.Equals("DBH"))
            {
                currentValueDisp.text = "Current DBH: " + JsonModelObj.redOak.DBH + " cm";
            }
            if (indicator.TreeParamType.Equals("Height"))
            {
                currentValueDisp.text = "Current Height: " + JsonModelObj.redOak.Height + " m";
            }
            if (indicator.TreeParamType.Equals("Age"))
            {
                currentValueDisp.text = "Current Age: " + JsonModelObj.redOak.Age + " years";
            }
            return;
        }
    }

    public void clearText()
    {
        currentValueDisp.text = "";
    }
}