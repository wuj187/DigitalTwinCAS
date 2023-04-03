using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

/*
 * Author: Digital Twin Forest Team
 * Purpose: Extract tree parameters and prepare string for displaying tree parameters
 */

public class TreeParamDisplay : MonoBehaviour
{
    public DataModel DataModelObj;

    public Text TreeParamDisp;

    public Dropdown dropdown;

    private string s1, s2, s3, s4;

    public int curIndex = 0;

    public void extractTreeParam(int value)
    {
        curIndex = value;
        if(value == 0)
        {
            s1 = "  Density: " + DataModelObj.RedPineData.Density + " trees/m^2\n\n";
            s2 = "  DBH: " + DataModelObj.RedPineData.DBH + " cm\n\n";
            s3 = "  Height: " + DataModelObj.RedPineData.Height + " m\n\n";
            s4 = "  Age: " + DataModelObj.RedPineData.Age + " years";
        }

        if(value == 1)
        {
            s1 = "  Density: " + DataModelObj.OakData.Density + " trees/m^2\n\n";
            s2 = "  DBH: " + DataModelObj.OakData.DBH + " cm\n\n";
            s3 = "  Height: " + DataModelObj.OakData.Height + " m\n\n";
            s4 = "  Age: " + DataModelObj.OakData.Age + " years";
        }

        if (value == 2)
        {
            s1 = "  Density: " + DataModelObj.BeechData.Density + " trees/m^2\n\n";
            s2 = "  DBH: " + DataModelObj.BeechData.DBH + " cm\n\n";
            s3 = "  Height: " + DataModelObj.BeechData.Height + " m\n\n";
            s4 = "  Age: " + DataModelObj.BeechData.Age + " years";
        }

        if (value == 3)
        {
            s1 = "  Density: " + DataModelObj.BirchData.Density + " trees/m^2\n\n";
            s2 = "  DBH: " + DataModelObj.BirchData.DBH + " cm\n\n";
            s3 = "  Height: " + DataModelObj.BirchData.Height + " m\n\n";
            s4 = "  Age: " + DataModelObj.BirchData.Age + " years";
        }

        if (value == 4)
        {
            s1 = "  Density: " + DataModelObj.RedMapleData.Density + " trees/m^2\n\n";
            s2 = "  DBH: " + DataModelObj.RedMapleData.DBH + " cm\n\n";
            s3 = "  Height: " + DataModelObj.RedMapleData.Height + " m\n\n";
            s4 = "  Age: " + DataModelObj.RedMapleData.Age + " years";
        }

        if (value == 5)
        {
            s1 = "  Density: " + DataModelObj.WhitePineData.Density + " trees/m^2\n\n";
            s2 = "  DBH: " + DataModelObj.WhitePineData.DBH + " cm\n\n";
            s3 = "  Height: " + DataModelObj.WhitePineData.Height + " m\n\n";
            s4 = "  Age: " + DataModelObj.WhitePineData.Age + " years";
        }

        if (value == 6)
        {
            s1 = "  Density: " + DataModelObj.RedOakData.Density + " trees/m^2\n\n";
            s2 = "  DBH: " + DataModelObj.RedOakData.DBH + " cm\n\n";
            s3 = "  Height: " + DataModelObj.RedOakData.Height + " m\n\n";
            s4 = "  Age: " + DataModelObj.RedOakData.Age + " years";
        }

        TreeParamDisp.text = s1 + s2 + s3 + s4;
    }
}
