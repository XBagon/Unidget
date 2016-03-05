using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;





public class Tile : MonoBehaviour
{
    public Vector2 position;
    public GameObject Unidget;

    GameManager gm;

    public List<Property> Properties = new List<Property>();
  

    public void SetTexture()
    {
        GetComponent<MeshRenderer>().material = Properties.OrderByDescending(x => x.Amount).First().mat;
    }


    // Use this for initialization
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        Properties.AddRange(Property.props);

        for (int i = 0; i < Properties.Count; i++)
        {
            Properties[i].Amount = gm.GetRandomProperyValue();
        }

        SetTexture();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (gm.PayResources("Money", 50))
        {
            Unidget = (GameObject)GameObject.Instantiate(gm.Unidget, gameObject.transform.position + new Vector3(0, 0.5f, 0), new Quaternion());
            Unidget.GetComponent<Unidget>().Tile = gameObject;
        }
    }
    
}
