﻿using UnityEngine;
using System.Collections;

public class eggScript : MonoBehaviour {

	public float lifeTime = 3; 
	public bool hidden = false;
	public GameObject explosion;

	// Use this for initialization
	void Start () { }
	
	// Update is called once per frame
	void Update () {
		if ( !hidden ) {
			lifeTime -= Time.deltaTime;
		}

		if ( lifeTime <= 0 && this.renderer.enabled ) {
			this.renderer.enabled = false;
			this.hidden = true;

			GameObject clone;

			for (int x = 0; x < 4; x++) {
				clone = Instantiate(explosion, this.transform.position, this.transform.rotation) as GameObject;
				clone.SendMessage("setDirection", x); // Probably not the most efficient way, but it works.
			}
		}
	}
}
