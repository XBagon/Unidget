using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class AmountObject {
    public object obj;
    public float Amount;

    public AmountObject(System.Object obj, int Amount)
    {
        this.obj = obj;
        this.Amount = Amount;
    }

    public AmountObject(System.Object obj, float Amount)
    {
        this.obj = obj;
        this.Amount = Amount;
    }




}
