using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerupScript : MonoBehaviour {

	//Creates gameObjects.
	public GameObject plusOneBrick;
	public GameObject bombBrick;
	public GameObject speedBrick;


	// At initialization, places powerups under random soft boxes. Makes sure powerups aren't placed on top of each other.
	void Start () {

		GameObject[] boxes; // Array to hold all softboxes						
		List<GameObject> powerups = new List<GameObject>(); // List to hold all placed powerups
		GameObject box = null;

		boxes = GameObject.FindGameObjectsWithTag("softBox");

		// System.Random seems to provide more random posistions than unity standard random.
		System.Random rnd = new System.Random();

		// places 5 of each
		for (int i = 0; i < 6; i++) {
			bool spotAvailable = false;
			// find the posistion of a random softbox. loop if position already taken
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
			// place the powerup at box posistion
			powerups.Add(Instantiate(plusOneBrick, box.transform.position, Quaternion.identity) as GameObject);

			// Repeat for all types of powerup
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
	}
	
	// Update is called once per frame
	void Update () {}
}
