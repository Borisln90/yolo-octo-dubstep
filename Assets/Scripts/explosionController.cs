using UnityEngine;
using System.Collections;

public class explosionController : MonoBehaviour {

	public int direction;
	public float length;

	private Vector3 startPosition;


	// Use this for initialization
	void Start () {
		startPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		switch (direction) {
		case 0:
			this.transform.Translate(Vector3.down);
			break;
		case 1:
			this.transform.Translate(Vector3.up);
			break;
		case 2:
			this.transform.Translate(Vector3.left);
			break;
		case 3:
			this.transform.Translate(Vector3.right);
			break;
		default:
			break;
		}

		if ( this.transform.position.x > 13 ) {
			Destroy(gameObject);
		}
		if ( this.transform.position.x < -13 ) {
			Destroy(gameObject);
		}
		if ( this.transform.position.y > 13 ) {
			Destroy(gameObject);
		}
		if ( this.transform.position.y < -13 ) {
			Destroy(gameObject);
		}

		if (Vector3.Distance(this.startPosition, this.transform.position) >= this.length) {
			Destroy(gameObject);
		}
	}


	void OnTriggerEnter2D(Collider2D c) {
		if ( c.gameObject.tag == "softBox" ) {
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
			Application.LoadLevel(1);
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
}
