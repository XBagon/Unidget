using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

[Serializable]
public class Resource : Element {

    public static Resource Money = new Resource("Money");
    public static Resource Power = new Resource("Power");
    public static Resource Water = new Resource("Water");
    public static Resource Wheat = new Resource("Wheat");
    public static Resource Seeds = new Resource("Seeds");

    public static List<Resource> res = new List<Resource> {
    Money, Power, Water, Wheat, Seeds
    };

    public string Name;
    public int Amount;
    public Sprite sprite;


    public Resource(string name)
    {
        this.Name = name;
    }
	
}
