using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JsonModel : MonoBehaviour
{
    public _redPine redPine { get; set; }
    public _oak oak { get; set; }
    public _beech beech { get; set; }
    public _birch birch { get; set; }
    public _whitePine whitePine { get; set; }
    public _redMaple redMaple { get; set; }
    public _redOak redOak { get; set; }
    public _envData envData { get; set; }
}

public class _redPine : MonoBehaviour
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string AverageLAI { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _oak : MonoBehaviour
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string AverageLAI { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _beech : MonoBehaviour
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string AverageLAI { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _birch : MonoBehaviour
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string AverageLAI { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _whitePine : MonoBehaviour
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string AverageLAI { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _redMaple : MonoBehaviour
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string AverageLAI { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _redOak : MonoBehaviour
{
    public string treeName { get; set; }
    public string Density { get; set; }
    public string DBH { get; set; }
    public string AverageLAI { get; set; }
    public string Height { get; set; }
    public string Age { get; set; }
}

public class _envData : MonoBehaviour
{
    public string Humility { get; set; }
    public string Temp { get; set; }
    public string CO2CONCEN { get; set; }
    public string O2CONCEN { get; set; }
    public string SoilPH { get; set; }
}
