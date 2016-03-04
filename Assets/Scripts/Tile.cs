using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class Tile : MonoBehaviour
{
    public Vector2 position;
    GameManager gm;

    public float[] Properties;
    public int PropertyCount;
    //0 SoilQuality;
    //1 WindStrength;
    //2 SunStrength;
    //3 WaterStrength;
    //4 Water;
    //5 Iron;

    public void SetTexture()
    {
        Debug.Log(Array.IndexOf(Properties, Properties.Max()));
    }



    // Use this for initialization
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        PropertyCount = 6;

        Properties = new float[PropertyCount];
        
        

        for(int i = 0; i < PropertyCount; i++)
        {
            Properties[i] = gm.GetRandomProperyValue();
        }
        


        SetTexture();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (gm.PayResources("Money", 50)) GameObject.Instantiate(gm.Unidget, gameObject.transform.position + new Vector3(0, 0.5f, 0), new Quaternion());
    }
    
}
