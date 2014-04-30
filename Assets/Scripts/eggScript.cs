using UnityEngine;
using System.Collections;

public class eggScript : MonoBehaviour {

	public float lifeTime = 3; 
	public bool hidden = false;
	public GameObject explosion;

	private float explosionLength = 3f; //explosion timer

	// Use this for initialization
	void Start () { 
	}
	
	// Update is called once per frame
	void Update () {
		if ( !hidden ) {
			lifeTime -= Time.deltaTime; //reducing the time by seconds
		}

		//when lifetime hits 0 removes the "egg" and starts explosioncontroller script
		if ( lifeTime <= 0 && this.renderer.enabled ) {
			this.renderer.enabled = false;
			this.hidden = true;

			GameObject clone;

			//for loop that keeps cloning gameobject until destruction
			for (int x = 0; x < 4; x++) {
				clone = Instantiate(explosion, this.transform.position, this.transform.rotation) as GameObject;
				clone.SendMessage("setDirection", x);
				clone.SendMessage("setExplosionLength", this.explosionLength); // Probably not the most efficient way, but it works.
			}
			Destroy(gameObject);
		}
	}
	// sets the length of the explosion (adjustable through powerup)
	public void setExplosionLength(float l) {
		this.explosionLength = l;
	}

	void OnTriggerExit2D (Collider2D c) {
		this.collider2D.isTrigger = false;
	}
}
