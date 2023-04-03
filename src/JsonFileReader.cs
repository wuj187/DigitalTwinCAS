using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

/*
 * Author: Digital Twin Forest Team
 * Purpose: Reading Json File
 */

public class JsonFileReader : MonoBehaviour
{

    public TreeParamDisplay treeParamDisplay;
    public EnvDataDisplay envDataDisplay;
    public pieChartMaker graphMaker;
    public treePlanting treePlanter;
    public DataModel DataModelObj;
    private JsonModel JsonModelObj;   // used to parse the json file

    private void Awake()
    {
        readfile(0);
    }

    public void Start() {}

    public void readfile(int value)
    {
        int plotNumber = value + 1;

        string filePath;

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

        // set data model object
        DataModelObj.RedPineData = JsonModelObj.redPine;
        DataModelObj.OakData = JsonModelObj.oak;
        DataModelObj.BeechData = JsonModelObj.beech;
        DataModelObj.BirchData = JsonModelObj.birch;
        DataModelObj.RedMapleData = JsonModelObj.redMaple;
        DataModelObj.WhitePineData = JsonModelObj.whitePine;
        DataModelObj.RedOakData = JsonModelObj.redOak;
        DataModelObj.EnvData = JsonModelObj.envData;

        // update tree parameter display
        treeParamDisplay.extractTreeParam(treeParamDisplay.curIndex);

        //update env data display
        envDataDisplay.exactEnvData();

        //draw pie chart
        graphMaker.markChart();

        // plant trees
        treePlanter.plantTrees(value);
    }
}
