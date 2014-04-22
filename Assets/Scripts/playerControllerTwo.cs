using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class playerControllerTwo : MonoBehaviour {
	
	
	public float maxSpeed= 10f;
	public Transform spawnPoint;
	public GameObject Egg;
	public int eggLimit;
	public bool playerTwoDead = false;

	public KeyCode up;
	public KeyCode down;
	public KeyCode left;
	public KeyCode right;

	
	bool keyup = false;
	bool keydown = false;
	bool keyleft = false;
	bool keyright = false;
	
	private List<Object> eggs;
	
	
	
	Animator anim;  // Animation
	
	// Use this for initialization
	void Start () {
		
		anim = GetComponent<Animator>();
		eggs = new List<Object>();
		
	}
	
	// Update is called once per frame
	void Update () {



		
		anim.SetBool("left",keyleft);
		anim.SetBool("up",keyup);
		anim.SetBool("down",keydown);
		anim.SetBool("right",keyright);



		//Character controller
		if(Input.GetKey(up)){
		   transform.Translate(new Vector3(0,maxSpeed,0)* Time.deltaTime);
		keyleft = false;
		keyup = true;
		keyright = false;
		keydown = false;
		} 
		if(Input.GetKey(down)){
		transform.Translate(new Vector3(0,-maxSpeed,0)* Time.deltaTime);
		keyleft = false;
		keyup = false;
		keyright = false;
		keydown = true;
		}
		if(Input.GetKey(left)){
			transform.Translate(new Vector3(-maxSpeed,0,0)* Time.deltaTime);
		keyleft = true;
		keyup = false;
		keyright = false;
		keydown = false;
		}
		if(Input.GetKey(right)){
		transform.Translate(new Vector3(maxSpeed,0,0)* Time.deltaTime);
		keyleft = false;
		keyup = false;
		keyright = true;
		keydown = false;
	}




		
		
		// Spawn object
		
		if (Input.GetKeyDown("m") && eggs.Count != this.eggLimit) {
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
