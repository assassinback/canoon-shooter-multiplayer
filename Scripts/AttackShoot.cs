using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackShoot : MonoBehaviour {
	public GameObject prefab;
	float distance= 100.0f;
	public GameObject child;
	// Use this for initialization
	void Start () {

		child = transform.Find ("Shooter").gameObject;


	}
	bool mouseDown;
//	float force = 1000;
	// Update is called once per frame

	void Update () {
////		if (!isLocalPlayer) {
////			return;
////		}
//		if (Input.GetMouseButtonDown (0)) {
//			mouseDown = true;
//		}
//		if (mouseDown) {
//			force += 100;
//
//		}
//		if (Input.GetMouseButtonUp (0)) {
//			mouseDown = false;
//			CmdAttack ();
////			}
////		} else {
////			return;
////
////		
////
////		}
//		}
	}

//	[Command]
	public void Attack(float force)
	{
		float x = Screen.width / 2;
		print (Screen.height);
		float y = Screen.height / 2;
//		float y = 800f;
//		Vector3 position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 position = new Vector3 (x, y, distance);
		position = Camera.main.ScreenToWorldPoint (position);
		var go = Instantiate (prefab, child.transform.position, Quaternion.identity)as GameObject;
//		var go = Instantiate (prefab, new Vector3(-4f,17f,-58f), Quaternion.identity)as GameObject;
		go.transform.LookAt (position);
		Debug.Log (position);
		go.GetComponent<Rigidbody> ().AddForce (go.transform.forward * force);

//		NetworkServer.Spawn (go);
//		MouseDown = false;
	    force = 3000;


	}
}
