using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overall_Forest_Data : MonoBehaviour
{
    // overall environmental data
    private double humility = 90.0;            //unit: %
    private double temp = 15.0;                //unit: C
    private double co2_concentration = 340.0;  //unit: microL / L
    private double o2_concentration = 220.0;   //unit: miliL  / L
    private double soilPH = 6.6;

    // overall tree data
    private double avgHeight = 20.0;         // unit: m
    private double avgPrimemter = 95.0;      // unit: cm
    private double treeDensity = 2.5;       // unit: /100*m^2
    private double avgAge = 35;
    private double LAI = 0.7;     //leaf area index

    public double getHumility()
    {
        return humility;
    }

    public void setHumility(double data)
    {
        humility = data;
    }

    // -------------

    public double getTemp()
    {
        return temp;
    }

    public void setTemp(double data)
    {
        temp = data;
    }

    // ---------------

    public double getCO2()
    {
        return co2_concentration;
    }

    public void setCO2(double data)
    {
        co2_concentration = data;
    }

    // ----------------

    public double getO2()
    {
        return o2_concentration;
    }

    public void setO2(double data)
    {
        o2_concentration = data;
    }

    // -----------------

    public double getSoilPH()
    {
        return soilPH;
    }

    public void setSoilPH(double data)
    {
        soilPH = data;
    }

    // ----------------

    public double getAvgHeight()
    {
        return avgHeight;
    }

    public void setAvgHeight(double data)
    {
        avgHeight = data;
    }

    // ---------------

    public double getAvgPrimeter()
    {
        return avgPrimemter;
    }

    public void setAvgPrimeter(double data)
    {
        avgPrimemter = data;
    }

    // -----------------

    public double getTreeDensity()
    {
        return treeDensity;
    }

    public void setTreeDensity(double data)
    {
        treeDensity = data;
    }

    // -----------------

    public double getTreeAge()
    {
        return avgAge;
    }

    public void setTreeAge(double data)
    {
        avgAge = data;
    }

    // ---------------

    public double getLAI()
    {
        return LAI;
    }

    public void setLAI(double data)
    {
        LAI = data;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    


}
