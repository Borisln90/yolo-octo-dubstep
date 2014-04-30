using UnityEngine;
using System.Collections;

public class QuitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) // If Left Mouse Down is pressed
			Application.LoadLevel(0);	//Loads level 0 application
	
	}
}
