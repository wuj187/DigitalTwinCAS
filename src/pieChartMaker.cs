using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;
using UnityEngine.UI;

/*
 * Author: Digital Twin Forest Team
 * Purpose: Make the pie chart to show the ratio of different tree types
 */

public class pieChartMaker : MonoBehaviour
{
    public DataModel data;
    public Image redPinePortion;
    public Image oakPortion;
    public Image beechPortion;
    public Image birchPortion;
    public Image redMaplePortion;
    public Image whitePinePortion;
    public Image redOakPortion;

    public GameObject parentObject;

    private double[] values;
    private double sum;
    private double[] percentage;

    public void markChart()
    {
        calculateValues();
        setImagePortions();   
    }

    private void setImagePortions()
    {
        float totalRot = 0;
        

        Vector3 pos = new Vector3(150f, 200f, 0f);
        Vector2 size = new Vector2(600f, 600f);

        redPinePortion.transform.localPosition = pos; redPinePortion.rectTransform.sizeDelta = size;
        redPinePortion.fillAmount = (float)percentage[0];
        redPinePortion.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, totalRot));
        totalRot -= (float)percentage[0] * 360;

        oakPortion.transform.localPosition = pos; oakPortion.rectTransform.sizeDelta = size;
        oakPortion.fillAmount = (float)percentage[1];
        oakPortion.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, totalRot));
        totalRot -= (float)percentage[1] * 360;

        beechPortion.transform.localPosition = pos; beechPortion.rectTransform.sizeDelta = size;
        beechPortion.fillAmount = (float)percentage[2];
        beechPortion.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, totalRot));
        totalRot -= (float)percentage[2] * 360;

        birchPortion.transform.localPosition = pos; birchPortion.rectTransform.sizeDelta = size;
        birchPortion.fillAmount = (float)percentage[3];
        birchPortion.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, totalRot));
        totalRot -= (float)percentage[3] * 360;

        redMaplePortion.transform.localPosition = pos; redMaplePortion.rectTransform.sizeDelta = size;
        redMaplePortion.fillAmount = (float)percentage[4];
        redMaplePortion.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, totalRot));
        totalRot -= (float)percentage[4] * 360;

        whitePinePortion.transform.localPosition = pos; whitePinePortion.rectTransform.sizeDelta = size;
        whitePinePortion.fillAmount = (float)percentage[5];
        whitePinePortion.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, totalRot));
        totalRot -= (float)percentage[5] * 360;

        redOakPortion.transform.localPosition = pos; redOakPortion.rectTransform.sizeDelta = size;
        redOakPortion.fillAmount = (float)percentage[6];
        redOakPortion.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, totalRot));
    }

    private void calculateValues()
    {
        values = new[] {Convert.ToDouble(data.RedPineData.Density),
                        Convert.ToDouble(data.OakData.Density),
                        Convert.ToDouble(data.BeechData.Density),
                        Convert.ToDouble(data.BirchData.Density),
                        Convert.ToDouble(data.RedMapleData.Density),
                        Convert.ToDouble(data.WhitePineData.Density),
                        Convert.ToDouble(data.RedOakData.Density)};
        sum = values.Sum();

        percentage = new[] {values[0] / sum, values[1] / sum, values[2] / sum,
                            values[3] / sum, values[4] / sum, values[5] / sum,
                            values[6] / sum};
    }
}
