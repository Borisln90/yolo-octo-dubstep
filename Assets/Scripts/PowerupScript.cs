using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

	public Transform brick;


	// Use this for initialization
	void Start () {

		GameObject[] boxes;

		boxes = GameObject.FindGameObjectsWithTag("softBox");
		GameObject box = boxes[Random.Range(0, boxes.Length)] as GameObject;

		Instantiate(brick, box.transform.position, Quaternion.identity); // Instantiate a prefab randomly on stage.
		//Missing: Define specific arrays for placements, so that it doesnt end up where you cant reach it


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
