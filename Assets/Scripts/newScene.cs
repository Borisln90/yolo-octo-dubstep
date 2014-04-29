using UnityEngine;
using System.Collections;



public class newScene : MonoBehaviour {


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("2player")){ // Space button to go to the actual game
			Application.LoadLevel (1); // set the "game" scene to level 2. Done in build settings
		}
		if(Input.GetButton("3player")){
			Application.LoadLevel (4);
		}
		if(Input.GetButton("4player")){
			Application.LoadLevel (5);
		if(Input.GetKey(KeyCode.Escape)){
			Application.Quit();
			}
		}
	
	}
}
