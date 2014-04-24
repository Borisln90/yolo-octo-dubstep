using UnityEngine;
using System.Collections;

public class eggScript : MonoBehaviour {

	public float lifeTime = 3; 
	public bool hidden = false;
	public GameObject explosion;

	private float explosionLength = 3f;

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
				clone.SendMessage("setDirection", x);
				clone.SendMessage("setExplosionLength", this.explosionLength); // Probably not the most efficient way, but it works.
			}

			Destroy(gameObject);
		}
	}

	public void setExplosionLength(float l) {
		this.explosionLength = l;
	}

	void OnTriggerExit2D (Collider2D c) {
		this.collider2D.isTrigger = false;
	}
}
