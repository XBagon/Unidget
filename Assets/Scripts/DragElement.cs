using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class DragElement : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public static bool holding;
    public static DragElement active;
    public char rorp;
    public string Name;
    GameObject copy;
    public Element e;

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

 

    public void OnBeginDrag(PointerEventData eventData)
    {
        holding = true;
        active = this;
        copy = Instantiate(gameObject);
        copy.transform.SetParent(GetComponentInParent<Canvas>().gameObject.transform,false);
    }

    public void OnDrag(PointerEventData eventData)
    {
        copy.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Destroy(copy);
        holding = false;
        active = null;
    }

    
}

