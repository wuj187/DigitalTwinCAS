using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using Newtonsoft.Json;

/*
 * Author: Digital Twin Forest Team
 * Purpose: Write JSON files
 */

public class FileWriter : MonoBehaviour
{

    public ValueIndicator indicator;
    public TMP_InputField inputField;
    public Text notify;
    public FileReader FR;

    public void Awake()
    {
        removeMsg();
    }

    public void updateHandler()
    {
        string inputText = inputField.text;

        if (inputText == "")
        {
            notify.text = "Please Enter a Number";
            Invoke("removeMsg", 2);
            return;
        }
        else if(!isValid(inputText))
        {
            notify.text = "Input is not a vaild number";
            Invoke("removeMsg", 2);
            inputField.text = "";
            return;
        }
        else
        {
            writeFile(inputText);
            notify.text = "Updated";
            Invoke("removeMsg", 2);
            inputField.text = "";
            if (indicator.isEnvData)
            {
                FR.readEnvData();
            }
            else
            {
                FR.readTreeParam();
            }
        }
    }


    private void writeFile(string newValue)
    {
        //find the file path
        int plotNumber = indicator.plotNumber;
        string filePath;
        if (plotNumber == 15)
        {
            filePath = "./dataCenter/overalldata.json";
        }
        else
        {
            filePath = "./dataCenter/plot" + plotNumber.ToString() + "data.json";
        }

        // read first
        string plotJsonData = File.ReadAllText(filePath);
        JsonModel JsonModelObj = JsonConvert.DeserializeObject<JsonModel>(plotJsonData);

        if (indicator.isEnvData)
        {
            if (indicator.EnvDataType.Equals("Humility")) {JsonModelObj.envData.Humility = newValue;}
            if (indicator.EnvDataType.Equals("Temp")) {JsonModelObj.envData.Temp = newValue;}
            if (indicator.EnvDataType.Equals("SCContent")) {JsonModelObj.envData.SCContent = newValue;}
            if (indicator.EnvDataType.Equals("SNContent")) {JsonModelObj.envData.SNContent = newValue;}
            if (indicator.EnvDataType.Equals("LAI")) {JsonModelObj.envData.LAI = newValue;}
        }
        else
        {
            if (indicator.TreeType.Equals("RedPine"))
            {
                if (indicator.TreeParamType.Equals("Density")) { JsonModelObj.redPine.Density = newValue; }
                if (indicator.TreeParamType.Equals("DBH")) { JsonModelObj.redPine.DBH = newValue; }
                if (indicator.TreeParamType.Equals("Height")) { JsonModelObj.redPine.Height = newValue; }
                if (indicator.TreeParamType.Equals("Age")) { JsonModelObj.redPine.Age = newValue; }
            }
            if (indicator.TreeType.Equals("Oak"))
            {
                if (indicator.TreeParamType.Equals("Density")) { JsonModelObj.oak.Density = newValue; }
                if (indicator.TreeParamType.Equals("DBH")) { JsonModelObj.oak.DBH = newValue; }
                if (indicator.TreeParamType.Equals("Height")) { JsonModelObj.oak.Height = newValue; }
                if (indicator.TreeParamType.Equals("Age")) { JsonModelObj.oak.Age = newValue; }
            }
            if (indicator.TreeType.Equals("Beech"))
            {
                if (indicator.TreeParamType.Equals("Density")) { JsonModelObj.beech.Density = newValue; }
                if (indicator.TreeParamType.Equals("DBH")) { JsonModelObj.beech.DBH = newValue; }
                if (indicator.TreeParamType.Equals("Height")) { JsonModelObj.beech.Height = newValue; }
                if (indicator.TreeParamType.Equals("Age")) { JsonModelObj.beech.Age = newValue; }
            }
            if (indicator.TreeType.Equals("Birch"))
            {
                if (indicator.TreeParamType.Equals("Density")) { JsonModelObj.birch.Density = newValue; }
                if (indicator.TreeParamType.Equals("DBH")) { JsonModelObj.birch.DBH = newValue; }
                if (indicator.TreeParamType.Equals("Height")) { JsonModelObj.birch.Height = newValue; }
                if (indicator.TreeParamType.Equals("Age")) { JsonModelObj.birch.Age = newValue; }
            }
            if (indicator.TreeType.Equals("RedMaple"))
            {
                if (indicator.TreeParamType.Equals("Density")) { JsonModelObj.redMaple.Density = newValue; }
                if (indicator.TreeParamType.Equals("DBH")) { JsonModelObj.redMaple.DBH = newValue; }
                if (indicator.TreeParamType.Equals("Height")) { JsonModelObj.redMaple.Height = newValue; }
                if (indicator.TreeParamType.Equals("Age")) { JsonModelObj.redMaple.Age = newValue; }
            }
            if (indicator.TreeType.Equals("WhitePine"))
            {
                if (indicator.TreeParamType.Equals("Density")) { JsonModelObj.whitePine.Density = newValue; }
                if (indicator.TreeParamType.Equals("DBH")) { JsonModelObj.whitePine.DBH = newValue; }
                if (indicator.TreeParamType.Equals("Height")) { JsonModelObj.whitePine.Height = newValue; }
                if (indicator.TreeParamType.Equals("Age")) { JsonModelObj.whitePine.Age = newValue; }
            }
            if (indicator.TreeType.Equals("RedOak"))
            {
                if (indicator.TreeParamType.Equals("Density")) { JsonModelObj.redOak.Density = newValue; }
                if (indicator.TreeParamType.Equals("DBH")) { JsonModelObj.redOak.DBH = newValue; }
                if (indicator.TreeParamType.Equals("Height")) { JsonModelObj.redOak.Height = newValue; }
                if (indicator.TreeParamType.Equals("Age")) { JsonModelObj.redOak.Age = newValue; }
            }
        }



        // Serilize and write
        string output = Newtonsoft.Json.JsonConvert.SerializeObject(JsonModelObj);
        File.WriteAllText(filePath, output);
    }


    private void removeMsg()
    {
        notify.text = "";
    }


    private bool isValid(string s)
    {
        char[] pool = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', '-' };

        int i;
        for (i = 0; i < s.Length; i++)
        {
            if (! isIN(s[i], pool))
            {
                return false;
            }
        }
        return true;
    }


    private bool isIN(char target, char[] pool)
    {
        int i;
        for(i = 0; i < pool.Length; i++)
        {
            if (target == pool[i])
            {
                return true;
            }
        }
        return false;
    }
}