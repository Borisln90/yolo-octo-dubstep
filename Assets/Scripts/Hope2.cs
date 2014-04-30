using UnityEngine;
using System.Collections;

public class Hope2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((GameObject.FindGameObjectWithTag ("Player") == null) && (GameObject.FindGameObjectWithTag ("PlayerTwo") != null)){
			Application.LoadLevel (3);
		}
		if ((GameObject.FindGameObjectWithTag ("Player") != null) && (GameObject.FindGameObjectWithTag ("PlayerTwo") == null)){
			Application.LoadLevel (2);
		}
	}
}
