using UnityEngine;
using System.Collections;

public class eggScript : MonoBehaviour {

	public float lifeTime = 3; 
	public bool hidden = false;

	// Use this for initialization
	void Start () { }
	
	// Update is called once per frame
	void Update () {
		if ( !hidden ) {
			lifeTime -= Time.deltaTime;
		}

		if ( lifeTime <= 0 ) {
			this.renderer.enabled = false;
			this.hidden = true;
		}
	}
}
