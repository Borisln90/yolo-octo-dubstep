using UnityEngine;
using System.Collections;

public class Hope3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((GameObject.FindGameObjectWithTag ("Player") == null) && (GameObject.FindGameObjectWithTag ("PlayerTwo") != null) && (GameObject.FindGameObjectWithTag ("PlayerThree") == null)){
			Application.LoadLevel (3);
		}
		if ((GameObject.FindGameObjectWithTag ("Player") != null) && (GameObject.FindGameObjectWithTag ("PlayerTwo") == null) && (GameObject.FindGameObjectWithTag ("PlayerThree") == null)){
			Application.LoadLevel (2);
		}
		if ((GameObject.FindGameObjectWithTag ("Player") == null) && (GameObject.FindGameObjectWithTag ("PlayerTwo") == null) && (GameObject.FindGameObjectWithTag ("PlayerThree") != null)){
			Application.LoadLevel (6);
		}
	}
}
