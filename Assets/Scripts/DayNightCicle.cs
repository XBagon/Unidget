﻿using UnityEngine;
using System.Collections;

public class DayNightCicle : MonoBehaviour {

    public float speed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        this.transform.Rotate(Vector3.right * speed * Time.deltaTime, Space.World);
	}
}
