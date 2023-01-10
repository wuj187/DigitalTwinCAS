using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnvDataDisplay : MonoBehaviour
{

    public DataModel DataModelObj;

    public Text EnvDisp;

    private string s1, s2, s3, s4, s5;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    public void exactEnvData()
    {
        s1 = "  Humility: " + DataModelObj.EnvData.Humility + " %\n\n";
        s2 = "  Temperature: " + DataModelObj.EnvData.Temp + " C\n\n";
        s3 = "  CO2 Concentration: " + DataModelObj.EnvData.CO2CONCEN + " uL/L\n\n";
        s4 = "  O2 Concentration: " + DataModelObj.EnvData.O2CONCEN + " mL/L\n\n";
        s5 = "  Soil PH: " + DataModelObj.EnvData.SoilPH;

        EnvDisp.text = s1 + s2 + s3 + s4 + s5;
    }
}
