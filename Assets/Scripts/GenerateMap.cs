using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateMap : MonoBehaviour {
    public GameObject MapTile;
    public int initSize;
	// Use this for initialization
	void Start () {
        for(int x = 0; x < initSize; x++)
        {
            for (int y = 0; y < initSize; y++)
            {
               GameObject g = (GameObject)GameObject.Instantiate(MapTile, new Vector3(x,0,y), MapTile.transform.rotation);
                g.transform.parent = gameObject.transform;
                g.GetComponent<Tile>().position = new Vector2(x, y);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
