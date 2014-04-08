using UnityEngine;
using System.Collections;

public class CloudScript : MonoBehaviour {

	public Transform Cloud;

	float cloudDelay = 30;



	// Use this for initialization
	void Start () {

		StartCoroutine("instantiateCloud");
	
	}
	
	// Update is called once per frame
	void Update () {



	

	
	}



	IEnumerator instantiateCloud(){

		Instantiate(Cloud, new Vector3(Random.Range(-50,-40), Random.Range(-16,14), Random.Range(0,0)), Quaternion.identity);
		yield return new WaitForSeconds(cloudDelay);
		Start();


	}

}
