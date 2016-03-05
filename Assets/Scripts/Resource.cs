using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;


public class Resource : Element {

    public static Resource Money = new Resource("Money");
    public static Resource Power = new Resource("Power");
    public static Resource Water = new Resource("Water");
    public static Resource Wheat = new Resource("Wheat");
    public static Resource Seeds = new Resource("Seeds");

    public static List<Resource> res = new List<Resource> {
    Money, Power, Water, Wheat, Seeds
    };

    public string name;
    public int Amount;


    public Resource(string name)
    {
        this.name = name;
    }
	
}
