using System;
using System.Collections.Generic;
using UnityEngine;


public class Property : Element
{
    public static Property SoilQuality = new Property("Soil Quality", 0);
    public static Property WindStrength = new Property("Wind Strength", 1);
    public static Property SunStrength = new Property("Sun Strength", 2);
    public static Property WaterStrength = new Property("Water Strength", 3);
    public static Property Water = new Property("Water", 4);
    public static Property Iron = new Property("Iron", 5);

    [NonSerialized]
    public Material mat;
    public string name;
    public float Amount;

    public Property(string name, int index)
    {
        this.name = name;
        // mat = GameObject.Find("GameManager").GetComponent<GameManager>().PropertyMaterials[index];
        string path = "Materials/" + name.Replace(" ", "") + "Tile";
        mat = Resources.Load<Material>(path);
        Debug.Log(path);
    }


}