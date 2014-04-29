using UnityEngine;
using System.Collections;

public class PlayerOneWins : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Jump")){
			if Application.LoadLevel (1);
	}
		if(Input.GetKey(KeyCode.Escape)){
			Application.LoadLevel(0);
		}
	}
}