using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {


	public float maxSpeed= 10f;
	


	Animator anim;  // Animation

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();
	
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


	}


}
