using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;





public class Tile : MonoBehaviour
{
    public Vector2 position;
    public GameObject Unidget;
    public GameObject TileUI;

    bool full;

    public float waitTime;
    public float waitTimer;

    GameManager gm;

    public List<AmountObject> Properties = new List<AmountObject>();



    public void SetTexture()
    {
        Property prp = (Property)Properties.OrderByDescending(x => x.Amount).First().obj;
        GetComponent<MeshRenderer>().material = prp.mat;
    }


    // Use this for initialization
    void Start()
    {
        TileUI = GameObject.Find("TileUI");
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        for (int i = 0; i < Property.props.Count; i++)
        {
            Properties.Add(new AmountObject(Property.props[i], gm.GetRandomProperyValue()));
        }
        //Properties.AddRange(new List<Property>(Property.props));



        SetTexture();
    }


    // Update is called once per frame
    void Update()
    {

    }







    
    void OnMouseEnter()
    {
        waitTimer = waitTime;
    }

    void OnMouseOver() {
        waitTimer -= Time.deltaTime;

        if (waitTimer <= 0)
        {
            TileUI.GetComponent<TileUI>().UpdateUIText(Properties);
            TileUI.SetActive(true);
            TileUI.transform.GetChild(0).position = gameObject.transform.position + new Vector3(0,1,0);
            TileUI.transform.rotation = Camera.main.transform.rotation;
        }
    }

    void OnMouseExit()
    {
        if (waitTimer <= 0)
        {
            TileUI.SetActive(false);
        }
    }








    void OnMouseDown()
    {
        if (!full)
        {
            if(gm.PayResources("Money", 50))
            {
                Unidget = (GameObject)GameObject.Instantiate(gm.Unidget, gameObject.transform.position + new Vector3(0, 0.5f, 0), new Quaternion());
                Unidget.GetComponent<Unidget>().Tile = gameObject;
                full = true;
            }
        }
    }
    
}
