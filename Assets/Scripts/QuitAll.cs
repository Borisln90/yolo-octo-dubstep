﻿using UnityEngine;
using System.Collections;

public class QuitAll : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) // Looks for Left mouse click down.
			Application.Quit(); //Exits the application
	
	}
}
