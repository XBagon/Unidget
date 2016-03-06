using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TileUI : MonoBehaviour {

    public GameObject PropertyPrefab;

    Transform Panel;

    public List<Text> proptexts = new List<Text>();
    public List<Image> propimages = new List<Image>();

    // Use this for initialization
    void Start () {

        Panel = transform.GetChild(0);

        for (int i = 0; i < Property.props.Count; i++)
        {
            GameObject g = (GameObject)Instantiate(PropertyPrefab, Vector3.zero, new Quaternion());
            g.transform.SetParent(Panel, false);
            proptexts.Add(g.transform.GetChild(1).GetComponent<Text>());
            propimages.Add(g.transform.GetChild(0).GetComponent<Image>());
        }
	
	}

    public void UpdateUIText(List<Property> props)
    {
        for(int i = 0; i < proptexts.Count; i++)
        {
            proptexts[i].text =  props[i].Amount+ " %";
            propimages[i].material = props[i].mat;
        }
    }

    void Update()
    {
        
    }
	

}
