using UnityEngine;
using System.Collections;



public class newScene : MonoBehaviour {


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	//Update function with if statements that looks for keyInputs which matches the desired amount of player participant.
	void Update () {
		if(Input.GetButton("2player")){ 	// Input "2"
			Application.LoadLevel (1); 		//Loads level 1, which contains a 2 player game application
		}
		if(Input.GetButton("3player")){
			Application.LoadLevel (4);
		}
		if(Input.GetButton("4player")){
			Application.LoadLevel (5);
		if(Input.GetKey(KeyCode.Escape)){	//Escape keyCode
			Application.Quit();				//Shut down application
			}
		}
	
	}
}
