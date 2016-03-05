using UnityEngine;
using System.Collections;

public class UnidgetType : Element{

    public static UnidgetType Wheat = new UnidgetType("Wheat", Resource.Wheat, Property.SoilQuality);
    public static UnidgetType WindPower = new UnidgetType("WindPower", Resource.Power, Property.WindStrength);

    string name;

    Resource product;
    Property influence;

    public UnidgetType(string name, Resource product, Property influence)
    {
        this.name = name;
        this.product = product;
        this.influence = influence;
    }
}
