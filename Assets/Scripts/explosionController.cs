using UnityEngine;
using System.Collections;

public class explosionController : MonoBehaviour {

	public int direction;
	public AudioClip Explosion1;

	private float length = 3f;
	private Vector3 startPosition;


	// Use this for initialization
	void Start () {
		startPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		switch (direction) {
		case 0:
			this.transform.Translate(Vector3.down); //makes the explosion go down
			break;
		case 1:
			this.transform.Translate(Vector3.up); //makes the explosion go up
			break;
		case 2:
			this.transform.Translate(Vector3.left); //makes the explosion go left
			break;
		case 3:
			this.transform.Translate(Vector3.right); //makes the explosion go right
			break;
		default:
			break;
		}

		//sets the maximum length of the explosion so it wont reach further than the maps length
		if ( this.transform.position.x > 13 ) { 
			audio.PlayOneShot(Explosion1);
			Destroy(gameObject);
		}
		if ( this.transform.position.x < -13 ) {
			audio.PlayOneShot(Explosion1);
			Destroy(gameObject);
		}
		if ( this.transform.position.y > 13 ) {
			audio.PlayOneShot(Explosion1);
			Destroy(gameObject);
		}
		if ( this.transform.position.y < -13 ) {
			audio.PlayOneShot(Explosion1);
			Destroy(gameObject);
		}

		if (Vector3.Distance(this.startPosition, this.transform.position) >= this.length) {
			audio.PlayOneShot(Explosion1);
			Destroy(gameObject);
		}
	}

	//stops the explosion from going further when it hits a gameobject 
	void OnTriggerEnter2D(Collider2D c) {
		if ( c.gameObject.tag == "softBox" ) { 
			Destroy(c.gameObject);
			Destroy(this.gameObject);
			return;
		}
		if (c.gameObject.tag == "powerUpBomb") {
			Destroy (c.gameObject);
			Destroy (this.gameObject);
			return;
		}
		if (c.gameObject.tag == "powerUpOne") {
			Destroy(c.gameObject);
			Destroy(this.gameObject);
			return;
		}
		if (c.gameObject.tag == "powerUpSpeed") {
			Destroy(c.gameObject);
			Destroy(this.gameObject);
			return;
		}
		if ( c.gameObject.tag == "hardBox" ) {
			Destroy(this.gameObject);
			return;
		}
		if ( c.gameObject.tag == "Player" ) {
			Destroy(c.gameObject); // The player should probably destroy itself for animation reasons. 
			Destroy(this.gameObject);
			Application.LoadLevel(3);
			return;
		}
		if ( c.gameObject.tag == "PlayerTwo" ) {
			Destroy(c.gameObject); // The player should probably destroy itself for animation reasons. 
			Destroy(this.gameObject);
			Application.LoadLevel(2);
			return;
		}


	}

	void setDirection(int x) {
		this.direction = x;
	}

	public void setExplosionLength(float l) {
		this.length = l;
	}
}
