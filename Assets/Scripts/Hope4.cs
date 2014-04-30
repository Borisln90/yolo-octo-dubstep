using UnityEngine;
using System.Collections;

public class Hope4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//If statements that look for "player" == Null/ != NULL and other players being !=/== NULL, which then loads a Winscreen level to the specific player who won.
		if ((GameObject.FindGameObjectWithTag ("Player") == null) && (GameObject.FindGameObjectWithTag ("PlayerTwo") != null) && (GameObject.FindGameObjectWithTag ("PlayerThree") == null) && (GameObject.FindGameObjectWithTag ("Player") == null)){
			Application.LoadLevel (3);
		}
		if ((GameObject.FindGameObjectWithTag ("Player") != null) && (GameObject.FindGameObjectWithTag ("PlayerTwo") == null) && (GameObject.FindGameObjectWithTag ("PlayerThree") == null) && (GameObject.FindGameObjectWithTag ("Player") == null)){
			Application.LoadLevel (2);
		}
		if ((GameObject.FindGameObjectWithTag ("Player") == null) && (GameObject.FindGameObjectWithTag ("PlayerTwo") == null) && (GameObject.FindGameObjectWithTag ("PlayerThree") != null) && (GameObject.FindGameObjectWithTag ("Player") == null)){
			Application.LoadLevel (6);
		}
		if ((GameObject.FindGameObjectWithTag ("Player") == null) && (GameObject.FindGameObjectWithTag ("PlayerTwo") == null) && (GameObject.FindGameObjectWithTag ("PlayerThree") == null) && (GameObject.FindGameObjectWithTag ("Player") != null)){
			Application.LoadLevel (7);
		}
	}
}
