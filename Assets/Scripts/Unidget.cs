using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum Elements
{
    Sun, Water, Power, Seeds, Wheat
}

public class Unidget : MonoBehaviour {

    bool Store = false;

    List<Elements> elements = new List<Elements>();

    void addElement(Elements e)
    {
        elements.Add(e);
        Kombineren(Elements.Seeds, Elements.Water, Elements.Wheat);
    }

   public void Kombineren(Elements e, Elements e2, Elements result)
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
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
