using UnityEngine;
using System.Collections;



public class newScene : MonoBehaviour {


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Jump")){ // Space button to go to the actual game

			audio.Play ();
			Application.LoadLevel (1); // set the "game" scene to level 2. Done in build settings


		}
	
	}
}
