using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
using System;



public class GameManager : MonoBehaviour
{
    public GameObject Unidget;
    public GameObject BlockInfo;
    public AnimationCurve RandomCurve;


    //0 SoilQuality;
    //1 WindStrength;
    //2 SunStrength;
    //3 WaterStrength;
    //4 Water;
    //5 Iron;
   // public List<Material> PropertyMaterials = new List<Material>();

    

    public void Start()
    {
        Resources.AddRange(Resource.res);
    }

    public List<Resource> Resources = new List<Resource>();

    public float GetRandomProperyValue()
    {
        float y = RandomCurve.Evaluate(UnityEngine.Random.Range(0f,1f));
        return y * 100;
    }

    public bool PayResources(string resource, int amount)
    {
        
        if (Resources.Where(s => s.Name == resource).First().Amount >= amount)
        {
            int a = Resources.Where(s => s.Name == resource).First().Amount-= amount;
            return true;
        }

        return false;
    }
}
