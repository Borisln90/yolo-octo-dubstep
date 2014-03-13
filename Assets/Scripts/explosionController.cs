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
	}

	void setDirection(int x) {
		this.direction = x;
	}
}
