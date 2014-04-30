using UnityEngine;
using System.Collections;

public class CloudMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	//Calls a translate function which moves the opject across the screen(right) at a random pace - timed from 1-3 * deltaTime.
	void Update () {
		this.transform.Translate(Vector3.right*Random.Range(1,3)*Time.deltaTime);
	
	}
}


		                        