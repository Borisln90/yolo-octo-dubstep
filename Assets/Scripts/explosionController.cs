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
		default:
			break;
		}
	
	}

	public void StartMove () {
		
	}
}
