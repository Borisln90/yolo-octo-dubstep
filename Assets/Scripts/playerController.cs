using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class playerController : MonoBehaviour {
	
	//variables, transforms and opjects and function-control to control values and objects within the game. "Will be specified in the inspector".
	public float maxSpeed= 10f;
	public float explosionLength;
	public Transform spawnPoint;
	public GameObject Egg;
	public int eggLimit;

	//keyCodes to edit specific keyInputs for each player in the controller window.
	public KeyCode up;
	public KeyCode down;
	public KeyCode left;
	public KeyCode right;
	public KeyCode BombLaying;
	
	//Create bools, set to false for controller inputs.
	bool keyup = false;
	bool keydown = false;
	bool keyleft = false;
	bool keyright = false;

	//list of all the eggs the player have at a current time.
	private List<Object> eggs;
	
	
	
	Animator anim;  // Animation
	
	// Use this for initialization
	void Start () {
		//Defines anim as the Animator, which is used to create/utilize the sprite animations.
		anim = GetComponent<Animator>();
		//Creates the list
		eggs = new List<Object>();
	}
	
	// Update is called once per frame
	void Update () {

		//Controls the animator, if pressed, then true and plays the specific animation.
		anim.SetBool("left",keyleft);
		anim.SetBool("up",keyup);
		anim.SetBool("down",keydown);
		anim.SetBool("right",keyright);
		

		//Character controller
		if(Input.GetKey(up)){ //Specific keyCode
			transform.Translate(new Vector3(0,maxSpeed,0)* Time.deltaTime); //translate for speed
			keyleft = false; // Sets other keyinput bools to false, to ensure that only one anim is true
			keyup = true;	//Same principle for below mentioned controller inputs
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
		
		
		
		
		
		
		// Spawn egg object
		//if input & egg.Count is different from the limit, an Egg object is instantiated on the player position.
		
		if (Input.GetKeyDown(BombLaying) && eggs.Count != this.eggLimit) {
			GameObject e = Instantiate(Egg,spawnPoint.position,spawnPoint.rotation) as GameObject;
			e.SendMessage("setExplosionLength", this.explosionLength); //call setExplosionLength function in egg object.
			eggs.Add(e); // Adds object to the egg list.
		}
		eggs.RemoveAll(HasExploded); // Destroys the egg. List is repeatedly checked for object existence.
		
		
		
		
	}
	//Void function which triggers on collision with the powerUp objects.
	void OnTriggerEnter2D (Collider2D c) {
		if (c.gameObject.tag == "powerUpOne") { // if gameObjects collides with specific powerup Object
			Destroy(c.gameObject); // Gameobject is destroyed
			this.eggLimit = this.eggLimit + 1;	//Egglimit is increased
		}
		if (c.gameObject.tag == "powerUpSpeed") {
			Destroy(c.gameObject);
			this.maxSpeed += 3f; // Speed of the player is increased
		}
		if (c.gameObject.tag == "powerUpBomb") {
			Destroy(c.gameObject);
			this.explosionLength += 2f; // Explosion length of the player is increased
		}
	}
	
	private static bool HasExploded(Object o) { // checks if object == 0 or NULL
		if (o == null) {
			return true;
		}
		return false;
	}
	
	
}
