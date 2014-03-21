using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

	public Transform brick;





	// Use this for initialization
	void Start () {

		Instantiate(brick, new Vector3(Random.Range(-8,8), Random.Range(-8,8), Random.Range(0,0)), Quaternion.identity); // Instantiate a prefab randomly on stage.
		//Missing: Define specific arrays for placements, so that it doesnt end up where you cant reach it


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
