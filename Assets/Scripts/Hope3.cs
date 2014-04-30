using UnityEngine;
using System.Collections;

public class Hope3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Same script procedure is initiated and described script Hope 3 & Script Hope4. 
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
