using UnityEngine;
using System.Collections;

public class Hope2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//updates: Checks for Player == NULL & PlayerTwo != Null 
		if ((GameObject.FindGameObjectWithTag ("Player") == null) && (GameObject.FindGameObjectWithTag ("PlayerTwo") != null)){
			Application.LoadLevel (3);	//Adds level 3, defines a winscreen of the winning player.
										//See below for similar code with different player win screen level.
		}
		if ((GameObject.FindGameObjectWithTag ("Player") != null) && (GameObject.FindGameObjectWithTag ("PlayerTwo") == null)){
			Application.LoadLevel (2);
		}
	}
}
