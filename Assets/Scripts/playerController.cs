using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class playerController : MonoBehaviour {


	public float maxSpeed= 10f;
	public Transform spawnPoint;
	public GameObject Egg;
	public int eggLimit;

	private List<Object> eggs;
	


	Animator anim;  // Animation

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();
		eggs = new List<Object>();
	
	}
	
	// Update is called once per frame
	void Update () {

		float moveX = Input.GetAxis("Horizontal");
		float moveY = Input.GetAxis("Vertical");


		anim.SetFloat("SpeedLeft", moveX); // Animation
		anim.SetFloat("SpeedUpDown", moveY); // Animation


		//Moves Forward and back along z axis //Up/Down
		transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical")* maxSpeed);
		//Moves Left and right along x Axis //Left/Right
		transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal")* maxSpeed);

		// Spawn object

		if (Input.GetKeyDown("x") && eggs.Count != this.eggLimit) {
			eggs.Add(Instantiate(Egg,spawnPoint.position,spawnPoint.rotation));
		}
		eggs.RemoveAll(HasExploded);




	}

	void OnTriggerEnter2D (Collider2D c) {
		if (c.gameObject.tag == "powerUpOne") {
			print("yo");
			Destroy(c.gameObject);
			this.eggLimit = this.eggLimit + 1;
			
		}
	}

	private static bool HasExploded(Object o) {
		if (o == null) {
			return true;
		}
		return false;
	}


}
