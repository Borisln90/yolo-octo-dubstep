using UnityEngine;
using System.Collections;

public class explosionController : MonoBehaviour {

	public int direction;

	// Use this for initialization
	void Start () {
	
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
	}


	void OnTriggerEnter2D(Collider2D c) {
		if (c.gameObject.tag == "softBox") {
			Destroy(c.gameObject);
			Destroy(this.gameObject);
		}
		if (c.gameObject.tag == "hardBox") {
			Destroy(this.gameObject);
		}
	}

	void setDirection(int x) {
		this.direction = x;
	}
}
