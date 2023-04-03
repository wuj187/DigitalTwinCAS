using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: Digital Twin Forest Team
 * Purpose: JSON model for Newtonsoft parser
 */

public class JsonModel 
{
    public _redPine redPine;
    public _oak oak;
    public _beech beech { get; set; }
    public _birch birch { get; set; }
    public _whitePine whitePine { get; set; }
    public _redMaple redMaple { get; set; }
    public _redOak redOak { get; set; }
    public _envData envData  { get; set; }
}

public class _redPine
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _oak 
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _beech 
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _birch 
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _whitePine 
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _redMaple 
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _redOak 
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _envData 
{
    public string Humility { get; set; }
    public string Temp { get; set; }
    public string SCContent { get; set; }
    public string SNContent { get; set; }
    public string LAI { get; set; }
}
