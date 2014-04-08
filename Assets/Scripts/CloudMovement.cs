using UnityEngine;
using System.Collections;

public class CloudMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector3.right*Random.Range(1,3)*Time.deltaTime);
	
	}
}


		                        