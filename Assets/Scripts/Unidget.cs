using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class Element 
{

}


public class Unidget : MonoBehaviour {
    public Material mat;
    public GameObject Tile;
    public Tile stats;
    GameManager gm;
    bool Store = false;

    public List<Element> elements = new List<Element>();

    public void addElement(Element e)
    {
        elements.Add(e);
        Kombinieren(Resource.Seeds, Resource.Water, UnidgetType.Wheat);
        Kombinieren(Resource.Power, Property.WindStrength, UnidgetType.WindPower);
    }


   public void Kombinieren(Element e, Element e2, UnidgetType result)
    {
        if (elements.Contains(e) && elements.Contains(e2))
        {
            elements.Remove(e);
            elements.Remove(e2);
            elements.Add(result);
        }
    }

	// Use this for initialization
	void Start () {
        foreach (MeshRenderer m in transform.GetComponentsInChildren<MeshRenderer>()) {

            m.material = mat;
        }

        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        stats = Tile.GetComponent<Tile>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
