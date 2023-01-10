using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
public class TreeParamDisplay : MonoBehaviour
{
    public DataModel DataModelObj;

    public Text TreeParamDisp;

    public Dropdown dropdown;

    private string s1, s2, s3, s4, s5;

    public int curIndex = 0;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update() {}

    public void extractTreeParam(int value)
    {
        curIndex = value;
        if(value == 0)
        {
            s1 = "  Density: " + DataModelObj.RedPineData.Density + "\n\n";
            s2 = "  DBH: " + DataModelObj.RedPineData.DBH + "\n\n";
            s3 = "  Average LAI: " + DataModelObj.RedPineData.AverageLAI + "\n\n";
            s4 = "  Height: " + DataModelObj.RedPineData.Height + "\n\n";
            s5 = "  Age: " + DataModelObj.RedPineData.Age;
        }

        if(value == 1)
        {
            s1 = "  Density: " + DataModelObj.OakData.Density + "\n\n";
            s2 = "  DBH: " + DataModelObj.OakData.DBH + "\n\n";
            s3 = "  Average LAI: " + DataModelObj.OakData.AverageLAI + "\n\n";
            s4 = "  Height: " + DataModelObj.OakData.Height + "\n\n";
            s5 = "  Age: " + DataModelObj.OakData.Age;
        }

        if (value == 2)
        {
            s1 = "  Density: " + DataModelObj.BeechData.Density + "\n\n";
            s2 = "  DBH: " + DataModelObj.BeechData.DBH + "\n\n";
            s3 = "  Average LAI: " + DataModelObj.BeechData.AverageLAI + "\n\n";
            s4 = "  Height: " + DataModelObj.BeechData.Height + "\n\n";
            s5 = "  Age: " + DataModelObj.BeechData.Age;
        }

        if (value == 3)
        {
            s1 = "  Density: " + DataModelObj.BirchData.Density + "\n\n";
            s2 = "  DBH: " + DataModelObj.BirchData.DBH + "\n\n";
            s3 = "  Average LAI: " + DataModelObj.BirchData.AverageLAI + "\n\n";
            s4 = "  Height: " + DataModelObj.BirchData.Height + "\n\n";
            s5 = "  Age: " + DataModelObj.BirchData.Age;
        }

        if (value == 4)
        {
            s1 = "  Density: " + DataModelObj.RedMapleData.Density + "\n\n";
            s2 = "  DBH: " + DataModelObj.RedMapleData.DBH + "\n\n";
            s3 = "  Average LAI: " + DataModelObj.RedMapleData.AverageLAI + "\n\n";
            s4 = "  Height: " + DataModelObj.RedMapleData.Height + "\n\n";
            s5 = "  Age: " + DataModelObj.RedMapleData.Age;
        }

        if (value == 5)
        {
            s1 = "  Density: " + DataModelObj.WhitePineData.Density + "\n\n";
            s2 = "  DBH: " + DataModelObj.WhitePineData.DBH + "\n\n";
            s3 = "  Average LAI: " + DataModelObj.WhitePineData.AverageLAI + "\n\n";
            s4 = "  Height: " + DataModelObj.WhitePineData.Height + "\n\n";
            s5 = "  Age: " + DataModelObj.WhitePineData.Age;
        }

        if (value == 6)
        {
            s1 = "  Density: " + DataModelObj.RedOakData.Density + "\n\n";
            s2 = "  DBH: " + DataModelObj.RedOakData.DBH + "\n\n";
            s3 = "  Average LAI: " + DataModelObj.RedOakData.AverageLAI + "\n\n";
            s4 = "  Height: " + DataModelObj.RedOakData.Height + "\n\n";
            s5 = "  Age: " + DataModelObj.RedOakData.Age;
        }

        TreeParamDisp.text = s1 + s2 + s3 + s4 + s5;
    }
}
