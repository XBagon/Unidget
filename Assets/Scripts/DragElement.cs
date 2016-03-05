using UnityEngine;
using System.Collections;
using System.Linq;

public class DragElement : MonoBehaviour {
    public char rorp;
    public string Name;
    Element e;

    void Start()
    {
        if (rorp == 'R')
        {
            e=Resource.res.Where(x => x.Name == Name).First();
        }

        if (rorp == 'P')
        {
            e=Property.props.Where(x => x.Name == Name).First();
        }
    }

    void OnMouseDrag()
    {
        Debug.Log("Drag");
    }

    void OnMouseUp()
    {
        Debug.Log("UP");
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.transform.gameObject.name);
            if (hit.transform.gameObject.GetComponent<Unidget>())
            {
                hit.transform.gameObject.GetComponent<Unidget>().addElement(e);
            }
        }
    }
}
