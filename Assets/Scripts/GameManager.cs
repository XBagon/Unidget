using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Unidget;
    public AnimationCurve RandomCurve;
    public Text moneyIndicator;



    public List<Material> PropetyMaterials = new List<Material>();

    

    public void Start()
    {

    }

    public List<int> Resources = new List<int>();

    public float GetRandomProperyValue()
    {
        float y = RandomCurve.Evaluate(Random.value);
        return y * 100;
    }

    public int GetResource(string name)
    {
        switch (name)
        {
            case "Money": return 0;
            case "Power": return 1;
            case "Water": return 2;
        }
        return 0;
    }

    public void Update ()
    {
        moneyIndicator.text = Resources[0] + "";
    }


    public bool PayResources(string resource, int amount)
    {
        if (Resources[GetResource(resource)] >= amount)
        {
            Resources[GetResource(resource)] -= amount;
            return true;
        }

        return false;
    }
}
