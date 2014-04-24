using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerupScript : MonoBehaviour {

	public GameObject plusOneBrick;
	public GameObject bombBrick;
	public GameObject speedBrick;


	// Use this for initialization
	void Start () {

		GameObject[] boxes;
		List<GameObject> powerups = new List<GameObject>();
		GameObject box = null;

		boxes = GameObject.FindGameObjectsWithTag("softBox");

		System.Random rnd = new System.Random();


		for (int i = 0; i < 5; i++) {
			bool spotAvailable = false;
			while (!spotAvailable) {
				box = boxes[rnd.Next(0, boxes.Length)] as GameObject;
				if (powerups.Count == 0) {
					break;
				}
				foreach (GameObject o in powerups) {
					if (box.transform.position == o.transform.position) {
						spotAvailable = false;
						break;
					} else {
						spotAvailable = true;
					}
				}
			}
			powerups.Add(Instantiate(plusOneBrick, box.transform.position, Quaternion.identity) as GameObject);

			spotAvailable = false;
			while (!spotAvailable) {
				box = boxes[rnd.Next(0, boxes.Length)] as GameObject;
				if (powerups.Count == 0) {
					break;
				}
				foreach (GameObject o in powerups) {
					if (box.transform.position == o.transform.position) {
						spotAvailable = false;
						break;
					} else {
						spotAvailable = true;
					}
				}
			}
			powerups.Add(Instantiate(bombBrick, box.transform.position, Quaternion.identity) as GameObject);

			spotAvailable = false;
			while (!spotAvailable) {
				box = boxes[rnd.Next(0, boxes.Length)] as GameObject;
				if (powerups.Count == 0) {
					break;
				}
				foreach (GameObject o in powerups) {
					if (box.transform.position == o.transform.position) {
						spotAvailable = false;
						break;
					} else {
						spotAvailable = true;
					}
				}
			}
			powerups.Add(Instantiate(speedBrick, box.transform.position, Quaternion.identity) as GameObject);
		}
		 // Instantiate a prefab randomly on stage.
		//Missing: Define specific arrays for placements, so that it doesnt end up where you cant reach it


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
