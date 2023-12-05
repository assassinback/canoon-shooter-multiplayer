using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Converter : MonoBehaviour {
	public GameObject wall2;
	public GameObject wall1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y<-30) {
			Destroy (gameObject);

		}
	}

	void OnTriggerExit(Collider col)
	{

		if (col.gameObject.tag=="Launcher") {
			GetComponent<BoxCollider> ().isTrigger = false;
			GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, 100	));
			GetComponent<Rigidbody> ().AddTorque (new Vector3 (0, 0, 10));
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag=="Bullet"||col.gameObject.tag=="Plane") {

			wall2.SetActive (true);
			wall1.SetActive (false);

		}
//		if (col.gameObject.tag=="Box") {
//			wall2.SetActive (true);
//			wall1.SetActive (false);
//		}


	}
}
