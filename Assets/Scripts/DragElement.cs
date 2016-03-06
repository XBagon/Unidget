using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEngine.EventSystems;
using System;

public class DragElement : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDropHandler {
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

 

    public void OnBeginDrag(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }

}

